//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace DLV_DL5 {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class S5Data {
        
        private S5DataDodaciListVydany[] dodaciListVydanyListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DodaciListVydany", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataDodaciListVydany[] DodaciListVydanyList {
            get {
                return this.dodaciListVydanyListField;
            }
            set {
                this.dodaciListVydanyListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydany {
        
        private group groupField;
        
        private string cisloDokladuField;
        
        private string odkazField;
        
        private string pocetPolozekField;
        
        private S5DataDodaciListVydanyAdresa adresaField;
        
        private S5DataDodaciListVydanyMojeFirma mojeFirmaField;
        
        private S5DataDodaciListVydanySuma sumaField;
        
        private S5DataDodaciListVydanyDetailniRozpisDPH detailniRozpisDPHField;
        
        private S5DataDodaciListVydanyPolozky polozkyField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydany() {
            this.objectNameField = "DodaciListVydany";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public group Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CisloDokladu {
            get {
                return this.cisloDokladuField;
            }
            set {
                this.cisloDokladuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Odkaz {
            get {
                return this.odkazField;
            }
            set {
                this.odkazField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PocetPolozek {
            get {
                return this.pocetPolozekField;
            }
            set {
                this.pocetPolozekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyAdresa Adresa {
            get {
                return this.adresaField;
            }
            set {
                this.adresaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyMojeFirma MojeFirma {
            get {
                return this.mojeFirmaField;
            }
            set {
                this.mojeFirmaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanySuma Suma {
            get {
                return this.sumaField;
            }
            set {
                this.sumaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyDetailniRozpisDPH DetailniRozpisDPH {
            get {
                return this.detailniRozpisDPHField;
            }
            set {
                this.detailniRozpisDPHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyPolozky Polozky {
            get {
                return this.polozkyField;
            }
            set {
                this.polozkyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class group {
        
        private string idField;
        
        private string kodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyAdresa {
        
        private S5DataDodaciListVydanyAdresaFirma firmaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyAdresaFirma Firma {
            get {
                return this.firmaField;
            }
            set {
                this.firmaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyAdresaFirma {
        
        private group groupField;
        
        private string iCOField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydanyAdresaFirma() {
            this.objectNameField = "Firma";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public group Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ICO {
            get {
                return this.iCOField;
            }
            set {
                this.iCOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyMojeFirma {
        
        private string icField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IC {
            get {
                return this.icField;
            }
            set {
                this.icField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanySuma {
        
        private string celkemField;
        
        private string zakladField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Celkem {
            get {
                return this.celkemField;
            }
            set {
                this.celkemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zaklad {
            get {
                return this.zakladField;
            }
            set {
                this.zakladField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyDetailniRozpisDPH {
        
        private S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPH[] detailniRozpisDPHField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        public S5DataDodaciListVydanyDetailniRozpisDPH() {
            this.objectNameField = "DetailniRozpisDPH";
            this.objectTypeField = "List";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DetailniRozpisDPH", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPH[] DetailniRozpisDPH {
            get {
                return this.detailniRozpisDPHField;
            }
            set {
                this.detailniRozpisDPHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPH {
        
        private string sumaCelkemField;
        
        private string sumaDPHField;
        
        private string sumaZakladField;
        
        private S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPHSazbaDPH sazbaDPHField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPH() {
            this.objectNameField = "DetailniRozpisDPH";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SumaCelkem {
            get {
                return this.sumaCelkemField;
            }
            set {
                this.sumaCelkemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SumaDPH {
            get {
                return this.sumaDPHField;
            }
            set {
                this.sumaDPHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SumaZaklad {
            get {
                return this.sumaZakladField;
            }
            set {
                this.sumaZakladField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPHSazbaDPH SazbaDPH {
            get {
                return this.sazbaDPHField;
            }
            set {
                this.sazbaDPHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPHSazbaDPH {
        
        private string sazbaField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPHSazbaDPH() {
            this.objectNameField = "SazbaDPH";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Sazba {
            get {
                return this.sazbaField;
            }
            set {
                this.sazbaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyPolozky {
        
        private S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydaneho[] polozkaDodacihoListuVydanehoField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        public S5DataDodaciListVydanyPolozky() {
            this.objectNameField = "PolozkaDodacihoListuVydaneho";
            this.objectTypeField = "List";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PolozkaDodacihoListuVydaneho", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydaneho[] PolozkaDodacihoListuVydaneho {
            get {
                return this.polozkaDodacihoListuVydanehoField;
            }
            set {
                this.polozkaDodacihoListuVydanehoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydaneho {
        
        private string celkovaCenaField;
        
        private string jednCenaField;
        
        private string mnozstviField;
        
        private S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoDPH dPHField;
        
        private S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozky obsahPolozkyField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydaneho() {
            this.objectNameField = "PolozkaDodacihoListuVydaneho";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CelkovaCena {
            get {
                return this.celkovaCenaField;
            }
            set {
                this.celkovaCenaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JednCena {
            get {
                return this.jednCenaField;
            }
            set {
                this.jednCenaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mnozstvi {
            get {
                return this.mnozstviField;
            }
            set {
                this.mnozstviField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoDPH DPH {
            get {
                return this.dPHField;
            }
            set {
                this.dPHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozky ObsahPolozky {
            get {
                return this.obsahPolozkyField;
            }
            set {
                this.obsahPolozkyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoDPH {
        
        private string celkemField;
        
        private string danField;
        
        private string sazbaField;
        
        private string zakladField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Celkem {
            get {
                return this.celkemField;
            }
            set {
                this.celkemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Dan {
            get {
                return this.danField;
            }
            set {
                this.danField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Sazba {
            get {
                return this.sazbaField;
            }
            set {
                this.sazbaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zaklad {
            get {
                return this.zakladField;
            }
            set {
                this.zakladField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozky {
        
        private S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozkyArtikl artiklField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozky() {
            this.objectNameField = "ObsahPolozkySArtiklem";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozkyArtikl Artikl {
            get {
                return this.artiklField;
            }
            set {
                this.artiklField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozkyArtikl {
        
        private group groupField;
        
        private string kodField;
        
        private string nazevField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydanehoObsahPolozkyArtikl() {
            this.objectNameField = "Artikl";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public group Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
