/**************************************************************************
 * Sistrategia.SAT.CFDI.ComprobanteTimbre.cs 
 * 
 * Author(s):   José Ernesto Ocampo Cicero <ernesto@sistrategia.com>
 * Last Update:	2014-Oct-10
 * Created:	    2010-Dec-16
 * 
 * (C) 2010-2014 José Ernesto Ocampo Cicero
 * Copyright (C) José Ernesto Ocampo Cicero, 2010-2014
 * All rights reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. 
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace Sistrategia.SAT.CFDI
{
    public class ComprobanteTimbre // : XmlElement
    {
        private string version;
        private string uuid;
        private DateTime fechaTimbrado;
        private string selloCFD;
        private string noCertificadoSAT;
        private string selloSAT;

        //<xs:attribute name="version" use="required" fixed="1.0">        
        //</xs:attribute>
        /// <summary>
        /// Atributo requerido para la expresión de la versión del estándar del Timbre Fiscal Digital
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="version" use="required" fixed="1.0">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para la expresión de la versión del estándar del Timbre Fiscal Digital
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("version")]
        public string Version {
            get { return this.version; }
            set { this.version = value; }
        }

        /// <summary>
        /// Atributo requerido para expresar los 36 caracteres del UUID de la transacción de timbrado
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="UUID" use="required" id="UUID">
        /// <xs:annotation>
        /// <xs:documentation>
        /// Atributo requerido para expresar los 36 caracteres del UUID de la transacción de timbrado
        /// </xs:documentation>
        /// </xs:annotation>
        /// <xs:simpleType>
        /// <xs:restriction base="xs:string">
        /// <xs:whiteSpace value="collapse"/>
        /// <xs:length value="36"/>
        /// <xs:pattern value="[a-f0-9A-F]{8}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{12}"/>
        /// </xs:restriction>
        /// </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("UUID")]
        public string UUID {
            get { return this.uuid; }
            set { this.uuid = value; }
        }

        //<xs:attribute name="FechaTimbrado" use="required">
        //<xs:annotation>
        //<xs:documentation>
        //Atributo requerido para expresar la fecha y hora de la generación del timbre
        //</xs:documentation>
        //</xs:annotation>
        //<xs:simpleType>
        //<xs:restriction base="xs:dateTime">
        //<xs:whiteSpace value="collapse"/>
        //</xs:restriction>
        //</xs:simpleType>
        //</xs:attribute>
        [XmlAttribute("FechaTimbrado")]
        public DateTime FechaTimbrado {
            get { return this.fechaTimbrado; }
            set { this.fechaTimbrado = value; }
        }

        //<xs:attribute name="selloCFD" use="required">
        //<xs:annotation>
        //<xs:documentation>
        //Atributo requerido para contener el sello digital del comprobante fiscal, que será timbrado. El sello deberá ser expresado cómo una cadena de texto en formato Base 64.
        //</xs:documentation>
        //</xs:annotation>
        //<xs:simpleType>
        //<xs:restriction base="xs:string">
        //<xs:whiteSpace value="collapse"/>
        //</xs:restriction>
        //</xs:simpleType>
        //</xs:attribute>
        [XmlAttribute("selloCFD")]
        public string SelloCFD {
            get { return this.selloCFD; }
            set { this.selloCFD = value; }
        }

        //<xs:attribute name="noCertificadoSAT" use="required">
        //<xs:annotation>
        //<xs:documentation>
        //Atributo requerido para expresar el número de serie del certificado del SAT usado para el Timbre
        //</xs:documentation>
        //</xs:annotation>
        //<xs:simpleType>
        //<xs:restriction base="xs:string">
        //<xs:whiteSpace value="collapse"/>
        //<xs:length value="20"/>
        //</xs:restriction>
        //</xs:simpleType>
        //</xs:attribute>
        [XmlAttribute("noCertificadoSAT")]
        public string NoCertificadoSAT {
            get { return this.noCertificadoSAT; }
            set { this.noCertificadoSAT = value; }
        }

        //<xs:attribute name="selloSAT" use="required">
        //<xs:annotation>
        //<xs:documentation>
        //Atributo requerido para contener el sello digital del Timbre Fiscal Digital, al que hacen referencia las reglas de resolución miscelánea aplicable. El sello deberá ser expresado cómo una cadena de texto en formato Base 64.
        //</xs:documentation>
        //</xs:annotation>
        //<xs:simpleType>
        //<xs:restriction base="xs:string">
        //<xs:whiteSpace value="collapse"/>
        //</xs:restriction>
        //</xs:simpleType>
        //</xs:attribute>
        [XmlAttribute("selloSAT")]
        public string SelloSAT {
            get { return this.selloSAT; }
            set { this.selloSAT = value; }
        }
    }
}
