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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The default implementation of the CurrentTransformer class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Meas")]
    [XmlNamespacePrefixAttribute("cimMeas")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/CurrentTransformer")]
    [DebuggerDisplayAttribute("CurrentTransformer {UUID}")]
    public class CurrentTransformer : Equipment, ICurrentTransformer, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MaxRatio property
        /// </summary>
        private float _maxRatio;
        
        /// <summary>
        /// The backing field for the CoreCount property
        /// </summary>
        private int _coreCount;
        
        /// <summary>
        /// The backing field for the CtClass property
        /// </summary>
        private string _ctClass;
        
        /// <summary>
        /// The backing field for the Usage property
        /// </summary>
        private string _usage;
        
        /// <summary>
        /// The backing field for the AccuracyLimit property
        /// </summary>
        private string _accuracyLimit;
        
        /// <summary>
        /// The backing field for the AccuracyClass property
        /// </summary>
        private string _accuracyClass;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The maxRatio property
        /// </summary>
        [XmlElementNameAttribute("maxRatio")]
        [XmlAttributeAttribute(true)]
        public virtual float MaxRatio
        {
            get
            {
                return this._maxRatio;
            }
            set
            {
                if ((this._maxRatio != value))
                {
                    float old = this._maxRatio;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxRatioChanging(e);
                    this.OnPropertyChanging("MaxRatio", e);
                    this._maxRatio = value;
                    this.OnMaxRatioChanged(e);
                    this.OnPropertyChanged("MaxRatio", e);
                }
            }
        }
        
        /// <summary>
        /// The coreCount property
        /// </summary>
        [XmlElementNameAttribute("coreCount")]
        [XmlAttributeAttribute(true)]
        public virtual int CoreCount
        {
            get
            {
                return this._coreCount;
            }
            set
            {
                if ((this._coreCount != value))
                {
                    int old = this._coreCount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCoreCountChanging(e);
                    this.OnPropertyChanging("CoreCount", e);
                    this._coreCount = value;
                    this.OnCoreCountChanged(e);
                    this.OnPropertyChanged("CoreCount", e);
                }
            }
        }
        
        /// <summary>
        /// The ctClass property
        /// </summary>
        [XmlElementNameAttribute("ctClass")]
        [XmlAttributeAttribute(true)]
        public virtual string CtClass
        {
            get
            {
                return this._ctClass;
            }
            set
            {
                if ((this._ctClass != value))
                {
                    string old = this._ctClass;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCtClassChanging(e);
                    this.OnPropertyChanging("CtClass", e);
                    this._ctClass = value;
                    this.OnCtClassChanged(e);
                    this.OnPropertyChanged("CtClass", e);
                }
            }
        }
        
        /// <summary>
        /// The usage property
        /// </summary>
        [XmlElementNameAttribute("usage")]
        [XmlAttributeAttribute(true)]
        public virtual string Usage
        {
            get
            {
                return this._usage;
            }
            set
            {
                if ((this._usage != value))
                {
                    string old = this._usage;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUsageChanging(e);
                    this.OnPropertyChanging("Usage", e);
                    this._usage = value;
                    this.OnUsageChanged(e);
                    this.OnPropertyChanged("Usage", e);
                }
            }
        }
        
        /// <summary>
        /// The accuracyLimit property
        /// </summary>
        [XmlElementNameAttribute("accuracyLimit")]
        [XmlAttributeAttribute(true)]
        public virtual string AccuracyLimit
        {
            get
            {
                return this._accuracyLimit;
            }
            set
            {
                if ((this._accuracyLimit != value))
                {
                    string old = this._accuracyLimit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAccuracyLimitChanging(e);
                    this.OnPropertyChanging("AccuracyLimit", e);
                    this._accuracyLimit = value;
                    this.OnAccuracyLimitChanged(e);
                    this.OnPropertyChanged("AccuracyLimit", e);
                }
            }
        }
        
        /// <summary>
        /// The accuracyClass property
        /// </summary>
        [XmlElementNameAttribute("accuracyClass")]
        [XmlAttributeAttribute(true)]
        public virtual string AccuracyClass
        {
            get
            {
                return this._accuracyClass;
            }
            set
            {
                if ((this._accuracyClass != value))
                {
                    string old = this._accuracyClass;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAccuracyClassChanging(e);
                    this.OnPropertyChanging("AccuracyClass", e);
                    this._accuracyClass = value;
                    this.OnAccuracyClassChanged(e);
                    this.OnPropertyChanged("AccuracyClass", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/CurrentTransformer")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MaxRatio property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxRatioChanging;
        
        /// <summary>
        /// Gets fired when the MaxRatio property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxRatioChanged;
        
        /// <summary>
        /// Gets fired before the CoreCount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CoreCountChanging;
        
        /// <summary>
        /// Gets fired when the CoreCount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CoreCountChanged;
        
        /// <summary>
        /// Gets fired before the CtClass property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CtClassChanging;
        
        /// <summary>
        /// Gets fired when the CtClass property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CtClassChanged;
        
        /// <summary>
        /// Gets fired before the Usage property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UsageChanging;
        
        /// <summary>
        /// Gets fired when the Usage property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UsageChanged;
        
        /// <summary>
        /// Gets fired before the AccuracyLimit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccuracyLimitChanging;
        
        /// <summary>
        /// Gets fired when the AccuracyLimit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccuracyLimitChanged;
        
        /// <summary>
        /// Gets fired before the AccuracyClass property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccuracyClassChanging;
        
        /// <summary>
        /// Gets fired when the AccuracyClass property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccuracyClassChanged;
        
        /// <summary>
        /// Raises the MaxRatioChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxRatioChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxRatioChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxRatioChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxRatioChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxRatioChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CoreCountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCoreCountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CoreCountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CoreCountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCoreCountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CoreCountChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CtClassChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCtClassChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CtClassChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CtClassChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCtClassChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CtClassChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UsageChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUsageChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UsageChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UsageChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUsageChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UsageChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AccuracyLimitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccuracyLimitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccuracyLimitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AccuracyLimitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccuracyLimitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccuracyLimitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AccuracyClassChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccuracyClassChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccuracyClassChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AccuracyClassChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccuracyClassChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccuracyClassChanged;
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
            if ((attribute == "MAXRATIO"))
            {
                return this.MaxRatio;
            }
            if ((attribute == "CORECOUNT"))
            {
                return this.CoreCount;
            }
            if ((attribute == "CTCLASS"))
            {
                return this.CtClass;
            }
            if ((attribute == "USAGE"))
            {
                return this.Usage;
            }
            if ((attribute == "ACCURACYLIMIT"))
            {
                return this.AccuracyLimit;
            }
            if ((attribute == "ACCURACYCLASS"))
            {
                return this.AccuracyClass;
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
            if ((feature == "MAXRATIO"))
            {
                this.MaxRatio = ((float)(value));
                return;
            }
            if ((feature == "CORECOUNT"))
            {
                this.CoreCount = ((int)(value));
                return;
            }
            if ((feature == "CTCLASS"))
            {
                this.CtClass = ((string)(value));
                return;
            }
            if ((feature == "USAGE"))
            {
                this.Usage = ((string)(value));
                return;
            }
            if ((feature == "ACCURACYLIMIT"))
            {
                this.AccuracyLimit = ((string)(value));
                return;
            }
            if ((feature == "ACCURACYCLASS"))
            {
                this.AccuracyClass = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/CurrentTransformer")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the maxRatio property
        /// </summary>
        private sealed class MaxRatioProxy : ModelPropertyChange<ICurrentTransformer, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxRatioProxy(ICurrentTransformer modelElement) : 
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
                    return this.ModelElement.MaxRatio;
                }
                set
                {
                    this.ModelElement.MaxRatio = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxRatioChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxRatioChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the coreCount property
        /// </summary>
        private sealed class CoreCountProxy : ModelPropertyChange<ICurrentTransformer, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CoreCountProxy(ICurrentTransformer modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.CoreCount;
                }
                set
                {
                    this.ModelElement.CoreCount = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CoreCountChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CoreCountChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ctClass property
        /// </summary>
        private sealed class CtClassProxy : ModelPropertyChange<ICurrentTransformer, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CtClassProxy(ICurrentTransformer modelElement) : 
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
                    return this.ModelElement.CtClass;
                }
                set
                {
                    this.ModelElement.CtClass = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CtClassChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CtClassChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the usage property
        /// </summary>
        private sealed class UsageProxy : ModelPropertyChange<ICurrentTransformer, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UsageProxy(ICurrentTransformer modelElement) : 
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
                    return this.ModelElement.Usage;
                }
                set
                {
                    this.ModelElement.Usage = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UsageChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UsageChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the accuracyLimit property
        /// </summary>
        private sealed class AccuracyLimitProxy : ModelPropertyChange<ICurrentTransformer, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AccuracyLimitProxy(ICurrentTransformer modelElement) : 
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
                    return this.ModelElement.AccuracyLimit;
                }
                set
                {
                    this.ModelElement.AccuracyLimit = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AccuracyLimitChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AccuracyLimitChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the accuracyClass property
        /// </summary>
        private sealed class AccuracyClassProxy : ModelPropertyChange<ICurrentTransformer, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AccuracyClassProxy(ICurrentTransformer modelElement) : 
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
                    return this.ModelElement.AccuracyClass;
                }
                set
                {
                    this.ModelElement.AccuracyClass = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AccuracyClassChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AccuracyClassChanged -= handler;
            }
        }
    }
}

