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
    /// The default implementation of the MarketStatement class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "MarketStatement")]
    [DebuggerDisplayAttribute("MarketStatement {UUID}")]
    public class MarketStatement : Document, IMarketStatement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TradeDate property
        /// </summary>
        private DateTime _tradeDate;
        
        /// <summary>
        /// The backing field for the TransactionDate property
        /// </summary>
        private DateTime _transactionDate;
        
        /// <summary>
        /// The backing field for the ReferenceNumber property
        /// </summary>
        private string _referenceNumber;
        
        /// <summary>
        /// The backing field for the End property
        /// </summary>
        private DateTime _end;
        
        /// <summary>
        /// The backing field for the Start property
        /// </summary>
        private DateTime _start;
        
        /// <summary>
        /// The backing field for the MarketStatementLineItem property
        /// </summary>
        private MarketStatementMarketStatementLineItemCollection _marketStatementLineItem;
        
        private static IClass _classInstance;
        
        public MarketStatement()
        {
            this._marketStatementLineItem = new MarketStatementMarketStatementLineItemCollection(this);
            this._marketStatementLineItem.CollectionChanging += this.MarketStatementLineItemCollectionChanging;
            this._marketStatementLineItem.CollectionChanged += this.MarketStatementLineItemCollectionChanged;
        }
        
        /// <summary>
        /// The tradeDate property
        /// </summary>
        [XmlElementNameAttribute("tradeDate")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime TradeDate
        {
            get
            {
                return this._tradeDate;
            }
            set
            {
                if ((this._tradeDate != value))
                {
                    DateTime old = this._tradeDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTradeDateChanging(e);
                    this.OnPropertyChanging("TradeDate", e);
                    this._tradeDate = value;
                    this.OnTradeDateChanged(e);
                    this.OnPropertyChanged("TradeDate", e);
                }
            }
        }
        
        /// <summary>
        /// The transactionDate property
        /// </summary>
        [XmlElementNameAttribute("transactionDate")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime TransactionDate
        {
            get
            {
                return this._transactionDate;
            }
            set
            {
                if ((this._transactionDate != value))
                {
                    DateTime old = this._transactionDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransactionDateChanging(e);
                    this.OnPropertyChanging("TransactionDate", e);
                    this._transactionDate = value;
                    this.OnTransactionDateChanged(e);
                    this.OnPropertyChanged("TransactionDate", e);
                }
            }
        }
        
        /// <summary>
        /// The referenceNumber property
        /// </summary>
        [XmlElementNameAttribute("referenceNumber")]
        [XmlAttributeAttribute(true)]
        public virtual string ReferenceNumber
        {
            get
            {
                return this._referenceNumber;
            }
            set
            {
                if ((this._referenceNumber != value))
                {
                    string old = this._referenceNumber;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferenceNumberChanging(e);
                    this.OnPropertyChanging("ReferenceNumber", e);
                    this._referenceNumber = value;
                    this.OnReferenceNumberChanged(e);
                    this.OnPropertyChanged("ReferenceNumber", e);
                }
            }
        }
        
        /// <summary>
        /// The end property
        /// </summary>
        [XmlElementNameAttribute("end")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime End
        {
            get
            {
                return this._end;
            }
            set
            {
                if ((this._end != value))
                {
                    DateTime old = this._end;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEndChanging(e);
                    this.OnPropertyChanging("End", e);
                    this._end = value;
                    this.OnEndChanged(e);
                    this.OnPropertyChanged("End", e);
                }
            }
        }
        
        /// <summary>
        /// The start property
        /// </summary>
        [XmlElementNameAttribute("start")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime Start
        {
            get
            {
                return this._start;
            }
            set
            {
                if ((this._start != value))
                {
                    DateTime old = this._start;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartChanging(e);
                    this.OnPropertyChanging("Start", e);
                    this._start = value;
                    this.OnStartChanged(e);
                    this.OnPropertyChanged("Start", e);
                }
            }
        }
        
        /// <summary>
        /// The MarketStatementLineItem property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("MarketStatement")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IMarketStatementLineItem> MarketStatementLineItem
        {
            get
            {
                return this._marketStatementLineItem;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new MarketStatementReferencedElementsCollection(this));
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
                            "MarketStatement")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TradeDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TradeDateChanging;
        
        /// <summary>
        /// Gets fired when the TradeDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TradeDateChanged;
        
        /// <summary>
        /// Gets fired before the TransactionDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransactionDateChanging;
        
        /// <summary>
        /// Gets fired when the TransactionDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransactionDateChanged;
        
        /// <summary>
        /// Gets fired before the ReferenceNumber property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the ReferenceNumber property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the End property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndChanging;
        
        /// <summary>
        /// Gets fired when the End property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndChanged;
        
        /// <summary>
        /// Gets fired before the Start property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartChanging;
        
        /// <summary>
        /// Gets fired when the Start property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartChanged;
        
        /// <summary>
        /// Raises the TradeDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTradeDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TradeDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TradeDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTradeDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TradeDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransactionDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransactionDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransactionDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransactionDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransactionDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransactionDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferenceNumberChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferenceNumberChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferenceNumberChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferenceNumberChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferenceNumberChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferenceNumberChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EndChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EndChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the MarketStatementLineItem property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MarketStatementLineItemCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("MarketStatementLineItem", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the MarketStatementLineItem property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MarketStatementLineItemCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("MarketStatementLineItem", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TRADEDATE"))
            {
                return this.TradeDate;
            }
            if ((attribute == "TRANSACTIONDATE"))
            {
                return this.TransactionDate;
            }
            if ((attribute == "REFERENCENUMBER"))
            {
                return this.ReferenceNumber;
            }
            if ((attribute == "END"))
            {
                return this.End;
            }
            if ((attribute == "START"))
            {
                return this.Start;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "MARKETSTATEMENTLINEITEM"))
            {
                return this._marketStatementLineItem;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TRADEDATE"))
            {
                this.TradeDate = ((DateTime)(value));
                return;
            }
            if ((feature == "TRANSACTIONDATE"))
            {
                this.TransactionDate = ((DateTime)(value));
                return;
            }
            if ((feature == "REFERENCENUMBER"))
            {
                this.ReferenceNumber = ((string)(value));
                return;
            }
            if ((feature == "END"))
            {
                this.End = ((DateTime)(value));
                return;
            }
            if ((feature == "START"))
            {
                this.Start = ((DateTime)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                        "MarketStatement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MarketStatement class
        /// </summary>
        public class MarketStatementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MarketStatement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MarketStatementReferencedElementsCollection(MarketStatement parent)
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
                    count = (count + this._parent.MarketStatementLineItem.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MarketStatementLineItem.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MarketStatementLineItem.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IMarketStatementLineItem marketStatementLineItemCasted = item.As<IMarketStatementLineItem>();
                if ((marketStatementLineItemCasted != null))
                {
                    this._parent.MarketStatementLineItem.Add(marketStatementLineItemCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.MarketStatementLineItem.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.MarketStatementLineItem.Contains(item))
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
                IEnumerator<IModelElement> marketStatementLineItemEnumerator = this._parent.MarketStatementLineItem.GetEnumerator();
                try
                {
                    for (
                    ; marketStatementLineItemEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = marketStatementLineItemEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    marketStatementLineItemEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IMarketStatementLineItem marketStatementLineItemItem = item.As<IMarketStatementLineItem>();
                if (((marketStatementLineItemItem != null) 
                            && this._parent.MarketStatementLineItem.Remove(marketStatementLineItemItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.MarketStatementLineItem).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the tradeDate property
        /// </summary>
        private sealed class TradeDateProxy : ModelPropertyChange<IMarketStatement, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TradeDateProxy(IMarketStatement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.TradeDate;
                }
                set
                {
                    this.ModelElement.TradeDate = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TradeDateChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TradeDateChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the transactionDate property
        /// </summary>
        private sealed class TransactionDateProxy : ModelPropertyChange<IMarketStatement, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransactionDateProxy(IMarketStatement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.TransactionDate;
                }
                set
                {
                    this.ModelElement.TransactionDate = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TransactionDateChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TransactionDateChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referenceNumber property
        /// </summary>
        private sealed class ReferenceNumberProxy : ModelPropertyChange<IMarketStatement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferenceNumberProxy(IMarketStatement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ReferenceNumber;
                }
                set
                {
                    this.ModelElement.ReferenceNumber = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReferenceNumberChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReferenceNumberChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the end property
        /// </summary>
        private sealed class EndProxy : ModelPropertyChange<IMarketStatement, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EndProxy(IMarketStatement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.End;
                }
                set
                {
                    this.ModelElement.End = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EndChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EndChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the start property
        /// </summary>
        private sealed class StartProxy : ModelPropertyChange<IMarketStatement, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartProxy(IMarketStatement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.Start;
                }
                set
                {
                    this.ModelElement.Start = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StartChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StartChanged -= handler;
            }
        }
    }
}

