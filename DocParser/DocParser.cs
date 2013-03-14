using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Novacode;

namespace DocParser
{
    /// <summary>
    /// List of possible data types.
    /// </summary>
    public enum DocFieldDataType
    {
        Text, Integer, Decimal, Date, Boolean, List
    }
    /// <summary>
    /// This structure contains the string value extracted from the document, and the type indicated by the configuration tool.
    /// </summary>
    public struct DocField
    {
        public string Text;
        public DocFieldDataType Type;
    }

    /// <summary>
    /// This class uses an XML map to extract data from a *.docx document
    /// </summary>
    public class DocParser
    {
        /// <summary>
        /// This method returns a dictionary object containing the text and indicated value type of every item specified in the map.
        /// The keys are referenced by the field name configured in the mapping tool.
        /// </summary>
        /// <param name="documentPath">File path of the *.docx document</param>
        /// <param name="mapPath">File path of the XML file containing the field mappings</param>
        /// <returns></returns>
        public static Dictionary<string, DocField> CaptureDocumentInfo(string documentPath, string mapPath)
        {
            var xml = XElement.Load(mapPath);
            var doc = DocX.Load(documentPath);
            var data = new Dictionary<string, DocField>();

            //query the map
            var map = xml.Elements("Field")
                .Select(x => new
                {
                    paragraph = (int)x.Attribute("paragraph"),
                    name = (string)x.Attribute("name"),
                    type = (DocFieldDataType)Enum.Parse(typeof(DocFieldDataType), (string)x.Attribute("type"))
                })
                .ToDictionary(x => x.paragraph, x => new DocField() { Text = x.name, Type = x.type });

            foreach (var field in map)
            {
                if (field.Key > doc.Paragraphs.Count)
                    continue;
                data.Add(field.Value.Text, new DocField() { Text = doc.Paragraphs[field.Key].Text, Type = field.Value.Type });
            }

            return data;
        }
    }

}
