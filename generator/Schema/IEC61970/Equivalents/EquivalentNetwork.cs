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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.Equivalents
{
    
    
    /// <summary>
    /// The default implementation of the EquivalentNetwork class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Equivalents")]
    [XmlNamespacePrefixAttribute("cimEquivalents")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Equivalents/EquivalentNetwork" +
        "")]
    [DebuggerDisplayAttribute("EquivalentNetwork {UUID}")]
    public class EquivalentNetwork : ConnectivityNodeContainer, IEquivalentNetwork, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EquivalentEquipments property
        /// </summary>
        private EquivalentNetworkEquivalentEquipmentsCollection _equivalentEquipments;
        
        private static IClass _classInstance;
        
        public EquivalentNetwork()
        {
            this._equivalentEquipments = new EquivalentNetworkEquivalentEquipmentsCollection(this);
            this._equivalentEquipments.CollectionChanging += this.EquivalentEquipmentsCollectionChanging;
            this._equivalentEquipments.CollectionChanged += this.EquivalentEquipmentsCollectionChanged;
        }
        
        /// <summary>
        /// The EquivalentEquipments property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("EquivalentNetwork")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IEquivalentEquipment> EquivalentEquipments
        {
            get
            {
                return this._equivalentEquipments;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EquivalentNetworkReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Equivalents/EquivalentNetwork" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EquivalentEquipments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EquivalentEquipmentsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("EquivalentEquipments", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EquivalentEquipments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EquivalentEquipmentsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EquivalentEquipments", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "EQUIVALENTEQUIPMENTS"))
            {
                return this._equivalentEquipments;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Equivalents/EquivalentNetwork" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EquivalentNetwork class
        /// </summary>
        public class EquivalentNetworkReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EquivalentNetwork _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EquivalentNetworkReferencedElementsCollection(EquivalentNetwork parent)
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
                    count = (count + this._parent.EquivalentEquipments.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EquivalentEquipments.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EquivalentEquipments.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEquivalentEquipment equivalentEquipmentsCasted = item.As<IEquivalentEquipment>();
                if ((equivalentEquipmentsCasted != null))
                {
                    this._parent.EquivalentEquipments.Add(equivalentEquipmentsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EquivalentEquipments.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EquivalentEquipments.Contains(item))
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
                IEnumerator<IModelElement> equivalentEquipmentsEnumerator = this._parent.EquivalentEquipments.GetEnumerator();
                try
                {
                    for (
                    ; equivalentEquipmentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = equivalentEquipmentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    equivalentEquipmentsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEquivalentEquipment equivalentEquipmentItem = item.As<IEquivalentEquipment>();
                if (((equivalentEquipmentItem != null) 
                            && this._parent.EquivalentEquipments.Remove(equivalentEquipmentItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EquivalentEquipments).GetEnumerator();
            }
        }
    }
}

