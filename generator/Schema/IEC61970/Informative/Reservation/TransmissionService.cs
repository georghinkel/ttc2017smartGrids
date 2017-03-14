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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation
{
    
    
    /// <summary>
    /// The default implementation of the TransmissionService class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Reservation")]
    [XmlNamespacePrefixAttribute("cimReservation")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Reservation/Trans" +
        "missionService")]
    [DebuggerDisplayAttribute("TransmissionService {UUID}")]
    public class TransmissionService : IdentifiedObject, ITransmissionService, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Offering property
        /// </summary>
        private TransmissionServiceOfferingCollection _offering;
        
        /// <summary>
        /// The backing field for the OfferedAs property
        /// </summary>
        private TransmissionServiceOfferedAsCollection _offeredAs;
        
        /// <summary>
        /// The backing field for the ScheduledBy property
        /// </summary>
        private TransmissionServiceScheduledByCollection _scheduledBy;
        
        /// <summary>
        /// The backing field for the ReservedBy_ServiceReservation property
        /// </summary>
        private TransmissionServiceReservedBy_ServiceReservationCollection _reservedBy_ServiceReservation;
        
        /// <summary>
        /// The backing field for the TransContractFor property
        /// </summary>
        private IOpenAccessProduct _transContractFor;
        
        /// <summary>
        /// The backing field for the Offers property
        /// </summary>
        private ITransmissionProvider _offers;
        
        private static IClass _classInstance;
        
        public TransmissionService()
        {
            this._offering = new TransmissionServiceOfferingCollection(this);
            this._offering.CollectionChanging += this.OfferingCollectionChanging;
            this._offering.CollectionChanged += this.OfferingCollectionChanged;
            this._offeredAs = new TransmissionServiceOfferedAsCollection(this);
            this._offeredAs.CollectionChanging += this.OfferedAsCollectionChanging;
            this._offeredAs.CollectionChanged += this.OfferedAsCollectionChanged;
            this._scheduledBy = new TransmissionServiceScheduledByCollection(this);
            this._scheduledBy.CollectionChanging += this.ScheduledByCollectionChanging;
            this._scheduledBy.CollectionChanged += this.ScheduledByCollectionChanged;
            this._reservedBy_ServiceReservation = new TransmissionServiceReservedBy_ServiceReservationCollection(this);
            this._reservedBy_ServiceReservation.CollectionChanging += this.ReservedBy_ServiceReservationCollectionChanging;
            this._reservedBy_ServiceReservation.CollectionChanged += this.ReservedBy_ServiceReservationCollectionChanged;
        }
        
        /// <summary>
        /// The Offering property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OfferedOn")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransmissionPath> Offering
        {
            get
            {
                return this._offering;
            }
        }
        
        /// <summary>
        /// The OfferedAs property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Offers")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransmissionProduct> OfferedAs
        {
            get
            {
                return this._offeredAs;
            }
        }
        
        /// <summary>
        /// The ScheduledBy property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ScheduleFor")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAvailableTransmissionCapacity> ScheduledBy
        {
            get
            {
                return this._scheduledBy;
            }
        }
        
        /// <summary>
        /// The ReservedBy_ServiceReservation property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Reserves_TransmissionService")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IServiceReservation> ReservedBy_ServiceReservation
        {
            get
            {
                return this._reservedBy_ServiceReservation;
            }
        }
        
        /// <summary>
        /// The TransContractFor property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProvidedBy_TransmissionService")]
        public virtual IOpenAccessProduct TransContractFor
        {
            get
            {
                return this._transContractFor;
            }
            set
            {
                if ((this._transContractFor != value))
                {
                    IOpenAccessProduct old = this._transContractFor;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransContractForChanging(e);
                    this.OnPropertyChanging("TransContractFor", e);
                    this._transContractFor = value;
                    if ((old != null))
                    {
                        old.ProvidedBy_TransmissionService.Remove(this);
                        old.Deleted -= this.OnResetTransContractFor;
                    }
                    if ((value != null))
                    {
                        value.ProvidedBy_TransmissionService.Add(this);
                        value.Deleted += this.OnResetTransContractFor;
                    }
                    this.OnTransContractForChanged(e);
                    this.OnPropertyChanged("TransContractFor", e);
                }
            }
        }
        
        /// <summary>
        /// The Offers property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OfferedBy")]
        public virtual ITransmissionProvider Offers
        {
            get
            {
                return this._offers;
            }
            set
            {
                if ((this._offers != value))
                {
                    ITransmissionProvider old = this._offers;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOffersChanging(e);
                    this.OnPropertyChanging("Offers", e);
                    this._offers = value;
                    if ((old != null))
                    {
                        old.OfferedBy.Remove(this);
                        old.Deleted -= this.OnResetOffers;
                    }
                    if ((value != null))
                    {
                        value.OfferedBy.Add(this);
                        value.Deleted += this.OnResetOffers;
                    }
                    this.OnOffersChanged(e);
                    this.OnPropertyChanged("Offers", e);
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
                return base.ReferencedElements.Concat(new TransmissionServiceReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Reservation/Trans" +
                            "missionService")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TransContractFor property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransContractForChanging;
        
        /// <summary>
        /// Gets fired when the TransContractFor property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransContractForChanged;
        
        /// <summary>
        /// Gets fired before the Offers property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OffersChanging;
        
        /// <summary>
        /// Gets fired when the Offers property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OffersChanged;
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Offering property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OfferingCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Offering", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Offering property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OfferingCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Offering", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OfferedAs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OfferedAsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("OfferedAs", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OfferedAs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OfferedAsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OfferedAs", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ScheduledBy property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ScheduledByCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ScheduledBy", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ScheduledBy property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ScheduledByCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ScheduledBy", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ReservedBy_ServiceReservation property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReservedBy_ServiceReservationCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ReservedBy_ServiceReservation", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ReservedBy_ServiceReservation property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReservedBy_ServiceReservationCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ReservedBy_ServiceReservation", e);
        }
        
        /// <summary>
        /// Raises the TransContractForChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransContractForChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransContractForChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransContractForChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransContractForChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransContractForChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TransContractFor property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTransContractFor(object sender, System.EventArgs eventArgs)
        {
            this.TransContractFor = null;
        }
        
        /// <summary>
        /// Raises the OffersChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOffersChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OffersChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OffersChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOffersChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OffersChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Offers property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOffers(object sender, System.EventArgs eventArgs)
        {
            this.Offers = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "OFFERING"))
            {
                return this._offering;
            }
            if ((feature == "OFFEREDAS"))
            {
                return this._offeredAs;
            }
            if ((feature == "SCHEDULEDBY"))
            {
                return this._scheduledBy;
            }
            if ((feature == "RESERVEDBY_SERVICERESERVATION"))
            {
                return this._reservedBy_ServiceReservation;
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
            if ((feature == "TRANSCONTRACTFOR"))
            {
                this.TransContractFor = ((IOpenAccessProduct)(value));
                return;
            }
            if ((feature == "OFFERS"))
            {
                this.Offers = ((ITransmissionProvider)(value));
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
            if ((attribute == "TransContractFor"))
            {
                return new TransContractForProxy(this);
            }
            if ((attribute == "Offers"))
            {
                return new OffersProxy(this);
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
            if ((reference == "TransContractFor"))
            {
                return new TransContractForProxy(this);
            }
            if ((reference == "Offers"))
            {
                return new OffersProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Reservation/Trans" +
                        "missionService")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransmissionService class
        /// </summary>
        public class TransmissionServiceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransmissionService _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransmissionServiceReferencedElementsCollection(TransmissionService parent)
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
                    count = (count + this._parent.Offering.Count);
                    count = (count + this._parent.OfferedAs.Count);
                    count = (count + this._parent.ScheduledBy.Count);
                    count = (count + this._parent.ReservedBy_ServiceReservation.Count);
                    if ((this._parent.TransContractFor != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Offers != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Offering.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.OfferedAs.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ScheduledBy.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ReservedBy_ServiceReservation.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransContractForChanged += this.PropagateValueChanges;
                this._parent.OffersChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Offering.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.OfferedAs.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ScheduledBy.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ReservedBy_ServiceReservation.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransContractForChanged -= this.PropagateValueChanges;
                this._parent.OffersChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ITransmissionPath offeringCasted = item.As<ITransmissionPath>();
                if ((offeringCasted != null))
                {
                    this._parent.Offering.Add(offeringCasted);
                }
                ITransmissionProduct offeredAsCasted = item.As<ITransmissionProduct>();
                if ((offeredAsCasted != null))
                {
                    this._parent.OfferedAs.Add(offeredAsCasted);
                }
                IAvailableTransmissionCapacity scheduledByCasted = item.As<IAvailableTransmissionCapacity>();
                if ((scheduledByCasted != null))
                {
                    this._parent.ScheduledBy.Add(scheduledByCasted);
                }
                IServiceReservation reservedBy_ServiceReservationCasted = item.As<IServiceReservation>();
                if ((reservedBy_ServiceReservationCasted != null))
                {
                    this._parent.ReservedBy_ServiceReservation.Add(reservedBy_ServiceReservationCasted);
                }
                if ((this._parent.TransContractFor == null))
                {
                    IOpenAccessProduct transContractForCasted = item.As<IOpenAccessProduct>();
                    if ((transContractForCasted != null))
                    {
                        this._parent.TransContractFor = transContractForCasted;
                        return;
                    }
                }
                if ((this._parent.Offers == null))
                {
                    ITransmissionProvider offersCasted = item.As<ITransmissionProvider>();
                    if ((offersCasted != null))
                    {
                        this._parent.Offers = offersCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Offering.Clear();
                this._parent.OfferedAs.Clear();
                this._parent.ScheduledBy.Clear();
                this._parent.ReservedBy_ServiceReservation.Clear();
                this._parent.TransContractFor = null;
                this._parent.Offers = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Offering.Contains(item))
                {
                    return true;
                }
                if (this._parent.OfferedAs.Contains(item))
                {
                    return true;
                }
                if (this._parent.ScheduledBy.Contains(item))
                {
                    return true;
                }
                if (this._parent.ReservedBy_ServiceReservation.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.TransContractFor))
                {
                    return true;
                }
                if ((item == this._parent.Offers))
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
                IEnumerator<IModelElement> offeringEnumerator = this._parent.Offering.GetEnumerator();
                try
                {
                    for (
                    ; offeringEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = offeringEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    offeringEnumerator.Dispose();
                }
                IEnumerator<IModelElement> offeredAsEnumerator = this._parent.OfferedAs.GetEnumerator();
                try
                {
                    for (
                    ; offeredAsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = offeredAsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    offeredAsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> scheduledByEnumerator = this._parent.ScheduledBy.GetEnumerator();
                try
                {
                    for (
                    ; scheduledByEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = scheduledByEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    scheduledByEnumerator.Dispose();
                }
                IEnumerator<IModelElement> reservedBy_ServiceReservationEnumerator = this._parent.ReservedBy_ServiceReservation.GetEnumerator();
                try
                {
                    for (
                    ; reservedBy_ServiceReservationEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = reservedBy_ServiceReservationEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    reservedBy_ServiceReservationEnumerator.Dispose();
                }
                if ((this._parent.TransContractFor != null))
                {
                    array[arrayIndex] = this._parent.TransContractFor;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Offers != null))
                {
                    array[arrayIndex] = this._parent.Offers;
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
                ITransmissionPath transmissionPathItem = item.As<ITransmissionPath>();
                if (((transmissionPathItem != null) 
                            && this._parent.Offering.Remove(transmissionPathItem)))
                {
                    return true;
                }
                ITransmissionProduct transmissionProductItem = item.As<ITransmissionProduct>();
                if (((transmissionProductItem != null) 
                            && this._parent.OfferedAs.Remove(transmissionProductItem)))
                {
                    return true;
                }
                IAvailableTransmissionCapacity availableTransmissionCapacityItem = item.As<IAvailableTransmissionCapacity>();
                if (((availableTransmissionCapacityItem != null) 
                            && this._parent.ScheduledBy.Remove(availableTransmissionCapacityItem)))
                {
                    return true;
                }
                IServiceReservation serviceReservationItem = item.As<IServiceReservation>();
                if (((serviceReservationItem != null) 
                            && this._parent.ReservedBy_ServiceReservation.Remove(serviceReservationItem)))
                {
                    return true;
                }
                if ((this._parent.TransContractFor == item))
                {
                    this._parent.TransContractFor = null;
                    return true;
                }
                if ((this._parent.Offers == item))
                {
                    this._parent.Offers = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Offering).Concat(this._parent.OfferedAs).Concat(this._parent.ScheduledBy).Concat(this._parent.ReservedBy_ServiceReservation).Concat(this._parent.TransContractFor).Concat(this._parent.Offers).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TransContractFor property
        /// </summary>
        private sealed class TransContractForProxy : ModelPropertyChange<ITransmissionService, IOpenAccessProduct>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransContractForProxy(ITransmissionService modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOpenAccessProduct Value
            {
                get
                {
                    return this.ModelElement.TransContractFor;
                }
                set
                {
                    this.ModelElement.TransContractFor = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TransContractForChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TransContractForChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Offers property
        /// </summary>
        private sealed class OffersProxy : ModelPropertyChange<ITransmissionService, ITransmissionProvider>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OffersProxy(ITransmissionService modelElement) : 
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
                    return this.ModelElement.Offers;
                }
                set
                {
                    this.ModelElement.Offers = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OffersChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OffersChanged -= handler;
            }
        }
    }
}

