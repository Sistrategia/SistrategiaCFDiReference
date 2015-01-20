/**************************************************************************
 * Sistrategia.SAT.RetencionPago.RetencionesReceptorNacional.cs 
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
    /// Nodo requerido para expresar la información del contribuyente receptor en caso de que sea de nacionalidad mexicana.
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public class RetencionesReceptorNacional
    {
        private string rfcRecep;
        private string nomDenRazSocR;
        private string curpR;

        /// <summary>
        /// Atributo requerido para la clave del Registro Federal de Contribuyentes correspondiente al contribuyente receptor del documento.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="RFCRecep" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para la clave del Registro Federal de Contribuyentes correspondiente al contribuyente receptor del documento.
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="retenciones:t_RFC"/>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>   
        [XmlAttribute]
        public string RFCRecep {
            get { return this.rfcRecep; }
            set { this.rfcRecep = value; }
        }

        /// <summary>
        /// Atributo opcional para el nombre, denominación o razón social del contribuyente receptor del documento.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="NomDenRazSocR" use="optional">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo opcional para el nombre, denominación o razón social del contribuyente receptor del documento.
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
        public string NomDenRazSocR {
            get { return this.nomDenRazSocR; }
            set { this.nomDenRazSocR = value; }
        }

        /// <summary>
        /// Atributo opcional para la Clave Única del Registro Poblacional del contribuyente receptor del documento.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="CURPR" type="retenciones:t_CURP" use="optional">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo opcional para la Clave Única del Registro Poblacional del contribuyente receptor del documento.
        ///     </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>        
        [XmlAttribute]
        public string CURPR {
            get { return this.curpR; }
            set { this.curpR = value; }
        }
    }
}





