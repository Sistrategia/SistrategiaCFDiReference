/**************************************************************************
 * Sistrategia.SAT.CFDI.Retencion.cs 
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
    public class Retencion
    {
        private RetencionImpuesto impuesto;
        private decimal importe;

        /// <summary>
        /// Atributo requerido para señalar el tipo de impuesto retenido
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="impuesto" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo requerido para señalar el tipo de impuesto retenido</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:whiteSpace value="collapse"/>
        ///             <xs:enumeration value="ISR">
        ///                 <xs:annotation>
        ///                     <xs:documentation>Impuesto sobre la renta</xs:documentation>
        ///                 </xs:annotation>
        ///             </xs:enumeration>
        ///             <xs:enumeration value="IVA">
        ///                 <xs:annotation>
        ///                     <xs:documentation>Impuesto al Valor Agregado</xs:documentation>
        ///                 </xs:annotation>
        ///             </xs:enumeration>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("impuesto")]
        public RetencionImpuesto Impuesto {
            get { return this.impuesto; }
            set { this.impuesto = value; }
        }        

        /// <summary>
        /// Atributo requerido para señalar el importe o monto del impuesto retenido.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="importe" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para señalar el importe o monto del impuesto retenido.
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
    /// Atributo requerido para señalar el tipo de impuesto retenido.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public enum RetencionImpuesto
    {
        /// <summary>
        /// Impuesto sobre la renta
        /// </summary>
        ISR,
        /// <summary>
        /// Impuesto al Valor Agregado
        /// </summary>
        IVA,
    }
    //<xs:simpleType>
    //    <xs:restriction base="xs:string">
    //        <xs:whiteSpace value="collapse"/>
    //        <xs:enumeration value="ISR">
    //            <xs:annotation>
    //                <xs:documentation>Impuesto sobre la renta</xs:documentation>
    //            </xs:annotation>
    //        </xs:enumeration>
    //        <xs:enumeration value="IVA">
    //            <xs:annotation>
    //                <xs:documentation>Impuesto al Valor Agregado</xs:documentation>
    //            </xs:annotation>
    //        </xs:enumeration>
    //    </xs:restriction>
    //</xs:simpleType>
}
