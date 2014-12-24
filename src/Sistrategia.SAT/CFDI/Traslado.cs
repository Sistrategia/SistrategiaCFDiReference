/**************************************************************************
 * Sistrategia.SAT.CFDI.Traslado.cs 
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
    /// Nodo opcional para capturar los impuestos retenidos aplicables.
    /// </summary>
    /// <remarks>
    /// Nodo para la información detallada de una retención de impuesto específico.
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Traslado
    {
        private TrasladoImpuesto impuesto;
        private decimal tasa;
        private decimal importe;

        /// <summary>
        /// Atributo requerido para señalar el tipo de impuesto trasladado.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="impuesto" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para señalar el tipo de impuesto trasladado
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:string">
        ///       <xs:whiteSpace value="collapse"/>
        ///       <xs:enumeration value="IVA">
        ///       <xs:annotation>
        ///           <xs:documentation>Impuesto al Valor Agregado</xs:documentation>
        ///       </xs:annotation>
        ///       </xs:enumeration>
        ///       <xs:enumeration value="IEPS">
        ///          <xs:annotation>
        ///               <xs:documentation>Impuesto especial sobre productos y servicios</xs:documentation>
        ///           </xs:annotation>
        ///       </xs:enumeration>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("impuesto")]
        public TrasladoImpuesto Impuesto {
            get { return this.impuesto; }
            set { this.impuesto = value; }
        }        

        /// <summary>
        /// Atributo requerido para señalar la tasa del impuesto que se traslada por cada concepto amparado en el comprobante.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="tasa" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para señalar la tasa del impuesto que se traslada por cada concepto amparado en el comprobante.
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("tasa")]
        public decimal Tasa {
            get { return this.tasa; }
            set { this.tasa = value; }
        }        

        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto trasladado.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="importe" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para señalar el importe del impuesto trasladado.
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

    /// <summary>
    /// Atributo requerido para señalar el tipo de impuesto trasladado
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public enum TrasladoImpuesto
    {
        /// <summary>
        /// Impuesto al Valor Agregado
        /// </summary>
        IVA,
        /// <summary>
        /// Impuesto especial sobre productos y servicios
        /// </summary>
        IEPS,
    }
    //<xs:attribute name="impuesto" use="required">
    //    <xs:annotation>
    //    <xs:documentation>Atributo requerido para señalar el tipo de impuesto trasladado</xs:documentation>
    //    </xs:annotation>
    //    <xs:simpleType>
    //    <xs:restriction base="xs:string">
    //        <xs:whiteSpace value="collapse"/>
    //        <xs:enumeration value="IVA">
    //        <xs:annotation>
    //            <xs:documentation>Impuesto al Valor Agregado</xs:documentation>
    //        </xs:annotation>
    //        </xs:enumeration>
    //        <xs:enumeration value="IEPS">
    //        <xs:annotation>
    //            <xs:documentation>Impuesto especial sobre productos y servicios</xs:documentation>
    //        </xs:annotation>
    //        </xs:enumeration>
    //    </xs:restriction>
    //    </xs:simpleType>
    //</xs:attribute>
}
