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
    /// The default implementation of the Settlement class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "Settlement")]
    [DebuggerDisplayAttribute("Settlement {UUID}")]
    public partial class Settlement : Document, ISettlement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TradeDate property
        /// </summary>
        private DateTime _tradeDate;
        
        private static Lazy<ITypedElement> _tradeDateAttribute = new Lazy<ITypedElement>(RetrieveTradeDateAttribute);
        
        private static Lazy<ITypedElement> _marketReference = new Lazy<ITypedElement>(RetrieveMarketReference);
        
        /// <summary>
        /// The backing field for the Market property
        /// </summary>
        private IMarket _market;
        
        private static Lazy<ITypedElement> _erpLedgerEntriesReference = new Lazy<ITypedElement>(RetrieveErpLedgerEntriesReference);
        
        /// <summary>
        /// The backing field for the ErpLedgerEntries property
        /// </summary>
        private SettlementErpLedgerEntriesCollection _erpLedgerEntries;
        
        private static Lazy<ITypedElement> _erpInvoiceLineItemsReference = new Lazy<ITypedElement>(RetrieveErpInvoiceLineItemsReference);
        
        /// <summary>
        /// The backing field for the ErpInvoiceLineItems property
        /// </summary>
        private SettlementErpInvoiceLineItemsCollection _erpInvoiceLineItems;
        
        private static IClass _classInstance;
        
        public Settlement()
        {
            this._erpLedgerEntries = new SettlementErpLedgerEntriesCollection(this);
            this._erpLedgerEntries.CollectionChanging += this.ErpLedgerEntriesCollectionChanging;
            this._erpLedgerEntries.CollectionChanged += this.ErpLedgerEntriesCollectionChanged;
            this._erpInvoiceLineItems = new SettlementErpInvoiceLineItemsCollection(this);
            this._erpInvoiceLineItems.CollectionChanging += this.ErpInvoiceLineItemsCollectionChanging;
            this._erpInvoiceLineItems.CollectionChanged += this.ErpInvoiceLineItemsCollectionChanged;
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
                    this.OnPropertyChanging("TradeDate", e, _tradeDateAttribute);
                    this._tradeDate = value;
                    this.OnTradeDateChanged(e);
                    this.OnPropertyChanged("TradeDate", e, _tradeDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Market property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Settlements")]
        public virtual IMarket Market
        {
            get
            {
                return this._market;
            }
            set
            {
                if ((this._market != value))
                {
                    IMarket old = this._market;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMarketChanging(e);
                    this.OnPropertyChanging("Market", e, _marketReference);
                    this._market = value;
                    if ((old != null))
                    {
                        old.Settlements.Remove(this);
                        old.Deleted -= this.OnResetMarket;
                    }
                    if ((value != null))
                    {
                        value.Settlements.Add(this);
                        value.Deleted += this.OnResetMarket;
                    }
                    this.OnMarketChanged(e);
                    this.OnPropertyChanged("Market", e, _marketReference);
                }
            }
        }
        
        /// <summary>
        /// The ErpLedgerEntries property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Settlements")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IErpLedgerEntry> ErpLedgerEntries
        {
            get
            {
                return this._erpLedgerEntries;
            }
        }
        
        /// <summary>
        /// The ErpInvoiceLineItems property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Settlements")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IErpInvoiceLineItem> ErpInvoiceLineItems
        {
            get
            {
                return this._erpInvoiceLineItems;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SettlementReferencedElementsCollection(this));
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
                            "Settlement")));
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
        /// Gets fired before the Market property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MarketChanging;
        
        /// <summary>
        /// Gets fired when the Market property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MarketChanged;
        
        private static ITypedElement RetrieveTradeDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Settlement.ClassInstance)).Resolve("tradeDate")));
        }
        
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
        
        private static ITypedElement RetrieveMarketReference()
        {
            return ((ITypedElement)(((ModelElement)(Settlement.ClassInstance)).Resolve("Market")));
        }
        
        /// <summary>
        /// Raises the MarketChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMarketChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MarketChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MarketChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMarketChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MarketChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Market property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetMarket(object sender, System.EventArgs eventArgs)
        {
            this.Market = null;
        }
        
        private static ITypedElement RetrieveErpLedgerEntriesReference()
        {
            return ((ITypedElement)(((ModelElement)(Settlement.ClassInstance)).Resolve("ErpLedgerEntries")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ErpLedgerEntries property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpLedgerEntriesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ErpLedgerEntries", e, _erpLedgerEntriesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ErpLedgerEntries property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpLedgerEntriesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ErpLedgerEntries", e, _erpLedgerEntriesReference);
        }
        
        private static ITypedElement RetrieveErpInvoiceLineItemsReference()
        {
            return ((ITypedElement)(((ModelElement)(Settlement.ClassInstance)).Resolve("ErpInvoiceLineItems")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ErpInvoiceLineItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpInvoiceLineItemsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ErpInvoiceLineItems", e, _erpInvoiceLineItemsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ErpInvoiceLineItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpInvoiceLineItemsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ErpInvoiceLineItems", e, _erpInvoiceLineItemsReference);
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
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ERPLEDGERENTRIES"))
            {
                return this._erpLedgerEntries;
            }
            if ((feature == "ERPINVOICELINEITEMS"))
            {
                return this._erpInvoiceLineItems;
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
            if ((feature == "MARKET"))
            {
                this.Market = ((IMarket)(value));
                return;
            }
            if ((feature == "TRADEDATE"))
            {
                this.TradeDate = ((DateTime)(value));
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
            if ((attribute == "Market"))
            {
                return new MarketProxy(this);
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
            if ((reference == "Market"))
            {
                return new MarketProxy(this);
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
                        "Settlement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Settlement class
        /// </summary>
        public class SettlementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Settlement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SettlementReferencedElementsCollection(Settlement parent)
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
                    if ((this._parent.Market != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.ErpLedgerEntries.Count);
                    count = (count + this._parent.ErpInvoiceLineItems.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MarketChanged += this.PropagateValueChanges;
                this._parent.ErpLedgerEntries.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ErpInvoiceLineItems.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MarketChanged -= this.PropagateValueChanges;
                this._parent.ErpLedgerEntries.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ErpInvoiceLineItems.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Market == null))
                {
                    IMarket marketCasted = item.As<IMarket>();
                    if ((marketCasted != null))
                    {
                        this._parent.Market = marketCasted;
                        return;
                    }
                }
                IErpLedgerEntry erpLedgerEntriesCasted = item.As<IErpLedgerEntry>();
                if ((erpLedgerEntriesCasted != null))
                {
                    this._parent.ErpLedgerEntries.Add(erpLedgerEntriesCasted);
                }
                IErpInvoiceLineItem erpInvoiceLineItemsCasted = item.As<IErpInvoiceLineItem>();
                if ((erpInvoiceLineItemsCasted != null))
                {
                    this._parent.ErpInvoiceLineItems.Add(erpInvoiceLineItemsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Market = null;
                this._parent.ErpLedgerEntries.Clear();
                this._parent.ErpInvoiceLineItems.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Market))
                {
                    return true;
                }
                if (this._parent.ErpLedgerEntries.Contains(item))
                {
                    return true;
                }
                if (this._parent.ErpInvoiceLineItems.Contains(item))
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
                if ((this._parent.Market != null))
                {
                    array[arrayIndex] = this._parent.Market;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> erpLedgerEntriesEnumerator = this._parent.ErpLedgerEntries.GetEnumerator();
                try
                {
                    for (
                    ; erpLedgerEntriesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = erpLedgerEntriesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    erpLedgerEntriesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> erpInvoiceLineItemsEnumerator = this._parent.ErpInvoiceLineItems.GetEnumerator();
                try
                {
                    for (
                    ; erpInvoiceLineItemsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = erpInvoiceLineItemsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    erpInvoiceLineItemsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Market == item))
                {
                    this._parent.Market = null;
                    return true;
                }
                IErpLedgerEntry erpLedgerEntryItem = item.As<IErpLedgerEntry>();
                if (((erpLedgerEntryItem != null) 
                            && this._parent.ErpLedgerEntries.Remove(erpLedgerEntryItem)))
                {
                    return true;
                }
                IErpInvoiceLineItem erpInvoiceLineItemItem = item.As<IErpInvoiceLineItem>();
                if (((erpInvoiceLineItemItem != null) 
                            && this._parent.ErpInvoiceLineItems.Remove(erpInvoiceLineItemItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Market).Concat(this._parent.ErpLedgerEntries).Concat(this._parent.ErpInvoiceLineItems).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the tradeDate property
        /// </summary>
        private sealed class TradeDateProxy : ModelPropertyChange<ISettlement, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TradeDateProxy(ISettlement modelElement) : 
                    base(modelElement, "tradeDate")
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
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Market property
        /// </summary>
        private sealed class MarketProxy : ModelPropertyChange<ISettlement, IMarket>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MarketProxy(ISettlement modelElement) : 
                    base(modelElement, "Market")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IMarket Value
            {
                get
                {
                    return this.ModelElement.Market;
                }
                set
                {
                    this.ModelElement.Market = value;
                }
            }
        }
    }
}
