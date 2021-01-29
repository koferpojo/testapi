
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System;

namespace WebApplication1
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ApiController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        [Consumes("application/xml")]
        public async Task<string> TestPost()
        {
            string incomingXml = "";
            var requestDateTime = DateTime.Now.ToString("MMddyyyy HHmmss");
            var fileName = $@"C:\Users\Maksim\Documents\Visual Studio 2019\messagesFromAVP\{requestDateTime}.xml";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {

                incomingXml = await reader.ReadToEndAsync();
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(incomingXml);
                xdoc.Save(fileName);

            }
            //var requestDateTime = DateTime.Now.ToString("MMddyyyy HHmmss");
            //var fileName = $@"C:\Users\Maksim\Documents\Visual Studio 2019\messagesFromAVP\{requestDateTime}.xml";
            // var fileName = @"C:\Users\Maksim\Documents\Visual Studio 2019\data.txt";"
            System.IO.File.WriteAllText(fileName, incomingXml);
            return "OK "  + requestDateTime;

     
            //var serializer = new XmlSerializer(typeof(AggregatedMeteringDataReport));
            //AggregatedMeteringDataReport result;

            //using (TextReader reader = new StringReader(incomingXml))
            //{
            //    result = (AggregatedMeteringDataReport)serializer.Deserialize(reader);
            //}
            //return result.DocumentIdentification.ToString();
        }



        [HttpGet]
        [Route("[action]")]
        [Consumes("application/xml")]
        public string TestGet(string fileName)
        {
            try
            {

                //XmlTextReader xmlReader = new XmlTextReader($@"C:\Users\Maksim\Documents\Visual Studio 2019\messagesFromAVP");
                //while (xmlReader.Read())
                //{
                //  //switch (xmlReader.NodeType)
                ////    {
                //////        case XmlNodeType.Element:
                //////            listBox1.Items.Add("<" + xmlReader.Name + ">");
                //////            break;
                //////        case XmlNodeType.Text:
                //////            listBox1.Items.Add(xmlReader.Value);
                //////            break;
                //////        case XmlNodeType.EndElement:
                //////            listBox1.Items.Add("");
                //////            break;
                ////         }
                // }
                //XmlTextReader xmlReader = new XmlTextReader($@"C:\Users\Maksim\Documents\Visual Studio 2019\messagesFromAVP");
                string text = System.IO.File.ReadAllText($@"C:\Users\Maksim\Documents\Visual Studio 2019\messagesFromAVP\{fileName}");

                return "OK " + fileName + text;
            }


            catch (FileNotFoundException ex)
            {
                // Write error.
                return "FileNotFoundException";
            }


        }



        [HttpDelete]
        [Route("[action]")]
        public string TestDelete(string fileName)
        {

            string[] files = Directory.GetFiles($@"C:\Users\Maksim\Documents\Visual Studio 2019\messagesFromAVP");
            foreach (string file in files)
            {
                System.IO.File.Delete(file);
                Console.WriteLine($"{file} is deleted.");
            }

            return "OK";
        }

    }


}





   









