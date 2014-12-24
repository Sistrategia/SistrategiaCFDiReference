/**************************************************************************
 * Sistrategia.SAT.CFDI.Concepto.cs 
 * 
 * Author(s):   José Ernesto Ocampo Cicero <ernesto@sistrategia.com>
 * Last Update:	2014-Oct-10
 * Created:	    2010-Dec-24
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
    /// Nodo requerido para enlistar los conceptos cubiertos por el comprobante.
    /// </summary>
    /// <remarks>
    /// Nodo para introducir la información detallada de un bien o servicio amparado en el comprobante.
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Concepto
    {
        private decimal cantidad;
        private string unidad;
        private string noIdentificacion;
        private string descripcion;
        private decimal valorUnitario;
        private decimal importe;

        //private object[] items;

        ///// <summary>
        ///// ComplementoConcepto: Nodo opcional donde se incluirán los nodos complementarios de extensión al concepto, definidos por el SAT, de acuerdo a disposiciones particulares a un sector o actividad especifica.
        ///// CuentaPredial: Nodo opcional para asentar el número de cuenta predial con el que fue registrado el inmueble, en el sistema catastral de la entidad federativa de que trate, o bien para incorporar los datos de identificación del certificado de participación inmobiliaria no amortizable.
        ///// InformacionAduanera: Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas.
        ///// Parte: Nodo opcional para expresar las partes o componentes que integran la totalidad del concepto expresado en el comprobante fiscal digital a través de Internet.
        ///// </summary>        
        //[XmlElement("ComplementoConcepto", typeof(ComplementoConcepto))]
        //[XmlElement("CuentaPredial", typeof(CuentaPredial))]
        //[XmlElement("InformacionAduanera", typeof(InformacionAduanera))]
        //[XmlElement("Parte", typeof(ConceptoParte))]
        //public object[] Items {
        //    get { return this.items; }
        //    set { this.items = value; }
        //}
        ////<xs:choice minOccurs="0">
        ////    <xs:element name="InformacionAduanera" type="cfdi:t_InformacionAduanera" minOccurs="0" maxOccurs="unbounded">
        ////    <xs:annotation>
        ////        <xs:documentation>
        ////        Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas.
        ////        </xs:documentation>
        ////    </xs:annotation>
        ////    </xs:element>
        ////    <xs:element name="CuentaPredial" minOccurs="0">
        ////    <xs:annotation>
        ////        <xs:documentation>
        ////        Nodo opcional para asentar el número de cuenta predial con el que fue registrado el inmueble, en el sistema catastral de la entidad federativa de que trate, o bien para incorporar los datos de identificación del certificado de participación inmobiliaria no amortizable.
        ////        </xs:documentation>
        ////    </xs:annotation>
        ////    <xs:complexType>
        ////        <xs:attribute name="numero" use="required">
        ////        <xs:annotation>
        ////            <xs:documentation>
        ////            Atributo requerido para precisar el número de la cuenta predial del inmueble cubierto por el presente concepto, o bien para incorporar los datos de identificación del certificado de participación inmobiliaria no amortizable, tratándose de arrendamiento.
        ////            </xs:documentation>
        ////        </xs:annotation>
        ////        <xs:simpleType>
        ////            <xs:restriction base="xs:string">
        ////            <xs:whiteSpace value="collapse"/>
        ////            <xs:minLength value="1"/>
        ////            </xs:restriction>
        ////        </xs:simpleType>
        ////        </xs:attribute>
        ////    </xs:complexType>
        ////    </xs:element>
        ////    <xs:element name="ComplementoConcepto" minOccurs="0">
        ////    <xs:annotation>
        ////        <xs:documentation>
        ////        Nodo opcional donde se incluirán los nodos complementarios de extensión al concepto, definidos por el SAT, de acuerdo a disposiciones particulares a un sector o actividad especifica.
        ////        </xs:documentation>
        ////    </xs:annotation>
        ////    <xs:complexType>
        ////        <xs:sequence>
        ////        <xs:any minOccurs="0" maxOccurs="unbounded"/>
        ////        </xs:sequence>
        ////    </xs:complexType>
        ////    </xs:element>
        ////    <xs:element name="Parte" minOccurs="0" maxOccurs="unbounded">
        ////    <xs:annotation>
        ////        <xs:documentation>
        ////        Nodo opcional para expresar las partes o componentes que integran la totalidad del concepto expresado en el comprobante fiscal digital a través de Internet
        ////        </xs:documentation>
        ////    </xs:annotation>
        ////    <xs:complexType>
        ////        <xs:sequence>
        ////        <xs:element name="InformacionAduanera" type="cfdi:t_InformacionAduanera" minOccurs="0" maxOccurs="unbounded">
        ////            <xs:annotation>
        ////            <xs:documentation>
        ////                Nodo opcional para introducir la información aduanera aplicable cuando se trate de partes o componentes importados vendidos de primera mano.
        ////            </xs:documentation>
        ////            </xs:annotation>
        ////        </xs:element>
        ////        </xs:sequence>


        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por el presente concepto.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="cantidad" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por el presente concepto.
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:decimal">
        ///       <xs:whiteSpace value="collapse"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("cantidad")]
        public decimal Cantidad {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }        

        /// <summary>
        /// Atributo requerido para precisar la unidad de medida aplicable para la cantidad expresada en el concepto.
        /// </summary>
        /// <remarks>
        /// Antes era opcional.
        /// <code>
        /// <xs:attribute name="unidad" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para precisar la unidad de medida aplicable para la cantidad expresada en el concepto.
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:string">
        ///       <xs:whiteSpace value="collapse"/>
        ///       <xs:minLength value="1"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("unidad")]
        public string Unidad {
            get { return this.unidad; }
            set { this.unidad = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar el número de serie del bien o identificador del servicio amparado por el presente concepto.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="noIdentificacion" use="optional">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo opcional para expresar el número de serie del bien o identificador del servicio amparado por el presente concepto.
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:string">
        ///       <xs:minLength value="1"/>
        ///       <xs:whiteSpace value="collapse"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("noIdentificacion")]
        public string NoIdentificacion {
            get { return this.noIdentificacion; }
            set { this.noIdentificacion = value; }
        }        

        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por el presente concepto.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="descripcion" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para precisar la descripción del bien o servicio cubierto por el presente concepto.
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:string">
        ///       <xs:minLength value="1"/>
        ///       <xs:whiteSpace value="collapse"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("descripcion")]
        public string Descripcion {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        /// <summary>
        /// Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto por el presente concepto.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="valorUnitario" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto por el presente concepto.
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("valorUnitario")]
        public decimal ValorUnitario {
            get { return this.valorUnitario; }
            set { this.valorUnitario = value; }
        }
        

        /// <summary>
        /// Atributo requerido para precisar el importe total de los bienes o servicios del presente concepto. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en el concepto.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="importe" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para precisar el importe total de los bienes o servicios del presente concepto. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en el concepto.
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("importe")]
        public decimal Importe {
            get { return this.importe; }
            set { this.importe = value; }
        }
    }
}
