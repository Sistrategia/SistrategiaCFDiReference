﻿/**************************************************************************
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
using System.Collections.Generic;
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
    /// The referenced schema in the xsd at: http://www.sat.gob.mx/cfd/3/cfdv32.xsd
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

        //private string noAprobacion;
        //private string anoAprobacion;

        private string formaDePago;
        private string noCertificado;
        private string certificado;
        private string condicionesDePago;
        private decimal subTotal;
        private decimal descuento;
        private bool descuentoSpecified;
        //private decimal? descuento;
        private string motivoDescuento;

        private string tipoCambioField;
        private string monedaField;

        private decimal total;
        //private ComprobanteTipoDeComprobante tipoDeComprobante;
        private string metodoDePago;
        private string lugarExpedicionField;
        private string numCtaPagoField;
        private string folioFiscalOrigField;
        private bool fechaFolioFiscalOrigFieldSpecified = false;
        private string serieFolioFiscalOrigField;
        private DateTime fechaFolioFiscalOrigField;
        private decimal montoFolioFiscalOrigField;
        private bool montoFolioFiscalOrigFieldSpecified = false;




        private Emisor emisor;
        private Receptor receptor;        
        //private Concepto[] conceptos;
        private List<Concepto> conceptos;
        private Impuestos impuestos;

        private Complemento complemento;
        //private Addenda addenda;
        #endregion

        #region Constructors
        public Comprobante() {
            this.version = "3.2";
            this.emisor = new Emisor();
            this.receptor = new Receptor();
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

        ///// <summary>
        ///// Atributo requerido para precisar el número de aprobación emitido por el SAT, para el rango de folios al que pertenece el folio particular que ampara el comprobante fiscal digital.
        ///// </summary>
        ///// <remarks>
        ///// Este atributo no está presente en la versión 3.0 y 3.2 (Exclusivo de CFD)
        ///// </remarks>
        //[XmlAttribute("noAprobacion", DataType = "integer")]
        ////[XmlAttributeAttribute("noAprobacion", typeof(System.Decimal))]
        //public string NoAprobacion {
        //    get { return this.currentData.NoAprobacion; }
        //    set { this.currentData.NoAprobacion = value; }
        //}

        ///// <summary>
        ///// Atributo requerido para precisar el año en que se solicito el folio que se están utilizando para emitir el comprobante fiscal digital.
        ///// </summary>
        ///// <remarks>
        ///// 4 Dígitos
        ///// Este atributo empezó en la versión 2.0 hasta la versión 2.2 (no se encuentra en la versión 1.0)
        ///// Este atributo no está presente en la versión 3.0 y 3.2 (Exclusivo de CFD)
        ///// </remarks>
        //[XmlAttribute("anoAprobacion", DataType = "integer")]
        //public string AnoAprobacion {
        //    get { return this.currentData.AnoAprobacion; }
        //    set { this.currentData.AnoAprobacion = value; }
        //}


        /// <summary>
        /// Atributo requerido para precisar la forma de pago que aplica para este comprobante fiscal digital a través de Internet. Se utiliza para expresar Pago en una sola exhibición o número de parcialidad pagada contra el total de  parcialidades, Parcialidad 1 de X.
        /// </summary>
        /// <remarks>
        /// Requerido
        /// No debe contener espacios en blanco
        /// <code>
        /// <xs:attribute name="formaDePago" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido para precisar la forma de pago que aplica para este comprobnante fiscal digital a través de Internet. Se utiliza para expresar Pago en una sola exhibición o número de parcialidad pagada contra el total de parcialidades, Parcialidad 1 de X.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("formaDePago")]
        public string FormaDePago {
            get { return this.formaDePago; }
            set { this.formaDePago = value; }
        }


        /// <summary>
        /// Atributo requerido para expresar el número de serie del certificado de sello digital que ampara al comprobante, de acuerdo al acuse correspondiente a 20 posiciones otorgado por el sistema del SAT.
        /// </summary>
        /// <remarks>
        /// Requerido
        /// No debe contener espacios en blanco
        /// El largo debe estar a 20 caracteres
        /// <code>
        /// <xs:attribute name="noCertificado" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido para expresar el número de serie del certificado de sello digital que ampara al comprobante, de acuerdo al acuse correspondiente a 20 posiciones otorgado por el sistema del SAT.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:length value="20"/>
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("noCertificado")]
        public string NoCertificado {
            get { return this.noCertificado; }
            set { this.noCertificado = value; }
        }


        /// <summary>
        /// Atributo requerido que sirve para expresar el certificado de sello digital que ampara al comprobante como texto, en formato base 64.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="certificado" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido que sirve para expresar el certificado de sello digital que ampara al comprobante como texto, en formato base 64.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("certificado")]
        public string Certificado {
            get { return this.certificado; }
            set { this.certificado = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar las condiciones comerciales aplicables para el pago del comprobante fiscal digital a través de Internet.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="condicionesDePago" use="optional">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para expresar las condiciones comerciales aplicables para el pago del comprobante fiscal digital a través de Internet.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///           <xs:minLength value="1"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("condicionesDePago")]
        public string CondicionesDePago {
            get { return this.condicionesDePago; }
            set { this.condicionesDePago = value; }
        }        

        /// <summary>
        /// Atributo requerido para representar la suma de los importes antes de descuentos e impuestos.
        /// </summary>
        /// <remarks>
        /// Tipo t_Importe a 6 decimales
        /// <code>
        /// <xs:attribute name="subTotal" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido para representar la suma de los importes antes de descuentos e impuestos.
        ///       </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("subTotal")]
        public decimal SubTotal {
            get { return this.subTotal; }
            set { this.subTotal = value; }
        }

        /// <summary>
        /// Atributo opcional para representar el importe total de los descuentos aplicables antes de impuestos
        /// </summary>
        /// <remarks>
        /// Tipo t_Importe a 6 decimales
        /// <code>
        /// <xs:attribute name="descuento" type="cfdi:t_Importe" use="optional">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para representar el importe total de los descuentos aplicables antes de impuestos.
        ///       </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("descuento")]
        public decimal Descuento {
        //public decimal? Descuento {
            get { return this.descuento; }
            set { this.descuento = value; }
        }

        [XmlIgnore]
        public bool DescuentoSpecified {
            get { return this.descuentoSpecified; }
            set { this.descuentoSpecified = value; }
        }


        /// <summary>
        /// Atributo opcional para expresar el motivo del descuento aplicable.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="motivoDescuento" use="optional">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para expresar el motivo del descuento aplicable.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:minLength value="1"/>
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("motivoDescuento")]
        public string MotivoDescuento {
            get { return this.motivoDescuento; }
            set { this.motivoDescuento = value; }
        }

        /// <summary>
        /// Atributo opcional para representar el tipo de cambio conforme a la moneda usada
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="TipoCambio">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para representar el tipo de cambio conforme a la moneda usada
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("TipoCambio")]
        public string TipoCambio {
            get { return this.tipoCambioField; }
            set { this.tipoCambioField = value; }
        }        

        /// <summary>
        /// Atributo opcional para expresar la moneda utilizada para expresar los montos.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="Moneda">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para expresar la moneda utilizada para expresar los montos
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("Moneda")]
        public string Moneda {
            get { return this.monedaField; }
            set { this.monedaField = value; }
        }        

        /// <summary>
        /// Atributo requerido para representar la suma del subtotal, menos los descuentos aplicables, más los impuestos trasladados, menos los impuestos retenidos.
        /// </summary>
        /// <remarks>
        /// Tipo t_Importe a 6 decimales
        /// <code>
        /// <xs:attribute name="total" type="cfdi:t_Importe" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido para representar la suma del subtotal, menos los descuentos aplicables, más los impuestos trasladados, menos los impuestos retenidos.
        ///       </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("total")]
        public decimal Total {
            get { return this.total; }
            set { this.total = value; }
        }


        ///// <summary>
        ///// Atributo requerido para expresar el efecto del comprobante fiscal para el contribuyente emisor.
        ///// </summary>
        ///// <remarks>
        ///// <code>
        ///// <xs:attribute name="tipoDeComprobante" use="required">
        /////   <xs:annotation>
        /////       <xs:documentation>
        /////           Atributo requerido para expresar el efecto del comprobante fiscal para el contribuyente emisor.
        /////       </xs:documentation>
        /////   </xs:annotation>
        /////   <xs:simpleType>
        /////       <xs:restriction base="xs:string">
        /////           <xs:enumeration value="ingreso"/>
        /////           <xs:enumeration value="egreso"/>
        /////           <xs:enumeration value="traslado"/>
        /////       </xs:restriction>
        /////   </xs:simpleType>
        ///// </xs:attribute>
        ///// </code>
        ///// </remarks>
        //[XmlAttribute("tipoDeComprobante")]
        //public ComprobanteTipoDeComprobante TipoDeComprobante {
        //    get { return this.tipoDeComprobante; }
        //    set { this.tipoDeComprobante = value; }
        //}

        /// <summary>		
        /// Atributo requerido de texto libre para expresar el método de pago de los bienes o servicios amparados por el comprobante. Se entiende como método de pago leyendas tales como: cheque, tarjeta de crédito o debito, depósito en cuenta, etc.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="metodoDePago" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido de texto libre para expresar el método de pago de los bienes o servicios amparados por el comprobante. Se entiende como método de pago leyendas tales como: cheque, tarjeta de crédito o debito, depósito en cuenta, etc.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:minLength value="1"/>
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("metodoDePago")]
        public string MetodoDePago {
            get { return this.metodoDePago; }
            set { this.metodoDePago = value; }
        }

        /// <summary>
        /// Atributo requerido para incorporar el lugar de expedición del comprobante.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="LugarExpedicion" use="required">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo requerido para incorporar el lugar de expedición del comprobante.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:minLength value="1"/>
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("LugarExpedicion")]
        public string LugarExpedicion {
            get { return this.lugarExpedicionField; }
            set { this.lugarExpedicionField = value; }
        }

        /// <summary>
        /// Atributo Opcional para incorporar al menos los cuatro últimos digitos del número de cuenta con la que se realizó el pago.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="NumCtaPago">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo Opcional para incorporar al menos los cuatro últimos digitos del número de cuenta con la que se realizó el pago.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:minLength value="4"/>
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("NumCtaPago")]
        public string NumCtaPago {
            get { return this.numCtaPagoField; }
            set { this.numCtaPagoField = value; }
        }        

        /// <summary>
        /// Atributo opcional para señalar el número de folio fiscal del comprobante que se hubiese expedido por el valor total del comprobante, tratándose del pago en parcialidades.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="FolioFiscalOrig">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para señalar el número de folio fiscal del comprobante que se hubiese expedido por el valor total del comprobante, tratándose del pago en parcialidades.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("FolioFiscalOrig")]
        public string FolioFiscalOrig {
            get { return this.folioFiscalOrigField; }
            set { this.folioFiscalOrigField = value; }
        }

        /// <summary>
        /// Atributo opcional para señalar la serie del folio del comprobante que se hubiese expedido por el valor total del comprobante, tratándose del pago en parcialidades.
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="SerieFolioFiscalOrig">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para señalar la serie del folio del comprobante que se hubiese expedido por el valor total del comprobante, tratándose del pago en parcialidades.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:string">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("SerieFolioFiscalOrig")]
        public string SerieFolioFiscalOrig {
            get { return this.serieFolioFiscalOrigField; }
            set { this.serieFolioFiscalOrigField = value; }
        }

        /// <summary>
        /// Atributo opcional para señalar la fecha de expedición del comprobante que se hubiese emitido por el valor total del comprobante, tratándose del pago en parcialidades. Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601.
        /// </summary>
        /// <remarks>
        /// <code>
        //<xs:attribute name="FechaFolioFiscalOrig">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para señalar la fecha de expedición del comprobante que se hubiese emitido por el valor total del comprobante, tratándose del pago en parcialidades. Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601.
        ///       </xs:documentation>
        ///   </xs:annotation>
        ///   <xs:simpleType>
        ///       <xs:restriction base="xs:dateTime">
        ///           <xs:whiteSpace value="collapse"/>
        ///       </xs:restriction>
        ///   </xs:simpleType>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("FechaFolioFiscalOrig")]
        public System.DateTime FechaFolioFiscalOrig {
            get { return this.fechaFolioFiscalOrigField; }
            set { this.fechaFolioFiscalOrigField = value; }
        }
        

        [XmlIgnoreAttribute()]
        public bool FechaFolioFiscalOrigSpecified {
            get { return this.fechaFolioFiscalOrigFieldSpecified; }
            set { this.fechaFolioFiscalOrigFieldSpecified = value; }
        }

        /// <summary>
        /// Atributo opcional para señalar el total del comprobante que se hubiese expedido por el valor total de la operación, tratándose del pago en parcialidades
        /// </summary>
        /// <remarks>
        /// <code>
        /// <xs:attribute name="MontoFolioFiscalOrig" type="cfdi:t_Importe">
        ///   <xs:annotation>
        ///       <xs:documentation>
        ///           Atributo opcional para señalar el total del comprobante que se hubiese expedido por el valor total de la operación, tratándose del pago en parcialidades
        ///       </xs:documentation>
        ///   </xs:annotation>
        /// </xs:attribute>
        /// </code>
        /// </remarks>
        [XmlAttribute("MontoFolioFiscalOrig")]
        public decimal MontoFolioFiscalOrig {
            get { return this.montoFolioFiscalOrigField; }
            set { this.montoFolioFiscalOrigField = value; }
        }
        

        [XmlIgnoreAttribute()]
        public bool MontoFolioFiscalOrigSpecified {
            get { return this.montoFolioFiscalOrigFieldSpecified; }
            set { this.montoFolioFiscalOrigFieldSpecified = value; }
        }



        /// <summary>
        /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
        /// </summary>
        [XmlElement("Emisor", typeof(Emisor))]
        public Emisor Emisor {
            get { return this.emisor; }
            set { this.emisor = value; }
        }

        /// <summary>
        /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
        /// </summary>
        public Receptor Receptor {
            get { return this.receptor; }
            set { this.receptor = value; }
        }


        /////// <summary>
        /////// Nodo para introducir la información detallada de un bien o servicio amparado en el comprobante.
        /////// </summary>
        ////// [XmlArrayItemAttribute("Concepto", IsNullable = false)]
        ////public IList<ComprobanteConcepto> Conceptos {
        ////    get { return this.conceptos; }
        ////    //set { this.conceptos = value; }
        ////}

        ///// <summary>
        ///// Nodo para introducir la información detallada de un bien o servicio amparado en el comprobante.
        ///// </summary>
        //// [XmlArrayItemAttribute("Concepto", IsNullable = false)]
        //public IComprobanteConceptoCollection Conceptos {
        //    get { return this.currentData.Conceptos; }
        //    //set { this.currentData.Conceptos = value; }
        //}

        /// <summary>
        /// Nodo requerido para capturar los impuestos aplicables.
        /// </summary>
        public Impuestos Impuestos {
            get { return this.impuestos; }
            set { this.impuestos = value; }
        }


        /// <summary>
        /// Nodo opcional donde se incluirá el complemento Timbre Fiscal Digital de manera obligatoria 
        /// y los nodos complementarios determinados por el SAT, de acuerdo a las disposiciones particulares 
        /// a un sector o actividad específica.
        /// </summary>
        public Complemento Complemento {
            get { return this.complemento; }
            set { this.complemento = value; }
        }

          
    }
}
