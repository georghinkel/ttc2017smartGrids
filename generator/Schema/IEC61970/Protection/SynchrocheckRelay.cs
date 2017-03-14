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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Protection
{
    
    
    /// <summary>
    /// The default implementation of the SynchrocheckRelay class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Protection")]
    [XmlNamespacePrefixAttribute("cimProtection")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/SynchrocheckRelay")]
    [DebuggerDisplayAttribute("SynchrocheckRelay {UUID}")]
    public class SynchrocheckRelay : ProtectionEquipment, ISynchrocheckRelay, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MaxVoltDiff property
        /// </summary>
        private float _maxVoltDiff;
        
        /// <summary>
        /// The backing field for the MaxFreqDiff property
        /// </summary>
        private float _maxFreqDiff;
        
        /// <summary>
        /// The backing field for the MaxAngleDiff property
        /// </summary>
        private float _maxAngleDiff;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The maxVoltDiff property
        /// </summary>
        [XmlElementNameAttribute("maxVoltDiff")]
        [XmlAttributeAttribute(true)]
        public virtual float MaxVoltDiff
        {
            get
            {
                return this._maxVoltDiff;
            }
            set
            {
                if ((this._maxVoltDiff != value))
                {
                    float old = this._maxVoltDiff;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxVoltDiffChanging(e);
                    this.OnPropertyChanging("MaxVoltDiff", e);
                    this._maxVoltDiff = value;
                    this.OnMaxVoltDiffChanged(e);
                    this.OnPropertyChanged("MaxVoltDiff", e);
                }
            }
        }
        
        /// <summary>
        /// The maxFreqDiff property
        /// </summary>
        [XmlElementNameAttribute("maxFreqDiff")]
        [XmlAttributeAttribute(true)]
        public virtual float MaxFreqDiff
        {
            get
            {
                return this._maxFreqDiff;
            }
            set
            {
                if ((this._maxFreqDiff != value))
                {
                    float old = this._maxFreqDiff;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxFreqDiffChanging(e);
                    this.OnPropertyChanging("MaxFreqDiff", e);
                    this._maxFreqDiff = value;
                    this.OnMaxFreqDiffChanged(e);
                    this.OnPropertyChanged("MaxFreqDiff", e);
                }
            }
        }
        
        /// <summary>
        /// The maxAngleDiff property
        /// </summary>
        [XmlElementNameAttribute("maxAngleDiff")]
        [XmlAttributeAttribute(true)]
        public virtual float MaxAngleDiff
        {
            get
            {
                return this._maxAngleDiff;
            }
            set
            {
                if ((this._maxAngleDiff != value))
                {
                    float old = this._maxAngleDiff;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxAngleDiffChanging(e);
                    this.OnPropertyChanging("MaxAngleDiff", e);
                    this._maxAngleDiff = value;
                    this.OnMaxAngleDiffChanged(e);
                    this.OnPropertyChanged("MaxAngleDiff", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/SynchrocheckRelay")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MaxVoltDiff property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxVoltDiffChanging;
        
        /// <summary>
        /// Gets fired when the MaxVoltDiff property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxVoltDiffChanged;
        
        /// <summary>
        /// Gets fired before the MaxFreqDiff property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxFreqDiffChanging;
        
        /// <summary>
        /// Gets fired when the MaxFreqDiff property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxFreqDiffChanged;
        
        /// <summary>
        /// Gets fired before the MaxAngleDiff property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxAngleDiffChanging;
        
        /// <summary>
        /// Gets fired when the MaxAngleDiff property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxAngleDiffChanged;
        
        /// <summary>
        /// Raises the MaxVoltDiffChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxVoltDiffChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxVoltDiffChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxVoltDiffChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxVoltDiffChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxVoltDiffChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxFreqDiffChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxFreqDiffChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxFreqDiffChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxFreqDiffChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxFreqDiffChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxFreqDiffChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxAngleDiffChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxAngleDiffChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxAngleDiffChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxAngleDiffChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxAngleDiffChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxAngleDiffChanged;
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
            if ((attribute == "MAXVOLTDIFF"))
            {
                return this.MaxVoltDiff;
            }
            if ((attribute == "MAXFREQDIFF"))
            {
                return this.MaxFreqDiff;
            }
            if ((attribute == "MAXANGLEDIFF"))
            {
                return this.MaxAngleDiff;
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
            if ((feature == "MAXVOLTDIFF"))
            {
                this.MaxVoltDiff = ((float)(value));
                return;
            }
            if ((feature == "MAXFREQDIFF"))
            {
                this.MaxFreqDiff = ((float)(value));
                return;
            }
            if ((feature == "MAXANGLEDIFF"))
            {
                this.MaxAngleDiff = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/SynchrocheckRelay")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the maxVoltDiff property
        /// </summary>
        private sealed class MaxVoltDiffProxy : ModelPropertyChange<ISynchrocheckRelay, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxVoltDiffProxy(ISynchrocheckRelay modelElement) : 
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
                    return this.ModelElement.MaxVoltDiff;
                }
                set
                {
                    this.ModelElement.MaxVoltDiff = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxVoltDiffChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxVoltDiffChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the maxFreqDiff property
        /// </summary>
        private sealed class MaxFreqDiffProxy : ModelPropertyChange<ISynchrocheckRelay, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxFreqDiffProxy(ISynchrocheckRelay modelElement) : 
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
                    return this.ModelElement.MaxFreqDiff;
                }
                set
                {
                    this.ModelElement.MaxFreqDiff = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxFreqDiffChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxFreqDiffChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the maxAngleDiff property
        /// </summary>
        private sealed class MaxAngleDiffProxy : ModelPropertyChange<ISynchrocheckRelay, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxAngleDiffProxy(ISynchrocheckRelay modelElement) : 
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
                    return this.ModelElement.MaxAngleDiff;
                }
                set
                {
                    this.ModelElement.MaxAngleDiff = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxAngleDiffChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxAngleDiffChanged -= handler;
            }
        }
    }
}

