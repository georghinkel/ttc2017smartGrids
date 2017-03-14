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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.LoadModel
{
    
    
    /// <summary>
    /// The default implementation of the DayType class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#LoadModel")]
    [XmlNamespacePrefixAttribute("cimLoadModel")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/DayType")]
    [DebuggerDisplayAttribute("DayType {UUID}")]
    public class DayType : IdentifiedObject, IDayType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SeasonDayTypeSchedules property
        /// </summary>
        private DayTypeSeasonDayTypeSchedulesCollection _seasonDayTypeSchedules;
        
        private static IClass _classInstance;
        
        public DayType()
        {
            this._seasonDayTypeSchedules = new DayTypeSeasonDayTypeSchedulesCollection(this);
            this._seasonDayTypeSchedules.CollectionChanging += this.SeasonDayTypeSchedulesCollectionChanging;
            this._seasonDayTypeSchedules.CollectionChanged += this.SeasonDayTypeSchedulesCollectionChanged;
        }
        
        /// <summary>
        /// The SeasonDayTypeSchedules property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DayType")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ISeasonDayTypeSchedule> SeasonDayTypeSchedules
        {
            get
            {
                return this._seasonDayTypeSchedules;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DayTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/DayType")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the SeasonDayTypeSchedules property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SeasonDayTypeSchedulesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("SeasonDayTypeSchedules", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the SeasonDayTypeSchedules property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SeasonDayTypeSchedulesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("SeasonDayTypeSchedules", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SEASONDAYTYPESCHEDULES"))
            {
                return this._seasonDayTypeSchedules;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/DayType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DayType class
        /// </summary>
        public class DayTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DayType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DayTypeReferencedElementsCollection(DayType parent)
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
                    count = (count + this._parent.SeasonDayTypeSchedules.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SeasonDayTypeSchedules.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SeasonDayTypeSchedules.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISeasonDayTypeSchedule seasonDayTypeSchedulesCasted = item.As<ISeasonDayTypeSchedule>();
                if ((seasonDayTypeSchedulesCasted != null))
                {
                    this._parent.SeasonDayTypeSchedules.Add(seasonDayTypeSchedulesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SeasonDayTypeSchedules.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.SeasonDayTypeSchedules.Contains(item))
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
                IEnumerator<IModelElement> seasonDayTypeSchedulesEnumerator = this._parent.SeasonDayTypeSchedules.GetEnumerator();
                try
                {
                    for (
                    ; seasonDayTypeSchedulesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = seasonDayTypeSchedulesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    seasonDayTypeSchedulesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISeasonDayTypeSchedule seasonDayTypeScheduleItem = item.As<ISeasonDayTypeSchedule>();
                if (((seasonDayTypeScheduleItem != null) 
                            && this._parent.SeasonDayTypeSchedules.Remove(seasonDayTypeScheduleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SeasonDayTypeSchedules).GetEnumerator();
            }
        }
    }
}

