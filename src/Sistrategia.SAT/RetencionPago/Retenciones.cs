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
    /// Estándar de Documento Electrónico Retenciones e Información de Pagos.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/esquemas/retencionpago/1/retencionpagov1.xsd
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1", IsNullable = false)]
    public class Retenciones
    {
        private RetencionesEmisor emisorField;
        private RetencionesReceptor receptorField;
        private RetencionesPeriodo periodoField;
        private RetencionesTotales totalesField;
        private RetencionesComplemento complementoField;
        private RetencionesAddenda addendaField;
        private string versionField;
        private string folioIntField;
        private string selloField;
        private string numCertField;
        private string certField;
        private System.DateTime fechaExpField;

        //private c_Retenciones cveRetencField;
        private string cveRetencField;
        private string descRetencField;

        public Retenciones() {
            this.versionField = "1.0";
        }

        public RetencionesEmisor Emisor {
            get { return this.emisorField; }
            set { this.emisorField = value; }
        }

        public RetencionesReceptor Receptor {
            get { return this.receptorField; }
            set { this.receptorField = value; }
        }

        public RetencionesPeriodo Periodo {
            get { return this.periodoField; }
            set { this.periodoField = value; }
        }

        public RetencionesTotales Totales {
            get { return this.totalesField; }
            set { this.totalesField = value; }
        }

        public RetencionesComplemento Complemento {
            get { return this.complementoField; }
            set { this.complementoField = value; }
        }

        public RetencionesAddenda Addenda {
            get { return this.addendaField; }
            set { this.addendaField = value; }
        }

        [XmlAttribute]
        public string Version {
            get { return this.versionField; }
            set { this.versionField = value; }
        }

        [XmlAttribute]
        public string FolioInt {
            get { return this.folioIntField; }
            set { this.folioIntField = value; }
        }

        [XmlAttribute]
        public string Sello {
            get { return this.selloField; }
            set { this.selloField = value; }
        }

        [XmlAttribute]
        public string NumCert {
            get { return this.numCertField; }
            set { this.numCertField = value; }
        }

        [XmlAttribute]
        public string Cert {
            get { return this.certField; }
            set { this.certField = value; }
        }

        [XmlAttribute]
        public System.DateTime FechaExp {
            get { return this.fechaExpField; }
            set { this.fechaExpField = value; }
        }

        [XmlAttribute]
        //public c_Retenciones CveRetenc
        public string CveRetenc {
            get { return this.cveRetencField; }
            set { this.cveRetencField = value; }
        }

        [XmlAttribute]
        public string DescRetenc {
            get { return this.descRetencField; }
            set { this.descRetencField = value; }
        }
    }
}

