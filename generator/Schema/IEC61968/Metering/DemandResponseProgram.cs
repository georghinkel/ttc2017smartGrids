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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The default implementation of the DemandResponseProgram class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Metering")]
    [XmlNamespacePrefixAttribute("cimMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/DemandResponseProgra" +
        "m")]
    [DebuggerDisplayAttribute("DemandResponseProgram {UUID}")]
    public class DemandResponseProgram : IdentifiedObject, IDemandResponseProgram, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private string _type;
        
        /// <summary>
        /// The backing field for the CustomerAgreements property
        /// </summary>
        private DemandResponseProgramCustomerAgreementsCollection _customerAgreements;
        
        /// <summary>
        /// The backing field for the ValidityInterval property
        /// </summary>
        private IDateTimeInterval _validityInterval;
        
        /// <summary>
        /// The backing field for the EndDeviceGroups property
        /// </summary>
        private DemandResponseProgramEndDeviceGroupsCollection _endDeviceGroups;
        
        /// <summary>
        /// The backing field for the EndDeviceControls property
        /// </summary>
        private DemandResponseProgramEndDeviceControlsCollection _endDeviceControls;
        
        private static IClass _classInstance;
        
        public DemandResponseProgram()
        {
            this._customerAgreements = new DemandResponseProgramCustomerAgreementsCollection(this);
            this._customerAgreements.CollectionChanging += this.CustomerAgreementsCollectionChanging;
            this._customerAgreements.CollectionChanged += this.CustomerAgreementsCollectionChanged;
            this._endDeviceGroups = new DemandResponseProgramEndDeviceGroupsCollection(this);
            this._endDeviceGroups.CollectionChanging += this.EndDeviceGroupsCollectionChanging;
            this._endDeviceGroups.CollectionChanged += this.EndDeviceGroupsCollectionChanged;
            this._endDeviceControls = new DemandResponseProgramEndDeviceControlsCollection(this);
            this._endDeviceControls.CollectionChanging += this.EndDeviceControlsCollectionChanging;
            this._endDeviceControls.CollectionChanged += this.EndDeviceControlsCollectionChanged;
        }
        
        /// <summary>
        /// The type property
        /// </summary>
        [XmlElementNameAttribute("type")]
        [XmlAttributeAttribute(true)]
        public virtual string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    string old = this._type;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanging(e);
                    this.OnPropertyChanging("Type", e);
                    this._type = value;
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e);
                }
            }
        }
        
        /// <summary>
        /// The CustomerAgreements property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DemandResponseProgram")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICustomerAgreement> CustomerAgreements
        {
            get
            {
                return this._customerAgreements;
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
                    this.OnPropertyChanging("ValidityInterval", e);
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
                    this.OnPropertyChanged("ValidityInterval", e);
                }
            }
        }
        
        /// <summary>
        /// The EndDeviceGroups property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DemandResponseProgram")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IEndDeviceGroup> EndDeviceGroups
        {
            get
            {
                return this._endDeviceGroups;
            }
        }
        
        /// <summary>
        /// The EndDeviceControls property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DemandResponseProgram")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IEndDeviceControl> EndDeviceControls
        {
            get
            {
                return this._endDeviceControls;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DemandResponseProgramReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/DemandResponseProgra" +
                            "m")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the ValidityInterval property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValidityIntervalChanging;
        
        /// <summary>
        /// Gets fired when the ValidityInterval property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValidityIntervalChanged;
        
        /// <summary>
        /// Raises the TypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CustomerAgreements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CustomerAgreementsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("CustomerAgreements", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CustomerAgreements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CustomerAgreementsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CustomerAgreements", e);
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
        /// Forwards CollectionChanging notifications for the EndDeviceGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EndDeviceGroupsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("EndDeviceGroups", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EndDeviceGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EndDeviceGroupsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EndDeviceGroups", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EndDeviceControls property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EndDeviceControlsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("EndDeviceControls", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EndDeviceControls property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EndDeviceControlsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EndDeviceControls", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TYPE"))
            {
                return this.Type;
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
            if ((feature == "CUSTOMERAGREEMENTS"))
            {
                return this._customerAgreements;
            }
            if ((feature == "ENDDEVICEGROUPS"))
            {
                return this._endDeviceGroups;
            }
            if ((feature == "ENDDEVICECONTROLS"))
            {
                return this._endDeviceControls;
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
            if ((feature == "VALIDITYINTERVAL"))
            {
                this.ValidityInterval = ((IDateTimeInterval)(value));
                return;
            }
            if ((feature == "TYPE"))
            {
                this.Type = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/DemandResponseProgra" +
                        "m")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DemandResponseProgram class
        /// </summary>
        public class DemandResponseProgramReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DemandResponseProgram _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DemandResponseProgramReferencedElementsCollection(DemandResponseProgram parent)
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
                    count = (count + this._parent.CustomerAgreements.Count);
                    if ((this._parent.ValidityInterval != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.EndDeviceGroups.Count);
                    count = (count + this._parent.EndDeviceControls.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CustomerAgreements.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ValidityIntervalChanged += this.PropagateValueChanges;
                this._parent.EndDeviceGroups.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EndDeviceControls.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CustomerAgreements.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ValidityIntervalChanged -= this.PropagateValueChanges;
                this._parent.EndDeviceGroups.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EndDeviceControls.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICustomerAgreement customerAgreementsCasted = item.As<ICustomerAgreement>();
                if ((customerAgreementsCasted != null))
                {
                    this._parent.CustomerAgreements.Add(customerAgreementsCasted);
                }
                if ((this._parent.ValidityInterval == null))
                {
                    IDateTimeInterval validityIntervalCasted = item.As<IDateTimeInterval>();
                    if ((validityIntervalCasted != null))
                    {
                        this._parent.ValidityInterval = validityIntervalCasted;
                        return;
                    }
                }
                IEndDeviceGroup endDeviceGroupsCasted = item.As<IEndDeviceGroup>();
                if ((endDeviceGroupsCasted != null))
                {
                    this._parent.EndDeviceGroups.Add(endDeviceGroupsCasted);
                }
                IEndDeviceControl endDeviceControlsCasted = item.As<IEndDeviceControl>();
                if ((endDeviceControlsCasted != null))
                {
                    this._parent.EndDeviceControls.Add(endDeviceControlsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CustomerAgreements.Clear();
                this._parent.ValidityInterval = null;
                this._parent.EndDeviceGroups.Clear();
                this._parent.EndDeviceControls.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.CustomerAgreements.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.ValidityInterval))
                {
                    return true;
                }
                if (this._parent.EndDeviceGroups.Contains(item))
                {
                    return true;
                }
                if (this._parent.EndDeviceControls.Contains(item))
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
                IEnumerator<IModelElement> customerAgreementsEnumerator = this._parent.CustomerAgreements.GetEnumerator();
                try
                {
                    for (
                    ; customerAgreementsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = customerAgreementsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    customerAgreementsEnumerator.Dispose();
                }
                if ((this._parent.ValidityInterval != null))
                {
                    array[arrayIndex] = this._parent.ValidityInterval;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> endDeviceGroupsEnumerator = this._parent.EndDeviceGroups.GetEnumerator();
                try
                {
                    for (
                    ; endDeviceGroupsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = endDeviceGroupsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    endDeviceGroupsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> endDeviceControlsEnumerator = this._parent.EndDeviceControls.GetEnumerator();
                try
                {
                    for (
                    ; endDeviceControlsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = endDeviceControlsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    endDeviceControlsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ICustomerAgreement customerAgreementItem = item.As<ICustomerAgreement>();
                if (((customerAgreementItem != null) 
                            && this._parent.CustomerAgreements.Remove(customerAgreementItem)))
                {
                    return true;
                }
                if ((this._parent.ValidityInterval == item))
                {
                    this._parent.ValidityInterval = null;
                    return true;
                }
                IEndDeviceGroup endDeviceGroupItem = item.As<IEndDeviceGroup>();
                if (((endDeviceGroupItem != null) 
                            && this._parent.EndDeviceGroups.Remove(endDeviceGroupItem)))
                {
                    return true;
                }
                IEndDeviceControl endDeviceControlItem = item.As<IEndDeviceControl>();
                if (((endDeviceControlItem != null) 
                            && this._parent.EndDeviceControls.Remove(endDeviceControlItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CustomerAgreements).Concat(this._parent.ValidityInterval).Concat(this._parent.EndDeviceGroups).Concat(this._parent.EndDeviceControls).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IDemandResponseProgram, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IDemandResponseProgram modelElement) : 
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
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the validityInterval property
        /// </summary>
        private sealed class ValidityIntervalProxy : ModelPropertyChange<IDemandResponseProgram, IDateTimeInterval>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValidityIntervalProxy(IDemandResponseProgram modelElement) : 
                    base(modelElement)
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
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ValidityIntervalChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ValidityIntervalChanged -= handler;
            }
        }
    }
}

