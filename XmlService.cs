using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAdapter
{
    public class XmlService : IXmlHandler
    {
        public string GetXmlData()
        {
            return "<data>Example XML Data</data>";
        }
    }
}
