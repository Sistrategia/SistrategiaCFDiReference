/**************************************************************************
 * Sistrategia.SAT.CFDI.IComprobanteEmisor.cs 
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
    /// Tipo definido para expresar domicilios o direcciones
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd
    /// [XmlType(TypeName = "t_UbicacionFiscal", Namespace = "http://www.sat.gob.mx/cfd/3")]
    /// </remarks>    
    [XmlType(TypeName = "t_UbicacionFiscal", Namespace = "http://www.sat.gob.mx/cfd/3")]
    public interface IUbicacionFiscal // : IUbicacion
    {
        /// <summary>
        /// Este atributo requerido sirve para precisar la avenida, calle, camino o carretera donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="calle" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Este atributo requerido sirve para precisar la avenida, calle, camino o carretera donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("calle")]
        string Calle { get; set; }

        /// <summary>
        /// Este atributo opcional sirve para expresar el número particular en donde se da la ubicación sobre una calle dada.
        /// </summary>        
        /// <remarks>
        /// <code>
        /// <xs:attribute name="noExterior" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Este atributo opcional sirve para expresar el número particular en donde se da la ubicación sobre una calle dada.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("noExterior")]
        string NoExterior { get; set; }

        /// <summary>
        /// Este atributo opcional sirve para expresar información adicional para especificar 
        /// la ubicación cuando calle y número exterior (noExterior) no resulten suficientes 
        /// para determinar la ubicación de forma precisa.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="noInterior" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Este atributo opcional sirve para expresar información adicional para especificar la ubicación cuando calle y número exterior (noExterior) no resulten suficientes para determinar la ubicación de forma precisa.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("noInterior")]
        string NoInterior { get; set; }

        /// <summary>
        /// Este atributo opcional sirve para precisar la colonia en donde se da la ubicación cuando se desea ser más específico en casos de ubicaciones urbanas.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="colonia" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Este atributo opcional sirve para precisar la colonia en donde se da la ubicación cuando se desea ser más específico en casos de ubicaciones urbanas.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("colonia")]
        string Colonia { get; set; }

        /// <summary>
        /// Atributo opcional que sirve para precisar la ciudad o población donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="localidad" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo opcional que sirve para precisar la ciudad o población donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("localidad")]
        string Localidad { get; set; }

        /// <summary>
        /// Atributo opcional para expresar una referencia de ubicación adicional.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="referencia" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo opcional para expresar una referencia de ubicación adicional.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:whiteSpace value="collapse"/>
        ///             <xs:minLength value="1"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("referencia")]
        string Referencia { get; set; }

        /// <summary>
        /// Atributo requerido que sirve para precisar el municipio o delegación (en el caso del Distrito Federal) en donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="municipio" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo requerido que sirve para precisar el municipio o delegación (en el caso del Distrito Federal) en donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("municipio")]
        string Municipio { get; set; }

        /// <summary>
        /// Atributo requerido que sirve para precisar el estado o entidad federativa donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="estado" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo requerido que sirve para precisar el estado o entidad federativa donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("estado")]
        string Estado { get; set; }

        /// <summary>
        /// Atributo requerido que sirve para precisar el país donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="pais" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo requerido que sirve para precisar el país donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("pais")]
        string Pais { get; set; }

        /// <summary>
        /// Atributo requerido que sirve para asentar el código postal en donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="codigoPostal" use="required">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo requerido que sirve para asentar el código postal en donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:whiteSpace value="collapse"/>
        ///             <xs:length value="5"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("codigoPostal")]
        string CodigoPostal { get; set; }
    }
}
