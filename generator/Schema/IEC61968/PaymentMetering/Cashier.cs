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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    /// <summary>
    /// The default implementation of the Cashier class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#PaymentMetering")]
    [XmlNamespacePrefixAttribute("cimPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Cashier")]
    [DebuggerDisplayAttribute("Cashier {UUID}")]
    public partial class Cashier : IdentifiedObject, ICashier, IModelElement
    {
        
        private static Lazy<ITypedElement> _cashierShiftsReference = new Lazy<ITypedElement>(RetrieveCashierShiftsReference);
        
        /// <summary>
        /// The backing field for the CashierShifts property
        /// </summary>
        private CashierCashierShiftsCollection _cashierShifts;
        
        private static Lazy<ITypedElement> _electronicAddressReference = new Lazy<ITypedElement>(RetrieveElectronicAddressReference);
        
        /// <summary>
        /// The backing field for the ElectronicAddress property
        /// </summary>
        private IElectronicAddress _electronicAddress;
        
        private static Lazy<ITypedElement> _vendorReference = new Lazy<ITypedElement>(RetrieveVendorReference);
        
        /// <summary>
        /// The backing field for the Vendor property
        /// </summary>
        private IVendor _vendor;
        
        private static IClass _classInstance;
        
        public Cashier()
        {
            this._cashierShifts = new CashierCashierShiftsCollection(this);
            this._cashierShifts.CollectionChanging += this.CashierShiftsCollectionChanging;
            this._cashierShifts.CollectionChanged += this.CashierShiftsCollectionChanged;
        }
        
        /// <summary>
        /// The CashierShifts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Cashier")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICashierShift> CashierShifts
        {
            get
            {
                return this._cashierShifts;
            }
        }
        
        /// <summary>
        /// The electronicAddress property
        /// </summary>
        [XmlElementNameAttribute("electronicAddress")]
        [XmlAttributeAttribute(true)]
        public virtual IElectronicAddress ElectronicAddress
        {
            get
            {
                return this._electronicAddress;
            }
            set
            {
                if ((this._electronicAddress != value))
                {
                    IElectronicAddress old = this._electronicAddress;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnElectronicAddressChanging(e);
                    this.OnPropertyChanging("ElectronicAddress", e, _electronicAddressReference);
                    this._electronicAddress = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetElectronicAddress;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetElectronicAddress;
                    }
                    this.OnElectronicAddressChanged(e);
                    this.OnPropertyChanged("ElectronicAddress", e, _electronicAddressReference);
                }
            }
        }
        
        /// <summary>
        /// The Vendor property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Cashiers")]
        public virtual IVendor Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                if ((this._vendor != value))
                {
                    IVendor old = this._vendor;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVendorChanging(e);
                    this.OnPropertyChanging("Vendor", e, _vendorReference);
                    this._vendor = value;
                    if ((old != null))
                    {
                        old.Cashiers.Remove(this);
                        old.Deleted -= this.OnResetVendor;
                    }
                    if ((value != null))
                    {
                        value.Cashiers.Add(this);
                        value.Deleted += this.OnResetVendor;
                    }
                    this.OnVendorChanged(e);
                    this.OnPropertyChanged("Vendor", e, _vendorReference);
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
                return base.ReferencedElements.Concat(new CashierReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Cashier")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ElectronicAddress property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ElectronicAddressChanging;
        
        /// <summary>
        /// Gets fired when the ElectronicAddress property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ElectronicAddressChanged;
        
        /// <summary>
        /// Gets fired before the Vendor property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VendorChanging;
        
        /// <summary>
        /// Gets fired when the Vendor property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VendorChanged;
        
        private static ITypedElement RetrieveCashierShiftsReference()
        {
            return ((ITypedElement)(((ModelElement)(Cashier.ClassInstance)).Resolve("CashierShifts")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CashierShifts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CashierShiftsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("CashierShifts", e, _cashierShiftsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CashierShifts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CashierShiftsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CashierShifts", e, _cashierShiftsReference);
        }
        
        private static ITypedElement RetrieveElectronicAddressReference()
        {
            return ((ITypedElement)(((ModelElement)(Cashier.ClassInstance)).Resolve("electronicAddress")));
        }
        
        /// <summary>
        /// Raises the ElectronicAddressChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElectronicAddressChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ElectronicAddressChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ElectronicAddressChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElectronicAddressChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ElectronicAddressChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ElectronicAddress property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetElectronicAddress(object sender, System.EventArgs eventArgs)
        {
            this.ElectronicAddress = null;
        }
        
        private static ITypedElement RetrieveVendorReference()
        {
            return ((ITypedElement)(((ModelElement)(Cashier.ClassInstance)).Resolve("Vendor")));
        }
        
        /// <summary>
        /// Raises the VendorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVendorChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VendorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VendorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVendorChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VendorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Vendor property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetVendor(object sender, System.EventArgs eventArgs)
        {
            this.Vendor = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CASHIERSHIFTS"))
            {
                return this._cashierShifts;
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
            if ((feature == "ELECTRONICADDRESS"))
            {
                this.ElectronicAddress = ((IElectronicAddress)(value));
                return;
            }
            if ((feature == "VENDOR"))
            {
                this.Vendor = ((IVendor)(value));
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
            if ((attribute == "ElectronicAddress"))
            {
                return new ElectronicAddressProxy(this);
            }
            if ((attribute == "Vendor"))
            {
                return new VendorProxy(this);
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
            if ((reference == "ElectronicAddress"))
            {
                return new ElectronicAddressProxy(this);
            }
            if ((reference == "Vendor"))
            {
                return new VendorProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Cashier")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Cashier class
        /// </summary>
        public class CashierReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Cashier _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CashierReferencedElementsCollection(Cashier parent)
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
                    count = (count + this._parent.CashierShifts.Count);
                    if ((this._parent.ElectronicAddress != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Vendor != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CashierShifts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ElectronicAddressChanged += this.PropagateValueChanges;
                this._parent.VendorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CashierShifts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ElectronicAddressChanged -= this.PropagateValueChanges;
                this._parent.VendorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICashierShift cashierShiftsCasted = item.As<ICashierShift>();
                if ((cashierShiftsCasted != null))
                {
                    this._parent.CashierShifts.Add(cashierShiftsCasted);
                }
                if ((this._parent.ElectronicAddress == null))
                {
                    IElectronicAddress electronicAddressCasted = item.As<IElectronicAddress>();
                    if ((electronicAddressCasted != null))
                    {
                        this._parent.ElectronicAddress = electronicAddressCasted;
                        return;
                    }
                }
                if ((this._parent.Vendor == null))
                {
                    IVendor vendorCasted = item.As<IVendor>();
                    if ((vendorCasted != null))
                    {
                        this._parent.Vendor = vendorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CashierShifts.Clear();
                this._parent.ElectronicAddress = null;
                this._parent.Vendor = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.CashierShifts.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.ElectronicAddress))
                {
                    return true;
                }
                if ((item == this._parent.Vendor))
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
                IEnumerator<IModelElement> cashierShiftsEnumerator = this._parent.CashierShifts.GetEnumerator();
                try
                {
                    for (
                    ; cashierShiftsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = cashierShiftsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    cashierShiftsEnumerator.Dispose();
                }
                if ((this._parent.ElectronicAddress != null))
                {
                    array[arrayIndex] = this._parent.ElectronicAddress;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Vendor != null))
                {
                    array[arrayIndex] = this._parent.Vendor;
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
                ICashierShift cashierShiftItem = item.As<ICashierShift>();
                if (((cashierShiftItem != null) 
                            && this._parent.CashierShifts.Remove(cashierShiftItem)))
                {
                    return true;
                }
                if ((this._parent.ElectronicAddress == item))
                {
                    this._parent.ElectronicAddress = null;
                    return true;
                }
                if ((this._parent.Vendor == item))
                {
                    this._parent.Vendor = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CashierShifts).Concat(this._parent.ElectronicAddress).Concat(this._parent.Vendor).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the electronicAddress property
        /// </summary>
        private sealed class ElectronicAddressProxy : ModelPropertyChange<ICashier, IElectronicAddress>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ElectronicAddressProxy(ICashier modelElement) : 
                    base(modelElement, "electronicAddress")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IElectronicAddress Value
            {
                get
                {
                    return this.ModelElement.ElectronicAddress;
                }
                set
                {
                    this.ModelElement.ElectronicAddress = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Vendor property
        /// </summary>
        private sealed class VendorProxy : ModelPropertyChange<ICashier, IVendor>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VendorProxy(ICashier modelElement) : 
                    base(modelElement, "Vendor")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IVendor Value
            {
                get
                {
                    return this.ModelElement.Vendor;
                }
                set
                {
                    this.ModelElement.Vendor = value;
                }
            }
        }
    }
}

