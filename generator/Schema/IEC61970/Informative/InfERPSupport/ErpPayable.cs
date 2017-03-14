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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport
{
    
    
    /// <summary>
    /// The default implementation of the ErpPayable class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfERPSupport")]
    [XmlNamespacePrefixAttribute("cimInfERPSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
        "Payable")]
    [DebuggerDisplayAttribute("ErpPayable {UUID}")]
    public class ErpPayable : Document, IErpPayable, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ContractorItems property
        /// </summary>
        private ErpPayableContractorItemsCollection _contractorItems;
        
        /// <summary>
        /// The backing field for the ErpPayableLineItems property
        /// </summary>
        private ErpPayableErpPayableLineItemsCollection _erpPayableLineItems;
        
        private static IClass _classInstance;
        
        public ErpPayable()
        {
            this._contractorItems = new ErpPayableContractorItemsCollection(this);
            this._contractorItems.CollectionChanging += this.ContractorItemsCollectionChanging;
            this._contractorItems.CollectionChanged += this.ContractorItemsCollectionChanged;
            this._erpPayableLineItems = new ErpPayableErpPayableLineItemsCollection(this);
            this._erpPayableLineItems.CollectionChanging += this.ErpPayableLineItemsCollectionChanging;
            this._erpPayableLineItems.CollectionChanged += this.ErpPayableLineItemsCollectionChanged;
        }
        
        /// <summary>
        /// The ContractorItems property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ErpPayables")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IContractorItem> ContractorItems
        {
            get
            {
                return this._contractorItems;
            }
        }
        
        /// <summary>
        /// The ErpPayableLineItems property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ErpPayable")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IErpPayableLineItem> ErpPayableLineItems
        {
            get
            {
                return this._erpPayableLineItems;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ErpPayableReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
                            "Payable")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ContractorItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ContractorItemsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ContractorItems", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ContractorItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ContractorItemsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ContractorItems", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ErpPayableLineItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpPayableLineItemsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ErpPayableLineItems", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ErpPayableLineItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpPayableLineItemsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ErpPayableLineItems", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CONTRACTORITEMS"))
            {
                return this._contractorItems;
            }
            if ((feature == "ERPPAYABLELINEITEMS"))
            {
                return this._erpPayableLineItems;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
                        "Payable")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ErpPayable class
        /// </summary>
        public class ErpPayableReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ErpPayable _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ErpPayableReferencedElementsCollection(ErpPayable parent)
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
                    count = (count + this._parent.ContractorItems.Count);
                    count = (count + this._parent.ErpPayableLineItems.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ContractorItems.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ErpPayableLineItems.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ContractorItems.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ErpPayableLineItems.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IContractorItem contractorItemsCasted = item.As<IContractorItem>();
                if ((contractorItemsCasted != null))
                {
                    this._parent.ContractorItems.Add(contractorItemsCasted);
                }
                IErpPayableLineItem erpPayableLineItemsCasted = item.As<IErpPayableLineItem>();
                if ((erpPayableLineItemsCasted != null))
                {
                    this._parent.ErpPayableLineItems.Add(erpPayableLineItemsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ContractorItems.Clear();
                this._parent.ErpPayableLineItems.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ContractorItems.Contains(item))
                {
                    return true;
                }
                if (this._parent.ErpPayableLineItems.Contains(item))
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
                IEnumerator<IModelElement> contractorItemsEnumerator = this._parent.ContractorItems.GetEnumerator();
                try
                {
                    for (
                    ; contractorItemsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = contractorItemsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    contractorItemsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> erpPayableLineItemsEnumerator = this._parent.ErpPayableLineItems.GetEnumerator();
                try
                {
                    for (
                    ; erpPayableLineItemsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = erpPayableLineItemsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    erpPayableLineItemsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IContractorItem contractorItemItem = item.As<IContractorItem>();
                if (((contractorItemItem != null) 
                            && this._parent.ContractorItems.Remove(contractorItemItem)))
                {
                    return true;
                }
                IErpPayableLineItem erpPayableLineItemItem = item.As<IErpPayableLineItem>();
                if (((erpPayableLineItemItem != null) 
                            && this._parent.ErpPayableLineItems.Remove(erpPayableLineItemItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ContractorItems).Concat(this._parent.ErpPayableLineItems).GetEnumerator();
            }
        }
    }
}

