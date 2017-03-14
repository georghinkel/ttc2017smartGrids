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
    /// The default implementation of the TimeQuality class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/TimeQuality")]
    public class TimeQuality : ModelElement, ITimeQuality, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LeapSecondsKnown property
        /// </summary>
        private Nullable<bool> _leapSecondsKnown;
        
        /// <summary>
        /// The backing field for the ClockFailure property
        /// </summary>
        private Nullable<bool> _clockFailure;
        
        /// <summary>
        /// The backing field for the ClockNotSynchronized property
        /// </summary>
        private Nullable<bool> _clockNotSynchronized;
        
        /// <summary>
        /// The backing field for the TimeAccuracy property
        /// </summary>
        private Nullable<TimeAccuracyKind> _timeAccuracy;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The leapSecondsKnown property
        /// </summary>
        [XmlElementNameAttribute("leapSecondsKnown")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> LeapSecondsKnown
        {
            get
            {
                return this._leapSecondsKnown;
            }
            set
            {
                if ((this._leapSecondsKnown != value))
                {
                    Nullable<bool> old = this._leapSecondsKnown;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLeapSecondsKnownChanging(e);
                    this.OnPropertyChanging("LeapSecondsKnown", e);
                    this._leapSecondsKnown = value;
                    this.OnLeapSecondsKnownChanged(e);
                    this.OnPropertyChanged("LeapSecondsKnown", e);
                }
            }
        }
        
        /// <summary>
        /// The clockFailure property
        /// </summary>
        [XmlElementNameAttribute("clockFailure")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> ClockFailure
        {
            get
            {
                return this._clockFailure;
            }
            set
            {
                if ((this._clockFailure != value))
                {
                    Nullable<bool> old = this._clockFailure;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnClockFailureChanging(e);
                    this.OnPropertyChanging("ClockFailure", e);
                    this._clockFailure = value;
                    this.OnClockFailureChanged(e);
                    this.OnPropertyChanged("ClockFailure", e);
                }
            }
        }
        
        /// <summary>
        /// The clockNotSynchronized property
        /// </summary>
        [XmlElementNameAttribute("clockNotSynchronized")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> ClockNotSynchronized
        {
            get
            {
                return this._clockNotSynchronized;
            }
            set
            {
                if ((this._clockNotSynchronized != value))
                {
                    Nullable<bool> old = this._clockNotSynchronized;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnClockNotSynchronizedChanging(e);
                    this.OnPropertyChanging("ClockNotSynchronized", e);
                    this._clockNotSynchronized = value;
                    this.OnClockNotSynchronizedChanged(e);
                    this.OnPropertyChanged("ClockNotSynchronized", e);
                }
            }
        }
        
        /// <summary>
        /// The timeAccuracy property
        /// </summary>
        [XmlElementNameAttribute("timeAccuracy")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<TimeAccuracyKind> TimeAccuracy
        {
            get
            {
                return this._timeAccuracy;
            }
            set
            {
                if ((this._timeAccuracy != value))
                {
                    Nullable<TimeAccuracyKind> old = this._timeAccuracy;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTimeAccuracyChanging(e);
                    this.OnPropertyChanging("TimeAccuracy", e);
                    this._timeAccuracy = value;
                    this.OnTimeAccuracyChanged(e);
                    this.OnPropertyChanged("TimeAccuracy", e);
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
                            "taclasses/TimeQuality")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LeapSecondsKnown property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeapSecondsKnownChanging;
        
        /// <summary>
        /// Gets fired when the LeapSecondsKnown property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeapSecondsKnownChanged;
        
        /// <summary>
        /// Gets fired before the ClockFailure property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ClockFailureChanging;
        
        /// <summary>
        /// Gets fired when the ClockFailure property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ClockFailureChanged;
        
        /// <summary>
        /// Gets fired before the ClockNotSynchronized property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ClockNotSynchronizedChanging;
        
        /// <summary>
        /// Gets fired when the ClockNotSynchronized property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ClockNotSynchronizedChanged;
        
        /// <summary>
        /// Gets fired before the TimeAccuracy property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimeAccuracyChanging;
        
        /// <summary>
        /// Gets fired when the TimeAccuracy property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimeAccuracyChanged;
        
        /// <summary>
        /// Raises the LeapSecondsKnownChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeapSecondsKnownChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeapSecondsKnownChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeapSecondsKnownChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeapSecondsKnownChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeapSecondsKnownChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ClockFailureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnClockFailureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ClockFailureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ClockFailureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnClockFailureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ClockFailureChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ClockNotSynchronizedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnClockNotSynchronizedChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ClockNotSynchronizedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ClockNotSynchronizedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnClockNotSynchronizedChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ClockNotSynchronizedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TimeAccuracyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeAccuracyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimeAccuracyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TimeAccuracyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeAccuracyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimeAccuracyChanged;
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
            if ((attribute == "LEAPSECONDSKNOWN"))
            {
                return this.LeapSecondsKnown;
            }
            if ((attribute == "CLOCKFAILURE"))
            {
                return this.ClockFailure;
            }
            if ((attribute == "CLOCKNOTSYNCHRONIZED"))
            {
                return this.ClockNotSynchronized;
            }
            if ((attribute == "TIMEACCURACY"))
            {
                return this.TimeAccuracy;
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
            if ((feature == "LEAPSECONDSKNOWN"))
            {
                this.LeapSecondsKnown = ((bool)(value));
                return;
            }
            if ((feature == "CLOCKFAILURE"))
            {
                this.ClockFailure = ((bool)(value));
                return;
            }
            if ((feature == "CLOCKNOTSYNCHRONIZED"))
            {
                this.ClockNotSynchronized = ((bool)(value));
                return;
            }
            if ((feature == "TIMEACCURACY"))
            {
                this.TimeAccuracy = ((TimeAccuracyKind)(value));
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
                        "taclasses/TimeQuality")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the leapSecondsKnown property
        /// </summary>
        private sealed class LeapSecondsKnownProxy : ModelPropertyChange<ITimeQuality, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LeapSecondsKnownProxy(ITimeQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.LeapSecondsKnown;
                }
                set
                {
                    this.ModelElement.LeapSecondsKnown = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeapSecondsKnownChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeapSecondsKnownChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the clockFailure property
        /// </summary>
        private sealed class ClockFailureProxy : ModelPropertyChange<ITimeQuality, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ClockFailureProxy(ITimeQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.ClockFailure;
                }
                set
                {
                    this.ModelElement.ClockFailure = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ClockFailureChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ClockFailureChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the clockNotSynchronized property
        /// </summary>
        private sealed class ClockNotSynchronizedProxy : ModelPropertyChange<ITimeQuality, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ClockNotSynchronizedProxy(ITimeQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.ClockNotSynchronized;
                }
                set
                {
                    this.ModelElement.ClockNotSynchronized = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ClockNotSynchronizedChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ClockNotSynchronizedChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the timeAccuracy property
        /// </summary>
        private sealed class TimeAccuracyProxy : ModelPropertyChange<ITimeQuality, Nullable<TimeAccuracyKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TimeAccuracyProxy(ITimeQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<TimeAccuracyKind> Value
            {
                get
                {
                    return this.ModelElement.TimeAccuracy;
                }
                set
                {
                    this.ModelElement.TimeAccuracy = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TimeAccuracyChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TimeAccuracyChanged -= handler;
            }
        }
    }
}
