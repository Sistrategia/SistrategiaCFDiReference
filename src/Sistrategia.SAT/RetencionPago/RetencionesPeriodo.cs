/**************************************************************************
 * Sistrategia.SAT.RetencionPago.RetencionesPeriodo.cs 
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
    /// Nodo requerido para expresar el periodo que ampara el documento de retenciones e información de pagos.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/esquemas/retencionpago/1/retencionpagov1.xsd
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public class RetencionesPeriodo
    {
        private int mesIni;
        private int mesFin;
        private int ejerc;

        /// <summary>
        /// Atributo requerido para la expresión del mes inicial del periodo de la retención e información de pagos.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="MesIni" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para la expresión del mes inicial del periodo de la retención e información de pagos
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:int">
        ///       <xs:minInclusive value="1"/>
        ///       <xs:maxInclusive value="12"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute]
        public int MesIni {
            get { return this.mesIni; }
            set { this.mesIni = value; }
        }

        /// <summary>
        /// Atributo requerido para la expresión del mes final del periodo de la retención e información de pagos.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="MesFin" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para la expresión del mes final del periodo de la retención e información de pagos
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:int">
        ///       <xs:minInclusive value="1"/>
        ///       <xs:maxInclusive value="12"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute]
        public int MesFin {
            get { return this.mesFin; }
            set { this.mesFin = value; }
        }

        /// <summary>
        /// Atributo requerido para la expresión del ejercicio fiscal (año).
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="Ejerc" use="required">
        ///   <xs:annotation>
        ///     <xs:documentation>
        ///       Atributo requerido para la expresión del ejercicio fiscal (año)
        ///     </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///     <xs:restriction base="xs:int">
        ///       <xs:minInclusive value="2004"/>
        ///       <xs:maxInclusive value="2024"/>
        ///     </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute]
        public int Ejerc {
            get { return this.ejerc; }
            set { this.ejerc = value; }
        }
    }
}






