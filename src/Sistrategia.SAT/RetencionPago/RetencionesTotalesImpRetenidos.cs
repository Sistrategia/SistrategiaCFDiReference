/**************************************************************************
 * Sistrategia.SAT.RetencionPago.RetencionesTotalesImpRetenidosTipoPagoRet.cs 
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
using System.Xml;
using System.Xml.Serialization;

namespace Sistrategia.SAT.RetencionPago
{
    /// <summary>
    /// Nodo opcional para expresar el total de los impuestos retenidos que se desprenden de los conceptos expresados en el documento de retenciones e información de pagos.
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public class RetencionesTotalesImpRetenidos
    {
        private decimal baseRet;
        private bool baseRetSpecified;
        private RetencionesTotalesImpRetenidosImpuesto impuesto;
        private bool impuestoSpecified;
        private decimal _montoRet;

        private RetencionesTotalesImpRetenidosTipoPagoRet tipoPagoRet;

        [XmlAttribute]
        public decimal BaseRet {
            get { return this.baseRet; }
            set { this.baseRet = value; }
        }

        [XmlIgnore]
        public bool BaseRetSpecified {
            get { return this.baseRetSpecified; }
            set { this.baseRetSpecified = value; }
        }

        [XmlAttribute]
        public RetencionesTotalesImpRetenidosImpuesto Impuesto {
            get { return this.impuesto; }
            set { this.impuesto = value; }
        }

        [XmlIgnore]
        public bool ImpuestoSpecified {
            get { return this.impuestoSpecified; }
            set { this.impuestoSpecified = value; }
        }

        [XmlAttribute]
        public decimal montoRet {
            get { return this._montoRet; }
            set { this._montoRet = value; }
        }

        [XmlAttribute]
        public RetencionesTotalesImpRetenidosTipoPagoRet TipoPagoRet {
            get { return this.tipoPagoRet; }
            set { this.tipoPagoRet = value; }
        }
    }
}
