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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The default implementation of the PnodeClearing class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "PnodeClearing")]
    [DebuggerDisplayAttribute("PnodeClearing {UUID}")]
    public class PnodeClearing : MarketFactors, IPnodeClearing, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CongestLMP property
        /// </summary>
        private float _congestLMP;
        
        /// <summary>
        /// The backing field for the CostLMP property
        /// </summary>
        private float _costLMP;
        
        /// <summary>
        /// The backing field for the LossLMP property
        /// </summary>
        private float _lossLMP;
        
        /// <summary>
        /// The backing field for the Pnode property
        /// </summary>
        private IPnode _pnode;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The congestLMP property
        /// </summary>
        [XmlElementNameAttribute("congestLMP")]
        [XmlAttributeAttribute(true)]
        public virtual float CongestLMP
        {
            get
            {
                return this._congestLMP;
            }
            set
            {
                if ((this._congestLMP != value))
                {
                    float old = this._congestLMP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCongestLMPChanging(e);
                    this.OnPropertyChanging("CongestLMP", e);
                    this._congestLMP = value;
                    this.OnCongestLMPChanged(e);
                    this.OnPropertyChanged("CongestLMP", e);
                }
            }
        }
        
        /// <summary>
        /// The costLMP property
        /// </summary>
        [XmlElementNameAttribute("costLMP")]
        [XmlAttributeAttribute(true)]
        public virtual float CostLMP
        {
            get
            {
                return this._costLMP;
            }
            set
            {
                if ((this._costLMP != value))
                {
                    float old = this._costLMP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCostLMPChanging(e);
                    this.OnPropertyChanging("CostLMP", e);
                    this._costLMP = value;
                    this.OnCostLMPChanged(e);
                    this.OnPropertyChanged("CostLMP", e);
                }
            }
        }
        
        /// <summary>
        /// The lossLMP property
        /// </summary>
        [XmlElementNameAttribute("lossLMP")]
        [XmlAttributeAttribute(true)]
        public virtual float LossLMP
        {
            get
            {
                return this._lossLMP;
            }
            set
            {
                if ((this._lossLMP != value))
                {
                    float old = this._lossLMP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLossLMPChanging(e);
                    this.OnPropertyChanging("LossLMP", e);
                    this._lossLMP = value;
                    this.OnLossLMPChanged(e);
                    this.OnPropertyChanged("LossLMP", e);
                }
            }
        }
        
        /// <summary>
        /// The Pnode property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PnodeClearing")]
        public virtual IPnode Pnode
        {
            get
            {
                return this._pnode;
            }
            set
            {
                if ((this._pnode != value))
                {
                    IPnode old = this._pnode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPnodeChanging(e);
                    this.OnPropertyChanging("Pnode", e);
                    this._pnode = value;
                    if ((old != null))
                    {
                        old.PnodeClearing = null;
                        old.Deleted -= this.OnResetPnode;
                    }
                    if ((value != null))
                    {
                        value.PnodeClearing = this;
                        value.Deleted += this.OnResetPnode;
                    }
                    this.OnPnodeChanged(e);
                    this.OnPropertyChanged("Pnode", e);
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
                return base.ReferencedElements.Concat(new PnodeClearingReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                            "PnodeClearing")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CongestLMP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CongestLMPChanging;
        
        /// <summary>
        /// Gets fired when the CongestLMP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CongestLMPChanged;
        
        /// <summary>
        /// Gets fired before the CostLMP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CostLMPChanging;
        
        /// <summary>
        /// Gets fired when the CostLMP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CostLMPChanged;
        
        /// <summary>
        /// Gets fired before the LossLMP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LossLMPChanging;
        
        /// <summary>
        /// Gets fired when the LossLMP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LossLMPChanged;
        
        /// <summary>
        /// Gets fired before the Pnode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PnodeChanging;
        
        /// <summary>
        /// Gets fired when the Pnode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PnodeChanged;
        
        /// <summary>
        /// Raises the CongestLMPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCongestLMPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CongestLMPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CongestLMPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCongestLMPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CongestLMPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CostLMPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCostLMPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CostLMPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CostLMPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCostLMPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CostLMPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LossLMPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLossLMPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LossLMPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LossLMPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLossLMPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LossLMPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PnodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPnodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PnodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PnodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPnodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PnodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Pnode property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPnode(object sender, System.EventArgs eventArgs)
        {
            this.Pnode = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CONGESTLMP"))
            {
                return this.CongestLMP;
            }
            if ((attribute == "COSTLMP"))
            {
                return this.CostLMP;
            }
            if ((attribute == "LOSSLMP"))
            {
                return this.LossLMP;
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
            if ((feature == "PNODE"))
            {
                this.Pnode = ((IPnode)(value));
                return;
            }
            if ((feature == "CONGESTLMP"))
            {
                this.CongestLMP = ((float)(value));
                return;
            }
            if ((feature == "COSTLMP"))
            {
                this.CostLMP = ((float)(value));
                return;
            }
            if ((feature == "LOSSLMP"))
            {
                this.LossLMP = ((float)(value));
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
            if ((attribute == "Pnode"))
            {
                return new PnodeProxy(this);
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
            if ((reference == "Pnode"))
            {
                return new PnodeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                        "PnodeClearing")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PnodeClearing class
        /// </summary>
        public class PnodeClearingReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PnodeClearing _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PnodeClearingReferencedElementsCollection(PnodeClearing parent)
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
                    if ((this._parent.Pnode != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PnodeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PnodeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Pnode == null))
                {
                    IPnode pnodeCasted = item.As<IPnode>();
                    if ((pnodeCasted != null))
                    {
                        this._parent.Pnode = pnodeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Pnode = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Pnode))
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
                if ((this._parent.Pnode != null))
                {
                    array[arrayIndex] = this._parent.Pnode;
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
                if ((this._parent.Pnode == item))
                {
                    this._parent.Pnode = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Pnode).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the congestLMP property
        /// </summary>
        private sealed class CongestLMPProxy : ModelPropertyChange<IPnodeClearing, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CongestLMPProxy(IPnodeClearing modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.CongestLMP;
                }
                set
                {
                    this.ModelElement.CongestLMP = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CongestLMPChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CongestLMPChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the costLMP property
        /// </summary>
        private sealed class CostLMPProxy : ModelPropertyChange<IPnodeClearing, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CostLMPProxy(IPnodeClearing modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.CostLMP;
                }
                set
                {
                    this.ModelElement.CostLMP = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CostLMPChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CostLMPChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lossLMP property
        /// </summary>
        private sealed class LossLMPProxy : ModelPropertyChange<IPnodeClearing, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LossLMPProxy(IPnodeClearing modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LossLMP;
                }
                set
                {
                    this.ModelElement.LossLMP = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LossLMPChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LossLMPChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Pnode property
        /// </summary>
        private sealed class PnodeProxy : ModelPropertyChange<IPnodeClearing, IPnode>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PnodeProxy(IPnodeClearing modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPnode Value
            {
                get
                {
                    return this.ModelElement.Pnode;
                }
                set
                {
                    this.ModelElement.Pnode = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PnodeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PnodeChanged -= handler;
            }
        }
    }
}

