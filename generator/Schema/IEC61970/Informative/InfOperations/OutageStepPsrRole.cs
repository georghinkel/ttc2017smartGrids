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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations
{
    
    
    /// <summary>
    /// The default implementation of the OutageStepPsrRole class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfOperations")]
    [XmlNamespacePrefixAttribute("cimInfOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
        "ageStepPsrRole")]
    [DebuggerDisplayAttribute("OutageStepPsrRole {UUID}")]
    public class OutageStepPsrRole : Role, IOutageStepPsrRole, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ConductingEquipment property
        /// </summary>
        private IConductingEquipment _conductingEquipment;
        
        /// <summary>
        /// The backing field for the OutageStep property
        /// </summary>
        private IOutageStep _outageStep;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ConductingEquipment property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OutageStepRoles")]
        public virtual IConductingEquipment ConductingEquipment
        {
            get
            {
                return this._conductingEquipment;
            }
            set
            {
                if ((this._conductingEquipment != value))
                {
                    IConductingEquipment old = this._conductingEquipment;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConductingEquipmentChanging(e);
                    this.OnPropertyChanging("ConductingEquipment", e);
                    this._conductingEquipment = value;
                    if ((old != null))
                    {
                        old.OutageStepRoles.Remove(this);
                        old.Deleted -= this.OnResetConductingEquipment;
                    }
                    if ((value != null))
                    {
                        value.OutageStepRoles.Add(this);
                        value.Deleted += this.OnResetConductingEquipment;
                    }
                    this.OnConductingEquipmentChanged(e);
                    this.OnPropertyChanged("ConductingEquipment", e);
                }
            }
        }
        
        /// <summary>
        /// The OutageStep property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ConductingEquipmentRoles")]
        public virtual IOutageStep OutageStep
        {
            get
            {
                return this._outageStep;
            }
            set
            {
                if ((this._outageStep != value))
                {
                    IOutageStep old = this._outageStep;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOutageStepChanging(e);
                    this.OnPropertyChanging("OutageStep", e);
                    this._outageStep = value;
                    if ((old != null))
                    {
                        old.ConductingEquipmentRoles.Remove(this);
                        old.Deleted -= this.OnResetOutageStep;
                    }
                    if ((value != null))
                    {
                        value.ConductingEquipmentRoles.Add(this);
                        value.Deleted += this.OnResetOutageStep;
                    }
                    this.OnOutageStepChanged(e);
                    this.OnPropertyChanged("OutageStep", e);
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
                return base.ReferencedElements.Concat(new OutageStepPsrRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
                            "ageStepPsrRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ConductingEquipment property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanging;
        
        /// <summary>
        /// Gets fired when the ConductingEquipment property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanged;
        
        /// <summary>
        /// Gets fired before the OutageStep property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageStepChanging;
        
        /// <summary>
        /// Gets fired when the OutageStep property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageStepChanged;
        
        /// <summary>
        /// Raises the ConductingEquipmentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductingEquipmentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductingEquipmentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConductingEquipmentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductingEquipmentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductingEquipmentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ConductingEquipment property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConductingEquipment(object sender, System.EventArgs eventArgs)
        {
            this.ConductingEquipment = null;
        }
        
        /// <summary>
        /// Raises the OutageStepChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageStepChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageStepChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OutageStepChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageStepChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageStepChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OutageStep property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOutageStep(object sender, System.EventArgs eventArgs)
        {
            this.OutageStep = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "CONDUCTINGEQUIPMENT"))
            {
                this.ConductingEquipment = ((IConductingEquipment)(value));
                return;
            }
            if ((feature == "OUTAGESTEP"))
            {
                this.OutageStep = ((IOutageStep)(value));
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
            if ((attribute == "ConductingEquipment"))
            {
                return new ConductingEquipmentProxy(this);
            }
            if ((attribute == "OutageStep"))
            {
                return new OutageStepProxy(this);
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
            if ((reference == "ConductingEquipment"))
            {
                return new ConductingEquipmentProxy(this);
            }
            if ((reference == "OutageStep"))
            {
                return new OutageStepProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
                        "ageStepPsrRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OutageStepPsrRole class
        /// </summary>
        public class OutageStepPsrRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OutageStepPsrRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OutageStepPsrRoleReferencedElementsCollection(OutageStepPsrRole parent)
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
                    if ((this._parent.ConductingEquipment != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OutageStep != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConductingEquipmentChanged += this.PropagateValueChanges;
                this._parent.OutageStepChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConductingEquipmentChanged -= this.PropagateValueChanges;
                this._parent.OutageStepChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ConductingEquipment == null))
                {
                    IConductingEquipment conductingEquipmentCasted = item.As<IConductingEquipment>();
                    if ((conductingEquipmentCasted != null))
                    {
                        this._parent.ConductingEquipment = conductingEquipmentCasted;
                        return;
                    }
                }
                if ((this._parent.OutageStep == null))
                {
                    IOutageStep outageStepCasted = item.As<IOutageStep>();
                    if ((outageStepCasted != null))
                    {
                        this._parent.OutageStep = outageStepCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConductingEquipment = null;
                this._parent.OutageStep = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ConductingEquipment))
                {
                    return true;
                }
                if ((item == this._parent.OutageStep))
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
                if ((this._parent.ConductingEquipment != null))
                {
                    array[arrayIndex] = this._parent.ConductingEquipment;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OutageStep != null))
                {
                    array[arrayIndex] = this._parent.OutageStep;
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
                if ((this._parent.ConductingEquipment == item))
                {
                    this._parent.ConductingEquipment = null;
                    return true;
                }
                if ((this._parent.OutageStep == item))
                {
                    this._parent.OutageStep = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConductingEquipment).Concat(this._parent.OutageStep).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ConductingEquipment property
        /// </summary>
        private sealed class ConductingEquipmentProxy : ModelPropertyChange<IOutageStepPsrRole, IConductingEquipment>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConductingEquipmentProxy(IOutageStepPsrRole modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IConductingEquipment Value
            {
                get
                {
                    return this.ModelElement.ConductingEquipment;
                }
                set
                {
                    this.ModelElement.ConductingEquipment = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConductingEquipmentChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConductingEquipmentChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OutageStep property
        /// </summary>
        private sealed class OutageStepProxy : ModelPropertyChange<IOutageStepPsrRole, IOutageStep>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OutageStepProxy(IOutageStepPsrRole modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOutageStep Value
            {
                get
                {
                    return this.ModelElement.OutageStep;
                }
                set
                {
                    this.ModelElement.OutageStep = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OutageStepChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OutageStepChanged -= handler;
            }
        }
    }
}

