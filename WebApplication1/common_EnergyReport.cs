﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace DomainModel {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EnergyReport {
        
        private DocumentIdentification_type documentIdentificationField;
        
        private EICIdentification_type senderIdentificationField;
        
        private EICIdentification_type receiverIdentificationField;
        
        private DocumentDateTime_type documentDateTimeField;
        
        private DocumentIdentification_type originalDocumentIdentificationField;
        
        private AccountTimeSeries_type[] accountTimeSeriesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DocumentIdentification_type DocumentIdentification {
            get {
                return this.documentIdentificationField;
            }
            set {
                this.documentIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EICIdentification_type SenderIdentification {
            get {
                return this.senderIdentificationField;
            }
            set {
                this.senderIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EICIdentification_type ReceiverIdentification {
            get {
                return this.receiverIdentificationField;
            }
            set {
                this.receiverIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DocumentDateTime_type DocumentDateTime {
            get {
                return this.documentDateTimeField;
            }
            set {
                this.documentDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DocumentIdentification_type OriginalDocumentIdentification {
            get {
                return this.originalDocumentIdentificationField;
            }
            set {
                this.originalDocumentIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccountTimeSeries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountTimeSeries_type[] AccountTimeSeries {
            get {
                return this.accountTimeSeriesField;
            }
            set {
                this.accountTimeSeriesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DocumentIdentification_type {
        
        private string vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Quantity_type {
        
        private string vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MeasurementUnit_type {
        
        private Quantity_type outQtyField;
        
        private Quantity_type inQtyField;
        
        private MeasurementUnit_typeV vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Quantity_type OutQty {
            get {
                return this.outQtyField;
            }
            set {
                this.outQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Quantity_type InQty {
            get {
                return this.inQtyField;
            }
            set {
                this.inQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MeasurementUnit_typeV v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum MeasurementUnit_typeV {
        
        /// <remarks/>
        KWH,
        
        /// <remarks/>
        M3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Integer_type {
        
        private string vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AccountInterval_type {
        
        private Integer_type posField;
        
        private MeasurementUnit_type[] measurementUnitField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Integer_type Pos {
            get {
                return this.posField;
            }
            set {
                this.posField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MeasurementUnit_type[] MeasurementUnit {
            get {
                return this.measurementUnitField;
            }
            set {
                this.measurementUnitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Resolution_type {
        
        private Resolution_typeV vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Resolution_typeV v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum Resolution_typeV {
        
        /// <remarks/>
        PT1H,
        
        /// <remarks/>
        PT1D,
        
        /// <remarks/>
        PT1M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimeInterval_type {
        
        private string vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Period_type {
        
        private TimeInterval_type timeIntervalField;
        
        private Resolution_type resolutionField;
        
        private AccountInterval_type[] accountIntervalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TimeInterval_type TimeInterval {
            get {
                return this.timeIntervalField;
            }
            set {
                this.timeIntervalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Resolution_type Resolution {
            get {
                return this.resolutionField;
            }
            set {
                this.resolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccountInterval", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountInterval_type[] AccountInterval {
            get {
                return this.accountIntervalField;
            }
            set {
                this.accountIntervalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AccountTimeSeries_type {
        
        private EICIdentification_type accountingPointField;
        
        private Period_type[] periodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EICIdentification_type AccountingPoint {
            get {
                return this.accountingPointField;
            }
            set {
                this.accountingPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Period_type[] Period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EICIdentification_type {
        
        private string vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DocumentDateTime_type {
        
        private System.DateTime vField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
    }
}
