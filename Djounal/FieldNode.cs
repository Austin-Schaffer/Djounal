using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Djounal
{
    public class FieldNode : TreeNode
    {
        public bool boolIsEnabled;
        public int intFieldId;
        public string strFieldName;
        public FieldDataType dataType;
        private static string strDelimiter = "||";

        public enum FieldDataType { Boolean, Number, Text }

        public new string Text
        {
            get { return this.strFieldName + " [" + this.dataType + "]"; }
        }

        public FieldNode(int _fieldId, string _fieldName, FieldDataType _dataType, bool _isEnabled = true)
        {
            this.intFieldId = _fieldId;
            this.strFieldName = _fieldName;
            this.dataType = _dataType;
            this.boolIsEnabled = _isEnabled;
        }

        public FieldNode(string strXml)
        {
            string[] strValues = strXml.Split(new string[] { strDelimiter }, StringSplitOptions.None);

            this.intFieldId = int.Parse(strValues[0]);
            this.strFieldName = strValues[1];
            this.dataType = (FieldDataType)Enum.Parse(typeof(FieldDataType), strValues[2]);
            this.boolIsEnabled = bool.Parse(strValues[3]);

        }

        public string ToXmlString()
        {
            return string.Join(strDelimiter, new string[] { this.intFieldId.ToString(), this.strFieldName, this.dataType.ToString(), this.boolIsEnabled.ToString() }); ;
        }

        public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement ret = doc.CreateElement(this.strFieldName);
            ret.SetAttribute("FieldId", this.intFieldId.ToString());
            ret.SetAttribute("DataType", Enum.GetName(typeof(FieldDataType), this.dataType));
            ret.SetAttribute("IsEnabled", this.boolIsEnabled.ToString());

            return ret;
        }
    }
}
