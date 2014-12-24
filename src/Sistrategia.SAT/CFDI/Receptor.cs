/**************************************************************************
 * Sistrategia.SAT.CFDI.Receptor.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Sistrategia.SAT.CFDI
{
    /// <summary>
    /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Receptor
    {
        #region Private Fields
        private string rfc;
        private string nombre;
        private Ubicacion domicilio;
        #endregion

        /// <summary>
        /// Atributo requerido para precisar la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente receptor del comprobante.
        /// </summary>
        [XmlAttribute("rfc")]
        string RFC {
            get { return this.rfc; }
            set { this.rfc = value; }
        }

        /// <summary>
        /// Atributo opcional para precisar el nombre o razón social del contribuyente receptor.
        /// </summary>
        [XmlAttribute("nombre")]
        string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Nodo opcional para la definición de la ubicación donde se da el domicilio del receptor del comprobante fiscal.
        /// </summary>
        [XmlElement("Domicilio")]
        public Ubicacion Domicilio {
            get { return this.domicilio; }
            set { this.domicilio = value; }
        }
    }
}
