﻿/**************************************************************************
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
    /// Atributo opcional para señalar el tipo de impuesto retenido del periodo o ejercicio conforme al catálogo.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/esquemas/retencionpago/1")]
    public enum RetencionesTotalesImpRetenidosImpuesto
    {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
    }
}