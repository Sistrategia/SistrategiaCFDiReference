/**************************************************************************
 * Sistrategia.SAT.CFDI.Emisor.cs 
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
using System.Xml.Serialization;

namespace Sistrategia.SAT.CFDI
{
    /// <summary>
    /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Emisor
    {
        #region Private Fields
        private string rfc;
        private string nombre;
        private UbicacionFiscal domicilioFiscal;
        private Ubicacion expedidoEn;
        //private IList<RegimenFiscal> regimenFiscal;
        private List<RegimenFiscal> regimenFiscal;
        //private RegimenFiscal[] regimenFiscal;
        #endregion

        /// <summary>
        /// Atributo requerido para la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente emisor del comprobante sin guiones o espacios.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="rfc" type="cfdi:t_RFC" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo requerido para la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente emisor del comprobante sin guiones o espacios.</xs:documentation>
        ///     </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// <code>
        /// <xs:simpleType name="t_RFC">
        ///     <xs:annotation>
        ///         <xs:documentation>Tipo definido para expresar claves del Registro Federal de Contribuyentes</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:restriction base="xs:string">
        ///         <xs:minLength value="12"/>
        ///         <xs:maxLength value="13"/>
        ///         <xs:whiteSpace value="collapse"/>
        ///         <xs:pattern value="[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?"/>
        ///     </xs:restriction>
        /// </xs:simpleType>
        /// </code>
        /// </remarks>
        [XmlAttribute("rfc")]
        public string RFC {
            get { return this.rfc; }
            set { this.rfc = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Atributo opcional para el nombre, denominación o razón social del contribuyente emisor del comprobante.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="nombre">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo opcional para el nombre, denominación o razón social del contribuyente emisor del comprobante.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// <xs:minLength value="1"/>
        /// <xs:whiteSpace value="collapse"/>
        /// </remarks>
        [XmlAttribute("nombre")]
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Nodo opcional para precisar la información de ubicación del domicilio fiscal del contribuyente emisor.
        /// </summary>
        /// <remarks>
        /// Antes era requerido
        /// <code>
        /// <xs:element name="DomicilioFiscal" type="cfdi:t_UbicacionFiscal" minOccurs="0">
        ///     <xs:annotation>
        ///         <xs:documentation>Nodo opcional para precisar la información de ubicación del domicilio fiscal del contribuyente emisor</xs:documentation>
        ///     </xs:annotation>
        /// </xs:element>
        /// </code>
        /// </remarks>
        [XmlElement("DomicilioFiscal")]
        public UbicacionFiscal DomicilioFiscal {
            get { return this.domicilioFiscal; }
            set { this.domicilioFiscal = value; }
        }

        /// <summary>
        /// Nodo opcional para precisar la información de ubicación del domicilio en donde es emitido 
        /// el comprobante fiscal en caso de que sea distinto del domicilio fiscal del contribuyente emisor.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:element name="ExpedidoEn" type="cfdi:t_Ubicacion" minOccurs="0">
        ///     <xs:annotation>
        ///         <xs:documentation>Nodo opcional para precisar la información de ubicación del domicilio en donde es emitido el comprobante fiscal en caso de que sea distinto del domicilio fiscal del contribuyente emisor.</xs:documentation>
        ///     </xs:annotation>
        /// </xs:element>
        /// </code>
        /// </remarks>
        [XmlElement("ExpedidoEn")]
        public Ubicacion ExpedidoEn {
            get { return this.expedidoEn; }
            set { this.expedidoEn = value; }
        }

        /// <summary>
        /// Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:sequence>
        ///   <xs:element name="RegimenFiscal" maxOccurs="unbounded">
        ///     <xs:annotation>
        ///       <xs:documentation>Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:complexType>
        ///       <xs:attribute name="Regimen" use="required">
        ///         <xs:annotation>
        ///           <xs:documentation>Atributo requerido para incorporar el nombre del régimen en el que tributa el contribuyente emisor.</xs:documentation>
        ///         </xs:annotation>
        ///         <xs:simpleType>
        ///           <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///           </xs:restriction>
        ///         </xs:simpleType>
        ///       </xs:attribute>
        ///     </xs:complexType>
        ///   </xs:element>
        /// </xs:sequence>        
        /// </code>
        /// </remarks>
        [XmlElement("RegimenFiscal", IsNullable = false)]
        public List<RegimenFiscal> RegimenFiscal {
        //public RegimenFiscal[] RegimenFiscal {        
        //public IList<RegimenFiscal> RegimenFiscal {
            get { return this.regimenFiscal; }
            set { this.regimenFiscal = value; }
        }
    }
}
