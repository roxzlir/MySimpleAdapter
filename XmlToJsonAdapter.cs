using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAdapter
{
    public class XmlToJsonAdapter : IJsonHandler
    {
        private readonly IXmlHandler _xmlHandler;
        public XmlToJsonAdapter(IXmlHandler xmlHandler)
        {
            _xmlHandler = xmlHandler;
        }
        public string GetJsonData()
        {
            var xmlData = _xmlHandler.GetXmlData();
            return $"This is JSON data: {xmlData}";
        }
    }
}
