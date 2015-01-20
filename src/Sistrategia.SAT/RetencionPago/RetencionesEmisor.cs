/**************************************************************************
 * Sistrategia.SAT.RetencionPago.RetencionesEmisor.cs 
 * 
 * Author(s):   José Ernesto Ocampo Cicero <ernesto@sistrategia.com>
 * Last Update:	2015-Ene-20
 * Created:	    2014-Dec-16
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

namespace Sistrategia.SAT.RetencionPago
{
    /// <summary>
    /// Nodo requerido para expresar la información del contribuyente emisor del documento electrónico de retenciones e información de pagos.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/esquemas/retencionpago/1/retencionpagov1.xsd
    /// </remarks>
    [Serializable]    
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public class RetencionesEmisor
    {
        private string rfcEmisor;
        private string nomDenRazSocE;
        private string curpe;

        /// <summary>
        /// Atributo requerido para incorporar la clave en el Registro Federal de Contribuyentes correspondiente al contribuyente emisor del documento de retención e información de pagos, sin guiones o espacios.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="RFCEmisor" type="retenciones:t_RFC" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para incorporar la clave en el Registro Federal de Contribuyentes correspondiente al contribuyente emisor del documento de retención e información de pagos, sin guiones o espacios.
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute]
        public string RFCEmisor {
            get { return this.rfcEmisor; }
            set { this.rfcEmisor = value; }
        }

        /// <summary>
        /// Atributo opcional para el nombre, denominación o razón social del contribuyente emisor del documento de retención e información de pagos.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="NomDenRazSocE" use="optional">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo opcional para el nombre, denominación o razón social del contribuyente emisor del documento de retención e información de pagos.
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:string">
        ///       <xs:minLength value="1"/>
        ///       <xs:maxLength value="300"/>
        ///       <xs:whiteSpace value="collapse"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute]
        public string NomDenRazSocE {
            get { return this.nomDenRazSocE; }
            set { this.nomDenRazSocE = value; }
        }

        /// <summary>
        /// Atributo opcional para la Clave Única del Registro Poblacional del contribuyente emisor del documento de retención e información de pagos.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="CURPE" type="retenciones:t_CURP" use="optional">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo opcional para la Clave Única del Registro Poblacional del contribuyente emisor del documento de retención e información de pagos.
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute]
        public string CURPE {
            get { return this.curpe; }
            set { this.curpe = value; }
        }
    }
}
