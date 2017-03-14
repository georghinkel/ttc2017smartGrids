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
using TTC2017.SmartGrids.COSEM.InterfaceClasses;

namespace TTC2017.SmartGrids.COSEM.COSEMObjects
{
    
    
    /// <summary>
    /// The default implementation of the ElectricityNominalValues class
    /// </summary>
    [XmlNamespaceAttribute("objects")]
    [XmlNamespacePrefixAttribute("objects")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/El" +
        "ectricityNominalValues")]
    public class ElectricityNominalValues : Data, IElectricityNominalValues, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Voltage property
        /// </summary>
        private Nullable<double> _voltage;
        
        /// <summary>
        /// The backing field for the Nominalcurrent property
        /// </summary>
        private Nullable<double> _nominalcurrent;
        
        /// <summary>
        /// The backing field for the Frequency property
        /// </summary>
        private Nullable<double> _frequency;
        
        /// <summary>
        /// The backing field for the Maximumcurrent property
        /// </summary>
        private Nullable<double> _maximumcurrent;
        
        /// <summary>
        /// The backing field for the Reference_voltage_for_power_quality_measurement property
        /// </summary>
        private Nullable<double> _reference_voltage_for_power_quality_measurement;
        
        /// <summary>
        /// The backing field for the Reference_voltage_for_aux_power_supply property
        /// </summary>
        private Nullable<double> _reference_voltage_for_aux_power_supply;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Voltage property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Voltage
        {
            get
            {
                return this._voltage;
            }
            set
            {
                if ((this._voltage != value))
                {
                    Nullable<double> old = this._voltage;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVoltageChanging(e);
                    this.OnPropertyChanging("Voltage", e);
                    this._voltage = value;
                    this.OnVoltageChanged(e);
                    this.OnPropertyChanged("Voltage", e);
                }
            }
        }
        
        /// <summary>
        /// The Nominalcurrent property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Nominalcurrent
        {
            get
            {
                return this._nominalcurrent;
            }
            set
            {
                if ((this._nominalcurrent != value))
                {
                    Nullable<double> old = this._nominalcurrent;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNominalcurrentChanging(e);
                    this.OnPropertyChanging("Nominalcurrent", e);
                    this._nominalcurrent = value;
                    this.OnNominalcurrentChanged(e);
                    this.OnPropertyChanged("Nominalcurrent", e);
                }
            }
        }
        
        /// <summary>
        /// The Frequency property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Frequency
        {
            get
            {
                return this._frequency;
            }
            set
            {
                if ((this._frequency != value))
                {
                    Nullable<double> old = this._frequency;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFrequencyChanging(e);
                    this.OnPropertyChanging("Frequency", e);
                    this._frequency = value;
                    this.OnFrequencyChanged(e);
                    this.OnPropertyChanged("Frequency", e);
                }
            }
        }
        
        /// <summary>
        /// The Maximumcurrent property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Maximumcurrent
        {
            get
            {
                return this._maximumcurrent;
            }
            set
            {
                if ((this._maximumcurrent != value))
                {
                    Nullable<double> old = this._maximumcurrent;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaximumcurrentChanging(e);
                    this.OnPropertyChanging("Maximumcurrent", e);
                    this._maximumcurrent = value;
                    this.OnMaximumcurrentChanged(e);
                    this.OnPropertyChanged("Maximumcurrent", e);
                }
            }
        }
        
        /// <summary>
        /// The Reference_voltage_for_power_quality_measurement property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Reference_voltage_for_power_quality_measurement
        {
            get
            {
                return this._reference_voltage_for_power_quality_measurement;
            }
            set
            {
                if ((this._reference_voltage_for_power_quality_measurement != value))
                {
                    Nullable<double> old = this._reference_voltage_for_power_quality_measurement;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReference_voltage_for_power_quality_measurementChanging(e);
                    this.OnPropertyChanging("Reference_voltage_for_power_quality_measurement", e);
                    this._reference_voltage_for_power_quality_measurement = value;
                    this.OnReference_voltage_for_power_quality_measurementChanged(e);
                    this.OnPropertyChanged("Reference_voltage_for_power_quality_measurement", e);
                }
            }
        }
        
        /// <summary>
        /// The Reference_voltage_for_aux_power_supply property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Reference_voltage_for_aux_power_supply
        {
            get
            {
                return this._reference_voltage_for_aux_power_supply;
            }
            set
            {
                if ((this._reference_voltage_for_aux_power_supply != value))
                {
                    Nullable<double> old = this._reference_voltage_for_aux_power_supply;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReference_voltage_for_aux_power_supplyChanging(e);
                    this.OnPropertyChanging("Reference_voltage_for_aux_power_supply", e);
                    this._reference_voltage_for_aux_power_supply = value;
                    this.OnReference_voltage_for_aux_power_supplyChanged(e);
                    this.OnPropertyChanged("Reference_voltage_for_aux_power_supply", e);
                }
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/El" +
                            "ectricityNominalValues")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Voltage property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageChanging;
        
        /// <summary>
        /// Gets fired when the Voltage property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageChanged;
        
        /// <summary>
        /// Gets fired before the Nominalcurrent property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NominalcurrentChanging;
        
        /// <summary>
        /// Gets fired when the Nominalcurrent property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NominalcurrentChanged;
        
        /// <summary>
        /// Gets fired before the Frequency property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FrequencyChanging;
        
        /// <summary>
        /// Gets fired when the Frequency property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FrequencyChanged;
        
        /// <summary>
        /// Gets fired before the Maximumcurrent property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaximumcurrentChanging;
        
        /// <summary>
        /// Gets fired when the Maximumcurrent property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaximumcurrentChanged;
        
        /// <summary>
        /// Gets fired before the Reference_voltage_for_power_quality_measurement property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Reference_voltage_for_power_quality_measurementChanging;
        
        /// <summary>
        /// Gets fired when the Reference_voltage_for_power_quality_measurement property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Reference_voltage_for_power_quality_measurementChanged;
        
        /// <summary>
        /// Gets fired before the Reference_voltage_for_aux_power_supply property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Reference_voltage_for_aux_power_supplyChanging;
        
        /// <summary>
        /// Gets fired when the Reference_voltage_for_aux_power_supply property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Reference_voltage_for_aux_power_supplyChanged;
        
        /// <summary>
        /// Raises the VoltageChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VoltageChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NominalcurrentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNominalcurrentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NominalcurrentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NominalcurrentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNominalcurrentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NominalcurrentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FrequencyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFrequencyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FrequencyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FrequencyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFrequencyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FrequencyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaximumcurrentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaximumcurrentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaximumcurrentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaximumcurrentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaximumcurrentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaximumcurrentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Reference_voltage_for_power_quality_measurementChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReference_voltage_for_power_quality_measurementChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Reference_voltage_for_power_quality_measurementChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Reference_voltage_for_power_quality_measurementChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReference_voltage_for_power_quality_measurementChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Reference_voltage_for_power_quality_measurementChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Reference_voltage_for_aux_power_supplyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReference_voltage_for_aux_power_supplyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Reference_voltage_for_aux_power_supplyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Reference_voltage_for_aux_power_supplyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReference_voltage_for_aux_power_supplyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Reference_voltage_for_aux_power_supplyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VOLTAGE"))
            {
                return this.Voltage;
            }
            if ((attribute == "NOMINALCURRENT"))
            {
                return this.Nominalcurrent;
            }
            if ((attribute == "FREQUENCY"))
            {
                return this.Frequency;
            }
            if ((attribute == "MAXIMUMCURRENT"))
            {
                return this.Maximumcurrent;
            }
            if ((attribute == "REFERENCE_VOLTAGE_FOR_POWER_QUALITY_MEASUREMENT"))
            {
                return this.Reference_voltage_for_power_quality_measurement;
            }
            if ((attribute == "REFERENCE_VOLTAGE_FOR_AUX_POWER_SUPPLY"))
            {
                return this.Reference_voltage_for_aux_power_supply;
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
            if ((feature == "VOLTAGE"))
            {
                this.Voltage = ((double)(value));
                return;
            }
            if ((feature == "NOMINALCURRENT"))
            {
                this.Nominalcurrent = ((double)(value));
                return;
            }
            if ((feature == "FREQUENCY"))
            {
                this.Frequency = ((double)(value));
                return;
            }
            if ((feature == "MAXIMUMCURRENT"))
            {
                this.Maximumcurrent = ((double)(value));
                return;
            }
            if ((feature == "REFERENCE_VOLTAGE_FOR_POWER_QUALITY_MEASUREMENT"))
            {
                this.Reference_voltage_for_power_quality_measurement = ((double)(value));
                return;
            }
            if ((feature == "REFERENCE_VOLTAGE_FOR_AUX_POWER_SUPPLY"))
            {
                this.Reference_voltage_for_aux_power_supply = ((double)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/El" +
                        "ectricityNominalValues")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Voltage property
        /// </summary>
        private sealed class VoltageProxy : ModelPropertyChange<IElectricityNominalValues, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VoltageProxy(IElectricityNominalValues modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.Voltage;
                }
                set
                {
                    this.ModelElement.Voltage = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.VoltageChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.VoltageChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Nominalcurrent property
        /// </summary>
        private sealed class NominalcurrentProxy : ModelPropertyChange<IElectricityNominalValues, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NominalcurrentProxy(IElectricityNominalValues modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.Nominalcurrent;
                }
                set
                {
                    this.ModelElement.Nominalcurrent = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.NominalcurrentChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.NominalcurrentChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Frequency property
        /// </summary>
        private sealed class FrequencyProxy : ModelPropertyChange<IElectricityNominalValues, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FrequencyProxy(IElectricityNominalValues modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.Frequency;
                }
                set
                {
                    this.ModelElement.Frequency = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.FrequencyChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.FrequencyChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Maximumcurrent property
        /// </summary>
        private sealed class MaximumcurrentProxy : ModelPropertyChange<IElectricityNominalValues, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaximumcurrentProxy(IElectricityNominalValues modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.Maximumcurrent;
                }
                set
                {
                    this.ModelElement.Maximumcurrent = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaximumcurrentChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaximumcurrentChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Reference_voltage_for_power_quality_measurement property
        /// </summary>
        private sealed class Reference_voltage_for_power_quality_measurementProxy : ModelPropertyChange<IElectricityNominalValues, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Reference_voltage_for_power_quality_measurementProxy(IElectricityNominalValues modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.Reference_voltage_for_power_quality_measurement;
                }
                set
                {
                    this.ModelElement.Reference_voltage_for_power_quality_measurement = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Reference_voltage_for_power_quality_measurementChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Reference_voltage_for_power_quality_measurementChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Reference_voltage_for_aux_power_supply property
        /// </summary>
        private sealed class Reference_voltage_for_aux_power_supplyProxy : ModelPropertyChange<IElectricityNominalValues, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Reference_voltage_for_aux_power_supplyProxy(IElectricityNominalValues modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.Reference_voltage_for_aux_power_supply;
                }
                set
                {
                    this.ModelElement.Reference_voltage_for_aux_power_supply = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Reference_voltage_for_aux_power_supplyChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Reference_voltage_for_aux_power_supplyChanged -= handler;
            }
        }
    }
}

