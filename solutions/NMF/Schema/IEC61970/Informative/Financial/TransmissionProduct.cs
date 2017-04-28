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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial
{
    
    
    /// <summary>
    /// The default implementation of the TransmissionProduct class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Financial")]
    [XmlNamespacePrefixAttribute("cimFinancial")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Transmi" +
        "ssionProduct")]
    [DebuggerDisplayAttribute("TransmissionProduct {UUID}")]
    public partial class TransmissionProduct : IdentifiedObject, ITransmissionProduct, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TransmissionProductType property
        /// </summary>
        private object _transmissionProductType;
        
        private static Lazy<ITypedElement> _transmissionProductTypeAttribute = new Lazy<ITypedElement>(RetrieveTransmissionProductTypeAttribute);
        
        private static Lazy<ITypedElement> _locationForReference = new Lazy<ITypedElement>(RetrieveLocationForReference);
        
        /// <summary>
        /// The backing field for the LocationFor property
        /// </summary>
        private TransmissionProductLocationForCollection _locationFor;
        
        private static Lazy<ITypedElement> _transmissionProviderReference = new Lazy<ITypedElement>(RetrieveTransmissionProviderReference);
        
        /// <summary>
        /// The backing field for the TransmissionProvider property
        /// </summary>
        private ITransmissionProvider _transmissionProvider;
        
        private static Lazy<ITypedElement> _offersReference = new Lazy<ITypedElement>(RetrieveOffersReference);
        
        /// <summary>
        /// The backing field for the Offers property
        /// </summary>
        private TransmissionProductOffersCollection _offers;
        
        private static IClass _classInstance;
        
        public TransmissionProduct()
        {
            this._locationFor = new TransmissionProductLocationForCollection(this);
            this._locationFor.CollectionChanging += this.LocationForCollectionChanging;
            this._locationFor.CollectionChanged += this.LocationForCollectionChanged;
            this._offers = new TransmissionProductOffersCollection(this);
            this._offers.CollectionChanging += this.OffersCollectionChanging;
            this._offers.CollectionChanged += this.OffersCollectionChanged;
        }
        
        /// <summary>
        /// The transmissionProductType property
        /// </summary>
        [XmlElementNameAttribute("transmissionProductType")]
        [XmlAttributeAttribute(true)]
        public virtual object TransmissionProductType
        {
            get
            {
                return this._transmissionProductType;
            }
            set
            {
                if ((this._transmissionProductType != value))
                {
                    object old = this._transmissionProductType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransmissionProductTypeChanging(e);
                    this.OnPropertyChanging("TransmissionProductType", e, _transmissionProductTypeAttribute);
                    this._transmissionProductType = value;
                    this.OnTransmissionProductTypeChanged(e);
                    this.OnPropertyChanged("TransmissionProductType", e, _transmissionProductTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The LocationFor property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("LocatedOn")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransmissionPath> LocationFor
        {
            get
            {
                return this._locationFor;
            }
        }
        
        /// <summary>
        /// The TransmissionProvider property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransmissionProducts")]
        public virtual ITransmissionProvider TransmissionProvider
        {
            get
            {
                return this._transmissionProvider;
            }
            set
            {
                if ((this._transmissionProvider != value))
                {
                    ITransmissionProvider old = this._transmissionProvider;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransmissionProviderChanging(e);
                    this.OnPropertyChanging("TransmissionProvider", e, _transmissionProviderReference);
                    this._transmissionProvider = value;
                    if ((old != null))
                    {
                        old.TransmissionProducts.Remove(this);
                        old.Deleted -= this.OnResetTransmissionProvider;
                    }
                    if ((value != null))
                    {
                        value.TransmissionProducts.Add(this);
                        value.Deleted += this.OnResetTransmissionProvider;
                    }
                    this.OnTransmissionProviderChanged(e);
                    this.OnPropertyChanged("TransmissionProvider", e, _transmissionProviderReference);
                }
            }
        }
        
        /// <summary>
        /// The Offers property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OfferedAs")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransmissionService> Offers
        {
            get
            {
                return this._offers;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TransmissionProductReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Transmi" +
                            "ssionProduct")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TransmissionProductType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransmissionProductTypeChanging;
        
        /// <summary>
        /// Gets fired when the TransmissionProductType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransmissionProductTypeChanged;
        
        /// <summary>
        /// Gets fired before the TransmissionProvider property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransmissionProviderChanging;
        
        /// <summary>
        /// Gets fired when the TransmissionProvider property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransmissionProviderChanged;
        
        private static ITypedElement RetrieveTransmissionProductTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TransmissionProduct.ClassInstance)).Resolve("transmissionProductType")));
        }
        
        /// <summary>
        /// Raises the TransmissionProductTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransmissionProductTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransmissionProductTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransmissionProductTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransmissionProductTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransmissionProductTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLocationForReference()
        {
            return ((ITypedElement)(((ModelElement)(TransmissionProduct.ClassInstance)).Resolve("LocationFor")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LocationFor property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LocationForCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("LocationFor", e, _locationForReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LocationFor property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LocationForCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LocationFor", e, _locationForReference);
        }
        
        private static ITypedElement RetrieveTransmissionProviderReference()
        {
            return ((ITypedElement)(((ModelElement)(TransmissionProduct.ClassInstance)).Resolve("TransmissionProvider")));
        }
        
        /// <summary>
        /// Raises the TransmissionProviderChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransmissionProviderChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransmissionProviderChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransmissionProviderChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransmissionProviderChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransmissionProviderChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TransmissionProvider property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTransmissionProvider(object sender, System.EventArgs eventArgs)
        {
            this.TransmissionProvider = null;
        }
        
        private static ITypedElement RetrieveOffersReference()
        {
            return ((ITypedElement)(((ModelElement)(TransmissionProduct.ClassInstance)).Resolve("Offers")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Offers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OffersCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Offers", e, _offersReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Offers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OffersCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Offers", e, _offersReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TRANSMISSIONPRODUCTTYPE"))
            {
                return this.TransmissionProductType;
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
            if ((feature == "LOCATIONFOR"))
            {
                return this._locationFor;
            }
            if ((feature == "OFFERS"))
            {
                return this._offers;
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
            if ((feature == "TRANSMISSIONPROVIDER"))
            {
                this.TransmissionProvider = ((ITransmissionProvider)(value));
                return;
            }
            if ((feature == "TRANSMISSIONPRODUCTTYPE"))
            {
                this.TransmissionProductType = ((object)(value));
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
            if ((attribute == "TransmissionProvider"))
            {
                return new TransmissionProviderProxy(this);
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
            if ((reference == "TransmissionProvider"))
            {
                return new TransmissionProviderProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Transmi" +
                        "ssionProduct")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransmissionProduct class
        /// </summary>
        public class TransmissionProductReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransmissionProduct _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransmissionProductReferencedElementsCollection(TransmissionProduct parent)
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
                    count = (count + this._parent.LocationFor.Count);
                    if ((this._parent.TransmissionProvider != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Offers.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LocationFor.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransmissionProviderChanged += this.PropagateValueChanges;
                this._parent.Offers.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LocationFor.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransmissionProviderChanged -= this.PropagateValueChanges;
                this._parent.Offers.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ITransmissionPath locationForCasted = item.As<ITransmissionPath>();
                if ((locationForCasted != null))
                {
                    this._parent.LocationFor.Add(locationForCasted);
                }
                if ((this._parent.TransmissionProvider == null))
                {
                    ITransmissionProvider transmissionProviderCasted = item.As<ITransmissionProvider>();
                    if ((transmissionProviderCasted != null))
                    {
                        this._parent.TransmissionProvider = transmissionProviderCasted;
                        return;
                    }
                }
                ITransmissionService offersCasted = item.As<ITransmissionService>();
                if ((offersCasted != null))
                {
                    this._parent.Offers.Add(offersCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LocationFor.Clear();
                this._parent.TransmissionProvider = null;
                this._parent.Offers.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.LocationFor.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.TransmissionProvider))
                {
                    return true;
                }
                if (this._parent.Offers.Contains(item))
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
                IEnumerator<IModelElement> locationForEnumerator = this._parent.LocationFor.GetEnumerator();
                try
                {
                    for (
                    ; locationForEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = locationForEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    locationForEnumerator.Dispose();
                }
                if ((this._parent.TransmissionProvider != null))
                {
                    array[arrayIndex] = this._parent.TransmissionProvider;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> offersEnumerator = this._parent.Offers.GetEnumerator();
                try
                {
                    for (
                    ; offersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = offersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    offersEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ITransmissionPath transmissionPathItem = item.As<ITransmissionPath>();
                if (((transmissionPathItem != null) 
                            && this._parent.LocationFor.Remove(transmissionPathItem)))
                {
                    return true;
                }
                if ((this._parent.TransmissionProvider == item))
                {
                    this._parent.TransmissionProvider = null;
                    return true;
                }
                ITransmissionService transmissionServiceItem = item.As<ITransmissionService>();
                if (((transmissionServiceItem != null) 
                            && this._parent.Offers.Remove(transmissionServiceItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LocationFor).Concat(this._parent.TransmissionProvider).Concat(this._parent.Offers).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the transmissionProductType property
        /// </summary>
        private sealed class TransmissionProductTypeProxy : ModelPropertyChange<ITransmissionProduct, object>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransmissionProductTypeProxy(ITransmissionProduct modelElement) : 
                    base(modelElement, "transmissionProductType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override object Value
            {
                get
                {
                    return this.ModelElement.TransmissionProductType;
                }
                set
                {
                    this.ModelElement.TransmissionProductType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TransmissionProvider property
        /// </summary>
        private sealed class TransmissionProviderProxy : ModelPropertyChange<ITransmissionProduct, ITransmissionProvider>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransmissionProviderProxy(ITransmissionProduct modelElement) : 
                    base(modelElement, "TransmissionProvider")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITransmissionProvider Value
            {
                get
                {
                    return this.ModelElement.TransmissionProvider;
                }
                set
                {
                    this.ModelElement.TransmissionProvider = value;
                }
            }
        }
    }
}
