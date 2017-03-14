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
    /// The default implementation of the Coefficients class
    /// </summary>
    [XmlNamespaceAttribute("objects")]
    [XmlNamespacePrefixAttribute("objects")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Co" +
        "efficients")]
    public class Coefficients : Data, ICoefficients, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Transformer_magnetic_losses property
        /// </summary>
        private Nullable<double> _transformer_magnetic_losses;
        
        /// <summary>
        /// The backing field for the Transformer_iron_losses property
        /// </summary>
        private Nullable<double> _transformer_iron_losses;
        
        /// <summary>
        /// The backing field for the Line_resistance_losses property
        /// </summary>
        private Nullable<double> _line_resistance_losses;
        
        /// <summary>
        /// The backing field for the Line_reactance_losses property
        /// </summary>
        private Nullable<double> _line_reactance_losses;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Transformer_magnetic_losses property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Transformer_magnetic_losses
        {
            get
            {
                return this._transformer_magnetic_losses;
            }
            set
            {
                if ((this._transformer_magnetic_losses != value))
                {
                    Nullable<double> old = this._transformer_magnetic_losses;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransformer_magnetic_lossesChanging(e);
                    this.OnPropertyChanging("Transformer_magnetic_losses", e);
                    this._transformer_magnetic_losses = value;
                    this.OnTransformer_magnetic_lossesChanged(e);
                    this.OnPropertyChanged("Transformer_magnetic_losses", e);
                }
            }
        }
        
        /// <summary>
        /// The Transformer_iron_losses property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Transformer_iron_losses
        {
            get
            {
                return this._transformer_iron_losses;
            }
            set
            {
                if ((this._transformer_iron_losses != value))
                {
                    Nullable<double> old = this._transformer_iron_losses;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransformer_iron_lossesChanging(e);
                    this.OnPropertyChanging("Transformer_iron_losses", e);
                    this._transformer_iron_losses = value;
                    this.OnTransformer_iron_lossesChanged(e);
                    this.OnPropertyChanged("Transformer_iron_losses", e);
                }
            }
        }
        
        /// <summary>
        /// The Line_resistance_losses property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Line_resistance_losses
        {
            get
            {
                return this._line_resistance_losses;
            }
            set
            {
                if ((this._line_resistance_losses != value))
                {
                    Nullable<double> old = this._line_resistance_losses;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLine_resistance_lossesChanging(e);
                    this.OnPropertyChanging("Line_resistance_losses", e);
                    this._line_resistance_losses = value;
                    this.OnLine_resistance_lossesChanged(e);
                    this.OnPropertyChanged("Line_resistance_losses", e);
                }
            }
        }
        
        /// <summary>
        /// The Line_reactance_losses property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<double> Line_reactance_losses
        {
            get
            {
                return this._line_reactance_losses;
            }
            set
            {
                if ((this._line_reactance_losses != value))
                {
                    Nullable<double> old = this._line_reactance_losses;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLine_reactance_lossesChanging(e);
                    this.OnPropertyChanging("Line_reactance_losses", e);
                    this._line_reactance_losses = value;
                    this.OnLine_reactance_lossesChanged(e);
                    this.OnPropertyChanged("Line_reactance_losses", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Co" +
                            "efficients")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Transformer_magnetic_losses property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Transformer_magnetic_lossesChanging;
        
        /// <summary>
        /// Gets fired when the Transformer_magnetic_losses property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Transformer_magnetic_lossesChanged;
        
        /// <summary>
        /// Gets fired before the Transformer_iron_losses property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Transformer_iron_lossesChanging;
        
        /// <summary>
        /// Gets fired when the Transformer_iron_losses property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Transformer_iron_lossesChanged;
        
        /// <summary>
        /// Gets fired before the Line_resistance_losses property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Line_resistance_lossesChanging;
        
        /// <summary>
        /// Gets fired when the Line_resistance_losses property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Line_resistance_lossesChanged;
        
        /// <summary>
        /// Gets fired before the Line_reactance_losses property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Line_reactance_lossesChanging;
        
        /// <summary>
        /// Gets fired when the Line_reactance_losses property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Line_reactance_lossesChanged;
        
        /// <summary>
        /// Raises the Transformer_magnetic_lossesChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformer_magnetic_lossesChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Transformer_magnetic_lossesChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Transformer_magnetic_lossesChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformer_magnetic_lossesChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Transformer_magnetic_lossesChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Transformer_iron_lossesChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformer_iron_lossesChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Transformer_iron_lossesChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Transformer_iron_lossesChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformer_iron_lossesChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Transformer_iron_lossesChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Line_resistance_lossesChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLine_resistance_lossesChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Line_resistance_lossesChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Line_resistance_lossesChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLine_resistance_lossesChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Line_resistance_lossesChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Line_reactance_lossesChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLine_reactance_lossesChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Line_reactance_lossesChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Line_reactance_lossesChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLine_reactance_lossesChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Line_reactance_lossesChanged;
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
            if ((attribute == "TRANSFORMER_MAGNETIC_LOSSES"))
            {
                return this.Transformer_magnetic_losses;
            }
            if ((attribute == "TRANSFORMER_IRON_LOSSES"))
            {
                return this.Transformer_iron_losses;
            }
            if ((attribute == "LINE_RESISTANCE_LOSSES"))
            {
                return this.Line_resistance_losses;
            }
            if ((attribute == "LINE_REACTANCE_LOSSES"))
            {
                return this.Line_reactance_losses;
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
            if ((feature == "TRANSFORMER_MAGNETIC_LOSSES"))
            {
                this.Transformer_magnetic_losses = ((double)(value));
                return;
            }
            if ((feature == "TRANSFORMER_IRON_LOSSES"))
            {
                this.Transformer_iron_losses = ((double)(value));
                return;
            }
            if ((feature == "LINE_RESISTANCE_LOSSES"))
            {
                this.Line_resistance_losses = ((double)(value));
                return;
            }
            if ((feature == "LINE_REACTANCE_LOSSES"))
            {
                this.Line_reactance_losses = ((double)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Co" +
                        "efficients")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Transformer_magnetic_losses property
        /// </summary>
        private sealed class Transformer_magnetic_lossesProxy : ModelPropertyChange<ICoefficients, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Transformer_magnetic_lossesProxy(ICoefficients modelElement) : 
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
                    return this.ModelElement.Transformer_magnetic_losses;
                }
                set
                {
                    this.ModelElement.Transformer_magnetic_losses = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Transformer_magnetic_lossesChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Transformer_magnetic_lossesChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Transformer_iron_losses property
        /// </summary>
        private sealed class Transformer_iron_lossesProxy : ModelPropertyChange<ICoefficients, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Transformer_iron_lossesProxy(ICoefficients modelElement) : 
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
                    return this.ModelElement.Transformer_iron_losses;
                }
                set
                {
                    this.ModelElement.Transformer_iron_losses = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Transformer_iron_lossesChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Transformer_iron_lossesChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Line_resistance_losses property
        /// </summary>
        private sealed class Line_resistance_lossesProxy : ModelPropertyChange<ICoefficients, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Line_resistance_lossesProxy(ICoefficients modelElement) : 
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
                    return this.ModelElement.Line_resistance_losses;
                }
                set
                {
                    this.ModelElement.Line_resistance_losses = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Line_resistance_lossesChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Line_resistance_lossesChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Line_reactance_losses property
        /// </summary>
        private sealed class Line_reactance_lossesProxy : ModelPropertyChange<ICoefficients, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Line_reactance_lossesProxy(ICoefficients modelElement) : 
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
                    return this.ModelElement.Line_reactance_losses;
                }
                set
                {
                    this.ModelElement.Line_reactance_losses = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Line_reactance_lossesChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Line_reactance_lossesChanged -= handler;
            }
        }
    }
}

