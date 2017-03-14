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
    /// The default implementation of the TapSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/TapSchedule")]
    [DebuggerDisplayAttribute("TapSchedule {UUID}")]
    public class TapSchedule : SeasonDayTypeSchedule, ITapSchedule, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LineDropCompensation property
        /// </summary>
        private bool _lineDropCompensation;
        
        /// <summary>
        /// The backing field for the LineDropX property
        /// </summary>
        private float _lineDropX;
        
        /// <summary>
        /// The backing field for the LineDropR property
        /// </summary>
        private float _lineDropR;
        
        /// <summary>
        /// The backing field for the TapChanger property
        /// </summary>
        private ITapChanger _tapChanger;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The lineDropCompensation property
        /// </summary>
        [XmlElementNameAttribute("lineDropCompensation")]
        [XmlAttributeAttribute(true)]
        public virtual bool LineDropCompensation
        {
            get
            {
                return this._lineDropCompensation;
            }
            set
            {
                if ((this._lineDropCompensation != value))
                {
                    bool old = this._lineDropCompensation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineDropCompensationChanging(e);
                    this.OnPropertyChanging("LineDropCompensation", e);
                    this._lineDropCompensation = value;
                    this.OnLineDropCompensationChanged(e);
                    this.OnPropertyChanged("LineDropCompensation", e);
                }
            }
        }
        
        /// <summary>
        /// The lineDropX property
        /// </summary>
        [XmlElementNameAttribute("lineDropX")]
        [XmlAttributeAttribute(true)]
        public virtual float LineDropX
        {
            get
            {
                return this._lineDropX;
            }
            set
            {
                if ((this._lineDropX != value))
                {
                    float old = this._lineDropX;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineDropXChanging(e);
                    this.OnPropertyChanging("LineDropX", e);
                    this._lineDropX = value;
                    this.OnLineDropXChanged(e);
                    this.OnPropertyChanged("LineDropX", e);
                }
            }
        }
        
        /// <summary>
        /// The lineDropR property
        /// </summary>
        [XmlElementNameAttribute("lineDropR")]
        [XmlAttributeAttribute(true)]
        public virtual float LineDropR
        {
            get
            {
                return this._lineDropR;
            }
            set
            {
                if ((this._lineDropR != value))
                {
                    float old = this._lineDropR;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineDropRChanging(e);
                    this.OnPropertyChanging("LineDropR", e);
                    this._lineDropR = value;
                    this.OnLineDropRChanged(e);
                    this.OnPropertyChanged("LineDropR", e);
                }
            }
        }
        
        /// <summary>
        /// The TapChanger property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TapSchedules")]
        public virtual ITapChanger TapChanger
        {
            get
            {
                return this._tapChanger;
            }
            set
            {
                if ((this._tapChanger != value))
                {
                    ITapChanger old = this._tapChanger;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTapChangerChanging(e);
                    this.OnPropertyChanging("TapChanger", e);
                    this._tapChanger = value;
                    if ((old != null))
                    {
                        old.TapSchedules.Remove(this);
                        old.Deleted -= this.OnResetTapChanger;
                    }
                    if ((value != null))
                    {
                        value.TapSchedules.Add(this);
                        value.Deleted += this.OnResetTapChanger;
                    }
                    this.OnTapChangerChanged(e);
                    this.OnPropertyChanged("TapChanger", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TapScheduleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/TapSchedule")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LineDropCompensation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropCompensationChanging;
        
        /// <summary>
        /// Gets fired when the LineDropCompensation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropCompensationChanged;
        
        /// <summary>
        /// Gets fired before the LineDropX property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropXChanging;
        
        /// <summary>
        /// Gets fired when the LineDropX property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropXChanged;
        
        /// <summary>
        /// Gets fired before the LineDropR property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropRChanging;
        
        /// <summary>
        /// Gets fired when the LineDropR property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropRChanged;
        
        /// <summary>
        /// Gets fired before the TapChanger property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TapChangerChanging;
        
        /// <summary>
        /// Gets fired when the TapChanger property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TapChangerChanged;
        
        /// <summary>
        /// Raises the LineDropCompensationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropCompensationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropCompensationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropCompensationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropCompensationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropCompensationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropXChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropXChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropXChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropXChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropXChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropXChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropRChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropRChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropRChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropRChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TapChangerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTapChangerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TapChangerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TapChangerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTapChangerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TapChangerChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TapChanger property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTapChanger(object sender, System.EventArgs eventArgs)
        {
            this.TapChanger = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "LINEDROPCOMPENSATION"))
            {
                return this.LineDropCompensation;
            }
            if ((attribute == "LINEDROPX"))
            {
                return this.LineDropX;
            }
            if ((attribute == "LINEDROPR"))
            {
                return this.LineDropR;
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
            if ((feature == "TAPCHANGER"))
            {
                this.TapChanger = ((ITapChanger)(value));
                return;
            }
            if ((feature == "LINEDROPCOMPENSATION"))
            {
                this.LineDropCompensation = ((bool)(value));
                return;
            }
            if ((feature == "LINEDROPX"))
            {
                this.LineDropX = ((float)(value));
                return;
            }
            if ((feature == "LINEDROPR"))
            {
                this.LineDropR = ((float)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "TapChanger"))
            {
                return new TapChangerProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "TapChanger"))
            {
                return new TapChangerProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/TapSchedule")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TapSchedule class
        /// </summary>
        public class TapScheduleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TapSchedule _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TapScheduleReferencedElementsCollection(TapSchedule parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.TapChanger != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TapChangerChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TapChangerChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TapChanger == null))
                {
                    ITapChanger tapChangerCasted = item.As<ITapChanger>();
                    if ((tapChangerCasted != null))
                    {
                        this._parent.TapChanger = tapChangerCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TapChanger = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TapChanger))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.TapChanger != null))
                {
                    array[arrayIndex] = this._parent.TapChanger;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.TapChanger == item))
                {
                    this._parent.TapChanger = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TapChanger).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lineDropCompensation property
        /// </summary>
        private sealed class LineDropCompensationProxy : ModelPropertyChange<ITapSchedule, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineDropCompensationProxy(ITapSchedule modelElement) : 
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
                    return this.ModelElement.LineDropCompensation;
                }
                set
                {
                    this.ModelElement.LineDropCompensation = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LineDropCompensationChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LineDropCompensationChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lineDropX property
        /// </summary>
        private sealed class LineDropXProxy : ModelPropertyChange<ITapSchedule, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineDropXProxy(ITapSchedule modelElement) : 
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
                    return this.ModelElement.LineDropX;
                }
                set
                {
                    this.ModelElement.LineDropX = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LineDropXChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LineDropXChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lineDropR property
        /// </summary>
        private sealed class LineDropRProxy : ModelPropertyChange<ITapSchedule, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineDropRProxy(ITapSchedule modelElement) : 
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
                    return this.ModelElement.LineDropR;
                }
                set
                {
                    this.ModelElement.LineDropR = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LineDropRChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LineDropRChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TapChanger property
        /// </summary>
        private sealed class TapChangerProxy : ModelPropertyChange<ITapSchedule, ITapChanger>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TapChangerProxy(ITapSchedule modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITapChanger Value
            {
                get
                {
                    return this.ModelElement.TapChanger;
                }
                set
                {
                    this.ModelElement.TapChanger = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TapChangerChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TapChangerChanged -= handler;
            }
        }
    }
}

