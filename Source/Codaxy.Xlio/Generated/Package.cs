namespace XlsxLib.Xml.Package {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Box))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ISO3166))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RFC1766))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ISO6392))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(URI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IMT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DCMIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(W3CDTF))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Period))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UDC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LCC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DDC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MESH))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LCSH))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
    [System.Xml.Serialization.XmlRootAttribute("title", Namespace="http://purl.org/dc/elements/1.1/", IsNullable=false)]
    public partial class SimpleLiteral {
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/relationships")]
    [System.Xml.Serialization.XmlRootAttribute("Relationship", Namespace="http://schemas.openxmlformats.org/package/2006/relationships", IsNullable=false)]
    public partial class CT_Relationship {
        
        private ST_TargetMode targetModeField;
        
        private bool targetModeFieldSpecified;
        
        private string targetField;
        
        private string typeField;
        
        private string idField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ST_TargetMode TargetMode {
            get {
                return this.targetModeField;
            }
            set {
                this.targetModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetModeSpecified {
            get {
                return this.targetModeFieldSpecified;
            }
            set {
                this.targetModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/relationships")]
    public enum ST_TargetMode {
        
        /// <remarks/>
        External,
        
        /// <remarks/>
        Internal,
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/digital-signature")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureTime", Namespace="http://schemas.openxmlformats.org/package/2006/digital-signature", IsNullable=false)]
    public partial class CT_SignatureTime {
        
        private string formatField;
        
        private string valueField;
        
        /// <remarks/>
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/metadata/core-properties")]
    public partial class CT_Keyword {
        
        private string langField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/metadata/core-properties")]
    public partial class CT_Keywords {
        
        private CT_Keyword[] valueField;
        
        private string[] textField;
        
        private string langField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public CT_Keyword[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/metadata/core-properties")]
    [System.Xml.Serialization.XmlRootAttribute("coreProperties", Namespace="http://schemas.openxmlformats.org/package/2006/metadata/core-properties", IsNullable=false)]
    public partial class CT_CoreProperties {
        
        private string categoryField;
        
        private string contentStatusField;
        
        private SimpleLiteral createdField;
        
        private SimpleLiteral creatorField;
        
        private SimpleLiteral descriptionField;
        
        private SimpleLiteral identifierField;
        
        private CT_Keywords keywordsField;
        
        private SimpleLiteral languageField;
        
        private string lastModifiedByField;
        
        private System.DateTime lastPrintedField;
        
        private bool lastPrintedFieldSpecified;
        
        private SimpleLiteral modifiedField;
        
        private string revisionField;
        
        private SimpleLiteral subjectField;
        
        private SimpleLiteral titleField;
        
        private string versionField;
        
        /// <remarks/>
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public string contentStatus {
            get {
                return this.contentStatusField;
            }
            set {
                this.contentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/terms/")]
        public SimpleLiteral created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
        public SimpleLiteral creator {
            get {
                return this.creatorField;
            }
            set {
                this.creatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
        public SimpleLiteral description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
        public SimpleLiteral identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        public CT_Keywords keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
        public SimpleLiteral language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string lastModifiedBy {
            get {
                return this.lastModifiedByField;
            }
            set {
                this.lastModifiedByField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime lastPrinted {
            get {
                return this.lastPrintedField;
            }
            set {
                this.lastPrintedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastPrintedSpecified {
            get {
                return this.lastPrintedFieldSpecified;
            }
            set {
                this.lastPrintedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/terms/")]
        public SimpleLiteral modified {
            get {
                return this.modifiedField;
            }
            set {
                this.modifiedField = value;
            }
        }
        
        /// <remarks/>
        public string revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
        public SimpleLiteral subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
        public SimpleLiteral title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/content-types")]
    [System.Xml.Serialization.XmlRootAttribute("Override", Namespace="http://schemas.openxmlformats.org/package/2006/content-types", IsNullable=false)]
    public partial class CT_Override {
        
        private string contentTypeField;
        
        private string partNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentType {
            get {
                return this.contentTypeField;
            }
            set {
                this.contentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string PartName {
            get {
                return this.partNameField;
            }
            set {
                this.partNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/content-types")]
    [System.Xml.Serialization.XmlRootAttribute("Default", Namespace="http://schemas.openxmlformats.org/package/2006/content-types", IsNullable=false)]
    public partial class CT_Default {
        
        private string extensionField;
        
        private string contentTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentType {
            get {
                return this.contentTypeField;
            }
            set {
                this.contentTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class elementOrRefinementContainer {
        
        private SimpleLiteral[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contributor", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("coverage", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("creator", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("date", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("format", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("identifier", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("language", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("publisher", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("relation", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("rights", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("source", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("subject", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("type", typeof(SimpleLiteral), Namespace="http://purl.org/dc/elements/1.1/")]
        [System.Xml.Serialization.XmlElementAttribute("audience", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("mediator", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public SimpleLiteral[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:contributor")]
        contributor,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:coverage")]
        coverage,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:creator")]
        creator,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:date")]
        date,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:description")]
        description,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:format")]
        format,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:identifier")]
        identifier,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:language")]
        language,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:publisher")]
        publisher,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:relation")]
        relation,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:rights")]
        rights,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:source")]
        source,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:subject")]
        subject,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:title")]
        title,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://purl.org/dc/elements/1.1/:type")]
        type,
        
        /// <remarks/>
        audience,
        
        /// <remarks/>
        mediator,
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/elements/1.1/")]
    public partial class elementContainer {
        
        private SimpleLiteral[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contributor", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("coverage", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("creator", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("date", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("format", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("identifier", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("language", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("publisher", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("relation", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("rights", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("source", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("subject", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlElementAttribute("type", typeof(SimpleLiteral))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public SimpleLiteral[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/elements/1.1/", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        contributor,
        
        /// <remarks/>
        coverage,
        
        /// <remarks/>
        creator,
        
        /// <remarks/>
        date,
        
        /// <remarks/>
        description,
        
        /// <remarks/>
        format,
        
        /// <remarks/>
        identifier,
        
        /// <remarks/>
        language,
        
        /// <remarks/>
        publisher,
        
        /// <remarks/>
        relation,
        
        /// <remarks/>
        rights,
        
        /// <remarks/>
        source,
        
        /// <remarks/>
        subject,
        
        /// <remarks/>
        title,
        
        /// <remarks/>
        type,
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class TGN : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class Box : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class ISO3166 : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class Point : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class RFC1766 : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ISO639-2", Namespace="http://purl.org/dc/terms/")]
    public partial class ISO6392 : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class URI : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class IMT : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class DCMIType : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class W3CDTF : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class Period : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class UDC : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class LCC : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class DDC : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class MESH : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/dc/terms/")]
    public partial class LCSH : SimpleLiteral {
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/content-types")]
    [System.Xml.Serialization.XmlRootAttribute("Types", Namespace="http://schemas.openxmlformats.org/package/2006/content-types", IsNullable=false)]
    public partial class CT_Types {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Default", typeof(CT_Default))]
        [System.Xml.Serialization.XmlElementAttribute("Override", typeof(CT_Override))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/digital-signature")]
    [System.Xml.Serialization.XmlRootAttribute("RelationshipReference", Namespace="http://schemas.openxmlformats.org/package/2006/digital-signature", IsNullable=false)]
    public partial class CT_RelationshipReference {
        
        private string sourceIdField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceId {
            get {
                return this.sourceIdField;
            }
            set {
                this.sourceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/digital-signature")]
    [System.Xml.Serialization.XmlRootAttribute("RelationshipsGroupReference", Namespace="http://schemas.openxmlformats.org/package/2006/digital-signature", IsNullable=false)]
    public partial class CT_RelationshipsGroupReference {
        
        private string sourceTypeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string SourceType {
            get {
                return this.sourceTypeField;
            }
            set {
                this.sourceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openxmlformats.org/package/2006/relationships")]
    [System.Xml.Serialization.XmlRootAttribute("Relationships", Namespace="http://schemas.openxmlformats.org/package/2006/relationships", IsNullable=false)]
    public partial class CT_Relationships {
        
        private CT_Relationship[] relationshipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Relationship")]
        public CT_Relationship[] Relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
    }
}
