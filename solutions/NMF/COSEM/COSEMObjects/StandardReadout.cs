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
    /// The default implementation of the StandardReadout class
    /// </summary>
    [XmlNamespaceAttribute("objects")]
    [XmlNamespacePrefixAttribute("objects")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/St" +
        "andardReadout")]
    public partial class StandardReadout : Profilegeneric, IStandardReadout, IModelElement
    {
        
        /// <summary>
        /// The backing field for the GeneralLocalPortReadout property
        /// </summary>
        private string _generalLocalPortReadout;
        
        private static Lazy<ITypedElement> _generalLocalPortReadoutAttribute = new Lazy<ITypedElement>(RetrieveGeneralLocalPortReadoutAttribute);
        
        /// <summary>
        /// The backing field for the GeneralDisplayReadout property
        /// </summary>
        private string _generalDisplayReadout;
        
        private static Lazy<ITypedElement> _generalDisplayReadoutAttribute = new Lazy<ITypedElement>(RetrieveGeneralDisplayReadoutAttribute);
        
        /// <summary>
        /// The backing field for the AlternateDisplayReadout property
        /// </summary>
        private string _alternateDisplayReadout;
        
        private static Lazy<ITypedElement> _alternateDisplayReadoutAttribute = new Lazy<ITypedElement>(RetrieveAlternateDisplayReadoutAttribute);
        
        /// <summary>
        /// The backing field for the ServiceDisplayReadout property
        /// </summary>
        private string _serviceDisplayReadout;
        
        private static Lazy<ITypedElement> _serviceDisplayReadoutAttribute = new Lazy<ITypedElement>(RetrieveServiceDisplayReadoutAttribute);
        
        /// <summary>
        /// The backing field for the ListConfigMeterData property
        /// </summary>
        private string _listConfigMeterData;
        
        private static Lazy<ITypedElement> _listConfigMeterDataAttribute = new Lazy<ITypedElement>(RetrieveListConfigMeterDataAttribute);
        
        /// <summary>
        /// The backing field for the AdditionalReadout property
        /// </summary>
        private string _additionalReadout;
        
        private static Lazy<ITypedElement> _additionalReadoutAttribute = new Lazy<ITypedElement>(RetrieveAdditionalReadoutAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The GeneralLocalPortReadout property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string GeneralLocalPortReadout
        {
            get
            {
                return this._generalLocalPortReadout;
            }
            set
            {
                if ((this._generalLocalPortReadout != value))
                {
                    string old = this._generalLocalPortReadout;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGeneralLocalPortReadoutChanging(e);
                    this.OnPropertyChanging("GeneralLocalPortReadout", e, _generalLocalPortReadoutAttribute);
                    this._generalLocalPortReadout = value;
                    this.OnGeneralLocalPortReadoutChanged(e);
                    this.OnPropertyChanged("GeneralLocalPortReadout", e, _generalLocalPortReadoutAttribute);
                }
            }
        }
        
        /// <summary>
        /// The GeneralDisplayReadout property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string GeneralDisplayReadout
        {
            get
            {
                return this._generalDisplayReadout;
            }
            set
            {
                if ((this._generalDisplayReadout != value))
                {
                    string old = this._generalDisplayReadout;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGeneralDisplayReadoutChanging(e);
                    this.OnPropertyChanging("GeneralDisplayReadout", e, _generalDisplayReadoutAttribute);
                    this._generalDisplayReadout = value;
                    this.OnGeneralDisplayReadoutChanged(e);
                    this.OnPropertyChanged("GeneralDisplayReadout", e, _generalDisplayReadoutAttribute);
                }
            }
        }
        
        /// <summary>
        /// The AlternateDisplayReadout property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string AlternateDisplayReadout
        {
            get
            {
                return this._alternateDisplayReadout;
            }
            set
            {
                if ((this._alternateDisplayReadout != value))
                {
                    string old = this._alternateDisplayReadout;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAlternateDisplayReadoutChanging(e);
                    this.OnPropertyChanging("AlternateDisplayReadout", e, _alternateDisplayReadoutAttribute);
                    this._alternateDisplayReadout = value;
                    this.OnAlternateDisplayReadoutChanged(e);
                    this.OnPropertyChanged("AlternateDisplayReadout", e, _alternateDisplayReadoutAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ServiceDisplayReadout property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string ServiceDisplayReadout
        {
            get
            {
                return this._serviceDisplayReadout;
            }
            set
            {
                if ((this._serviceDisplayReadout != value))
                {
                    string old = this._serviceDisplayReadout;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnServiceDisplayReadoutChanging(e);
                    this.OnPropertyChanging("ServiceDisplayReadout", e, _serviceDisplayReadoutAttribute);
                    this._serviceDisplayReadout = value;
                    this.OnServiceDisplayReadoutChanged(e);
                    this.OnPropertyChanged("ServiceDisplayReadout", e, _serviceDisplayReadoutAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ListConfigMeterData property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string ListConfigMeterData
        {
            get
            {
                return this._listConfigMeterData;
            }
            set
            {
                if ((this._listConfigMeterData != value))
                {
                    string old = this._listConfigMeterData;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnListConfigMeterDataChanging(e);
                    this.OnPropertyChanging("ListConfigMeterData", e, _listConfigMeterDataAttribute);
                    this._listConfigMeterData = value;
                    this.OnListConfigMeterDataChanged(e);
                    this.OnPropertyChanged("ListConfigMeterData", e, _listConfigMeterDataAttribute);
                }
            }
        }
        
        /// <summary>
        /// The AdditionalReadout property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string AdditionalReadout
        {
            get
            {
                return this._additionalReadout;
            }
            set
            {
                if ((this._additionalReadout != value))
                {
                    string old = this._additionalReadout;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAdditionalReadoutChanging(e);
                    this.OnPropertyChanging("AdditionalReadout", e, _additionalReadoutAttribute);
                    this._additionalReadout = value;
                    this.OnAdditionalReadoutChanged(e);
                    this.OnPropertyChanged("AdditionalReadout", e, _additionalReadoutAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/St" +
                            "andardReadout")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the GeneralLocalPortReadout property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneralLocalPortReadoutChanging;
        
        /// <summary>
        /// Gets fired when the GeneralLocalPortReadout property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneralLocalPortReadoutChanged;
        
        /// <summary>
        /// Gets fired before the GeneralDisplayReadout property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneralDisplayReadoutChanging;
        
        /// <summary>
        /// Gets fired when the GeneralDisplayReadout property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneralDisplayReadoutChanged;
        
        /// <summary>
        /// Gets fired before the AlternateDisplayReadout property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AlternateDisplayReadoutChanging;
        
        /// <summary>
        /// Gets fired when the AlternateDisplayReadout property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AlternateDisplayReadoutChanged;
        
        /// <summary>
        /// Gets fired before the ServiceDisplayReadout property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ServiceDisplayReadoutChanging;
        
        /// <summary>
        /// Gets fired when the ServiceDisplayReadout property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ServiceDisplayReadoutChanged;
        
        /// <summary>
        /// Gets fired before the ListConfigMeterData property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ListConfigMeterDataChanging;
        
        /// <summary>
        /// Gets fired when the ListConfigMeterData property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ListConfigMeterDataChanged;
        
        /// <summary>
        /// Gets fired before the AdditionalReadout property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AdditionalReadoutChanging;
        
        /// <summary>
        /// Gets fired when the AdditionalReadout property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AdditionalReadoutChanged;
        
        private static ITypedElement RetrieveGeneralLocalPortReadoutAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardReadout.ClassInstance)).Resolve("GeneralLocalPortReadout")));
        }
        
        /// <summary>
        /// Raises the GeneralLocalPortReadoutChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneralLocalPortReadoutChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneralLocalPortReadoutChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GeneralLocalPortReadoutChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneralLocalPortReadoutChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneralLocalPortReadoutChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveGeneralDisplayReadoutAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardReadout.ClassInstance)).Resolve("GeneralDisplayReadout")));
        }
        
        /// <summary>
        /// Raises the GeneralDisplayReadoutChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneralDisplayReadoutChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneralDisplayReadoutChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GeneralDisplayReadoutChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneralDisplayReadoutChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneralDisplayReadoutChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveAlternateDisplayReadoutAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardReadout.ClassInstance)).Resolve("AlternateDisplayReadout")));
        }
        
        /// <summary>
        /// Raises the AlternateDisplayReadoutChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAlternateDisplayReadoutChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AlternateDisplayReadoutChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AlternateDisplayReadoutChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAlternateDisplayReadoutChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AlternateDisplayReadoutChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveServiceDisplayReadoutAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardReadout.ClassInstance)).Resolve("ServiceDisplayReadout")));
        }
        
        /// <summary>
        /// Raises the ServiceDisplayReadoutChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnServiceDisplayReadoutChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ServiceDisplayReadoutChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ServiceDisplayReadoutChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnServiceDisplayReadoutChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ServiceDisplayReadoutChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveListConfigMeterDataAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardReadout.ClassInstance)).Resolve("ListConfigMeterData")));
        }
        
        /// <summary>
        /// Raises the ListConfigMeterDataChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnListConfigMeterDataChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ListConfigMeterDataChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ListConfigMeterDataChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnListConfigMeterDataChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ListConfigMeterDataChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveAdditionalReadoutAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardReadout.ClassInstance)).Resolve("AdditionalReadout")));
        }
        
        /// <summary>
        /// Raises the AdditionalReadoutChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAdditionalReadoutChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AdditionalReadoutChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AdditionalReadoutChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAdditionalReadoutChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AdditionalReadoutChanged;
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
            if ((attribute == "GENERALLOCALPORTREADOUT"))
            {
                return this.GeneralLocalPortReadout;
            }
            if ((attribute == "GENERALDISPLAYREADOUT"))
            {
                return this.GeneralDisplayReadout;
            }
            if ((attribute == "ALTERNATEDISPLAYREADOUT"))
            {
                return this.AlternateDisplayReadout;
            }
            if ((attribute == "SERVICEDISPLAYREADOUT"))
            {
                return this.ServiceDisplayReadout;
            }
            if ((attribute == "LISTCONFIGMETERDATA"))
            {
                return this.ListConfigMeterData;
            }
            if ((attribute == "ADDITIONALREADOUT"))
            {
                return this.AdditionalReadout;
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
            if ((feature == "GENERALLOCALPORTREADOUT"))
            {
                this.GeneralLocalPortReadout = ((string)(value));
                return;
            }
            if ((feature == "GENERALDISPLAYREADOUT"))
            {
                this.GeneralDisplayReadout = ((string)(value));
                return;
            }
            if ((feature == "ALTERNATEDISPLAYREADOUT"))
            {
                this.AlternateDisplayReadout = ((string)(value));
                return;
            }
            if ((feature == "SERVICEDISPLAYREADOUT"))
            {
                this.ServiceDisplayReadout = ((string)(value));
                return;
            }
            if ((feature == "LISTCONFIGMETERDATA"))
            {
                this.ListConfigMeterData = ((string)(value));
                return;
            }
            if ((feature == "ADDITIONALREADOUT"))
            {
                this.AdditionalReadout = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/St" +
                        "andardReadout")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GeneralLocalPortReadout property
        /// </summary>
        private sealed class GeneralLocalPortReadoutProxy : ModelPropertyChange<IStandardReadout, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GeneralLocalPortReadoutProxy(IStandardReadout modelElement) : 
                    base(modelElement, "GeneralLocalPortReadout")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.GeneralLocalPortReadout;
                }
                set
                {
                    this.ModelElement.GeneralLocalPortReadout = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GeneralDisplayReadout property
        /// </summary>
        private sealed class GeneralDisplayReadoutProxy : ModelPropertyChange<IStandardReadout, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GeneralDisplayReadoutProxy(IStandardReadout modelElement) : 
                    base(modelElement, "GeneralDisplayReadout")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.GeneralDisplayReadout;
                }
                set
                {
                    this.ModelElement.GeneralDisplayReadout = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AlternateDisplayReadout property
        /// </summary>
        private sealed class AlternateDisplayReadoutProxy : ModelPropertyChange<IStandardReadout, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AlternateDisplayReadoutProxy(IStandardReadout modelElement) : 
                    base(modelElement, "AlternateDisplayReadout")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.AlternateDisplayReadout;
                }
                set
                {
                    this.ModelElement.AlternateDisplayReadout = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ServiceDisplayReadout property
        /// </summary>
        private sealed class ServiceDisplayReadoutProxy : ModelPropertyChange<IStandardReadout, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ServiceDisplayReadoutProxy(IStandardReadout modelElement) : 
                    base(modelElement, "ServiceDisplayReadout")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ServiceDisplayReadout;
                }
                set
                {
                    this.ModelElement.ServiceDisplayReadout = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ListConfigMeterData property
        /// </summary>
        private sealed class ListConfigMeterDataProxy : ModelPropertyChange<IStandardReadout, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ListConfigMeterDataProxy(IStandardReadout modelElement) : 
                    base(modelElement, "ListConfigMeterData")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ListConfigMeterData;
                }
                set
                {
                    this.ModelElement.ListConfigMeterData = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AdditionalReadout property
        /// </summary>
        private sealed class AdditionalReadoutProxy : ModelPropertyChange<IStandardReadout, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AdditionalReadoutProxy(IStandardReadout modelElement) : 
                    base(modelElement, "AdditionalReadout")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.AdditionalReadout;
                }
                set
                {
                    this.ModelElement.AdditionalReadout = value;
                }
            }
        }
    }
}
