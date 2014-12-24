/**************************************************************************
 * Sistrategia.SAT.CFDI.Impuestos.cs 
 * 
 * Author(s):   José Ernesto Ocampo Cicero <ernesto@sistrategia.com>
 * Last Update:	2014-Oct-10
 * Created:	    2010-Dec-24
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
    /// Nodo requerido para capturar los impuestos aplicables.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd    
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Impuestos
    {
        private Retencion[] retenciones;
        private Traslado[] traslados;

        private decimal totalImpuestosRetenidos;
        private bool totalImpuestosRetenidosSpecified = false;
        private decimal totalImpuestosTrasladados;
        private bool totalImpuestosTrasladadosSpecified = false;

        /// <summary>
        /// Nodo opcional para capturar los impuestos retenidos aplicables
        /// </summary>
        [XmlArrayItem("Retencion", IsNullable = false)]
        public Retencion[] Retenciones {
            get { return this.retenciones; }
            set { this.retenciones = value; }
        }

        /// <summary>
        /// Nodo opcional para asentar o referir los impuestos trasladados aplicables
        /// </summary>
        [XmlArrayItem("Traslado", IsNullable = false)]
        public Traslado[] Traslados {
            get { return this.traslados; }
            set { this.traslados = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar el total de los impuestos retenidos que se desprenden 
        /// de los conceptos expresados en el comprobante fiscal digital a través de Internet.
        /// </summary>
        [XmlAttribute("totalImpuestosRetenidos")]
        public decimal TotalImpuestosRetenidos {
            get { return this.totalImpuestosRetenidos; }
            set { this.totalImpuestosRetenidos = value; }
        }
        //<xs:attribute name="totalImpuestosRetenidos" type="cfdi:t_Importe" use="optional">
        //    <xs:annotation>
        //    <xs:documentation>Atributo opcional para expresar el total de los impuestos retenidos que se desprenden de los conceptos expresados en el comprobante fiscal digital a través de Internet.</xs:documentation>
        //    </xs:annotation>
        //</xs:attribute>


        [XmlIgnore]
        public bool TotalImpuestosRetenidosSpecified {
            get { return this.totalImpuestosRetenidosSpecified; }
            set { this.totalImpuestosRetenidosSpecified = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar el total de los impuestos trasladados que se desprenden 
        /// de los conceptos expresados en el comprobante fiscal digital a través de Internet.
        /// </summary>
        [XmlAttribute("totalImpuestosTrasladados")]
        public decimal TotalImpuestosTrasladados {
            get { return this.totalImpuestosTrasladados; }
            set { this.totalImpuestosTrasladados = value; }
        }
        //<xs:attribute name="totalImpuestosTrasladados" type="cfdi:t_Importe" use="optional">
        //    <xs:annotation>
        //    <xs:documentation>Atributo opcional para expresar el total de los impuestos trasladados que se desprenden de los conceptos expresados en el comprobante fiscal digital a través de Internet.</xs:documentation>
        //    </xs:annotation>
        //</xs:attribute>

        [XmlIgnore]
        public bool TotalImpuestosTrasladadosSpecified {
            get { return this.totalImpuestosTrasladadosSpecified; }
            set { this.totalImpuestosTrasladadosSpecified = value; }
        }
    }
}
