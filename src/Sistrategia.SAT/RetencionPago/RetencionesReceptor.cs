/**************************************************************************
 * Sistrategia.SAT.RetencionPago.RetencionesReceptor.cs 
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
    /// Nodo requerido para expresar la información del contribuyente receptor del documento electrónico de retenciones e información de pagos.
    /// </summary>
    /// <remarks>
    /// See full schema at http://www.sat.gob.mx/esquemas/retencionpago/1/retencionpagov1.xsd
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public class RetencionesReceptor
    {
        private object item;
        //private RetencionesReceptorNacionalidad nacionalidadField;
        private string nacionalidad;

        //[XmlAttribute("Extranjero", typeof(RetencionesReceptorExtranjero))]
        //[XmlAttribute("Nacional", typeof(RetencionesReceptorNacional))]
        public object Item {
            get { return this.item; }
            set { this.item = value; }
        }

        [XmlAttribute]
        //public RetencionesReceptorNacionalidad Nacionalidad
        public string Nacionalidad {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
    }
}
