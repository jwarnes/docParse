using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Novacode;

namespace AwardsDatabase
{
    #region Structures
    /// <summary>
    /// List of possible data types.
    /// </summary>
    public enum DocFieldDataType
    {
        Text, Integer, Decimal, Date, Boolean, List
    }
    /// <summary>
    /// This structure contains the string value extracted from the document, and the data type expected
    /// </summary>
    public struct DocField
    {
        public string Text;
        public DocFieldDataType Type;
    }
    #endregion

    /// <summary>
    /// This class uses an XML map to extract data from a *.docx document
    /// </summary>
    public static class DocParser
    {
        /// <summary>
        /// Imports a word document and populates tagged fields in a form with the parsed data
        /// </summary>
        /// <param name="form">The form that will receive the data from the document</param>
        public static void ImportAndPopulate(Form form)
        {
            var open = new OpenFileDialog() { Title = "Import Word Document", Filter = "Word 2007/2010 Document|*.docx" };
            if (open.ShowDialog() == DialogResult.OK && File.Exists(open.FileName))
            {
                try
                {
                    string[] skip = { "Select", "Click to", "Click here" };
                    var replace = new Dictionary<string, string>();
                    replace.Add("Agreement to Pursue", "ATP");
                    replace.Add("Agreement to Submit", "ATS");

                    PopulateForm(form, open.FileName, skip, replace);
                    MessageBox.Show(string.Format("Finished attempted import of '{0}'.\n\n It is very important that all fields are manually reviewed to ensure correct entry!", Path.GetFileName(open.FileName)),
                        "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error importing {0}.\n{1}", Path.GetFileName(open.FileName), ex.Message)
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Capture Data
        /// <summary>
        /// This method returns a dictionary object containing the text and indicated value type of every item specified in the map.
        /// The keys are referenced by the field name configured in the mapping tool.
        /// </summary>
        /// <param name="documentPath">File path of the *.docx document</param>
        /// <param name="mapPath">File path of the XML file containing the field mappings</param>
        /// <returns></returns>
        public static Dictionary<string, DocField> CaptureDocumentData(string documentPath, string mapPath)
        {
            var xml = XElement.Load(mapPath);
            var doc = DocX.Load(documentPath);
            var data = new Dictionary<string, DocField>();

            //query the xml map and convert the result set to a dictionary object
            var map = xml.Elements("Field")
                .Select(x => new
                {
                    paragraph = (int)x.Attribute("paragraph"),
                    info = new DocField() 
                    { 
                        Type = (DocFieldDataType)Enum.Parse(typeof(DocFieldDataType), (string)x.Attribute("type")),
                        Text = (string)x.Attribute("name")
                    }
                })
                .ToDictionary(x => x.paragraph, x => x.info);

            foreach (var field in map)
            {
                if (field.Key > doc.Paragraphs.Count)
                    continue;
                data.Add(field.Value.Text, new DocField() { Text = doc.Paragraphs[field.Key].Text, Type = field.Value.Type });
            }

            return data;
        }

        public static Dictionary<string, DocField> CaptureDocumentData(string documentPath)
        {
            var doc = DocX.Load(documentPath);
            var path = "";
            if (doc.Paragraphs[2].Text.Trim() == "Agreement to Pursue")
                path = "ATP.xml";
            if (doc.Paragraphs[2].Text.Trim() == "Agreement to Submit")
                path = "ATS.xml";
            doc.Dispose();

            return CaptureDocumentData(documentPath, path);

        }
        #endregion

        #region Validation/Conversion Methods
        /// <summary>
        /// This helper method tests if the DocField's text property can easily be converted into the type specified by it's type property
        /// </summary>
        /// <param name="field">The field to validate</param>
        /// <returns></returns>
        private static bool FieldIsValid(DocField field)
        {
            switch (field.Type)
            {
                case DocFieldDataType.Boolean:
                case DocFieldDataType.Date:
                case DocFieldDataType.Integer:
                case DocFieldDataType.Decimal:
                default:
                    return true;

            }
        }

        public static bool GetBoolean(string s)
        {
            s = s.Trim();
            return (s.Contains("☒") || s.ToLower() == "yes");
        }

        public static DateTime GetDate(string s)
        {
            var date = new DateTime();
            DateTime.TryParse(s, out date);
            return date;
        }

        public static int GetInteger(string s)
        {
            int i;
            return int.TryParse(s, out i) ? i : 0;
        }

        public static decimal GetCurrency(string s)
        {
            s = s.Replace("USD $", "");
            s = s.Replace(",", "");
            decimal d;
            return decimal.TryParse(s, out d) ? d : 0;
            
        }

        #endregion

        #region Form Population
        public static void PopulateForm(Form form, string path)
        {
            var data = DocParser.CaptureDocumentData(path);
            RecurseControls(form.Controls, data, null, null);
        }
        public static void PopulateForm(Form form, string path, string[] skipOver, Dictionary<string, string> replace)
        {
            var data = DocParser.CaptureDocumentData(path);
            RecurseControls(form.Controls, data, skipOver, replace);
        }
        public static void PopulateForm(Form form, Dictionary<string, DocField> data, string[] skipOver, Dictionary<string, string> replace)
        {
            RecurseControls(form.Controls, data, skipOver, replace);
        }
        public static void PopulateForm(Form form, Dictionary<string, DocField> data)
        {
            RecurseControls(form.Controls, data, null, null);
        }

        private static void RecurseControls(Control.ControlCollection controls, Dictionary<string, DocField> data, string[] skipOver, Dictionary<string, string> replace)
        {
            //recurse through all controls on the form, looking for tags
            foreach (Control c in controls)
            {
                if (c.Controls.Count > 0) RecurseControls(c.Controls, data, skipOver, replace);

                //determine if the control is tagged, and if that tag is also a variable in our data dictionary
                if (c.Tag == null) continue;
                var tag = c.Tag.ToString();
                if (!data.ContainsKey(tag)) continue;

                var item = data[tag];

                //filter out fields that contain default values like "Click here to enter"
                if (skipOver != null)
                {
                    var skip = false;
                    foreach (var s in skipOver)
                    {
                        if (item.Text.StartsWith(s))
                            skip = true;
                    }
                    if (skip) continue;
                }

                //replace strings
                if (replace != null && replace.ContainsKey(item.Text)) item.Text = replace[item.Text];
                
                //populate data according to control type
                if (c is TextBox)
                {
                    if (item.Type == DocFieldDataType.Text || item.Type == DocFieldDataType.Integer) c.Text = item.Text;
                    if (item.Type == DocFieldDataType.Decimal) c.Text = DocParser.GetCurrency(item.Text).ToString();
                }
                else if (c is ComboBox)
                {
                    c.Text = item.Text;
                    //if we can't find the appropriate item in the dropdown list, color it red to get the user's attention
                    if (((ComboBox)c).FindString(item.Text) == -1) c.BackColor = Color.Red;
                    else ((ComboBox)c).SelectedIndex = ((ComboBox)c).FindString(item.Text);
                }
                else if (c is DateTimePicker && item.Type == DocFieldDataType.Date)
                    ((DateTimePicker)c).Value = DocParser.GetDate(item.Text);
                else if (c is CheckBox) ((CheckBox)c).Checked = DocParser.GetBoolean(item.Text);
            }
        }

        #endregion

    }

}
