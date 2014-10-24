/**************************************************************************
 * Sistrategia.SAT.CFDI.Ubicacion.cs 
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
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(TypeName = "t_Ubicacion", Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Ubicacion
    {
        #region Private fields
        private string calle;
        private string noExterior;
        private string noInterior;
        private string colonia;
        private string localidad;
        private string referencia;
        private string municipio;
        private string estado;
        private string pais;
        private string codigoPostal;
        #endregion

        /// <summary>
        /// Este atributo opcional sirve para precisar la avenida, calle, camino o carretera donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="calle" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Este atributo opcional sirve para precisar la avenida, calle, camino o carretera donde se da la ubicación.</xs:documentation>
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
        public string Calle {
            get { return this.calle; }
            set { this.calle = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Este atributo opcional sirve para expresar el número particular en donde se da la ubicación sobre una calle dada        
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
        public string NoExterior {
            get { return this.noExterior; }
            set { this.noExterior = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Este atributo opcional sirve para expresar información adicional para especificar la ubicación 
        /// cuando calle y número exterior (noExterior) no resulten suficientes para determinar 
        /// la ubicación de forma precisa.
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
        public string NoInterior {
            get { return this.noInterior; }
            set { this.noInterior = SATManager.NormalizeWhiteSpace(value); }
        }

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
        public string Colonia {
            get { return this.colonia; }
            set { this.colonia = SATManager.NormalizeWhiteSpace(value); }
        }

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
        public string Localidad {
            get { return this.localidad; }
            set { this.localidad = SATManager.NormalizeWhiteSpace(value); }
        }

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
        ///             <xs:minLength value="1"/>
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("referencia")]
        public string Referencia {
            get { return this.referencia; }
            set { this.referencia = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Atributo opcional que sirve para precisar el municipio o delegación (en el caso del Distrito Federal) 
        /// en donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="municipio" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo opcional que sirve para precisar el municipio o delegación (en el caso del Distrito Federal) en donde se da la ubicación.</xs:documentation>
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
        public string Municipio {
            get { return this.municipio; }
            set { this.municipio = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Atributo opcional que sirve para precisar el estado o entidad federativa donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="estado" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo opcional que sirve para precisar el estado o entidad federativa donde se da la ubicación.</xs:documentation>
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
        public string Estado {
            get { return this.estado; }
            set { this.estado = SATManager.NormalizeWhiteSpace(value); }
        }

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
        public string Pais {
            get { return this.pais; }
            set { this.pais = SATManager.NormalizeWhiteSpace(value); }
        }

        /// <summary>
        /// Atributo opcional que sirve para asentar el código postal en donde se da la ubicación.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="codigoPostal" use="optional">
        ///     <xs:annotation>
        ///         <xs:documentation>Atributo opcional que sirve para asentar el código postal en donde se da la ubicación.</xs:documentation>
        ///     </xs:annotation>
        ///     <xs:simpleType>
        ///         <xs:restriction base="xs:string">
        ///             <xs:whiteSpace value="collapse"/>
        ///         </xs:restriction>
        ///     </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("codigoPostal")]
        public string CodigoPostal {
            get { return this.codigoPostal; }
            set { this.codigoPostal = SATManager.NormalizeWhiteSpace(value); }
        }
    }
}