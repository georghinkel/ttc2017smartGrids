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
    /// The default implementation of the Line class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/Line")]
    [DebuggerDisplayAttribute("Line {UUID}")]
    public class Line : EquipmentContainer, ILine, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TransmissionRightOfWay property
        /// </summary>
        private ITransmissionRightOfWay _transmissionRightOfWay;
        
        /// <summary>
        /// The backing field for the Flowgates property
        /// </summary>
        private LineFlowgatesCollection _flowgates;
        
        /// <summary>
        /// The backing field for the Region property
        /// </summary>
        private ISubGeographicalRegion _region;
        
        private static IClass _classInstance;
        
        public Line()
        {
            this._flowgates = new LineFlowgatesCollection(this);
            this._flowgates.CollectionChanging += this.FlowgatesCollectionChanging;
            this._flowgates.CollectionChanged += this.FlowgatesCollectionChanged;
        }
        
        /// <summary>
        /// The TransmissionRightOfWay property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Lines")]
        public virtual ITransmissionRightOfWay TransmissionRightOfWay
        {
            get
            {
                return this._transmissionRightOfWay;
            }
            set
            {
                if ((this._transmissionRightOfWay != value))
                {
                    ITransmissionRightOfWay old = this._transmissionRightOfWay;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransmissionRightOfWayChanging(e);
                    this.OnPropertyChanging("TransmissionRightOfWay", e);
                    this._transmissionRightOfWay = value;
                    if ((old != null))
                    {
                        old.Lines.Remove(this);
                        old.Deleted -= this.OnResetTransmissionRightOfWay;
                    }
                    if ((value != null))
                    {
                        value.Lines.Add(this);
                        value.Deleted += this.OnResetTransmissionRightOfWay;
                    }
                    this.OnTransmissionRightOfWayChanged(e);
                    this.OnPropertyChanged("TransmissionRightOfWay", e);
                }
            }
        }
        
        /// <summary>
        /// The Flowgates property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Lines")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IFlowgate> Flowgates
        {
            get
            {
                return this._flowgates;
            }
        }
        
        /// <summary>
        /// The Region property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Lines")]
        public virtual ISubGeographicalRegion Region
        {
            get
            {
                return this._region;
            }
            set
            {
                if ((this._region != value))
                {
                    ISubGeographicalRegion old = this._region;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRegionChanging(e);
                    this.OnPropertyChanging("Region", e);
                    this._region = value;
                    if ((old != null))
                    {
                        old.Lines.Remove(this);
                        old.Deleted -= this.OnResetRegion;
                    }
                    if ((value != null))
                    {
                        value.Lines.Add(this);
                        value.Deleted += this.OnResetRegion;
                    }
                    this.OnRegionChanged(e);
                    this.OnPropertyChanged("Region", e);
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
                return base.ReferencedElements.Concat(new LineReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/Line")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TransmissionRightOfWay property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransmissionRightOfWayChanging;
        
        /// <summary>
        /// Gets fired when the TransmissionRightOfWay property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransmissionRightOfWayChanged;
        
        /// <summary>
        /// Gets fired before the Region property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegionChanging;
        
        /// <summary>
        /// Gets fired when the Region property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegionChanged;
        
        /// <summary>
        /// Raises the TransmissionRightOfWayChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransmissionRightOfWayChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransmissionRightOfWayChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransmissionRightOfWayChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransmissionRightOfWayChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransmissionRightOfWayChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TransmissionRightOfWay property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTransmissionRightOfWay(object sender, System.EventArgs eventArgs)
        {
            this.TransmissionRightOfWay = null;
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Flowgates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void FlowgatesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Flowgates", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Flowgates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void FlowgatesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Flowgates", e);
        }
        
        /// <summary>
        /// Raises the RegionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RegionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Region property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRegion(object sender, System.EventArgs eventArgs)
        {
            this.Region = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "FLOWGATES"))
            {
                return this._flowgates;
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
            if ((feature == "TRANSMISSIONRIGHTOFWAY"))
            {
                this.TransmissionRightOfWay = ((ITransmissionRightOfWay)(value));
                return;
            }
            if ((feature == "REGION"))
            {
                this.Region = ((ISubGeographicalRegion)(value));
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
            if ((attribute == "TransmissionRightOfWay"))
            {
                return new TransmissionRightOfWayProxy(this);
            }
            if ((attribute == "Region"))
            {
                return new RegionProxy(this);
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
            if ((reference == "TransmissionRightOfWay"))
            {
                return new TransmissionRightOfWayProxy(this);
            }
            if ((reference == "Region"))
            {
                return new RegionProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/Line")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Line class
        /// </summary>
        public class LineReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Line _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LineReferencedElementsCollection(Line parent)
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
                    if ((this._parent.TransmissionRightOfWay != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Flowgates.Count);
                    if ((this._parent.Region != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TransmissionRightOfWayChanged += this.PropagateValueChanges;
                this._parent.Flowgates.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.RegionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TransmissionRightOfWayChanged -= this.PropagateValueChanges;
                this._parent.Flowgates.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.RegionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TransmissionRightOfWay == null))
                {
                    ITransmissionRightOfWay transmissionRightOfWayCasted = item.As<ITransmissionRightOfWay>();
                    if ((transmissionRightOfWayCasted != null))
                    {
                        this._parent.TransmissionRightOfWay = transmissionRightOfWayCasted;
                        return;
                    }
                }
                IFlowgate flowgatesCasted = item.As<IFlowgate>();
                if ((flowgatesCasted != null))
                {
                    this._parent.Flowgates.Add(flowgatesCasted);
                }
                if ((this._parent.Region == null))
                {
                    ISubGeographicalRegion regionCasted = item.As<ISubGeographicalRegion>();
                    if ((regionCasted != null))
                    {
                        this._parent.Region = regionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TransmissionRightOfWay = null;
                this._parent.Flowgates.Clear();
                this._parent.Region = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TransmissionRightOfWay))
                {
                    return true;
                }
                if (this._parent.Flowgates.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Region))
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
                if ((this._parent.TransmissionRightOfWay != null))
                {
                    array[arrayIndex] = this._parent.TransmissionRightOfWay;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> flowgatesEnumerator = this._parent.Flowgates.GetEnumerator();
                try
                {
                    for (
                    ; flowgatesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = flowgatesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    flowgatesEnumerator.Dispose();
                }
                if ((this._parent.Region != null))
                {
                    array[arrayIndex] = this._parent.Region;
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
                if ((this._parent.TransmissionRightOfWay == item))
                {
                    this._parent.TransmissionRightOfWay = null;
                    return true;
                }
                IFlowgate flowgateItem = item.As<IFlowgate>();
                if (((flowgateItem != null) 
                            && this._parent.Flowgates.Remove(flowgateItem)))
                {
                    return true;
                }
                if ((this._parent.Region == item))
                {
                    this._parent.Region = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TransmissionRightOfWay).Concat(this._parent.Flowgates).Concat(this._parent.Region).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TransmissionRightOfWay property
        /// </summary>
        private sealed class TransmissionRightOfWayProxy : ModelPropertyChange<ILine, ITransmissionRightOfWay>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransmissionRightOfWayProxy(ILine modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITransmissionRightOfWay Value
            {
                get
                {
                    return this.ModelElement.TransmissionRightOfWay;
                }
                set
                {
                    this.ModelElement.TransmissionRightOfWay = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TransmissionRightOfWayChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TransmissionRightOfWayChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Region property
        /// </summary>
        private sealed class RegionProxy : ModelPropertyChange<ILine, ISubGeographicalRegion>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RegionProxy(ILine modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISubGeographicalRegion Value
            {
                get
                {
                    return this.ModelElement.Region;
                }
                set
                {
                    this.ModelElement.Region = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RegionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RegionChanged -= handler;
            }
        }
    }
}

