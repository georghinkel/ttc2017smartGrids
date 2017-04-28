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
    /// The default implementation of the DescriptionInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/DescriptionInfo")]
    public partial class DescriptionInfo : ModelElement, IDescriptionInfo, IModelElement
    {
        
        private static Lazy<ITypedElement> _dPLReference = new Lazy<ITypedElement>(RetrieveDPLReference);
        
        /// <summary>
        /// The backing field for the DPL property
        /// </summary>
        private ObservableAssociationOrderedSet<IDPL> _dPL;
        
        private static Lazy<ITypedElement> _lPLReference = new Lazy<ITypedElement>(RetrieveLPLReference);
        
        /// <summary>
        /// The backing field for the LPL property
        /// </summary>
        private ObservableAssociationOrderedSet<ILPL> _lPL;
        
        private static Lazy<ITypedElement> _cSDReference = new Lazy<ITypedElement>(RetrieveCSDReference);
        
        /// <summary>
        /// The backing field for the CSD property
        /// </summary>
        private ObservableAssociationOrderedSet<ICSD> _cSD;
        
        private static Lazy<ITypedElement> _c_PrimitiveCDCReference = new Lazy<ITypedElement>(RetrieveC_PrimitiveCDCReference);
        
        /// <summary>
        /// The backing field for the C_PrimitiveCDC property
        /// </summary>
        private ObservableAssociationOrderedSet<IC_PrimitiveCDC> _c_PrimitiveCDC;
        
        private static IClass _classInstance;
        
        public DescriptionInfo()
        {
            this._dPL = new ObservableAssociationOrderedSet<IDPL>();
            this._dPL.CollectionChanging += this.DPLCollectionChanging;
            this._dPL.CollectionChanged += this.DPLCollectionChanged;
            this._lPL = new ObservableAssociationOrderedSet<ILPL>();
            this._lPL.CollectionChanging += this.LPLCollectionChanging;
            this._lPL.CollectionChanged += this.LPLCollectionChanged;
            this._cSD = new ObservableAssociationOrderedSet<ICSD>();
            this._cSD.CollectionChanging += this.CSDCollectionChanging;
            this._cSD.CollectionChanged += this.CSDCollectionChanged;
            this._c_PrimitiveCDC = new ObservableAssociationOrderedSet<IC_PrimitiveCDC>();
            this._c_PrimitiveCDC.CollectionChanging += this.C_PrimitiveCDCCollectionChanging;
            this._c_PrimitiveCDC.CollectionChanged += this.C_PrimitiveCDCCollectionChanged;
        }
        
        /// <summary>
        /// The DPL property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDPL> DPL
        {
            get
            {
                return this._dPL;
            }
        }
        
        /// <summary>
        /// The LPL property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ILPL> LPL
        {
            get
            {
                return this._lPL;
            }
        }
        
        /// <summary>
        /// The CSD property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICSD> CSD
        {
            get
            {
                return this._cSD;
            }
        }
        
        /// <summary>
        /// The C_PrimitiveCDC property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IC_PrimitiveCDC> C_PrimitiveCDC
        {
            get
            {
                return this._c_PrimitiveCDC;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DescriptionInfoReferencedElementsCollection(this));
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
                            "taclasses/DescriptionInfo")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveDPLReference()
        {
            return ((ITypedElement)(((ModelElement)(DescriptionInfo.ClassInstance)).Resolve("DPL")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the DPL property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DPLCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("DPL", e, _dPLReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the DPL property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DPLCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DPL", e, _dPLReference);
        }
        
        private static ITypedElement RetrieveLPLReference()
        {
            return ((ITypedElement)(((ModelElement)(DescriptionInfo.ClassInstance)).Resolve("LPL")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LPL property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LPLCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("LPL", e, _lPLReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LPL property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LPLCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LPL", e, _lPLReference);
        }
        
        private static ITypedElement RetrieveCSDReference()
        {
            return ((ITypedElement)(((ModelElement)(DescriptionInfo.ClassInstance)).Resolve("CSD")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CSD property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CSDCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("CSD", e, _cSDReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CSD property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CSDCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CSD", e, _cSDReference);
        }
        
        private static ITypedElement RetrieveC_PrimitiveCDCReference()
        {
            return ((ITypedElement)(((ModelElement)(DescriptionInfo.ClassInstance)).Resolve("C_PrimitiveCDC")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the C_PrimitiveCDC property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void C_PrimitiveCDCCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("C_PrimitiveCDC", e, _c_PrimitiveCDCReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the C_PrimitiveCDC property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void C_PrimitiveCDCCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("C_PrimitiveCDC", e, _c_PrimitiveCDCReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "DPL"))
            {
                return this._dPL;
            }
            if ((feature == "LPL"))
            {
                return this._lPL;
            }
            if ((feature == "CSD"))
            {
                return this._cSD;
            }
            if ((feature == "C_PRIMITIVECDC"))
            {
                return this._c_PrimitiveCDC;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/DescriptionInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DescriptionInfo class
        /// </summary>
        public class DescriptionInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DescriptionInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DescriptionInfoReferencedElementsCollection(DescriptionInfo parent)
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
                    count = (count + this._parent.DPL.Count);
                    count = (count + this._parent.LPL.Count);
                    count = (count + this._parent.CSD.Count);
                    count = (count + this._parent.C_PrimitiveCDC.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DPL.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.LPL.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.CSD.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.C_PrimitiveCDC.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DPL.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.LPL.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.CSD.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.C_PrimitiveCDC.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IDPL dPLCasted = item.As<IDPL>();
                if ((dPLCasted != null))
                {
                    this._parent.DPL.Add(dPLCasted);
                }
                ILPL lPLCasted = item.As<ILPL>();
                if ((lPLCasted != null))
                {
                    this._parent.LPL.Add(lPLCasted);
                }
                ICSD cSDCasted = item.As<ICSD>();
                if ((cSDCasted != null))
                {
                    this._parent.CSD.Add(cSDCasted);
                }
                IC_PrimitiveCDC c_PrimitiveCDCCasted = item.As<IC_PrimitiveCDC>();
                if ((c_PrimitiveCDCCasted != null))
                {
                    this._parent.C_PrimitiveCDC.Add(c_PrimitiveCDCCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DPL.Clear();
                this._parent.LPL.Clear();
                this._parent.CSD.Clear();
                this._parent.C_PrimitiveCDC.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.DPL.Contains(item))
                {
                    return true;
                }
                if (this._parent.LPL.Contains(item))
                {
                    return true;
                }
                if (this._parent.CSD.Contains(item))
                {
                    return true;
                }
                if (this._parent.C_PrimitiveCDC.Contains(item))
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
                IEnumerator<IModelElement> dPLEnumerator = this._parent.DPL.GetEnumerator();
                try
                {
                    for (
                    ; dPLEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = dPLEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    dPLEnumerator.Dispose();
                }
                IEnumerator<IModelElement> lPLEnumerator = this._parent.LPL.GetEnumerator();
                try
                {
                    for (
                    ; lPLEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = lPLEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    lPLEnumerator.Dispose();
                }
                IEnumerator<IModelElement> cSDEnumerator = this._parent.CSD.GetEnumerator();
                try
                {
                    for (
                    ; cSDEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = cSDEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    cSDEnumerator.Dispose();
                }
                IEnumerator<IModelElement> c_PrimitiveCDCEnumerator = this._parent.C_PrimitiveCDC.GetEnumerator();
                try
                {
                    for (
                    ; c_PrimitiveCDCEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = c_PrimitiveCDCEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    c_PrimitiveCDCEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IDPL dPLItem = item.As<IDPL>();
                if (((dPLItem != null) 
                            && this._parent.DPL.Remove(dPLItem)))
                {
                    return true;
                }
                ILPL lPLItem = item.As<ILPL>();
                if (((lPLItem != null) 
                            && this._parent.LPL.Remove(lPLItem)))
                {
                    return true;
                }
                ICSD cSDItem = item.As<ICSD>();
                if (((cSDItem != null) 
                            && this._parent.CSD.Remove(cSDItem)))
                {
                    return true;
                }
                IC_PrimitiveCDC c_PrimitiveCDCItem = item.As<IC_PrimitiveCDC>();
                if (((c_PrimitiveCDCItem != null) 
                            && this._parent.C_PrimitiveCDC.Remove(c_PrimitiveCDCItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DPL).Concat(this._parent.LPL).Concat(this._parent.CSD).Concat(this._parent.C_PrimitiveCDC).GetEnumerator();
            }
        }
    }
}
