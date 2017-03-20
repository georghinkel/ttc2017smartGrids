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
    /// The default implementation of the SVCInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/SVCInfo" +
        "")]
    [DebuggerDisplayAttribute("SVCInfo {UUID}")]
    public partial class SVCInfo : FACTSDeviceInfo, ISVCInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CapacitiveRating property
        /// </summary>
        private float _capacitiveRating;
        
        private static Lazy<ITypedElement> _capacitiveRatingAttribute = new Lazy<ITypedElement>(RetrieveCapacitiveRatingAttribute);
        
        /// <summary>
        /// The backing field for the InductiveRating property
        /// </summary>
        private float _inductiveRating;
        
        private static Lazy<ITypedElement> _inductiveRatingAttribute = new Lazy<ITypedElement>(RetrieveInductiveRatingAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The capacitiveRating property
        /// </summary>
        [XmlElementNameAttribute("capacitiveRating")]
        [XmlAttributeAttribute(true)]
        public virtual float CapacitiveRating
        {
            get
            {
                return this._capacitiveRating;
            }
            set
            {
                if ((this._capacitiveRating != value))
                {
                    float old = this._capacitiveRating;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCapacitiveRatingChanging(e);
                    this.OnPropertyChanging("CapacitiveRating", e, _capacitiveRatingAttribute);
                    this._capacitiveRating = value;
                    this.OnCapacitiveRatingChanged(e);
                    this.OnPropertyChanged("CapacitiveRating", e, _capacitiveRatingAttribute);
                }
            }
        }
        
        /// <summary>
        /// The inductiveRating property
        /// </summary>
        [XmlElementNameAttribute("inductiveRating")]
        [XmlAttributeAttribute(true)]
        public virtual float InductiveRating
        {
            get
            {
                return this._inductiveRating;
            }
            set
            {
                if ((this._inductiveRating != value))
                {
                    float old = this._inductiveRating;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInductiveRatingChanging(e);
                    this.OnPropertyChanging("InductiveRating", e, _inductiveRatingAttribute);
                    this._inductiveRating = value;
                    this.OnInductiveRatingChanged(e);
                    this.OnPropertyChanged("InductiveRating", e, _inductiveRatingAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/SVCInfo" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CapacitiveRating property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CapacitiveRatingChanging;
        
        /// <summary>
        /// Gets fired when the CapacitiveRating property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CapacitiveRatingChanged;
        
        /// <summary>
        /// Gets fired before the InductiveRating property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InductiveRatingChanging;
        
        /// <summary>
        /// Gets fired when the InductiveRating property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InductiveRatingChanged;
        
        private static ITypedElement RetrieveCapacitiveRatingAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SVCInfo.ClassInstance)).Resolve("capacitiveRating")));
        }
        
        /// <summary>
        /// Raises the CapacitiveRatingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCapacitiveRatingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CapacitiveRatingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CapacitiveRatingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCapacitiveRatingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CapacitiveRatingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveInductiveRatingAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SVCInfo.ClassInstance)).Resolve("inductiveRating")));
        }
        
        /// <summary>
        /// Raises the InductiveRatingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInductiveRatingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InductiveRatingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InductiveRatingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInductiveRatingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InductiveRatingChanged;
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
            if ((attribute == "CAPACITIVERATING"))
            {
                return this.CapacitiveRating;
            }
            if ((attribute == "INDUCTIVERATING"))
            {
                return this.InductiveRating;
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
            if ((feature == "CAPACITIVERATING"))
            {
                this.CapacitiveRating = ((float)(value));
                return;
            }
            if ((feature == "INDUCTIVERATING"))
            {
                this.InductiveRating = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/SVCInfo" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the capacitiveRating property
        /// </summary>
        private sealed class CapacitiveRatingProxy : ModelPropertyChange<ISVCInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CapacitiveRatingProxy(ISVCInfo modelElement) : 
                    base(modelElement, "capacitiveRating")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.CapacitiveRating;
                }
                set
                {
                    this.ModelElement.CapacitiveRating = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the inductiveRating property
        /// </summary>
        private sealed class InductiveRatingProxy : ModelPropertyChange<ISVCInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InductiveRatingProxy(ISVCInfo modelElement) : 
                    base(modelElement, "inductiveRating")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.InductiveRating;
                }
                set
                {
                    this.ModelElement.InductiveRating = value;
                }
            }
        }
    }
}

