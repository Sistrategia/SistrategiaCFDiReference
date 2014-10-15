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

            Sistrategia.SAT.CFDI.IComprobante cfdi = Sistrategia.SAT.SATManager.CreateComprobante();

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            MemoryStream ms = new MemoryStream();
            XmlTextWriter xmlWriter = new XmlTextWriter(ms, System.Text.Encoding.UTF8);
            XmlSerializer serializer = null;

            //serializer = new System.Xml.Serialization.XmlSerializer(cfd.GetType());

            XmlAttributes attrs = new XmlAttributes();
            XmlElementAttribute attr = new XmlElementAttribute();
            attr.Namespace = "http://www.sat.gob.mx/cfd/3";
            attrs.XmlElements.Add(attr);
            XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();
            //attrOverrides.Add(typeof(Sistrategia.SAT.CFDI.Comprobante), "cfdi:Comprobante", attrs);
            attrOverrides.Add(typeof(Sistrategia.SAT.CFDI.IComprobante), "cfdi:Comprobante", attrs);
            serializer = new XmlSerializer(cfdi.GetType(), attrOverrides);
            //serializer = new XmlSerializer(typeof(Sistrategia.SAT.CFDI.IComprobante), attrOverrides);

            serializer.Serialize(xmlWriter, cfdi, ns); //, "utf-8");
            xmlWriter.Flush();
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            ms.Close();
            string xmlString = System.Text.Encoding.UTF8.GetString(ms.ToArray());
            xmlWriter.Close();
            byte[] file = System.Text.Encoding.UTF8.GetBytes(xmlString);
            //byte[] file = ms.ToArray();
            byte[] response = null;

            Console.Write(xmlString);


            
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
