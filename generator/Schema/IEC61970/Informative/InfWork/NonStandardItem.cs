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
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The default implementation of the NonStandardItem class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/NonStanda" +
        "rdItem")]
    [DebuggerDisplayAttribute("NonStandardItem {UUID}")]
    public class NonStandardItem : Document, INonStandardItem, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Code property
        /// </summary>
        private string _code;
        
        /// <summary>
        /// The backing field for the Amount property
        /// </summary>
        private float _amount;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The code property
        /// </summary>
        [XmlElementNameAttribute("code")]
        [XmlAttributeAttribute(true)]
        public virtual string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                if ((this._code != value))
                {
                    string old = this._code;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCodeChanging(e);
                    this.OnPropertyChanging("Code", e);
                    this._code = value;
                    this.OnCodeChanged(e);
                    this.OnPropertyChanged("Code", e);
                }
            }
        }
        
        /// <summary>
        /// The amount property
        /// </summary>
        [XmlElementNameAttribute("amount")]
        [XmlAttributeAttribute(true)]
        public virtual float Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if ((this._amount != value))
                {
                    float old = this._amount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAmountChanging(e);
                    this.OnPropertyChanging("Amount", e);
                    this._amount = value;
                    this.OnAmountChanged(e);
                    this.OnPropertyChanged("Amount", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/NonStanda" +
                            "rdItem")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        /// <summary>
        /// Gets fired before the Amount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AmountChanging;
        
        /// <summary>
        /// Gets fired when the Amount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AmountChanged;
        
        /// <summary>
        /// Raises the CodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AmountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AmountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AmountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AmountChanged;
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
            if ((attribute == "CODE"))
            {
                return this.Code;
            }
            if ((attribute == "AMOUNT"))
            {
                return this.Amount;
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
            if ((feature == "CODE"))
            {
                this.Code = ((string)(value));
                return;
            }
            if ((feature == "AMOUNT"))
            {
                this.Amount = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/NonStanda" +
                        "rdItem")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the code property
        /// </summary>
        private sealed class CodeProxy : ModelPropertyChange<INonStandardItem, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CodeProxy(INonStandardItem modelElement) : 
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
                    return this.ModelElement.Code;
                }
                set
                {
                    this.ModelElement.Code = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CodeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CodeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the amount property
        /// </summary>
        private sealed class AmountProxy : ModelPropertyChange<INonStandardItem, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AmountProxy(INonStandardItem modelElement) : 
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
                    return this.ModelElement.Amount;
                }
                set
                {
                    this.ModelElement.Amount = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AmountChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AmountChanged -= handler;
            }
        }
    }
}
