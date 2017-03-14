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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The default implementation of the ScaledValueConfig class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/ScaledValueConfig")]
    public class ScaledValueConfig : ModelElement, IScaledValueConfig, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ScaleFactor property
        /// </summary>
        private Nullable<float> _scaleFactor;
        
        /// <summary>
        /// The backing field for the Offset property
        /// </summary>
        private Nullable<float> _offset;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The scaleFactor property
        /// </summary>
        [XmlElementNameAttribute("scaleFactor")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> ScaleFactor
        {
            get
            {
                return this._scaleFactor;
            }
            set
            {
                if ((this._scaleFactor != value))
                {
                    Nullable<float> old = this._scaleFactor;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnScaleFactorChanging(e);
                    this.OnPropertyChanging("ScaleFactor", e);
                    this._scaleFactor = value;
                    this.OnScaleFactorChanged(e);
                    this.OnPropertyChanged("ScaleFactor", e);
                }
            }
        }
        
        /// <summary>
        /// The offset property
        /// </summary>
        [XmlElementNameAttribute("offset")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> Offset
        {
            get
            {
                return this._offset;
            }
            set
            {
                if ((this._offset != value))
                {
                    Nullable<float> old = this._offset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOffsetChanging(e);
                    this.OnPropertyChanging("Offset", e);
                    this._offset = value;
                    this.OnOffsetChanged(e);
                    this.OnPropertyChanged("Offset", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                            "taclasses/ScaledValueConfig")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ScaleFactor property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ScaleFactorChanging;
        
        /// <summary>
        /// Gets fired when the ScaleFactor property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ScaleFactorChanged;
        
        /// <summary>
        /// Gets fired before the Offset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OffsetChanging;
        
        /// <summary>
        /// Gets fired when the Offset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OffsetChanged;
        
        /// <summary>
        /// Raises the ScaleFactorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnScaleFactorChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ScaleFactorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ScaleFactorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnScaleFactorChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ScaleFactorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OffsetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOffsetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OffsetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OffsetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOffsetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OffsetChanged;
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
            if ((attribute == "SCALEFACTOR"))
            {
                return this.ScaleFactor;
            }
            if ((attribute == "OFFSET"))
            {
                return this.Offset;
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
            if ((feature == "SCALEFACTOR"))
            {
                this.ScaleFactor = ((float)(value));
                return;
            }
            if ((feature == "OFFSET"))
            {
                this.Offset = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/ScaledValueConfig")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the scaleFactor property
        /// </summary>
        private sealed class ScaleFactorProxy : ModelPropertyChange<IScaledValueConfig, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ScaleFactorProxy(IScaledValueConfig modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.ScaleFactor;
                }
                set
                {
                    this.ModelElement.ScaleFactor = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ScaleFactorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ScaleFactorChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the offset property
        /// </summary>
        private sealed class OffsetProxy : ModelPropertyChange<IScaledValueConfig, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OffsetProxy(IScaledValueConfig modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.Offset;
                }
                set
                {
                    this.ModelElement.Offset = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OffsetChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OffsetChanged -= handler;
            }
        }
    }
}

