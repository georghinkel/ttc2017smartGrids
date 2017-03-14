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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The default implementation of the AnalogLimitSet class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Meas")]
    [XmlNamespacePrefixAttribute("cimMeas")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/AnalogLimitSet")]
    [DebuggerDisplayAttribute("AnalogLimitSet {UUID}")]
    public class AnalogLimitSet : LimitSet, IAnalogLimitSet, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Measurements property
        /// </summary>
        private AnalogLimitSetMeasurementsCollection _measurements;
        
        /// <summary>
        /// The backing field for the Limits property
        /// </summary>
        private AnalogLimitSetLimitsCollection _limits;
        
        private static IClass _classInstance;
        
        public AnalogLimitSet()
        {
            this._measurements = new AnalogLimitSetMeasurementsCollection(this);
            this._measurements.CollectionChanging += this.MeasurementsCollectionChanging;
            this._measurements.CollectionChanged += this.MeasurementsCollectionChanged;
            this._limits = new AnalogLimitSetLimitsCollection(this);
            this._limits.CollectionChanging += this.LimitsCollectionChanging;
            this._limits.CollectionChanged += this.LimitsCollectionChanged;
        }
        
        /// <summary>
        /// The Measurements property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("LimitSets")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAnalog> Measurements
        {
            get
            {
                return this._measurements;
            }
        }
        
        /// <summary>
        /// The Limits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("LimitSet")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAnalogLimit> Limits
        {
            get
            {
                return this._limits;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AnalogLimitSetReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/AnalogLimitSet")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Measurements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MeasurementsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Measurements", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Measurements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MeasurementsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Measurements", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Limits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LimitsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Limits", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Limits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LimitsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Limits", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "MEASUREMENTS"))
            {
                return this._measurements;
            }
            if ((feature == "LIMITS"))
            {
                return this._limits;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/AnalogLimitSet")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AnalogLimitSet class
        /// </summary>
        public class AnalogLimitSetReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AnalogLimitSet _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AnalogLimitSetReferencedElementsCollection(AnalogLimitSet parent)
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
                    count = (count + this._parent.Measurements.Count);
                    count = (count + this._parent.Limits.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Measurements.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Limits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Measurements.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Limits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAnalog measurementsCasted = item.As<IAnalog>();
                if ((measurementsCasted != null))
                {
                    this._parent.Measurements.Add(measurementsCasted);
                }
                IAnalogLimit limitsCasted = item.As<IAnalogLimit>();
                if ((limitsCasted != null))
                {
                    this._parent.Limits.Add(limitsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Measurements.Clear();
                this._parent.Limits.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Measurements.Contains(item))
                {
                    return true;
                }
                if (this._parent.Limits.Contains(item))
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
                IEnumerator<IModelElement> measurementsEnumerator = this._parent.Measurements.GetEnumerator();
                try
                {
                    for (
                    ; measurementsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = measurementsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    measurementsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> limitsEnumerator = this._parent.Limits.GetEnumerator();
                try
                {
                    for (
                    ; limitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = limitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    limitsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAnalog analogItem = item.As<IAnalog>();
                if (((analogItem != null) 
                            && this._parent.Measurements.Remove(analogItem)))
                {
                    return true;
                }
                IAnalogLimit analogLimitItem = item.As<IAnalogLimit>();
                if (((analogLimitItem != null) 
                            && this._parent.Limits.Remove(analogLimitItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Measurements).Concat(this._parent.Limits).GetEnumerator();
            }
        }
    }
}

