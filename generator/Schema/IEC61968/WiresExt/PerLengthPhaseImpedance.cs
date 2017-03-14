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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.WiresExt
{
    
    
    /// <summary>
    /// The default implementation of the PerLengthPhaseImpedance class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#WiresExt")]
    [XmlNamespacePrefixAttribute("cimWiresExt")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/PerLengthPhaseImpeda" +
        "nce")]
    [DebuggerDisplayAttribute("PerLengthPhaseImpedance {UUID}")]
    public class PerLengthPhaseImpedance : IdentifiedObject, IPerLengthPhaseImpedance, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ConductorCount property
        /// </summary>
        private int _conductorCount;
        
        /// <summary>
        /// The backing field for the ConductorSegments property
        /// </summary>
        private PerLengthPhaseImpedanceConductorSegmentsCollection _conductorSegments;
        
        /// <summary>
        /// The backing field for the PhaseImpedanceData property
        /// </summary>
        private PerLengthPhaseImpedancePhaseImpedanceDataCollection _phaseImpedanceData;
        
        private static IClass _classInstance;
        
        public PerLengthPhaseImpedance()
        {
            this._conductorSegments = new PerLengthPhaseImpedanceConductorSegmentsCollection(this);
            this._conductorSegments.CollectionChanging += this.ConductorSegmentsCollectionChanging;
            this._conductorSegments.CollectionChanged += this.ConductorSegmentsCollectionChanged;
            this._phaseImpedanceData = new PerLengthPhaseImpedancePhaseImpedanceDataCollection(this);
            this._phaseImpedanceData.CollectionChanging += this.PhaseImpedanceDataCollectionChanging;
            this._phaseImpedanceData.CollectionChanged += this.PhaseImpedanceDataCollectionChanged;
        }
        
        /// <summary>
        /// The conductorCount property
        /// </summary>
        [XmlElementNameAttribute("conductorCount")]
        [XmlAttributeAttribute(true)]
        public virtual int ConductorCount
        {
            get
            {
                return this._conductorCount;
            }
            set
            {
                if ((this._conductorCount != value))
                {
                    int old = this._conductorCount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConductorCountChanging(e);
                    this.OnPropertyChanging("ConductorCount", e);
                    this._conductorCount = value;
                    this.OnConductorCountChanged(e);
                    this.OnPropertyChanged("ConductorCount", e);
                }
            }
        }
        
        /// <summary>
        /// The ConductorSegments property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PhaseImpedance")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDistributionLineSegment> ConductorSegments
        {
            get
            {
                return this._conductorSegments;
            }
        }
        
        /// <summary>
        /// The PhaseImpedanceData property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PhaseImpedance")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IPhaseImpedanceData> PhaseImpedanceData
        {
            get
            {
                return this._phaseImpedanceData;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new PerLengthPhaseImpedanceReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/PerLengthPhaseImpeda" +
                            "nce")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ConductorCount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductorCountChanging;
        
        /// <summary>
        /// Gets fired when the ConductorCount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductorCountChanged;
        
        /// <summary>
        /// Raises the ConductorCountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductorCountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductorCountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConductorCountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductorCountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductorCountChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ConductorSegments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConductorSegmentsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ConductorSegments", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ConductorSegments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConductorSegmentsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ConductorSegments", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the PhaseImpedanceData property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PhaseImpedanceDataCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("PhaseImpedanceData", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the PhaseImpedanceData property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PhaseImpedanceDataCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("PhaseImpedanceData", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CONDUCTORCOUNT"))
            {
                return this.ConductorCount;
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
            if ((feature == "CONDUCTORSEGMENTS"))
            {
                return this._conductorSegments;
            }
            if ((feature == "PHASEIMPEDANCEDATA"))
            {
                return this._phaseImpedanceData;
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
            if ((feature == "CONDUCTORCOUNT"))
            {
                this.ConductorCount = ((int)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/PerLengthPhaseImpeda" +
                        "nce")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PerLengthPhaseImpedance class
        /// </summary>
        public class PerLengthPhaseImpedanceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PerLengthPhaseImpedance _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PerLengthPhaseImpedanceReferencedElementsCollection(PerLengthPhaseImpedance parent)
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
                    count = (count + this._parent.ConductorSegments.Count);
                    count = (count + this._parent.PhaseImpedanceData.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConductorSegments.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.PhaseImpedanceData.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConductorSegments.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.PhaseImpedanceData.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IDistributionLineSegment conductorSegmentsCasted = item.As<IDistributionLineSegment>();
                if ((conductorSegmentsCasted != null))
                {
                    this._parent.ConductorSegments.Add(conductorSegmentsCasted);
                }
                IPhaseImpedanceData phaseImpedanceDataCasted = item.As<IPhaseImpedanceData>();
                if ((phaseImpedanceDataCasted != null))
                {
                    this._parent.PhaseImpedanceData.Add(phaseImpedanceDataCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConductorSegments.Clear();
                this._parent.PhaseImpedanceData.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ConductorSegments.Contains(item))
                {
                    return true;
                }
                if (this._parent.PhaseImpedanceData.Contains(item))
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
                IEnumerator<IModelElement> conductorSegmentsEnumerator = this._parent.ConductorSegments.GetEnumerator();
                try
                {
                    for (
                    ; conductorSegmentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = conductorSegmentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    conductorSegmentsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> phaseImpedanceDataEnumerator = this._parent.PhaseImpedanceData.GetEnumerator();
                try
                {
                    for (
                    ; phaseImpedanceDataEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = phaseImpedanceDataEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    phaseImpedanceDataEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IDistributionLineSegment distributionLineSegmentItem = item.As<IDistributionLineSegment>();
                if (((distributionLineSegmentItem != null) 
                            && this._parent.ConductorSegments.Remove(distributionLineSegmentItem)))
                {
                    return true;
                }
                IPhaseImpedanceData phaseImpedanceDataItem = item.As<IPhaseImpedanceData>();
                if (((phaseImpedanceDataItem != null) 
                            && this._parent.PhaseImpedanceData.Remove(phaseImpedanceDataItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConductorSegments).Concat(this._parent.PhaseImpedanceData).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the conductorCount property
        /// </summary>
        private sealed class ConductorCountProxy : ModelPropertyChange<IPerLengthPhaseImpedance, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConductorCountProxy(IPerLengthPhaseImpedance modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.ConductorCount;
                }
                set
                {
                    this.ModelElement.ConductorCount = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConductorCountChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConductorCountChanged -= handler;
            }
        }
    }
}

