using Newtonsoft.Json;
using System.Xml.Linq;

namespace AdapterPattern.Adapters
{
    public class XmlAdapter
    {
        public string JsonToXmlAdapter(string jsonToAdapt)
        {
            XNode adaptedNode = JsonConvert.DeserializeXNode(jsonToAdapt, "Person");
            return adaptedNode.ToString();
        }
    }
}
