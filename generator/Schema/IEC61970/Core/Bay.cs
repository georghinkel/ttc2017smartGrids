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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The default implementation of the Bay class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Core")]
    [XmlNamespacePrefixAttribute("cimCore")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/Bay")]
    [DebuggerDisplayAttribute("Bay {UUID}")]
    public partial class Bay : EquipmentContainer, IBay, IModelElement
    {
        
        /// <summary>
        /// The backing field for the BayEnergyMeasFlag property
        /// </summary>
        private bool _bayEnergyMeasFlag;
        
        private static Lazy<ITypedElement> _bayEnergyMeasFlagAttribute = new Lazy<ITypedElement>(RetrieveBayEnergyMeasFlagAttribute);
        
        /// <summary>
        /// The backing field for the BusBarConfiguration property
        /// </summary>
        private Nullable<BusbarConfiguration> _busBarConfiguration;
        
        private static Lazy<ITypedElement> _busBarConfigurationAttribute = new Lazy<ITypedElement>(RetrieveBusBarConfigurationAttribute);
        
        /// <summary>
        /// The backing field for the BayPowerMeasFlag property
        /// </summary>
        private bool _bayPowerMeasFlag;
        
        private static Lazy<ITypedElement> _bayPowerMeasFlagAttribute = new Lazy<ITypedElement>(RetrieveBayPowerMeasFlagAttribute);
        
        /// <summary>
        /// The backing field for the BreakerConfiguration property
        /// </summary>
        private Nullable<BreakerConfiguration> _breakerConfiguration;
        
        private static Lazy<ITypedElement> _breakerConfigurationAttribute = new Lazy<ITypedElement>(RetrieveBreakerConfigurationAttribute);
        
        private static Lazy<ITypedElement> _voltageLevelReference = new Lazy<ITypedElement>(RetrieveVoltageLevelReference);
        
        /// <summary>
        /// The backing field for the VoltageLevel property
        /// </summary>
        private IVoltageLevel _voltageLevel;
        
        private static Lazy<ITypedElement> _substationReference = new Lazy<ITypedElement>(RetrieveSubstationReference);
        
        /// <summary>
        /// The backing field for the Substation property
        /// </summary>
        private ISubstation _substation;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The bayEnergyMeasFlag property
        /// </summary>
        [XmlElementNameAttribute("bayEnergyMeasFlag")]
        [XmlAttributeAttribute(true)]
        public virtual bool BayEnergyMeasFlag
        {
            get
            {
                return this._bayEnergyMeasFlag;
            }
            set
            {
                if ((this._bayEnergyMeasFlag != value))
                {
                    bool old = this._bayEnergyMeasFlag;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBayEnergyMeasFlagChanging(e);
                    this.OnPropertyChanging("BayEnergyMeasFlag", e, _bayEnergyMeasFlagAttribute);
                    this._bayEnergyMeasFlag = value;
                    this.OnBayEnergyMeasFlagChanged(e);
                    this.OnPropertyChanged("BayEnergyMeasFlag", e, _bayEnergyMeasFlagAttribute);
                }
            }
        }
        
        /// <summary>
        /// The busBarConfiguration property
        /// </summary>
        [XmlElementNameAttribute("busBarConfiguration")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<BusbarConfiguration> BusBarConfiguration
        {
            get
            {
                return this._busBarConfiguration;
            }
            set
            {
                if ((this._busBarConfiguration != value))
                {
                    Nullable<BusbarConfiguration> old = this._busBarConfiguration;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBusBarConfigurationChanging(e);
                    this.OnPropertyChanging("BusBarConfiguration", e, _busBarConfigurationAttribute);
                    this._busBarConfiguration = value;
                    this.OnBusBarConfigurationChanged(e);
                    this.OnPropertyChanged("BusBarConfiguration", e, _busBarConfigurationAttribute);
                }
            }
        }
        
        /// <summary>
        /// The bayPowerMeasFlag property
        /// </summary>
        [XmlElementNameAttribute("bayPowerMeasFlag")]
        [XmlAttributeAttribute(true)]
        public virtual bool BayPowerMeasFlag
        {
            get
            {
                return this._bayPowerMeasFlag;
            }
            set
            {
                if ((this._bayPowerMeasFlag != value))
                {
                    bool old = this._bayPowerMeasFlag;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBayPowerMeasFlagChanging(e);
                    this.OnPropertyChanging("BayPowerMeasFlag", e, _bayPowerMeasFlagAttribute);
                    this._bayPowerMeasFlag = value;
                    this.OnBayPowerMeasFlagChanged(e);
                    this.OnPropertyChanged("BayPowerMeasFlag", e, _bayPowerMeasFlagAttribute);
                }
            }
        }
        
        /// <summary>
        /// The breakerConfiguration property
        /// </summary>
        [XmlElementNameAttribute("breakerConfiguration")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<BreakerConfiguration> BreakerConfiguration
        {
            get
            {
                return this._breakerConfiguration;
            }
            set
            {
                if ((this._breakerConfiguration != value))
                {
                    Nullable<BreakerConfiguration> old = this._breakerConfiguration;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBreakerConfigurationChanging(e);
                    this.OnPropertyChanging("BreakerConfiguration", e, _breakerConfigurationAttribute);
                    this._breakerConfiguration = value;
                    this.OnBreakerConfigurationChanged(e);
                    this.OnPropertyChanged("BreakerConfiguration", e, _breakerConfigurationAttribute);
                }
            }
        }
        
        /// <summary>
        /// The VoltageLevel property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Bays")]
        public virtual IVoltageLevel VoltageLevel
        {
            get
            {
                return this._voltageLevel;
            }
            set
            {
                if ((this._voltageLevel != value))
                {
                    IVoltageLevel old = this._voltageLevel;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVoltageLevelChanging(e);
                    this.OnPropertyChanging("VoltageLevel", e, _voltageLevelReference);
                    this._voltageLevel = value;
                    if ((old != null))
                    {
                        old.Bays.Remove(this);
                        old.Deleted -= this.OnResetVoltageLevel;
                    }
                    if ((value != null))
                    {
                        value.Bays.Add(this);
                        value.Deleted += this.OnResetVoltageLevel;
                    }
                    this.OnVoltageLevelChanged(e);
                    this.OnPropertyChanged("VoltageLevel", e, _voltageLevelReference);
                }
            }
        }
        
        /// <summary>
        /// The Substation property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Bays")]
        public virtual ISubstation Substation
        {
            get
            {
                return this._substation;
            }
            set
            {
                if ((this._substation != value))
                {
                    ISubstation old = this._substation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSubstationChanging(e);
                    this.OnPropertyChanging("Substation", e, _substationReference);
                    this._substation = value;
                    if ((old != null))
                    {
                        old.Bays.Remove(this);
                        old.Deleted -= this.OnResetSubstation;
                    }
                    if ((value != null))
                    {
                        value.Bays.Add(this);
                        value.Deleted += this.OnResetSubstation;
                    }
                    this.OnSubstationChanged(e);
                    this.OnPropertyChanged("Substation", e, _substationReference);
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
                return base.ReferencedElements.Concat(new BayReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/Bay")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the BayEnergyMeasFlag property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BayEnergyMeasFlagChanging;
        
        /// <summary>
        /// Gets fired when the BayEnergyMeasFlag property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BayEnergyMeasFlagChanged;
        
        /// <summary>
        /// Gets fired before the BusBarConfiguration property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BusBarConfigurationChanging;
        
        /// <summary>
        /// Gets fired when the BusBarConfiguration property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BusBarConfigurationChanged;
        
        /// <summary>
        /// Gets fired before the BayPowerMeasFlag property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BayPowerMeasFlagChanging;
        
        /// <summary>
        /// Gets fired when the BayPowerMeasFlag property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BayPowerMeasFlagChanged;
        
        /// <summary>
        /// Gets fired before the BreakerConfiguration property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BreakerConfigurationChanging;
        
        /// <summary>
        /// Gets fired when the BreakerConfiguration property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BreakerConfigurationChanged;
        
        /// <summary>
        /// Gets fired before the VoltageLevel property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageLevelChanging;
        
        /// <summary>
        /// Gets fired when the VoltageLevel property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageLevelChanged;
        
        /// <summary>
        /// Gets fired before the Substation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubstationChanging;
        
        /// <summary>
        /// Gets fired when the Substation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubstationChanged;
        
        private static ITypedElement RetrieveBayEnergyMeasFlagAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Bay.ClassInstance)).Resolve("bayEnergyMeasFlag")));
        }
        
        /// <summary>
        /// Raises the BayEnergyMeasFlagChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBayEnergyMeasFlagChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BayEnergyMeasFlagChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BayEnergyMeasFlagChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBayEnergyMeasFlagChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BayEnergyMeasFlagChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveBusBarConfigurationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Bay.ClassInstance)).Resolve("busBarConfiguration")));
        }
        
        /// <summary>
        /// Raises the BusBarConfigurationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBusBarConfigurationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BusBarConfigurationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BusBarConfigurationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBusBarConfigurationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BusBarConfigurationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveBayPowerMeasFlagAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Bay.ClassInstance)).Resolve("bayPowerMeasFlag")));
        }
        
        /// <summary>
        /// Raises the BayPowerMeasFlagChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBayPowerMeasFlagChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BayPowerMeasFlagChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BayPowerMeasFlagChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBayPowerMeasFlagChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BayPowerMeasFlagChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveBreakerConfigurationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Bay.ClassInstance)).Resolve("breakerConfiguration")));
        }
        
        /// <summary>
        /// Raises the BreakerConfigurationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBreakerConfigurationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BreakerConfigurationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BreakerConfigurationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBreakerConfigurationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BreakerConfigurationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveVoltageLevelReference()
        {
            return ((ITypedElement)(((ModelElement)(Bay.ClassInstance)).Resolve("VoltageLevel")));
        }
        
        /// <summary>
        /// Raises the VoltageLevelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageLevelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageLevelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VoltageLevelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageLevelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageLevelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the VoltageLevel property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetVoltageLevel(object sender, System.EventArgs eventArgs)
        {
            this.VoltageLevel = null;
        }
        
        private static ITypedElement RetrieveSubstationReference()
        {
            return ((ITypedElement)(((ModelElement)(Bay.ClassInstance)).Resolve("Substation")));
        }
        
        /// <summary>
        /// Raises the SubstationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubstationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubstationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SubstationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubstationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubstationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Substation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSubstation(object sender, System.EventArgs eventArgs)
        {
            this.Substation = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "BAYENERGYMEASFLAG"))
            {
                return this.BayEnergyMeasFlag;
            }
            if ((attribute == "BUSBARCONFIGURATION"))
            {
                return this.BusBarConfiguration;
            }
            if ((attribute == "BAYPOWERMEASFLAG"))
            {
                return this.BayPowerMeasFlag;
            }
            if ((attribute == "BREAKERCONFIGURATION"))
            {
                return this.BreakerConfiguration;
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
            if ((feature == "VOLTAGELEVEL"))
            {
                this.VoltageLevel = ((IVoltageLevel)(value));
                return;
            }
            if ((feature == "SUBSTATION"))
            {
                this.Substation = ((ISubstation)(value));
                return;
            }
            if ((feature == "BAYENERGYMEASFLAG"))
            {
                this.BayEnergyMeasFlag = ((bool)(value));
                return;
            }
            if ((feature == "BUSBARCONFIGURATION"))
            {
                this.BusBarConfiguration = ((BusbarConfiguration)(value));
                return;
            }
            if ((feature == "BAYPOWERMEASFLAG"))
            {
                this.BayPowerMeasFlag = ((bool)(value));
                return;
            }
            if ((feature == "BREAKERCONFIGURATION"))
            {
                this.BreakerConfiguration = ((BreakerConfiguration)(value));
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
            if ((attribute == "VoltageLevel"))
            {
                return new VoltageLevelProxy(this);
            }
            if ((attribute == "Substation"))
            {
                return new SubstationProxy(this);
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
            if ((reference == "VoltageLevel"))
            {
                return new VoltageLevelProxy(this);
            }
            if ((reference == "Substation"))
            {
                return new SubstationProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/Bay")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Bay class
        /// </summary>
        public class BayReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Bay _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BayReferencedElementsCollection(Bay parent)
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
                    if ((this._parent.VoltageLevel != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Substation != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.VoltageLevelChanged += this.PropagateValueChanges;
                this._parent.SubstationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.VoltageLevelChanged -= this.PropagateValueChanges;
                this._parent.SubstationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.VoltageLevel == null))
                {
                    IVoltageLevel voltageLevelCasted = item.As<IVoltageLevel>();
                    if ((voltageLevelCasted != null))
                    {
                        this._parent.VoltageLevel = voltageLevelCasted;
                        return;
                    }
                }
                if ((this._parent.Substation == null))
                {
                    ISubstation substationCasted = item.As<ISubstation>();
                    if ((substationCasted != null))
                    {
                        this._parent.Substation = substationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.VoltageLevel = null;
                this._parent.Substation = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.VoltageLevel))
                {
                    return true;
                }
                if ((item == this._parent.Substation))
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
                if ((this._parent.VoltageLevel != null))
                {
                    array[arrayIndex] = this._parent.VoltageLevel;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Substation != null))
                {
                    array[arrayIndex] = this._parent.Substation;
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
                if ((this._parent.VoltageLevel == item))
                {
                    this._parent.VoltageLevel = null;
                    return true;
                }
                if ((this._parent.Substation == item))
                {
                    this._parent.Substation = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.VoltageLevel).Concat(this._parent.Substation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the bayEnergyMeasFlag property
        /// </summary>
        private sealed class BayEnergyMeasFlagProxy : ModelPropertyChange<IBay, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BayEnergyMeasFlagProxy(IBay modelElement) : 
                    base(modelElement, "bayEnergyMeasFlag")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.BayEnergyMeasFlag;
                }
                set
                {
                    this.ModelElement.BayEnergyMeasFlag = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the busBarConfiguration property
        /// </summary>
        private sealed class BusBarConfigurationProxy : ModelPropertyChange<IBay, Nullable<BusbarConfiguration>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BusBarConfigurationProxy(IBay modelElement) : 
                    base(modelElement, "busBarConfiguration")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<BusbarConfiguration> Value
            {
                get
                {
                    return this.ModelElement.BusBarConfiguration;
                }
                set
                {
                    this.ModelElement.BusBarConfiguration = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the bayPowerMeasFlag property
        /// </summary>
        private sealed class BayPowerMeasFlagProxy : ModelPropertyChange<IBay, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BayPowerMeasFlagProxy(IBay modelElement) : 
                    base(modelElement, "bayPowerMeasFlag")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.BayPowerMeasFlag;
                }
                set
                {
                    this.ModelElement.BayPowerMeasFlag = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the breakerConfiguration property
        /// </summary>
        private sealed class BreakerConfigurationProxy : ModelPropertyChange<IBay, Nullable<BreakerConfiguration>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BreakerConfigurationProxy(IBay modelElement) : 
                    base(modelElement, "breakerConfiguration")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<BreakerConfiguration> Value
            {
                get
                {
                    return this.ModelElement.BreakerConfiguration;
                }
                set
                {
                    this.ModelElement.BreakerConfiguration = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the VoltageLevel property
        /// </summary>
        private sealed class VoltageLevelProxy : ModelPropertyChange<IBay, IVoltageLevel>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VoltageLevelProxy(IBay modelElement) : 
                    base(modelElement, "VoltageLevel")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IVoltageLevel Value
            {
                get
                {
                    return this.ModelElement.VoltageLevel;
                }
                set
                {
                    this.ModelElement.VoltageLevel = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Substation property
        /// </summary>
        private sealed class SubstationProxy : ModelPropertyChange<IBay, ISubstation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SubstationProxy(IBay modelElement) : 
                    base(modelElement, "Substation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISubstation Value
            {
                get
                {
                    return this.ModelElement.Substation;
                }
                set
                {
                    this.ModelElement.Substation = value;
                }
            }
        }
    }
}

