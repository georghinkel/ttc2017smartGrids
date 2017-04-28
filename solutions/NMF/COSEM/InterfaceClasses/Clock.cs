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
using TTC2017.SmartGrids.COSEM;
using TTC2017.SmartGrids.COSEM.Datatypes;

namespace TTC2017.SmartGrids.COSEM.InterfaceClasses
{
    
    
    /// <summary>
    /// The default implementation of the Clock class
    /// </summary>
    [XmlNamespaceAttribute("interface")]
    [XmlNamespacePrefixAttribute("inter")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
        "s/Clock")]
    public partial class Clock : Base, IClock, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Time property
        /// </summary>
        private string _time;
        
        private static Lazy<ITypedElement> _timeAttribute = new Lazy<ITypedElement>(RetrieveTimeAttribute);
        
        /// <summary>
        /// The backing field for the Time_zone property
        /// </summary>
        private ObservableOrderedSet<long> _time_zone;
        
        private static Lazy<ITypedElement> _time_zoneAttribute = new Lazy<ITypedElement>(RetrieveTime_zoneAttribute);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private string _status;
        
        private static Lazy<ITypedElement> _statusAttribute = new Lazy<ITypedElement>(RetrieveStatusAttribute);
        
        /// <summary>
        /// The backing field for the Daylight_savings_begin property
        /// </summary>
        private string _daylight_savings_begin;
        
        private static Lazy<ITypedElement> _daylight_savings_beginAttribute = new Lazy<ITypedElement>(RetrieveDaylight_savings_beginAttribute);
        
        /// <summary>
        /// The backing field for the Daylight_savings_end property
        /// </summary>
        private string _daylight_savings_end;
        
        private static Lazy<ITypedElement> _daylight_savings_endAttribute = new Lazy<ITypedElement>(RetrieveDaylight_savings_endAttribute);
        
        /// <summary>
        /// The backing field for the Daylight_savings_deviation property
        /// </summary>
        private ObservableOrderedSet<int> _daylight_savings_deviation;
        
        private static Lazy<ITypedElement> _daylight_savings_deviationAttribute = new Lazy<ITypedElement>(RetrieveDaylight_savings_deviationAttribute);
        
        /// <summary>
        /// The backing field for the Daylight_savings_enabled property
        /// </summary>
        private Nullable<bool> _daylight_savings_enabled;
        
        private static Lazy<ITypedElement> _daylight_savings_enabledAttribute = new Lazy<ITypedElement>(RetrieveDaylight_savings_enabledAttribute);
        
        private static IClass _classInstance;
        
        public Clock()
        {
            this._time_zone = new ObservableOrderedSet<long>();
            this._time_zone.CollectionChanging += this.Time_zoneCollectionChanging;
            this._time_zone.CollectionChanged += this.Time_zoneCollectionChanged;
            this._daylight_savings_deviation = new ObservableOrderedSet<int>();
            this._daylight_savings_deviation.CollectionChanging += this.Daylight_savings_deviationCollectionChanging;
            this._daylight_savings_deviation.CollectionChanged += this.Daylight_savings_deviationCollectionChanged;
        }
        
        /// <summary>
        /// The time property
        /// </summary>
        [XmlElementNameAttribute("time")]
        [XmlAttributeAttribute(true)]
        public virtual string Time
        {
            get
            {
                return this._time;
            }
            set
            {
                if ((this._time != value))
                {
                    string old = this._time;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTimeChanging(e);
                    this.OnPropertyChanging("Time", e, _timeAttribute);
                    this._time = value;
                    this.OnTimeChanged(e);
                    this.OnPropertyChanged("Time", e, _timeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The time_zone property
        /// </summary>
        [UpperBoundAttribute(720)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("time_zone")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<long> Time_zone
        {
            get
            {
                return this._time_zone;
            }
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        [XmlElementNameAttribute("status")]
        [XmlAttributeAttribute(true)]
        public virtual string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                if ((this._status != value))
                {
                    string old = this._status;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStatusChanging(e);
                    this.OnPropertyChanging("Status", e, _statusAttribute);
                    this._status = value;
                    this.OnStatusChanged(e);
                    this.OnPropertyChanged("Status", e, _statusAttribute);
                }
            }
        }
        
        /// <summary>
        /// The daylight_savings_begin property
        /// </summary>
        [XmlElementNameAttribute("daylight_savings_begin")]
        [XmlAttributeAttribute(true)]
        public virtual string Daylight_savings_begin
        {
            get
            {
                return this._daylight_savings_begin;
            }
            set
            {
                if ((this._daylight_savings_begin != value))
                {
                    string old = this._daylight_savings_begin;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDaylight_savings_beginChanging(e);
                    this.OnPropertyChanging("Daylight_savings_begin", e, _daylight_savings_beginAttribute);
                    this._daylight_savings_begin = value;
                    this.OnDaylight_savings_beginChanged(e);
                    this.OnPropertyChanged("Daylight_savings_begin", e, _daylight_savings_beginAttribute);
                }
            }
        }
        
        /// <summary>
        /// The daylight_savings_end property
        /// </summary>
        [XmlElementNameAttribute("daylight_savings_end")]
        [XmlAttributeAttribute(true)]
        public virtual string Daylight_savings_end
        {
            get
            {
                return this._daylight_savings_end;
            }
            set
            {
                if ((this._daylight_savings_end != value))
                {
                    string old = this._daylight_savings_end;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDaylight_savings_endChanging(e);
                    this.OnPropertyChanging("Daylight_savings_end", e, _daylight_savings_endAttribute);
                    this._daylight_savings_end = value;
                    this.OnDaylight_savings_endChanged(e);
                    this.OnPropertyChanged("Daylight_savings_end", e, _daylight_savings_endAttribute);
                }
            }
        }
        
        /// <summary>
        /// The daylight_savings_deviation property
        /// </summary>
        [UpperBoundAttribute(120)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("daylight_savings_deviation")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<int> Daylight_savings_deviation
        {
            get
            {
                return this._daylight_savings_deviation;
            }
        }
        
        /// <summary>
        /// The daylight_savings_enabled property
        /// </summary>
        [XmlElementNameAttribute("daylight_savings_enabled")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> Daylight_savings_enabled
        {
            get
            {
                return this._daylight_savings_enabled;
            }
            set
            {
                if ((this._daylight_savings_enabled != value))
                {
                    Nullable<bool> old = this._daylight_savings_enabled;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDaylight_savings_enabledChanging(e);
                    this.OnPropertyChanging("Daylight_savings_enabled", e, _daylight_savings_enabledAttribute);
                    this._daylight_savings_enabled = value;
                    this.OnDaylight_savings_enabledChanged(e);
                    this.OnPropertyChanged("Daylight_savings_enabled", e, _daylight_savings_enabledAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                            "s/Clock")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Time property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimeChanging;
        
        /// <summary>
        /// Gets fired when the Time property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimeChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the Daylight_savings_begin property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Daylight_savings_beginChanging;
        
        /// <summary>
        /// Gets fired when the Daylight_savings_begin property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Daylight_savings_beginChanged;
        
        /// <summary>
        /// Gets fired before the Daylight_savings_end property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Daylight_savings_endChanging;
        
        /// <summary>
        /// Gets fired when the Daylight_savings_end property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Daylight_savings_endChanged;
        
        /// <summary>
        /// Gets fired before the Daylight_savings_enabled property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Daylight_savings_enabledChanging;
        
        /// <summary>
        /// Gets fired when the Daylight_savings_enabled property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Daylight_savings_enabledChanged;
        
        private static ITypedElement RetrieveTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("time")));
        }
        
        /// <summary>
        /// Raises the TimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTime_zoneAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("time_zone")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Time_zone property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Time_zoneCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Time_zone", e, _time_zoneAttribute);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Time_zone property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Time_zoneCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Time_zone", e, _time_zoneAttribute);
        }
        
        private static ITypedElement RetrieveStatusAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("status")));
        }
        
        /// <summary>
        /// Raises the StatusChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StatusChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDaylight_savings_beginAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("daylight_savings_begin")));
        }
        
        /// <summary>
        /// Raises the Daylight_savings_beginChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDaylight_savings_beginChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Daylight_savings_beginChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Daylight_savings_beginChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDaylight_savings_beginChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Daylight_savings_beginChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDaylight_savings_endAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("daylight_savings_end")));
        }
        
        /// <summary>
        /// Raises the Daylight_savings_endChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDaylight_savings_endChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Daylight_savings_endChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Daylight_savings_endChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDaylight_savings_endChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Daylight_savings_endChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDaylight_savings_deviationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("daylight_savings_deviation")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Daylight_savings_deviation property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Daylight_savings_deviationCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Daylight_savings_deviation", e, _daylight_savings_deviationAttribute);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Daylight_savings_deviation property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Daylight_savings_deviationCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Daylight_savings_deviation", e, _daylight_savings_deviationAttribute);
        }
        
        private static ITypedElement RetrieveDaylight_savings_enabledAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Clock.ClassInstance)).Resolve("daylight_savings_enabled")));
        }
        
        /// <summary>
        /// Raises the Daylight_savings_enabledChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDaylight_savings_enabledChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Daylight_savings_enabledChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Daylight_savings_enabledChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDaylight_savings_enabledChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Daylight_savings_enabledChanged;
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
            if ((attribute == "TIME"))
            {
                return this.Time;
            }
            if ((attribute == "TIME_ZONE"))
            {
                if ((index < this.Time_zone.Count))
                {
                    return this.Time_zone[index];
                }
                else
                {
                    return null;
                }
            }
            if ((attribute == "STATUS"))
            {
                return this.Status;
            }
            if ((attribute == "DAYLIGHT_SAVINGS_BEGIN"))
            {
                return this.Daylight_savings_begin;
            }
            if ((attribute == "DAYLIGHT_SAVINGS_END"))
            {
                return this.Daylight_savings_end;
            }
            if ((attribute == "DAYLIGHT_SAVINGS_DEVIATION"))
            {
                if ((index < this.Daylight_savings_deviation.Count))
                {
                    return this.Daylight_savings_deviation[index];
                }
                else
                {
                    return null;
                }
            }
            if ((attribute == "DAYLIGHT_SAVINGS_ENABLED"))
            {
                return this.Daylight_savings_enabled;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "TIME_ZONE"))
            {
                return this._time_zone;
            }
            if ((feature == "DAYLIGHT_SAVINGS_DEVIATION"))
            {
                return this._daylight_savings_deviation;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TIME"))
            {
                this.Time = ((string)(value));
                return;
            }
            if ((feature == "STATUS"))
            {
                this.Status = ((string)(value));
                return;
            }
            if ((feature == "DAYLIGHT_SAVINGS_BEGIN"))
            {
                this.Daylight_savings_begin = ((string)(value));
                return;
            }
            if ((feature == "DAYLIGHT_SAVINGS_END"))
            {
                this.Daylight_savings_end = ((string)(value));
                return;
            }
            if ((feature == "DAYLIGHT_SAVINGS_ENABLED"))
            {
                this.Daylight_savings_enabled = ((bool)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                        "s/Clock")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the time property
        /// </summary>
        private sealed class TimeProxy : ModelPropertyChange<IClock, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TimeProxy(IClock modelElement) : 
                    base(modelElement, "time")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Time;
                }
                set
                {
                    this.ModelElement.Time = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<IClock, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(IClock modelElement) : 
                    base(modelElement, "status")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Status;
                }
                set
                {
                    this.ModelElement.Status = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the daylight_savings_begin property
        /// </summary>
        private sealed class Daylight_savings_beginProxy : ModelPropertyChange<IClock, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Daylight_savings_beginProxy(IClock modelElement) : 
                    base(modelElement, "daylight_savings_begin")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Daylight_savings_begin;
                }
                set
                {
                    this.ModelElement.Daylight_savings_begin = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the daylight_savings_end property
        /// </summary>
        private sealed class Daylight_savings_endProxy : ModelPropertyChange<IClock, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Daylight_savings_endProxy(IClock modelElement) : 
                    base(modelElement, "daylight_savings_end")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Daylight_savings_end;
                }
                set
                {
                    this.ModelElement.Daylight_savings_end = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the daylight_savings_enabled property
        /// </summary>
        private sealed class Daylight_savings_enabledProxy : ModelPropertyChange<IClock, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Daylight_savings_enabledProxy(IClock modelElement) : 
                    base(modelElement, "daylight_savings_enabled")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.Daylight_savings_enabled;
                }
                set
                {
                    this.ModelElement.Daylight_savings_enabled = value;
                }
            }
        }
    }
}
