//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.SmartGrids.CIM
{
    
    
    /// <summary>
    /// The default implementation of the Element class
    /// </summary>
    [XmlIdentifierAttribute("UUID")]
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14")]
    [XmlNamespacePrefixAttribute("cim")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//Element")]
    [DebuggerDisplayAttribute("Element {UUID}")]
    public abstract partial class Element : ModelElement, IElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the UUID property
        /// </summary>
        private string _uUID;
        
        private static Lazy<ITypedElement> _uUIDAttribute = new Lazy<ITypedElement>(RetrieveUUIDAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The UUID property
        /// </summary>
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        public virtual string UUID
        {
            get
            {
                return this._uUID;
            }
            set
            {
                if ((this._uUID != value))
                {
                    string old = this._uUID;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUUIDChanging(e);
                    this.OnPropertyChanging("UUID", e, _uUIDAttribute);
                    this._uUID = value;
                    this.OnUUIDChanged(e);
                    this.OnPropertyChanged("UUID", e, _uUIDAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//Element")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the current model element can be identified by an attribute value
        /// </summary>
        public override bool IsIdentified
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired before the UUID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UUIDChanging;
        
        /// <summary>
        /// Gets fired when the UUID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UUIDChanged;
        
        private static ITypedElement RetrieveUUIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Element.ClassInstance)).Resolve("UUID")));
        }
        
        /// <summary>
        /// Raises the UUIDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUUIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UUIDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UUIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUUIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UUIDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "UUID"))
            {
                return this.UUID;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "UUID"))
            {
                this.UUID = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//Element")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Gets the identifier string for this model element
        /// </summary>
        /// <returns>The identifier string</returns>
        public override string ToIdentifierString()
        {
            if ((this.UUID == null))
            {
                return null;
            }
            return this.UUID.ToString();
        }
        
        protected override Uri CreateUriWithFragment(string fragment, bool absolute, IModelElement baseElement)
        {
            return this.CreateUriFromGlobalIdentifier(fragment, absolute);
        }
        
        protected override void PropagateNewModel(Model newModel, Model oldModel, IModelElement subtreeRoot)
        {
            string id = this.ToIdentifierString();
            if ((oldModel != null))
            {
                oldModel.UnregisterId(id);
            }
            if ((newModel != null))
            {
                newModel.RegisterId(id, this);
            }
            base.PropagateNewModel(newModel, oldModel, subtreeRoot);
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the UUID property
        /// </summary>
        private sealed class UUIDProxy : ModelPropertyChange<IElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UUIDProxy(IElement modelElement) : 
                    base(modelElement, "UUID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.UUID;
                }
                set
                {
                    this.ModelElement.UUID = value;
                }
            }
        }
    }
}

