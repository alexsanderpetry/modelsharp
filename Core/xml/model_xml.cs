﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace org.pescuma.ModelSharp.Core.xml {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class model {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string namespaceField;
        
        private string projectNamespaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("type", typeof(type))]
        [System.Xml.Serialization.XmlElementAttribute("using", typeof(@using))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string projectNamespace {
            get {
                return this.projectNamespaceField;
            }
            set {
                this.projectNamespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class type {
        
        private baseClass baseClassField;
        
        private object[] itemsField;
        
        private bool cloneableField;
        
        private bool cloneableFieldSpecified;
        
        private bool deepCopyField;
        
        private bool deepCopyFieldSpecified;
        
        private string docField;
        
        private string extendsField;
        
        private bool immutableField;
        
        private bool immutableFieldSpecified;
        
        private string implementsField;
        
        private string nameField;
        
        private bool serializableField;
        
        private bool serializableFieldSpecified;
        
        /// <remarks/>
        public baseClass baseClass {
            get {
                return this.baseClassField;
            }
            set {
                this.baseClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("collection", typeof(collection))]
        [System.Xml.Serialization.XmlElementAttribute("component", typeof(component))]
        [System.Xml.Serialization.XmlElementAttribute("computed-property", typeof(computedproperty))]
        [System.Xml.Serialization.XmlElementAttribute("property", typeof(property))]
        [System.Xml.Serialization.XmlElementAttribute("using", typeof(@using))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool cloneable {
            get {
                return this.cloneableField;
            }
            set {
                this.cloneableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cloneableSpecified {
            get {
                return this.cloneableFieldSpecified;
            }
            set {
                this.cloneableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deepCopy {
            get {
                return this.deepCopyField;
            }
            set {
                this.deepCopyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deepCopySpecified {
            get {
                return this.deepCopyFieldSpecified;
            }
            set {
                this.deepCopyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string doc {
            get {
                return this.docField;
            }
            set {
                this.docField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extends {
            get {
                return this.extendsField;
            }
            set {
                this.extendsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool immutable {
            get {
                return this.immutableField;
            }
            set {
                this.immutableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool immutableSpecified {
            get {
                return this.immutableFieldSpecified;
            }
            set {
                this.immutableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string implements {
            get {
                return this.implementsField;
            }
            set {
                this.implementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool serializable {
            get {
                return this.serializableField;
            }
            set {
                this.serializableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serializableSpecified {
            get {
                return this.serializableFieldSpecified;
            }
            set {
                this.serializableFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class baseClass {
        
        private bool hasChildPropertyChangedField;
        
        private bool hasChildPropertyChangedFieldSpecified;
        
        private bool hasChildPropertyChangingField;
        
        private bool hasChildPropertyChangingFieldSpecified;
        
        private bool hasCopyFromField;
        
        private bool hasCopyFromFieldSpecified;
        
        private bool hasPropertiesField;
        
        private bool hasPropertiesFieldSpecified;
        
        private bool hasPropertyChangedField;
        
        private bool hasPropertyChangedFieldSpecified;
        
        private bool hasPropertyChangingField;
        
        private bool hasPropertyChangingFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasChildPropertyChanged {
            get {
                return this.hasChildPropertyChangedField;
            }
            set {
                this.hasChildPropertyChangedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasChildPropertyChangedSpecified {
            get {
                return this.hasChildPropertyChangedFieldSpecified;
            }
            set {
                this.hasChildPropertyChangedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasChildPropertyChanging {
            get {
                return this.hasChildPropertyChangingField;
            }
            set {
                this.hasChildPropertyChangingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasChildPropertyChangingSpecified {
            get {
                return this.hasChildPropertyChangingFieldSpecified;
            }
            set {
                this.hasChildPropertyChangingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasCopyFrom {
            get {
                return this.hasCopyFromField;
            }
            set {
                this.hasCopyFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCopyFromSpecified {
            get {
                return this.hasCopyFromFieldSpecified;
            }
            set {
                this.hasCopyFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasProperties {
            get {
                return this.hasPropertiesField;
            }
            set {
                this.hasPropertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasPropertiesSpecified {
            get {
                return this.hasPropertiesFieldSpecified;
            }
            set {
                this.hasPropertiesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasPropertyChanged {
            get {
                return this.hasPropertyChangedField;
            }
            set {
                this.hasPropertyChangedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasPropertyChangedSpecified {
            get {
                return this.hasPropertyChangedFieldSpecified;
            }
            set {
                this.hasPropertyChangedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasPropertyChanging {
            get {
                return this.hasPropertyChangingField;
            }
            set {
                this.hasPropertyChangingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasPropertyChangingSpecified {
            get {
                return this.hasPropertyChangingFieldSpecified;
            }
            set {
                this.hasPropertyChangingFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class collection {
        
        private bool deepCopyField;
        
        private bool deepCopyFieldSpecified;
        
        private string docField;
        
        private bool lazyField;
        
        private bool lazyFieldSpecified;
        
        private string nameField;
        
        private bool readOnlyField;
        
        private bool readOnlyFieldSpecified;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deepCopy {
            get {
                return this.deepCopyField;
            }
            set {
                this.deepCopyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deepCopySpecified {
            get {
                return this.deepCopyFieldSpecified;
            }
            set {
                this.deepCopyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string doc {
            get {
                return this.docField;
            }
            set {
                this.docField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool lazy {
            get {
                return this.lazyField;
            }
            set {
                this.lazyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lazySpecified {
            get {
                return this.lazyFieldSpecified;
            }
            set {
                this.lazyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool readOnly {
            get {
                return this.readOnlyField;
            }
            set {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool readOnlySpecified {
            get {
                return this.readOnlyFieldSpecified;
            }
            set {
                this.readOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class component {
        
        private validation[] validationField;
        
        private string defaultField;
        
        private string docField;
        
        private bool lazyField;
        
        private bool lazyFieldSpecified;
        
        private string nameField;
        
        private bool receiveInConstructorField;
        
        private bool receiveInConstructorFieldSpecified;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        private string typeField;
        
        private string validation1Field;
        
        private string validationAttribField;
        
        private string validationExceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validation")]
        public validation[] validation {
            get {
                return this.validationField;
            }
            set {
                this.validationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string doc {
            get {
                return this.docField;
            }
            set {
                this.docField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool lazy {
            get {
                return this.lazyField;
            }
            set {
                this.lazyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lazySpecified {
            get {
                return this.lazyFieldSpecified;
            }
            set {
                this.lazyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool receiveInConstructor {
            get {
                return this.receiveInConstructorField;
            }
            set {
                this.receiveInConstructorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiveInConstructorSpecified {
            get {
                return this.receiveInConstructorFieldSpecified;
            }
            set {
                this.receiveInConstructorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("validation")]
        public string validation1 {
            get {
                return this.validation1Field;
            }
            set {
                this.validation1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validationAttrib {
            get {
                return this.validationAttribField;
            }
            set {
                this.validationAttribField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validationException {
            get {
                return this.validationExceptionField;
            }
            set {
                this.validationExceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class validation {
        
        private string attribField;
        
        private string exceptionField;
        
        private string testField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attrib {
            get {
                return this.attribField;
            }
            set {
                this.attribField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string test {
            get {
                return this.testField;
            }
            set {
                this.testField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("computed-property", Namespace="", IsNullable=false)]
    public partial class computedproperty {
        
        private bool cachedField;
        
        private bool cachedFieldSpecified;
        
        private string dependsOnField;
        
        private string docField;
        
        private string formulaField;
        
        private string getterField;
        
        private string nameField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool cached {
            get {
                return this.cachedField;
            }
            set {
                this.cachedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cachedSpecified {
            get {
                return this.cachedFieldSpecified;
            }
            set {
                this.cachedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dependsOn {
            get {
                return this.dependsOnField;
            }
            set {
                this.dependsOnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string doc {
            get {
                return this.docField;
            }
            set {
                this.docField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formula {
            get {
                return this.formulaField;
            }
            set {
                this.formulaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string getter {
            get {
                return this.getterField;
            }
            set {
                this.getterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class property {
        
        private validation[] validationField;
        
        private bool deepCopyField;
        
        private bool deepCopyFieldSpecified;
        
        private string defaultField;
        
        private string docField;
        
        private string getterField;
        
        private string nameField;
        
        private bool receiveInConstructorField;
        
        private bool receiveInConstructorFieldSpecified;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        private string requiredExceptionField;
        
        private string setterField;
        
        private string typeField;
        
        private string validation1Field;
        
        private string validationAttribField;
        
        private string validationExceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validation")]
        public validation[] validation {
            get {
                return this.validationField;
            }
            set {
                this.validationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deepCopy {
            get {
                return this.deepCopyField;
            }
            set {
                this.deepCopyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deepCopySpecified {
            get {
                return this.deepCopyFieldSpecified;
            }
            set {
                this.deepCopyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string doc {
            get {
                return this.docField;
            }
            set {
                this.docField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string getter {
            get {
                return this.getterField;
            }
            set {
                this.getterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool receiveInConstructor {
            get {
                return this.receiveInConstructorField;
            }
            set {
                this.receiveInConstructorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiveInConstructorSpecified {
            get {
                return this.receiveInConstructorFieldSpecified;
            }
            set {
                this.receiveInConstructorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requiredException {
            get {
                return this.requiredExceptionField;
            }
            set {
                this.requiredExceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string setter {
            get {
                return this.setterField;
            }
            set {
                this.setterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("validation")]
        public string validation1 {
            get {
                return this.validation1Field;
            }
            set {
                this.validation1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validationAttrib {
            get {
                return this.validationAttribField;
            }
            set {
                this.validationAttribField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validationException {
            get {
                return this.validationExceptionField;
            }
            set {
                this.validationExceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class @using {
        
        private string namespaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string @namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
    }
}
