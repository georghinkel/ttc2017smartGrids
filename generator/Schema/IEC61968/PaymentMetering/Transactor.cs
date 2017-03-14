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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    /// <summary>
    /// The default implementation of the Transactor class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#PaymentMetering")]
    [XmlNamespacePrefixAttribute("cimPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Transactor")]
    [DebuggerDisplayAttribute("Transactor {UUID}")]
    public class Transactor : IdentifiedObject, ITransactor, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MerchantAccounts property
        /// </summary>
        private TransactorMerchantAccountsCollection _merchantAccounts;
        
        private static IClass _classInstance;
        
        public Transactor()
        {
            this._merchantAccounts = new TransactorMerchantAccountsCollection(this);
            this._merchantAccounts.CollectionChanging += this.MerchantAccountsCollectionChanging;
            this._merchantAccounts.CollectionChanged += this.MerchantAccountsCollectionChanged;
        }
        
        /// <summary>
        /// The MerchantAccounts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Transactors")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IMerchantAccount> MerchantAccounts
        {
            get
            {
                return this._merchantAccounts;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TransactorReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Transactor")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the MerchantAccounts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MerchantAccountsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("MerchantAccounts", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the MerchantAccounts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MerchantAccountsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("MerchantAccounts", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "MERCHANTACCOUNTS"))
            {
                return this._merchantAccounts;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Transactor")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Transactor class
        /// </summary>
        public class TransactorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Transactor _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransactorReferencedElementsCollection(Transactor parent)
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
                    count = (count + this._parent.MerchantAccounts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MerchantAccounts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MerchantAccounts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IMerchantAccount merchantAccountsCasted = item.As<IMerchantAccount>();
                if ((merchantAccountsCasted != null))
                {
                    this._parent.MerchantAccounts.Add(merchantAccountsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.MerchantAccounts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.MerchantAccounts.Contains(item))
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
                IEnumerator<IModelElement> merchantAccountsEnumerator = this._parent.MerchantAccounts.GetEnumerator();
                try
                {
                    for (
                    ; merchantAccountsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = merchantAccountsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    merchantAccountsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IMerchantAccount merchantAccountItem = item.As<IMerchantAccount>();
                if (((merchantAccountItem != null) 
                            && this._parent.MerchantAccounts.Remove(merchantAccountItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.MerchantAccounts).GetEnumerator();
            }
        }
    }
}

