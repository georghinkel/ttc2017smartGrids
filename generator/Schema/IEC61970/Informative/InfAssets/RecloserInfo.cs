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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The default implementation of the RecloserInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Reclose" +
        "rInfo")]
    [DebuggerDisplayAttribute("RecloserInfo {UUID}")]
    public class RecloserInfo : SwitchInfo, IRecloserInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the PhaseTripRating property
        /// </summary>
        private float _phaseTripRating;
        
        /// <summary>
        /// The backing field for the GroundTripNormalEnabled property
        /// </summary>
        private bool _groundTripNormalEnabled;
        
        /// <summary>
        /// The backing field for the GroundTripRating property
        /// </summary>
        private float _groundTripRating;
        
        /// <summary>
        /// The backing field for the RecloseLockoutCount property
        /// </summary>
        private int _recloseLockoutCount;
        
        /// <summary>
        /// The backing field for the GroundTripCapable property
        /// </summary>
        private bool _groundTripCapable;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The phaseTripRating property
        /// </summary>
        [XmlElementNameAttribute("phaseTripRating")]
        [XmlAttributeAttribute(true)]
        public virtual float PhaseTripRating
        {
            get
            {
                return this._phaseTripRating;
            }
            set
            {
                if ((this._phaseTripRating != value))
                {
                    float old = this._phaseTripRating;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhaseTripRatingChanging(e);
                    this.OnPropertyChanging("PhaseTripRating", e);
                    this._phaseTripRating = value;
                    this.OnPhaseTripRatingChanged(e);
                    this.OnPropertyChanged("PhaseTripRating", e);
                }
            }
        }
        
        /// <summary>
        /// The groundTripNormalEnabled property
        /// </summary>
        [XmlElementNameAttribute("groundTripNormalEnabled")]
        [XmlAttributeAttribute(true)]
        public virtual bool GroundTripNormalEnabled
        {
            get
            {
                return this._groundTripNormalEnabled;
            }
            set
            {
                if ((this._groundTripNormalEnabled != value))
                {
                    bool old = this._groundTripNormalEnabled;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGroundTripNormalEnabledChanging(e);
                    this.OnPropertyChanging("GroundTripNormalEnabled", e);
                    this._groundTripNormalEnabled = value;
                    this.OnGroundTripNormalEnabledChanged(e);
                    this.OnPropertyChanged("GroundTripNormalEnabled", e);
                }
            }
        }
        
        /// <summary>
        /// The groundTripRating property
        /// </summary>
        [XmlElementNameAttribute("groundTripRating")]
        [XmlAttributeAttribute(true)]
        public virtual float GroundTripRating
        {
            get
            {
                return this._groundTripRating;
            }
            set
            {
                if ((this._groundTripRating != value))
                {
                    float old = this._groundTripRating;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGroundTripRatingChanging(e);
                    this.OnPropertyChanging("GroundTripRating", e);
                    this._groundTripRating = value;
                    this.OnGroundTripRatingChanged(e);
                    this.OnPropertyChanged("GroundTripRating", e);
                }
            }
        }
        
        /// <summary>
        /// The recloseLockoutCount property
        /// </summary>
        [XmlElementNameAttribute("recloseLockoutCount")]
        [XmlAttributeAttribute(true)]
        public virtual int RecloseLockoutCount
        {
            get
            {
                return this._recloseLockoutCount;
            }
            set
            {
                if ((this._recloseLockoutCount != value))
                {
                    int old = this._recloseLockoutCount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRecloseLockoutCountChanging(e);
                    this.OnPropertyChanging("RecloseLockoutCount", e);
                    this._recloseLockoutCount = value;
                    this.OnRecloseLockoutCountChanged(e);
                    this.OnPropertyChanged("RecloseLockoutCount", e);
                }
            }
        }
        
        /// <summary>
        /// The groundTripCapable property
        /// </summary>
        [XmlElementNameAttribute("groundTripCapable")]
        [XmlAttributeAttribute(true)]
        public virtual bool GroundTripCapable
        {
            get
            {
                return this._groundTripCapable;
            }
            set
            {
                if ((this._groundTripCapable != value))
                {
                    bool old = this._groundTripCapable;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGroundTripCapableChanging(e);
                    this.OnPropertyChanging("GroundTripCapable", e);
                    this._groundTripCapable = value;
                    this.OnGroundTripCapableChanged(e);
                    this.OnPropertyChanged("GroundTripCapable", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Reclose" +
                            "rInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PhaseTripRating property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseTripRatingChanging;
        
        /// <summary>
        /// Gets fired when the PhaseTripRating property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseTripRatingChanged;
        
        /// <summary>
        /// Gets fired before the GroundTripNormalEnabled property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GroundTripNormalEnabledChanging;
        
        /// <summary>
        /// Gets fired when the GroundTripNormalEnabled property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GroundTripNormalEnabledChanged;
        
        /// <summary>
        /// Gets fired before the GroundTripRating property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GroundTripRatingChanging;
        
        /// <summary>
        /// Gets fired when the GroundTripRating property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GroundTripRatingChanged;
        
        /// <summary>
        /// Gets fired before the RecloseLockoutCount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RecloseLockoutCountChanging;
        
        /// <summary>
        /// Gets fired when the RecloseLockoutCount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RecloseLockoutCountChanged;
        
        /// <summary>
        /// Gets fired before the GroundTripCapable property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GroundTripCapableChanging;
        
        /// <summary>
        /// Gets fired when the GroundTripCapable property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GroundTripCapableChanged;
        
        /// <summary>
        /// Raises the PhaseTripRatingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseTripRatingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseTripRatingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhaseTripRatingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseTripRatingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseTripRatingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GroundTripNormalEnabledChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGroundTripNormalEnabledChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GroundTripNormalEnabledChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GroundTripNormalEnabledChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGroundTripNormalEnabledChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GroundTripNormalEnabledChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GroundTripRatingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGroundTripRatingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GroundTripRatingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GroundTripRatingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGroundTripRatingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GroundTripRatingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RecloseLockoutCountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRecloseLockoutCountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RecloseLockoutCountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RecloseLockoutCountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRecloseLockoutCountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RecloseLockoutCountChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GroundTripCapableChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGroundTripCapableChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GroundTripCapableChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GroundTripCapableChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGroundTripCapableChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GroundTripCapableChanged;
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
            if ((attribute == "PHASETRIPRATING"))
            {
                return this.PhaseTripRating;
            }
            if ((attribute == "GROUNDTRIPNORMALENABLED"))
            {
                return this.GroundTripNormalEnabled;
            }
            if ((attribute == "GROUNDTRIPRATING"))
            {
                return this.GroundTripRating;
            }
            if ((attribute == "RECLOSELOCKOUTCOUNT"))
            {
                return this.RecloseLockoutCount;
            }
            if ((attribute == "GROUNDTRIPCAPABLE"))
            {
                return this.GroundTripCapable;
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
            if ((feature == "PHASETRIPRATING"))
            {
                this.PhaseTripRating = ((float)(value));
                return;
            }
            if ((feature == "GROUNDTRIPNORMALENABLED"))
            {
                this.GroundTripNormalEnabled = ((bool)(value));
                return;
            }
            if ((feature == "GROUNDTRIPRATING"))
            {
                this.GroundTripRating = ((float)(value));
                return;
            }
            if ((feature == "RECLOSELOCKOUTCOUNT"))
            {
                this.RecloseLockoutCount = ((int)(value));
                return;
            }
            if ((feature == "GROUNDTRIPCAPABLE"))
            {
                this.GroundTripCapable = ((bool)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Reclose" +
                        "rInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the phaseTripRating property
        /// </summary>
        private sealed class PhaseTripRatingProxy : ModelPropertyChange<IRecloserInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhaseTripRatingProxy(IRecloserInfo modelElement) : 
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
                    return this.ModelElement.PhaseTripRating;
                }
                set
                {
                    this.ModelElement.PhaseTripRating = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PhaseTripRatingChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PhaseTripRatingChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the groundTripNormalEnabled property
        /// </summary>
        private sealed class GroundTripNormalEnabledProxy : ModelPropertyChange<IRecloserInfo, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GroundTripNormalEnabledProxy(IRecloserInfo modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.GroundTripNormalEnabled;
                }
                set
                {
                    this.ModelElement.GroundTripNormalEnabled = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.GroundTripNormalEnabledChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.GroundTripNormalEnabledChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the groundTripRating property
        /// </summary>
        private sealed class GroundTripRatingProxy : ModelPropertyChange<IRecloserInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GroundTripRatingProxy(IRecloserInfo modelElement) : 
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
                    return this.ModelElement.GroundTripRating;
                }
                set
                {
                    this.ModelElement.GroundTripRating = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.GroundTripRatingChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.GroundTripRatingChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the recloseLockoutCount property
        /// </summary>
        private sealed class RecloseLockoutCountProxy : ModelPropertyChange<IRecloserInfo, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RecloseLockoutCountProxy(IRecloserInfo modelElement) : 
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
                    return this.ModelElement.RecloseLockoutCount;
                }
                set
                {
                    this.ModelElement.RecloseLockoutCount = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RecloseLockoutCountChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RecloseLockoutCountChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the groundTripCapable property
        /// </summary>
        private sealed class GroundTripCapableProxy : ModelPropertyChange<IRecloserInfo, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GroundTripCapableProxy(IRecloserInfo modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.GroundTripCapable;
                }
                set
                {
                    this.ModelElement.GroundTripCapable = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.GroundTripCapableChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.GroundTripCapableChanged -= handler;
            }
        }
    }
}

