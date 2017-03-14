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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The default implementation of the CAESPlant class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/CAESPla" +
        "nt")]
    [DebuggerDisplayAttribute("CAESPlant {UUID}")]
    public class CAESPlant : PowerSystemResource, ICAESPlant, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EnergyStorageCapacity property
        /// </summary>
        private float _energyStorageCapacity;
        
        /// <summary>
        /// The backing field for the RatedCapacityP property
        /// </summary>
        private float _ratedCapacityP;
        
        /// <summary>
        /// The backing field for the ThermalGeneratingUnit property
        /// </summary>
        private IThermalGeneratingUnit _thermalGeneratingUnit;
        
        /// <summary>
        /// The backing field for the AirCompressor property
        /// </summary>
        private IAirCompressor _airCompressor;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The energyStorageCapacity property
        /// </summary>
        [XmlElementNameAttribute("energyStorageCapacity")]
        [XmlAttributeAttribute(true)]
        public virtual float EnergyStorageCapacity
        {
            get
            {
                return this._energyStorageCapacity;
            }
            set
            {
                if ((this._energyStorageCapacity != value))
                {
                    float old = this._energyStorageCapacity;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnergyStorageCapacityChanging(e);
                    this.OnPropertyChanging("EnergyStorageCapacity", e);
                    this._energyStorageCapacity = value;
                    this.OnEnergyStorageCapacityChanged(e);
                    this.OnPropertyChanged("EnergyStorageCapacity", e);
                }
            }
        }
        
        /// <summary>
        /// The ratedCapacityP property
        /// </summary>
        [XmlElementNameAttribute("ratedCapacityP")]
        [XmlAttributeAttribute(true)]
        public virtual float RatedCapacityP
        {
            get
            {
                return this._ratedCapacityP;
            }
            set
            {
                if ((this._ratedCapacityP != value))
                {
                    float old = this._ratedCapacityP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRatedCapacityPChanging(e);
                    this.OnPropertyChanging("RatedCapacityP", e);
                    this._ratedCapacityP = value;
                    this.OnRatedCapacityPChanged(e);
                    this.OnPropertyChanged("RatedCapacityP", e);
                }
            }
        }
        
        /// <summary>
        /// The ThermalGeneratingUnit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CAESPlant")]
        public virtual IThermalGeneratingUnit ThermalGeneratingUnit
        {
            get
            {
                return this._thermalGeneratingUnit;
            }
            set
            {
                if ((this._thermalGeneratingUnit != value))
                {
                    IThermalGeneratingUnit old = this._thermalGeneratingUnit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnThermalGeneratingUnitChanging(e);
                    this.OnPropertyChanging("ThermalGeneratingUnit", e);
                    this._thermalGeneratingUnit = value;
                    if ((old != null))
                    {
                        old.CAESPlant = null;
                        old.Deleted -= this.OnResetThermalGeneratingUnit;
                    }
                    if ((value != null))
                    {
                        value.CAESPlant = this;
                        value.Deleted += this.OnResetThermalGeneratingUnit;
                    }
                    this.OnThermalGeneratingUnitChanged(e);
                    this.OnPropertyChanged("ThermalGeneratingUnit", e);
                }
            }
        }
        
        /// <summary>
        /// The AirCompressor property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CAESPlant")]
        public virtual IAirCompressor AirCompressor
        {
            get
            {
                return this._airCompressor;
            }
            set
            {
                if ((this._airCompressor != value))
                {
                    IAirCompressor old = this._airCompressor;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAirCompressorChanging(e);
                    this.OnPropertyChanging("AirCompressor", e);
                    this._airCompressor = value;
                    if ((old != null))
                    {
                        old.CAESPlant = null;
                        old.Deleted -= this.OnResetAirCompressor;
                    }
                    if ((value != null))
                    {
                        value.CAESPlant = this;
                        value.Deleted += this.OnResetAirCompressor;
                    }
                    this.OnAirCompressorChanged(e);
                    this.OnPropertyChanged("AirCompressor", e);
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
                return base.ReferencedElements.Concat(new CAESPlantReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/CAESPla" +
                            "nt")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EnergyStorageCapacity property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyStorageCapacityChanging;
        
        /// <summary>
        /// Gets fired when the EnergyStorageCapacity property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyStorageCapacityChanged;
        
        /// <summary>
        /// Gets fired before the RatedCapacityP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RatedCapacityPChanging;
        
        /// <summary>
        /// Gets fired when the RatedCapacityP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RatedCapacityPChanged;
        
        /// <summary>
        /// Gets fired before the ThermalGeneratingUnit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the ThermalGeneratingUnit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanged;
        
        /// <summary>
        /// Gets fired before the AirCompressor property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AirCompressorChanging;
        
        /// <summary>
        /// Gets fired when the AirCompressor property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AirCompressorChanged;
        
        /// <summary>
        /// Raises the EnergyStorageCapacityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyStorageCapacityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyStorageCapacityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyStorageCapacityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyStorageCapacityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyStorageCapacityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RatedCapacityPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRatedCapacityPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RatedCapacityPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RatedCapacityPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRatedCapacityPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RatedCapacityPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThermalGeneratingUnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThermalGeneratingUnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThermalGeneratingUnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThermalGeneratingUnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThermalGeneratingUnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThermalGeneratingUnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ThermalGeneratingUnit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetThermalGeneratingUnit(object sender, System.EventArgs eventArgs)
        {
            this.ThermalGeneratingUnit = null;
        }
        
        /// <summary>
        /// Raises the AirCompressorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAirCompressorChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AirCompressorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AirCompressorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAirCompressorChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AirCompressorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AirCompressor property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAirCompressor(object sender, System.EventArgs eventArgs)
        {
            this.AirCompressor = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ENERGYSTORAGECAPACITY"))
            {
                return this.EnergyStorageCapacity;
            }
            if ((attribute == "RATEDCAPACITYP"))
            {
                return this.RatedCapacityP;
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
            if ((feature == "THERMALGENERATINGUNIT"))
            {
                this.ThermalGeneratingUnit = ((IThermalGeneratingUnit)(value));
                return;
            }
            if ((feature == "AIRCOMPRESSOR"))
            {
                this.AirCompressor = ((IAirCompressor)(value));
                return;
            }
            if ((feature == "ENERGYSTORAGECAPACITY"))
            {
                this.EnergyStorageCapacity = ((float)(value));
                return;
            }
            if ((feature == "RATEDCAPACITYP"))
            {
                this.RatedCapacityP = ((float)(value));
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
            if ((attribute == "ThermalGeneratingUnit"))
            {
                return new ThermalGeneratingUnitProxy(this);
            }
            if ((attribute == "AirCompressor"))
            {
                return new AirCompressorProxy(this);
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
            if ((reference == "ThermalGeneratingUnit"))
            {
                return new ThermalGeneratingUnitProxy(this);
            }
            if ((reference == "AirCompressor"))
            {
                return new AirCompressorProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/CAESPla" +
                        "nt")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CAESPlant class
        /// </summary>
        public class CAESPlantReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CAESPlant _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CAESPlantReferencedElementsCollection(CAESPlant parent)
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
                    if ((this._parent.ThermalGeneratingUnit != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AirCompressor != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ThermalGeneratingUnitChanged += this.PropagateValueChanges;
                this._parent.AirCompressorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ThermalGeneratingUnitChanged -= this.PropagateValueChanges;
                this._parent.AirCompressorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ThermalGeneratingUnit == null))
                {
                    IThermalGeneratingUnit thermalGeneratingUnitCasted = item.As<IThermalGeneratingUnit>();
                    if ((thermalGeneratingUnitCasted != null))
                    {
                        this._parent.ThermalGeneratingUnit = thermalGeneratingUnitCasted;
                        return;
                    }
                }
                if ((this._parent.AirCompressor == null))
                {
                    IAirCompressor airCompressorCasted = item.As<IAirCompressor>();
                    if ((airCompressorCasted != null))
                    {
                        this._parent.AirCompressor = airCompressorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ThermalGeneratingUnit = null;
                this._parent.AirCompressor = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ThermalGeneratingUnit))
                {
                    return true;
                }
                if ((item == this._parent.AirCompressor))
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
                if ((this._parent.ThermalGeneratingUnit != null))
                {
                    array[arrayIndex] = this._parent.ThermalGeneratingUnit;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AirCompressor != null))
                {
                    array[arrayIndex] = this._parent.AirCompressor;
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
                if ((this._parent.ThermalGeneratingUnit == item))
                {
                    this._parent.ThermalGeneratingUnit = null;
                    return true;
                }
                if ((this._parent.AirCompressor == item))
                {
                    this._parent.AirCompressor = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ThermalGeneratingUnit).Concat(this._parent.AirCompressor).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the energyStorageCapacity property
        /// </summary>
        private sealed class EnergyStorageCapacityProxy : ModelPropertyChange<ICAESPlant, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnergyStorageCapacityProxy(ICAESPlant modelElement) : 
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
                    return this.ModelElement.EnergyStorageCapacity;
                }
                set
                {
                    this.ModelElement.EnergyStorageCapacity = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EnergyStorageCapacityChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EnergyStorageCapacityChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ratedCapacityP property
        /// </summary>
        private sealed class RatedCapacityPProxy : ModelPropertyChange<ICAESPlant, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RatedCapacityPProxy(ICAESPlant modelElement) : 
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
                    return this.ModelElement.RatedCapacityP;
                }
                set
                {
                    this.ModelElement.RatedCapacityP = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RatedCapacityPChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RatedCapacityPChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ThermalGeneratingUnit property
        /// </summary>
        private sealed class ThermalGeneratingUnitProxy : ModelPropertyChange<ICAESPlant, IThermalGeneratingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ThermalGeneratingUnitProxy(ICAESPlant modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IThermalGeneratingUnit Value
            {
                get
                {
                    return this.ModelElement.ThermalGeneratingUnit;
                }
                set
                {
                    this.ModelElement.ThermalGeneratingUnit = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ThermalGeneratingUnitChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ThermalGeneratingUnitChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AirCompressor property
        /// </summary>
        private sealed class AirCompressorProxy : ModelPropertyChange<ICAESPlant, IAirCompressor>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AirCompressorProxy(ICAESPlant modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAirCompressor Value
            {
                get
                {
                    return this.ModelElement.AirCompressor;
                }
                set
                {
                    this.ModelElement.AirCompressor = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AirCompressorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AirCompressorChanged -= handler;
            }
        }
    }
}

