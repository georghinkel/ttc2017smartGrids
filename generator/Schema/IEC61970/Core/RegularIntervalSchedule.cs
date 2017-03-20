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
using TTC2017.SmartGrids.CIM;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The default implementation of the RegularIntervalSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Core")]
    [XmlNamespacePrefixAttribute("cimCore")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/RegularIntervalSchedule")]
    [DebuggerDisplayAttribute("RegularIntervalSchedule {UUID}")]
    public partial class RegularIntervalSchedule : BasicIntervalSchedule, IRegularIntervalSchedule, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EndTime property
        /// </summary>
        private string _endTime;
        
        private static Lazy<ITypedElement> _endTimeAttribute = new Lazy<ITypedElement>(RetrieveEndTimeAttribute);
        
        /// <summary>
        /// The backing field for the TimeStep property
        /// </summary>
        private float _timeStep;
        
        private static Lazy<ITypedElement> _timeStepAttribute = new Lazy<ITypedElement>(RetrieveTimeStepAttribute);
        
        private static Lazy<ITypedElement> _timePointsReference = new Lazy<ITypedElement>(RetrieveTimePointsReference);
        
        /// <summary>
        /// The backing field for the TimePoints property
        /// </summary>
        private RegularIntervalScheduleTimePointsCollection _timePoints;
        
        private static IClass _classInstance;
        
        public RegularIntervalSchedule()
        {
            this._timePoints = new RegularIntervalScheduleTimePointsCollection(this);
            this._timePoints.CollectionChanging += this.TimePointsCollectionChanging;
            this._timePoints.CollectionChanged += this.TimePointsCollectionChanged;
        }
        
        /// <summary>
        /// The endTime property
        /// </summary>
        [XmlElementNameAttribute("endTime")]
        [XmlAttributeAttribute(true)]
        public virtual string EndTime
        {
            get
            {
                return this._endTime;
            }
            set
            {
                if ((this._endTime != value))
                {
                    string old = this._endTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEndTimeChanging(e);
                    this.OnPropertyChanging("EndTime", e, _endTimeAttribute);
                    this._endTime = value;
                    this.OnEndTimeChanged(e);
                    this.OnPropertyChanged("EndTime", e, _endTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The timeStep property
        /// </summary>
        [XmlElementNameAttribute("timeStep")]
        [XmlAttributeAttribute(true)]
        public virtual float TimeStep
        {
            get
            {
                return this._timeStep;
            }
            set
            {
                if ((this._timeStep != value))
                {
                    float old = this._timeStep;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTimeStepChanging(e);
                    this.OnPropertyChanging("TimeStep", e, _timeStepAttribute);
                    this._timeStep = value;
                    this.OnTimeStepChanged(e);
                    this.OnPropertyChanged("TimeStep", e, _timeStepAttribute);
                }
            }
        }
        
        /// <summary>
        /// The TimePoints property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("IntervalSchedule")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IRegularTimePoint> TimePoints
        {
            get
            {
                return this._timePoints;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RegularIntervalScheduleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/RegularIntervalSchedule")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EndTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndTimeChanging;
        
        /// <summary>
        /// Gets fired when the EndTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndTimeChanged;
        
        /// <summary>
        /// Gets fired before the TimeStep property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimeStepChanging;
        
        /// <summary>
        /// Gets fired when the TimeStep property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimeStepChanged;
        
        private static ITypedElement RetrieveEndTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RegularIntervalSchedule.ClassInstance)).Resolve("endTime")));
        }
        
        /// <summary>
        /// Raises the EndTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EndTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTimeStepAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RegularIntervalSchedule.ClassInstance)).Resolve("timeStep")));
        }
        
        /// <summary>
        /// Raises the TimeStepChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeStepChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimeStepChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TimeStepChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeStepChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimeStepChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTimePointsReference()
        {
            return ((ITypedElement)(((ModelElement)(RegularIntervalSchedule.ClassInstance)).Resolve("TimePoints")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TimePoints property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TimePointsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TimePoints", e, _timePointsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TimePoints property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TimePointsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TimePoints", e, _timePointsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ENDTIME"))
            {
                return this.EndTime;
            }
            if ((attribute == "TIMESTEP"))
            {
                return this.TimeStep;
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
            if ((feature == "TIMEPOINTS"))
            {
                return this._timePoints;
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
            if ((feature == "ENDTIME"))
            {
                this.EndTime = ((string)(value));
                return;
            }
            if ((feature == "TIMESTEP"))
            {
                this.TimeStep = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/RegularIntervalSchedule")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RegularIntervalSchedule class
        /// </summary>
        public class RegularIntervalScheduleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RegularIntervalSchedule _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RegularIntervalScheduleReferencedElementsCollection(RegularIntervalSchedule parent)
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
                    count = (count + this._parent.TimePoints.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TimePoints.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TimePoints.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRegularTimePoint timePointsCasted = item.As<IRegularTimePoint>();
                if ((timePointsCasted != null))
                {
                    this._parent.TimePoints.Add(timePointsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TimePoints.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.TimePoints.Contains(item))
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
                IEnumerator<IModelElement> timePointsEnumerator = this._parent.TimePoints.GetEnumerator();
                try
                {
                    for (
                    ; timePointsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = timePointsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    timePointsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRegularTimePoint regularTimePointItem = item.As<IRegularTimePoint>();
                if (((regularTimePointItem != null) 
                            && this._parent.TimePoints.Remove(regularTimePointItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TimePoints).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the endTime property
        /// </summary>
        private sealed class EndTimeProxy : ModelPropertyChange<IRegularIntervalSchedule, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EndTimeProxy(IRegularIntervalSchedule modelElement) : 
                    base(modelElement, "endTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.EndTime;
                }
                set
                {
                    this.ModelElement.EndTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the timeStep property
        /// </summary>
        private sealed class TimeStepProxy : ModelPropertyChange<IRegularIntervalSchedule, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TimeStepProxy(IRegularIntervalSchedule modelElement) : 
                    base(modelElement, "timeStep")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.TimeStep;
                }
                set
                {
                    this.ModelElement.TimeStep = value;
                }
            }
        }
    }
}

