using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace cfdi
{
    class Program
    {
        static void Main(string[] args) {

            Sistrategia.SAT.CFDI.Comprobante cfdi = Sistrategia.SAT.SATManager.CreateComprobante();
            cfdi.Fecha = DateTime.Now;
            //IFormatProvider culture = new System.Globalization.CultureInfo("es-MX", true);
            //cfdi.Fecha = DateTime.ParseExact("22/12/2014 10:30:20", "dd/MM/yyyy HH:mm:ss", culture);
            cfdi.Emisor.RFC = "XAXX010101000";
            cfdi.Emisor.Nombre = "PUBLICO EN GENERAL";
            cfdi.Emisor.DomicilioFiscal = new Sistrategia.SAT.CFDI.UbicacionFiscal();            
            cfdi.Emisor.DomicilioFiscal.Pais = "MEXICO";
            cfdi.Emisor.RegimenFiscal = new List<Sistrategia.SAT.CFDI.RegimenFiscal>();
            //cfdi.Emisor.RegimenFiscal = new Sistrategia.SAT.CFDI.RegimenFiscal[2];
            cfdi.Emisor.RegimenFiscal.Add(new Sistrategia.SAT.CFDI.RegimenFiscal());
            //cfdi.Emisor.RegimenFiscal[0] = new Sistrategia.SAT.CFDI.RegimenFiscal();
            cfdi.Emisor.RegimenFiscal[0].Regimen = "Ley General P.M.";

            cfdi.Emisor.RegimenFiscal.Add(new Sistrategia.SAT.CFDI.RegimenFiscal());
            //cfdi.Emisor.RegimenFiscal[1] = new Sistrategia.SAT.CFDI.RegimenFiscal();
            cfdi.Emisor.RegimenFiscal[1].Regimen = "Otro Régimen";

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            //MemoryStream ms = new MemoryStream();
            //XmlTextWriter xmlWriter = new XmlTextWriter(ms, System.Text.Encoding.UTF8);
            XmlSerializer serializer = null;
            StreamWriter xmlWriter = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "\\cfdi.xml", false, System.Text.Encoding.UTF8);
            

            //serializer = new System.Xml.Serialization.XmlSerializer(cfd.GetType());

            //XmlAttributes attrs = new XmlAttributes();
            //XmlElementAttribute attr = new XmlElementAttribute();
            //attr.Namespace = "http://www.sat.gob.mx/cfd/3";
            //attrs.XmlElements.Add(attr);
            //XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();
            ////attrOverrides.Add(typeof(Sistrategia.SAT.CFDI.Comprobante), "cfdi:Comprobante", attrs);
            //attrOverrides.Add(typeof(Sistrategia.SAT.CFDI.IComprobante), "cfdi:Comprobante", attrs);
            //serializer = new XmlSerializer(cfdi.GetType(), attrOverrides);
            //serializer = new XmlSerializer(typeof(Sistrategia.SAT.CFDI.IComprobante), attrOverrides);

            serializer = new XmlSerializer(cfdi.GetType(), new Type[] { 
                typeof(Sistrategia.SAT.CFDI.Emisor)
                ,typeof(Sistrategia.SAT.CFDI.RegimenFiscal)
                ,typeof(Sistrategia.SAT.CFDI.Ubicacion)
                ,typeof(Sistrategia.SAT.CFDI.UbicacionFiscal)
            });
            //serializer.Serialize(xmlWriter, cfdi); //, "utf-8");
            serializer.Serialize(xmlWriter, cfdi, ns); //, "utf-8");
            xmlWriter.Flush();

            //ms.Seek(0, System.IO.SeekOrigin.Begin);
            //ms.Close();
            //string xmlString = System.Text.Encoding.UTF8.GetString(ms.ToArray());
            xmlWriter.Close();
            //byte[] file = System.Text.Encoding.UTF8.GetBytes(xmlString);
            ////byte[] file = ms.ToArray();
            //byte[] response = null;

            //Console.Write(xmlString);

            //StreamReader xmlReader = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\source.xml", System.Text.Encoding.UTF8);
            StreamReader xmlReader = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\cfdi.xml", System.Text.Encoding.UTF8);
            object theSource = serializer.Deserialize(xmlReader); //, "utf-8");

            Sistrategia.SAT.CFDI.Comprobante cfdi2 = theSource as Sistrategia.SAT.CFDI.Comprobante;

            System.Console.WriteLine(theSource.GetType().ToString());

            cfdi2.ToString();
            
            //if ("3.2".Equals(cfd.Version)) {
            //    ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            //}
            //else {
            //    ns.Add("", "http://www.sat.gob.mx/cfd/2");
            //}
            //ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //System.Xml.XmlTextWriter xmlWriter = new XmlTextWriter(ms, System.Text.Encoding.UTF8);
            //System.Xml.Serialization.XmlSerializer serializer = null;

            //if ("3.2".Equals("3.2")) {
            //    XmlAttributes attrs = new XmlAttributes();
            //    XmlElementAttribute attr = new XmlElementAttribute();
            //    attr.Namespace = "http://www.sat.gob.mx/cfd/3";
            //    attrs.XmlElements.Add(attr);
            //    XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();
            //    attrOverrides.Add(typeof(Sistrategia.Server.SAT.CFDI32.Comprobante), "cfdi:Comprobante", attrs);
            //    serializer = new XmlSerializer(cfd.GetType(), attrOverrides);
            //}
            //else {
            //    serializer = new System.Xml.Serialization.XmlSerializer(cfd.GetType());
            //}
            //serializer.Serialize(xmlWriter, cfd, ns); //, "utf-8");
            //xmlWriter.Flush();
            //ms.Seek(0, System.IO.SeekOrigin.Begin);
            //ms.Close();
            //string xmlString = System.Text.Encoding.UTF8.GetString(ms.ToArray());
            //xmlWriter.Close();
            //byte[] file = System.Text.Encoding.UTF8.GetBytes(xmlString);
            ////byte[] file = ms.ToArray();
            //byte[] response = null;


        }
    }
}
