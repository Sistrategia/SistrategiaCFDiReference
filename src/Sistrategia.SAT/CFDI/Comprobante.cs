/**************************************************************************
 * Sistrategia.SAT.CFDI.IEmisor.cs 
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
    /// Estándar de Comprobante fiscal digital a través de Internet.
    /// </summary>
    /// <remarks>
    /// Antes la definición era: "Estándar para la expresión de comprobantes fiscales digitales."
    /// El cambio se realizó en la versión 3.2
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>  
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    public class Comprobante // : IComprobante
    {
        #region Private Fields
        private string version;
        private string serie;   // opcional en CFDi
        private string folio;   // opcional en CFDi
        private DateTime fecha;
        private string sello;

        private Emisor emisor;
        #endregion

        #region Constructors
        public Comprobante() {
            this.version = "3.2";
            this.emisor = new Emisor();
            //this.receptor = new ComprobanteReceptor();
        }
        #endregion

        /// <summary>
        /// Atributo requerido con valor prefijado a 3.2 que indica la versión del estándar bajo el que se encuentra expresado el comprobante.
        /// </summary>
        /// <remarks>
        /// Requerido con valor prefijado a 3.2
        /// No debe contener espacios en blanco
        /// </remarks>
        [XmlAttribute("version")]
        public string Version {
            get { return version; }
            set {
                //if (value != "3.2") {
                //    throw new ArgumentException("Atributo requerido con valor prefijado a 3.2");
                //}
                this.version = value; // validar las posibles versiones
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la serie para control interno del contribuyente. Este atributo acepta una cadena de caracteres alfabéticos de 1 a 25 caracteres sin incluir caracteres acentuados.
        /// </summary>
        /// <remarks>
        /// Opcional
        /// El largo debe estar entre 1 y 25 caracteres
        /// No debe contener espacios en blanco
        /// </remarks>
        [XmlAttribute("serie")]
        public string Serie {
            get { return this.serie; }
            set { this.serie = value; }
        }

        /// <summary>
        ///   Atributo opcional para control interno del contribuyente que acepta un valor numérico entero superior a 0 que expresa el folio del comprobante.
        /// </summary>
        /// <remarks>
        /// opcional
        /// El largo debe estar entre 1 y 20 caracteres
        /// No debe contener espacios en blanco
        /// </remarks>
        [XmlAttribute("folio")]
        public string Folio {
            get { return this.folio; }
            set { this.folio = value; }
        }

        /// <summary>
        /// Atributo requerido para la expresión de la fecha y hora de expedición del comprobante fiscal. Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601.
        /// </summary>
        /// <remarks>
        /// Requerido
        /// Fecha y hora de expedición del comprobante fiscal
        /// No debe contener espacios en blanco
        /// </remarks>
        [XmlAttribute("fecha")]
        public DateTime Fecha {
            get { return this.fecha; }
            set { 
                // this.fecha = value; 
                string fechaString = Convert.ToDateTime(value).ToString("dd/MM/yyyy HH:mm:ss");
                IFormatProvider culture = new System.Globalization.CultureInfo("es-MX", true);
                value = DateTime.ParseExact(fechaString, "dd/MM/yyyy HH:mm:ss", culture);
                this.fecha = value;
            }
        }

        /// <summary>
        /// Atributo requerido para contener el sello digital del comprobante fiscal, al que hacen referencia las reglas de resolución miscelánea aplicable. El sello deberá ser expresado cómo una cadena de texto en formato Base 64.
        /// </summary>
        /// <remarks>
        /// Requerido
        /// El sello deberá ser expresado cómo una cadena de texto en formato Base 64.
        /// No debe contener espacios en blanco
        /// </remarks>
        [XmlAttribute("sello")]
        public string Sello {
            get { return this.sello; }
            set { this.sello = value; }
        }

        /// <summary>
        /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
        /// </summary>
        [XmlElement("Emisor", typeof(Emisor))]
        public Emisor Emisor {
            get { return this.emisor; }
            set { this.emisor = value; }
        }
          
    }
}
