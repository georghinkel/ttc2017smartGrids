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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.AssetModels
{
    
    
    /// <summary>
    /// The default implementation of the TransformerInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#AssetModels")]
    [XmlNamespacePrefixAttribute("cimAssetModels")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/TransformerInfo")]
    [DebuggerDisplayAttribute("TransformerInfo {UUID}")]
    public partial class TransformerInfo : IdentifiedObject, ITransformerInfo, IModelElement
    {
        
        private static Lazy<ITypedElement> _transformersReference = new Lazy<ITypedElement>(RetrieveTransformersReference);
        
        /// <summary>
        /// The backing field for the Transformers property
        /// </summary>
        private TransformerInfoTransformersCollection _transformers;
        
        private static Lazy<ITypedElement> _windingInfosReference = new Lazy<ITypedElement>(RetrieveWindingInfosReference);
        
        /// <summary>
        /// The backing field for the WindingInfos property
        /// </summary>
        private TransformerInfoWindingInfosCollection _windingInfos;
        
        private static Lazy<ITypedElement> _transformerAssetModelsReference = new Lazy<ITypedElement>(RetrieveTransformerAssetModelsReference);
        
        /// <summary>
        /// The backing field for the TransformerAssetModels property
        /// </summary>
        private TransformerInfoTransformerAssetModelsCollection _transformerAssetModels;
        
        private static Lazy<ITypedElement> _transformerAssetsReference = new Lazy<ITypedElement>(RetrieveTransformerAssetsReference);
        
        /// <summary>
        /// The backing field for the TransformerAssets property
        /// </summary>
        private TransformerInfoTransformerAssetsCollection _transformerAssets;
        
        private static IClass _classInstance;
        
        public TransformerInfo()
        {
            this._transformers = new TransformerInfoTransformersCollection(this);
            this._transformers.CollectionChanging += this.TransformersCollectionChanging;
            this._transformers.CollectionChanged += this.TransformersCollectionChanged;
            this._windingInfos = new TransformerInfoWindingInfosCollection(this);
            this._windingInfos.CollectionChanging += this.WindingInfosCollectionChanging;
            this._windingInfos.CollectionChanged += this.WindingInfosCollectionChanged;
            this._transformerAssetModels = new TransformerInfoTransformerAssetModelsCollection(this);
            this._transformerAssetModels.CollectionChanging += this.TransformerAssetModelsCollectionChanging;
            this._transformerAssetModels.CollectionChanged += this.TransformerAssetModelsCollectionChanged;
            this._transformerAssets = new TransformerInfoTransformerAssetsCollection(this);
            this._transformerAssets.CollectionChanging += this.TransformerAssetsCollectionChanging;
            this._transformerAssets.CollectionChanged += this.TransformerAssetsCollectionChanged;
        }
        
        /// <summary>
        /// The Transformers property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerInfo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDistributionTransformer> Transformers
        {
            get
            {
                return this._transformers;
            }
        }
        
        /// <summary>
        /// The WindingInfos property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerInfo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IWindingInfo> WindingInfos
        {
            get
            {
                return this._windingInfos;
            }
        }
        
        /// <summary>
        /// The TransformerAssetModels property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerInfo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransformerAssetModel> TransformerAssetModels
        {
            get
            {
                return this._transformerAssetModels;
            }
        }
        
        /// <summary>
        /// The TransformerAssets property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerInfo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransformerAsset> TransformerAssets
        {
            get
            {
                return this._transformerAssets;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TransformerInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/TransformerInfo")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveTransformersReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerInfo.ClassInstance)).Resolve("Transformers")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Transformers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformersCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Transformers", e, _transformersReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Transformers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformersCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Transformers", e, _transformersReference);
        }
        
        private static ITypedElement RetrieveWindingInfosReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerInfo.ClassInstance)).Resolve("WindingInfos")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the WindingInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void WindingInfosCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("WindingInfos", e, _windingInfosReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the WindingInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void WindingInfosCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("WindingInfos", e, _windingInfosReference);
        }
        
        private static ITypedElement RetrieveTransformerAssetModelsReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerInfo.ClassInstance)).Resolve("TransformerAssetModels")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TransformerAssetModels property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerAssetModelsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TransformerAssetModels", e, _transformerAssetModelsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TransformerAssetModels property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerAssetModelsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TransformerAssetModels", e, _transformerAssetModelsReference);
        }
        
        private static ITypedElement RetrieveTransformerAssetsReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerInfo.ClassInstance)).Resolve("TransformerAssets")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TransformerAssets property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerAssetsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TransformerAssets", e, _transformerAssetsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TransformerAssets property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerAssetsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TransformerAssets", e, _transformerAssetsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "TRANSFORMERS"))
            {
                return this._transformers;
            }
            if ((feature == "WINDINGINFOS"))
            {
                return this._windingInfos;
            }
            if ((feature == "TRANSFORMERASSETMODELS"))
            {
                return this._transformerAssetModels;
            }
            if ((feature == "TRANSFORMERASSETS"))
            {
                return this._transformerAssets;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/TransformerInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransformerInfo class
        /// </summary>
        public class TransformerInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransformerInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransformerInfoReferencedElementsCollection(TransformerInfo parent)
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
                    count = (count + this._parent.Transformers.Count);
                    count = (count + this._parent.WindingInfos.Count);
                    count = (count + this._parent.TransformerAssetModels.Count);
                    count = (count + this._parent.TransformerAssets.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Transformers.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.WindingInfos.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransformerAssetModels.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransformerAssets.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Transformers.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.WindingInfos.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransformerAssetModels.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransformerAssets.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IDistributionTransformer transformersCasted = item.As<IDistributionTransformer>();
                if ((transformersCasted != null))
                {
                    this._parent.Transformers.Add(transformersCasted);
                }
                IWindingInfo windingInfosCasted = item.As<IWindingInfo>();
                if ((windingInfosCasted != null))
                {
                    this._parent.WindingInfos.Add(windingInfosCasted);
                }
                ITransformerAssetModel transformerAssetModelsCasted = item.As<ITransformerAssetModel>();
                if ((transformerAssetModelsCasted != null))
                {
                    this._parent.TransformerAssetModels.Add(transformerAssetModelsCasted);
                }
                ITransformerAsset transformerAssetsCasted = item.As<ITransformerAsset>();
                if ((transformerAssetsCasted != null))
                {
                    this._parent.TransformerAssets.Add(transformerAssetsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Transformers.Clear();
                this._parent.WindingInfos.Clear();
                this._parent.TransformerAssetModels.Clear();
                this._parent.TransformerAssets.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Transformers.Contains(item))
                {
                    return true;
                }
                if (this._parent.WindingInfos.Contains(item))
                {
                    return true;
                }
                if (this._parent.TransformerAssetModels.Contains(item))
                {
                    return true;
                }
                if (this._parent.TransformerAssets.Contains(item))
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
                IEnumerator<IModelElement> transformersEnumerator = this._parent.Transformers.GetEnumerator();
                try
                {
                    for (
                    ; transformersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transformersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transformersEnumerator.Dispose();
                }
                IEnumerator<IModelElement> windingInfosEnumerator = this._parent.WindingInfos.GetEnumerator();
                try
                {
                    for (
                    ; windingInfosEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = windingInfosEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    windingInfosEnumerator.Dispose();
                }
                IEnumerator<IModelElement> transformerAssetModelsEnumerator = this._parent.TransformerAssetModels.GetEnumerator();
                try
                {
                    for (
                    ; transformerAssetModelsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transformerAssetModelsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transformerAssetModelsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> transformerAssetsEnumerator = this._parent.TransformerAssets.GetEnumerator();
                try
                {
                    for (
                    ; transformerAssetsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transformerAssetsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transformerAssetsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IDistributionTransformer distributionTransformerItem = item.As<IDistributionTransformer>();
                if (((distributionTransformerItem != null) 
                            && this._parent.Transformers.Remove(distributionTransformerItem)))
                {
                    return true;
                }
                IWindingInfo windingInfoItem = item.As<IWindingInfo>();
                if (((windingInfoItem != null) 
                            && this._parent.WindingInfos.Remove(windingInfoItem)))
                {
                    return true;
                }
                ITransformerAssetModel transformerAssetModelItem = item.As<ITransformerAssetModel>();
                if (((transformerAssetModelItem != null) 
                            && this._parent.TransformerAssetModels.Remove(transformerAssetModelItem)))
                {
                    return true;
                }
                ITransformerAsset transformerAssetItem = item.As<ITransformerAsset>();
                if (((transformerAssetItem != null) 
                            && this._parent.TransformerAssets.Remove(transformerAssetItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Transformers).Concat(this._parent.WindingInfos).Concat(this._parent.TransformerAssetModels).Concat(this._parent.TransformerAssets).GetEnumerator();
            }
        }
    }
}

