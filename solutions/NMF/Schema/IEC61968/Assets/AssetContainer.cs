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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Assets
{
    
    
    /// <summary>
    /// The default implementation of the AssetContainer class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Assets")]
    [XmlNamespacePrefixAttribute("cimAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Assets/AssetContainer")]
    [DebuggerDisplayAttribute("AssetContainer {UUID}")]
    public partial class AssetContainer : Asset, IAssetContainer, IModelElement
    {
        
        private static Lazy<ITypedElement> _landPropertiesReference = new Lazy<ITypedElement>(RetrieveLandPropertiesReference);
        
        /// <summary>
        /// The backing field for the LandProperties property
        /// </summary>
        private AssetContainerLandPropertiesCollection _landProperties;
        
        private static Lazy<ITypedElement> _assetsReference = new Lazy<ITypedElement>(RetrieveAssetsReference);
        
        /// <summary>
        /// The backing field for the Assets property
        /// </summary>
        private AssetContainerAssetsCollection _assets;
        
        private static Lazy<ITypedElement> _sealsReference = new Lazy<ITypedElement>(RetrieveSealsReference);
        
        /// <summary>
        /// The backing field for the Seals property
        /// </summary>
        private AssetContainerSealsCollection _seals;
        
        private static IClass _classInstance;
        
        public AssetContainer()
        {
            this._landProperties = new AssetContainerLandPropertiesCollection(this);
            this._landProperties.CollectionChanging += this.LandPropertiesCollectionChanging;
            this._landProperties.CollectionChanged += this.LandPropertiesCollectionChanged;
            this._assets = new AssetContainerAssetsCollection(this);
            this._assets.CollectionChanging += this.AssetsCollectionChanging;
            this._assets.CollectionChanged += this.AssetsCollectionChanged;
            this._seals = new AssetContainerSealsCollection(this);
            this._seals.CollectionChanging += this.SealsCollectionChanging;
            this._seals.CollectionChanged += this.SealsCollectionChanged;
        }
        
        /// <summary>
        /// The LandProperties property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AssetContainers")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ILandProperty> LandProperties
        {
            get
            {
                return this._landProperties;
            }
        }
        
        /// <summary>
        /// The Assets property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AssetContainer")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAsset> Assets
        {
            get
            {
                return this._assets;
            }
        }
        
        /// <summary>
        /// The Seals property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AssetContainer")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ISeal> Seals
        {
            get
            {
                return this._seals;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AssetContainerReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Assets/AssetContainer")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveLandPropertiesReference()
        {
            return ((ITypedElement)(((ModelElement)(ClassInstance)).Resolve("LandProperties")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LandProperties property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LandPropertiesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("LandProperties", e, _landPropertiesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LandProperties property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LandPropertiesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LandProperties", e, _landPropertiesReference);
        }
        
        private static ITypedElement RetrieveAssetsReference()
        {
            return ((ITypedElement)(((ModelElement)(ClassInstance)).Resolve("Assets")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Assets property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssetsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Assets", e, _assetsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Assets property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssetsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Assets", e, _assetsReference);
        }
        
        private static ITypedElement RetrieveSealsReference()
        {
            return ((ITypedElement)(((ModelElement)(ClassInstance)).Resolve("Seals")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Seals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SealsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Seals", e, _sealsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Seals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SealsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Seals", e, _sealsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LANDPROPERTIES"))
            {
                return this._landProperties;
            }
            if ((feature == "ASSETS"))
            {
                return this._assets;
            }
            if ((feature == "SEALS"))
            {
                return this._seals;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Assets/AssetContainer")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssetContainer class
        /// </summary>
        public class AssetContainerReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AssetContainer _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssetContainerReferencedElementsCollection(AssetContainer parent)
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
                    count = (count + this._parent.LandProperties.Count);
                    count = (count + this._parent.Assets.Count);
                    count = (count + this._parent.Seals.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LandProperties.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Assets.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Seals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LandProperties.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Assets.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Seals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ILandProperty landPropertiesCasted = item.As<ILandProperty>();
                if ((landPropertiesCasted != null))
                {
                    this._parent.LandProperties.Add(landPropertiesCasted);
                }
                IAsset assetsCasted = item.As<IAsset>();
                if ((assetsCasted != null))
                {
                    this._parent.Assets.Add(assetsCasted);
                }
                ISeal sealsCasted = item.As<ISeal>();
                if ((sealsCasted != null))
                {
                    this._parent.Seals.Add(sealsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LandProperties.Clear();
                this._parent.Assets.Clear();
                this._parent.Seals.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.LandProperties.Contains(item))
                {
                    return true;
                }
                if (this._parent.Assets.Contains(item))
                {
                    return true;
                }
                if (this._parent.Seals.Contains(item))
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
                IEnumerator<IModelElement> landPropertiesEnumerator = this._parent.LandProperties.GetEnumerator();
                try
                {
                    for (
                    ; landPropertiesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = landPropertiesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    landPropertiesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> assetsEnumerator = this._parent.Assets.GetEnumerator();
                try
                {
                    for (
                    ; assetsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assetsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assetsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> sealsEnumerator = this._parent.Seals.GetEnumerator();
                try
                {
                    for (
                    ; sealsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = sealsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    sealsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ILandProperty landPropertyItem = item.As<ILandProperty>();
                if (((landPropertyItem != null) 
                            && this._parent.LandProperties.Remove(landPropertyItem)))
                {
                    return true;
                }
                IAsset assetItem = item.As<IAsset>();
                if (((assetItem != null) 
                            && this._parent.Assets.Remove(assetItem)))
                {
                    return true;
                }
                ISeal sealItem = item.As<ISeal>();
                if (((sealItem != null) 
                            && this._parent.Seals.Remove(sealItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LandProperties).Concat(this._parent.Assets).Concat(this._parent.Seals).GetEnumerator();
            }
        }
    }
}
