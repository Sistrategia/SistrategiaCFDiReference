/**************************************************************************
 * Sistrategia.SAT.RetencionPago.RetencionesReceptorNacionalidad.cs 
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
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public enum RetencionesReceptorNacionalidad
    {
        /// <summary>
        /// Nacionalidad Mexicana
        /// </summary>
        Nacional,

        /// <summary>
        /// Procedente de otro pais
        /// </summary>
        Extranjero
    }
}

//<xs:attribute name="Nacionalidad" use="required">
//<xs:annotation>
//<xs:documentation>
//Atributo requerido para expresar la nacionalidad del receptor del documento.
//</xs:documentation>
//</xs:annotation>
//<xs:simpleType>
//<xs:restriction base="xs:string">
//<xs:whiteSpace value="collapse"/>
//<xs:enumeration value="Nacional">
//<xs:annotation>
//<xs:documentation>Nacionalidad Mexicana</xs:documentation>
//</xs:annotation>
//</xs:enumeration>
//<xs:enumeration value="Extranjero">
//<xs:annotation>
//<xs:documentation>Procedente de otro pais</xs:documentation>
//</xs:annotation>
//</xs:enumeration>
//</xs:restriction>
//</xs:simpleType>
//</xs:attribute>