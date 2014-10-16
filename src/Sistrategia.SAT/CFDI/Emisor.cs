﻿/**************************************************************************
 * Sistrategia.SAT.CFDI.Emisor.cs 
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
    /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>
    public class Emisor : IEmisor
    {
        #region Private Fields
        private string rfc;
        private string nombre;
        private IUbicacionFiscal domicilioFiscal;
        private IUbicacion expedidoEn;
        private IList<IRegimenFiscal> regimenFiscal;
        #endregion

        /// <summary>
        /// Atributo requerido para la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente emisor del comprobante sin guiones o espacios.
        /// </summary>
        /// <remarks>
        /// <xs:restriction base="xs:string">
        /// <xs:minLength value="12"/>
        /// <xs:maxLength value="13"/>
        /// <xs:whiteSpace value="collapse"/>
        /// <xs:pattern value="[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?"/>
        /// </xs:restriction>
        /// </remarks>
        [XmlAttribute("rfc")]
        public string RFC {
            get { return this.rfc; }
            set { this.rfc = value; }
        }

        /// <summary>
        /// Atributo opcional para el nombre, denominación o razón social del contribuyente emisor del comprobante.
        /// </summary>
        /// <remarks>
        /// <xs:minLength value="1"/>
        /// <xs:whiteSpace value="collapse"/>
        /// </remarks>
        [XmlAttribute("nombre")]
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Nodo opcional para precisar la información de ubicación del domicilio fiscal del contribuyente emisor.
        /// </summary>
        /// <remarks>Antes era requerido</remarks>
        [XmlElement("DomicilioFiscal")]
        public IUbicacionFiscal DomicilioFiscal {
            get { return this.domicilioFiscal; }
            set { this.domicilioFiscal = value; }
        }

        /// <summary>
        /// Nodo opcional para precisar la información de ubicación del domicilio en donde es emitido 
        /// el comprobante fiscal en caso de que sea distinto del domicilio fiscal del contribuyente emisor.
        /// </summary>
        [XmlElement("ExpedidoEn")]
        public IUbicacion ExpedidoEn {
            get { return this.expedidoEn; }
            set { this.expedidoEn = value; }
        }

        /// <summary>
        /// Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
        /// </summary>
        [XmlElement("RegimenFiscal", IsNullable = false)]
        public IList<IRegimenFiscal> RegimenFiscal {
            get { return this.regimenFiscal; }
            set { this.regimenFiscal = value; }
        }
    }
}
