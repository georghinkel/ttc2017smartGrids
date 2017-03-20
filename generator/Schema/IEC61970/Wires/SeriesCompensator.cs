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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The default implementation of the SeriesCompensator class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/SeriesCompensator")]
    [DebuggerDisplayAttribute("SeriesCompensator {UUID}")]
    public partial class SeriesCompensator : ConductingEquipment, ISeriesCompensator, IModelElement
    {
        
        /// <summary>
        /// The backing field for the R property
        /// </summary>
        private float _r;
        
        private static Lazy<ITypedElement> _rAttribute = new Lazy<ITypedElement>(RetrieveRAttribute);
        
        /// <summary>
        /// The backing field for the X property
        /// </summary>
        private float _x;
        
        private static Lazy<ITypedElement> _xAttribute = new Lazy<ITypedElement>(RetrieveXAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The r property
        /// </summary>
        [XmlElementNameAttribute("r")]
        [XmlAttributeAttribute(true)]
        public virtual float R
        {
            get
            {
                return this._r;
            }
            set
            {
                if ((this._r != value))
                {
                    float old = this._r;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRChanging(e);
                    this.OnPropertyChanging("R", e, _rAttribute);
                    this._r = value;
                    this.OnRChanged(e);
                    this.OnPropertyChanged("R", e, _rAttribute);
                }
            }
        }
        
        /// <summary>
        /// The x property
        /// </summary>
        [XmlElementNameAttribute("x")]
        [XmlAttributeAttribute(true)]
        public virtual float X
        {
            get
            {
                return this._x;
            }
            set
            {
                if ((this._x != value))
                {
                    float old = this._x;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnXChanging(e);
                    this.OnPropertyChanging("X", e, _xAttribute);
                    this._x = value;
                    this.OnXChanged(e);
                    this.OnPropertyChanged("X", e, _xAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/SeriesCompensator")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the R property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RChanging;
        
        /// <summary>
        /// Gets fired when the R property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RChanged;
        
        /// <summary>
        /// Gets fired before the X property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XChanging;
        
        /// <summary>
        /// Gets fired when the X property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XChanged;
        
        private static ITypedElement RetrieveRAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SeriesCompensator.ClassInstance)).Resolve("r")));
        }
        
        /// <summary>
        /// Raises the RChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveXAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SeriesCompensator.ClassInstance)).Resolve("x")));
        }
        
        /// <summary>
        /// Raises the XChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the XChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XChanged;
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
            if ((attribute == "R"))
            {
                return this.R;
            }
            if ((attribute == "X"))
            {
                return this.X;
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
            if ((feature == "R"))
            {
                this.R = ((float)(value));
                return;
            }
            if ((feature == "X"))
            {
                this.X = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/SeriesCompensator")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the r property
        /// </summary>
        private sealed class RProxy : ModelPropertyChange<ISeriesCompensator, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RProxy(ISeriesCompensator modelElement) : 
                    base(modelElement, "r")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.R;
                }
                set
                {
                    this.ModelElement.R = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the x property
        /// </summary>
        private sealed class XProxy : ModelPropertyChange<ISeriesCompensator, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XProxy(ISeriesCompensator modelElement) : 
                    base(modelElement, "x")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.X;
                }
                set
                {
                    this.ModelElement.X = value;
                }
            }
        }
    }
}

