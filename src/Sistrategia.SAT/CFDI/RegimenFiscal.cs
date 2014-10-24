/**************************************************************************
 * Sistrategia.SAT.CFDI.RegimenFiscal.cs 
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
using System.ComponentModel;
using System.Xml.Serialization;

namespace Sistrategia.SAT.CFDI
{
    /// <summary>
    /// Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class RegimenFiscal
    {
        private object[] items;
        private string regimen;

        /// <summary>
        /// Atributo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
        /// Regimen: Atributo requerido para incorporar el nombre del régimen en el que tributa el contribuyente emisor.
        /// </summary> 
        object[] Items { get; set; }

        /// <summary>
        /// Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:sequence>
        ///   <xs:element name="RegimenFiscal" maxOccurs="unbounded">
        ///     <xs:annotation>
        ///       <xs:documentation>
        ///         Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
        ///       </xs:documentation>
        ///     </xs:annotation>
        ///     <xs:complexType>
        ///       <xs:attribute name="Regimen" use="required">
        ///         <xs:annotation>
        ///           <xs:documentation>
        ///             Atributo requerido para incorporar el nombre del régimen en el que tributa el contribuyente emisor.
        ///           </xs:documentation>
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
        /// </xs:sequence>
        /// </code>
        /// </remarks>
        [XmlAttribute("Regimen")]
        public string Regimen {
            get { return this.regimen; }
            set { this.regimen = SATManager.NormalizeWhiteSpace(value); }
        }        
    }	
}
