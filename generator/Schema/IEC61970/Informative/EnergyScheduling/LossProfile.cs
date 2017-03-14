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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling
{
    
    
    /// <summary>
    /// The default implementation of the LossProfile class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#EnergyScheduling")]
    [XmlNamespacePrefixAttribute("cimEnergyScheduling")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
        "LossProfile")]
    [DebuggerDisplayAttribute("LossProfile {UUID}")]
    public class LossProfile : Profile, ILossProfile, IModelElement
    {
        
        /// <summary>
        /// The backing field for the HasLoss_ property
        /// </summary>
        private ITransmissionProvider _hasLoss_;
        
        /// <summary>
        /// The backing field for the EnergyTransaction property
        /// </summary>
        private IEnergyTransaction _energyTransaction;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The HasLoss_ property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("For")]
        public virtual ITransmissionProvider HasLoss_
        {
            get
            {
                return this._hasLoss_;
            }
            set
            {
                if ((this._hasLoss_ != value))
                {
                    ITransmissionProvider old = this._hasLoss_;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHasLoss_Changing(e);
                    this.OnPropertyChanging("HasLoss_", e);
                    this._hasLoss_ = value;
                    if ((old != null))
                    {
                        old.For.Remove(this);
                        old.Deleted -= this.OnResetHasLoss_;
                    }
                    if ((value != null))
                    {
                        value.For.Add(this);
                        value.Deleted += this.OnResetHasLoss_;
                    }
                    this.OnHasLoss_Changed(e);
                    this.OnPropertyChanged("HasLoss_", e);
                }
            }
        }
        
        /// <summary>
        /// The EnergyTransaction property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("LossProfiles")]
        public virtual IEnergyTransaction EnergyTransaction
        {
            get
            {
                return this._energyTransaction;
            }
            set
            {
                if ((this._energyTransaction != value))
                {
                    IEnergyTransaction old = this._energyTransaction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnergyTransactionChanging(e);
                    this.OnPropertyChanging("EnergyTransaction", e);
                    this._energyTransaction = value;
                    if ((old != null))
                    {
                        old.LossProfiles.Remove(this);
                        old.Deleted -= this.OnResetEnergyTransaction;
                    }
                    if ((value != null))
                    {
                        value.LossProfiles.Add(this);
                        value.Deleted += this.OnResetEnergyTransaction;
                    }
                    this.OnEnergyTransactionChanged(e);
                    this.OnPropertyChanged("EnergyTransaction", e);
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
                return base.ReferencedElements.Concat(new LossProfileReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                            "LossProfile")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the HasLoss_ property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HasLoss_Changing;
        
        /// <summary>
        /// Gets fired when the HasLoss_ property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HasLoss_Changed;
        
        /// <summary>
        /// Gets fired before the EnergyTransaction property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyTransactionChanging;
        
        /// <summary>
        /// Gets fired when the EnergyTransaction property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyTransactionChanged;
        
        /// <summary>
        /// Raises the HasLoss_Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHasLoss_Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HasLoss_Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HasLoss_Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHasLoss_Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HasLoss_Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the HasLoss_ property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetHasLoss_(object sender, System.EventArgs eventArgs)
        {
            this.HasLoss_ = null;
        }
        
        /// <summary>
        /// Raises the EnergyTransactionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyTransactionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyTransactionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyTransactionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyTransactionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyTransactionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EnergyTransaction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEnergyTransaction(object sender, System.EventArgs eventArgs)
        {
            this.EnergyTransaction = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "HASLOSS_"))
            {
                this.HasLoss_ = ((ITransmissionProvider)(value));
                return;
            }
            if ((feature == "ENERGYTRANSACTION"))
            {
                this.EnergyTransaction = ((IEnergyTransaction)(value));
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
            if ((attribute == "HasLoss_"))
            {
                return new HasLoss_Proxy(this);
            }
            if ((attribute == "EnergyTransaction"))
            {
                return new EnergyTransactionProxy(this);
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
            if ((reference == "HasLoss_"))
            {
                return new HasLoss_Proxy(this);
            }
            if ((reference == "EnergyTransaction"))
            {
                return new EnergyTransactionProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                        "LossProfile")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the LossProfile class
        /// </summary>
        public class LossProfileReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private LossProfile _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LossProfileReferencedElementsCollection(LossProfile parent)
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
                    if ((this._parent.HasLoss_ != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.EnergyTransaction != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.HasLoss_Changed += this.PropagateValueChanges;
                this._parent.EnergyTransactionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.HasLoss_Changed -= this.PropagateValueChanges;
                this._parent.EnergyTransactionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.HasLoss_ == null))
                {
                    ITransmissionProvider hasLoss_Casted = item.As<ITransmissionProvider>();
                    if ((hasLoss_Casted != null))
                    {
                        this._parent.HasLoss_ = hasLoss_Casted;
                        return;
                    }
                }
                if ((this._parent.EnergyTransaction == null))
                {
                    IEnergyTransaction energyTransactionCasted = item.As<IEnergyTransaction>();
                    if ((energyTransactionCasted != null))
                    {
                        this._parent.EnergyTransaction = energyTransactionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.HasLoss_ = null;
                this._parent.EnergyTransaction = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.HasLoss_))
                {
                    return true;
                }
                if ((item == this._parent.EnergyTransaction))
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
                if ((this._parent.HasLoss_ != null))
                {
                    array[arrayIndex] = this._parent.HasLoss_;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.EnergyTransaction != null))
                {
                    array[arrayIndex] = this._parent.EnergyTransaction;
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
                if ((this._parent.HasLoss_ == item))
                {
                    this._parent.HasLoss_ = null;
                    return true;
                }
                if ((this._parent.EnergyTransaction == item))
                {
                    this._parent.EnergyTransaction = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.HasLoss_).Concat(this._parent.EnergyTransaction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the HasLoss_ property
        /// </summary>
        private sealed class HasLoss_Proxy : ModelPropertyChange<ILossProfile, ITransmissionProvider>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HasLoss_Proxy(ILossProfile modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITransmissionProvider Value
            {
                get
                {
                    return this.ModelElement.HasLoss_;
                }
                set
                {
                    this.ModelElement.HasLoss_ = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.HasLoss_Changed += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.HasLoss_Changed -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EnergyTransaction property
        /// </summary>
        private sealed class EnergyTransactionProxy : ModelPropertyChange<ILossProfile, IEnergyTransaction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnergyTransactionProxy(ILossProfile modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEnergyTransaction Value
            {
                get
                {
                    return this.ModelElement.EnergyTransaction;
                }
                set
                {
                    this.ModelElement.EnergyTransaction = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EnergyTransactionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EnergyTransactionChanged -= handler;
            }
        }
    }
}

