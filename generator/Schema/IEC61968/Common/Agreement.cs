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
using TTC2017.SmartGrids.CIM;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Common
{
    
    
    /// <summary>
    /// The default implementation of the Agreement class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Common")]
    [XmlNamespacePrefixAttribute("cimCommon")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Common/Agreement")]
    [DebuggerDisplayAttribute("Agreement {UUID}")]
    public partial class Agreement : Document, IAgreement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SignDate property
        /// </summary>
        private string _signDate;
        
        private static Lazy<ITypedElement> _signDateAttribute = new Lazy<ITypedElement>(RetrieveSignDateAttribute);
        
        private static Lazy<ITypedElement> _validityIntervalReference = new Lazy<ITypedElement>(RetrieveValidityIntervalReference);
        
        /// <summary>
        /// The backing field for the ValidityInterval property
        /// </summary>
        private IDateTimeInterval _validityInterval;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The signDate property
        /// </summary>
        [XmlElementNameAttribute("signDate")]
        [XmlAttributeAttribute(true)]
        public virtual string SignDate
        {
            get
            {
                return this._signDate;
            }
            set
            {
                if ((this._signDate != value))
                {
                    string old = this._signDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSignDateChanging(e);
                    this.OnPropertyChanging("SignDate", e, _signDateAttribute);
                    this._signDate = value;
                    this.OnSignDateChanged(e);
                    this.OnPropertyChanged("SignDate", e, _signDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The validityInterval property
        /// </summary>
        [XmlElementNameAttribute("validityInterval")]
        [XmlAttributeAttribute(true)]
        public virtual IDateTimeInterval ValidityInterval
        {
            get
            {
                return this._validityInterval;
            }
            set
            {
                if ((this._validityInterval != value))
                {
                    IDateTimeInterval old = this._validityInterval;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValidityIntervalChanging(e);
                    this.OnPropertyChanging("ValidityInterval", e, _validityIntervalReference);
                    this._validityInterval = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetValidityInterval;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetValidityInterval;
                    }
                    this.OnValidityIntervalChanged(e);
                    this.OnPropertyChanged("ValidityInterval", e, _validityIntervalReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AgreementReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Common/Agreement")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SignDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SignDateChanging;
        
        /// <summary>
        /// Gets fired when the SignDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SignDateChanged;
        
        /// <summary>
        /// Gets fired before the ValidityInterval property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValidityIntervalChanging;
        
        /// <summary>
        /// Gets fired when the ValidityInterval property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValidityIntervalChanged;
        
        private static ITypedElement RetrieveSignDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Agreement.ClassInstance)).Resolve("signDate")));
        }
        
        /// <summary>
        /// Raises the SignDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSignDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SignDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SignDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSignDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SignDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveValidityIntervalReference()
        {
            return ((ITypedElement)(((ModelElement)(Agreement.ClassInstance)).Resolve("validityInterval")));
        }
        
        /// <summary>
        /// Raises the ValidityIntervalChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValidityIntervalChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValidityIntervalChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValidityIntervalChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValidityIntervalChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValidityIntervalChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ValidityInterval property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetValidityInterval(object sender, System.EventArgs eventArgs)
        {
            this.ValidityInterval = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SIGNDATE"))
            {
                return this.SignDate;
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
            if ((feature == "VALIDITYINTERVAL"))
            {
                this.ValidityInterval = ((IDateTimeInterval)(value));
                return;
            }
            if ((feature == "SIGNDATE"))
            {
                this.SignDate = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "ValidityInterval"))
            {
                return new ValidityIntervalProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "ValidityInterval"))
            {
                return new ValidityIntervalProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Common/Agreement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Agreement class
        /// </summary>
        public class AgreementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Agreement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AgreementReferencedElementsCollection(Agreement parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.ValidityInterval != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ValidityIntervalChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ValidityIntervalChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ValidityInterval == null))
                {
                    IDateTimeInterval validityIntervalCasted = item.As<IDateTimeInterval>();
                    if ((validityIntervalCasted != null))
                    {
                        this._parent.ValidityInterval = validityIntervalCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ValidityInterval = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ValidityInterval))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.ValidityInterval != null))
                {
                    array[arrayIndex] = this._parent.ValidityInterval;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ValidityInterval == item))
                {
                    this._parent.ValidityInterval = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ValidityInterval).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the signDate property
        /// </summary>
        private sealed class SignDateProxy : ModelPropertyChange<IAgreement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SignDateProxy(IAgreement modelElement) : 
                    base(modelElement, "signDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SignDate;
                }
                set
                {
                    this.ModelElement.SignDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the validityInterval property
        /// </summary>
        private sealed class ValidityIntervalProxy : ModelPropertyChange<IAgreement, IDateTimeInterval>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValidityIntervalProxy(IAgreement modelElement) : 
                    base(modelElement, "validityInterval")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDateTimeInterval Value
            {
                get
                {
                    return this.ModelElement.ValidityInterval;
                }
                set
                {
                    this.ModelElement.ValidityInterval = value;
                }
            }
        }
    }
}

