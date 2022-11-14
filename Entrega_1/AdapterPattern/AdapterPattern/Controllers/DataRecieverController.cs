using AdapterPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;
using AdapterPattern.Adapters;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataRecieverController : ControllerBase
    {
        //Función que recibe peticiones POST en JSON y las regresa en XML:
        [HttpPost]
        public string DataReciever(PersonModel personData)
        {
            string personDataJson = Newtonsoft.Json.JsonConvert.SerializeObject(personData);

            XmlAdapter adaptador = new XmlAdapter();

            string xmlAdaptedData = adaptador.JsonToXmlAdapter(personDataJson);

            return xmlAdaptedData.ToString();
        }
    }
}
