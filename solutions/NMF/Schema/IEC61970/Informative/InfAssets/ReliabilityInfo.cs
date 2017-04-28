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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The default implementation of the ReliabilityInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Reliabi" +
        "lityInfo")]
    [DebuggerDisplayAttribute("ReliabilityInfo {UUID}")]
    public partial class ReliabilityInfo : IdentifiedObject, IReliabilityInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MomFailureRate property
        /// </summary>
        private float _momFailureRate;
        
        private static Lazy<ITypedElement> _momFailureRateAttribute = new Lazy<ITypedElement>(RetrieveMomFailureRateAttribute);
        
        /// <summary>
        /// The backing field for the MTTR property
        /// </summary>
        private float _mTTR;
        
        private static Lazy<ITypedElement> _mTTRAttribute = new Lazy<ITypedElement>(RetrieveMTTRAttribute);
        
        private static Lazy<ITypedElement> _assetsReference = new Lazy<ITypedElement>(RetrieveAssetsReference);
        
        /// <summary>
        /// The backing field for the Assets property
        /// </summary>
        private ReliabilityInfoAssetsCollection _assets;
        
        private static Lazy<ITypedElement> _specificationReference = new Lazy<ITypedElement>(RetrieveSpecificationReference);
        
        /// <summary>
        /// The backing field for the Specification property
        /// </summary>
        private ISpecification _specification;
        
        private static IClass _classInstance;
        
        public ReliabilityInfo()
        {
            this._assets = new ReliabilityInfoAssetsCollection(this);
            this._assets.CollectionChanging += this.AssetsCollectionChanging;
            this._assets.CollectionChanged += this.AssetsCollectionChanged;
        }
        
        /// <summary>
        /// The momFailureRate property
        /// </summary>
        [XmlElementNameAttribute("momFailureRate")]
        [XmlAttributeAttribute(true)]
        public virtual float MomFailureRate
        {
            get
            {
                return this._momFailureRate;
            }
            set
            {
                if ((this._momFailureRate != value))
                {
                    float old = this._momFailureRate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMomFailureRateChanging(e);
                    this.OnPropertyChanging("MomFailureRate", e, _momFailureRateAttribute);
                    this._momFailureRate = value;
                    this.OnMomFailureRateChanged(e);
                    this.OnPropertyChanged("MomFailureRate", e, _momFailureRateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The mTTR property
        /// </summary>
        [XmlElementNameAttribute("mTTR")]
        [XmlAttributeAttribute(true)]
        public virtual float MTTR
        {
            get
            {
                return this._mTTR;
            }
            set
            {
                if ((this._mTTR != value))
                {
                    float old = this._mTTR;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMTTRChanging(e);
                    this.OnPropertyChanging("MTTR", e, _mTTRAttribute);
                    this._mTTR = value;
                    this.OnMTTRChanged(e);
                    this.OnPropertyChanged("MTTR", e, _mTTRAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Assets property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReliabilityInfos")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAsset> Assets
        {
            get
            {
                return this._assets;
            }
        }
        
        /// <summary>
        /// The Specification property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReliabilityInfos")]
        public virtual ISpecification Specification
        {
            get
            {
                return this._specification;
            }
            set
            {
                if ((this._specification != value))
                {
                    ISpecification old = this._specification;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSpecificationChanging(e);
                    this.OnPropertyChanging("Specification", e, _specificationReference);
                    this._specification = value;
                    if ((old != null))
                    {
                        old.ReliabilityInfos.Remove(this);
                        old.Deleted -= this.OnResetSpecification;
                    }
                    if ((value != null))
                    {
                        value.ReliabilityInfos.Add(this);
                        value.Deleted += this.OnResetSpecification;
                    }
                    this.OnSpecificationChanged(e);
                    this.OnPropertyChanged("Specification", e, _specificationReference);
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
                return base.ReferencedElements.Concat(new ReliabilityInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Reliabi" +
                            "lityInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MomFailureRate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MomFailureRateChanging;
        
        /// <summary>
        /// Gets fired when the MomFailureRate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MomFailureRateChanged;
        
        /// <summary>
        /// Gets fired before the MTTR property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MTTRChanging;
        
        /// <summary>
        /// Gets fired when the MTTR property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MTTRChanged;
        
        /// <summary>
        /// Gets fired before the Specification property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SpecificationChanging;
        
        /// <summary>
        /// Gets fired when the Specification property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SpecificationChanged;
        
        private static ITypedElement RetrieveMomFailureRateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ReliabilityInfo.ClassInstance)).Resolve("momFailureRate")));
        }
        
        /// <summary>
        /// Raises the MomFailureRateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMomFailureRateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MomFailureRateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MomFailureRateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMomFailureRateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MomFailureRateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveMTTRAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ReliabilityInfo.ClassInstance)).Resolve("mTTR")));
        }
        
        /// <summary>
        /// Raises the MTTRChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMTTRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MTTRChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MTTRChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMTTRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MTTRChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveAssetsReference()
        {
            return ((ITypedElement)(((ModelElement)(ReliabilityInfo.ClassInstance)).Resolve("Assets")));
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
        
        private static ITypedElement RetrieveSpecificationReference()
        {
            return ((ITypedElement)(((ModelElement)(ReliabilityInfo.ClassInstance)).Resolve("Specification")));
        }
        
        /// <summary>
        /// Raises the SpecificationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSpecificationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SpecificationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SpecificationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSpecificationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SpecificationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Specification property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSpecification(object sender, System.EventArgs eventArgs)
        {
            this.Specification = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MOMFAILURERATE"))
            {
                return this.MomFailureRate;
            }
            if ((attribute == "MTTR"))
            {
                return this.MTTR;
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
            if ((feature == "ASSETS"))
            {
                return this._assets;
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
            if ((feature == "SPECIFICATION"))
            {
                this.Specification = ((ISpecification)(value));
                return;
            }
            if ((feature == "MOMFAILURERATE"))
            {
                this.MomFailureRate = ((float)(value));
                return;
            }
            if ((feature == "MTTR"))
            {
                this.MTTR = ((float)(value));
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
            if ((attribute == "Specification"))
            {
                return new SpecificationProxy(this);
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
            if ((reference == "Specification"))
            {
                return new SpecificationProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Reliabi" +
                        "lityInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ReliabilityInfo class
        /// </summary>
        public class ReliabilityInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ReliabilityInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ReliabilityInfoReferencedElementsCollection(ReliabilityInfo parent)
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
                    count = (count + this._parent.Assets.Count);
                    if ((this._parent.Specification != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Assets.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.SpecificationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Assets.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.SpecificationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAsset assetsCasted = item.As<IAsset>();
                if ((assetsCasted != null))
                {
                    this._parent.Assets.Add(assetsCasted);
                }
                if ((this._parent.Specification == null))
                {
                    ISpecification specificationCasted = item.As<ISpecification>();
                    if ((specificationCasted != null))
                    {
                        this._parent.Specification = specificationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Assets.Clear();
                this._parent.Specification = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Assets.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Specification))
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
                if ((this._parent.Specification != null))
                {
                    array[arrayIndex] = this._parent.Specification;
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
                IAsset assetItem = item.As<IAsset>();
                if (((assetItem != null) 
                            && this._parent.Assets.Remove(assetItem)))
                {
                    return true;
                }
                if ((this._parent.Specification == item))
                {
                    this._parent.Specification = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Assets).Concat(this._parent.Specification).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the momFailureRate property
        /// </summary>
        private sealed class MomFailureRateProxy : ModelPropertyChange<IReliabilityInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MomFailureRateProxy(IReliabilityInfo modelElement) : 
                    base(modelElement, "momFailureRate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MomFailureRate;
                }
                set
                {
                    this.ModelElement.MomFailureRate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the mTTR property
        /// </summary>
        private sealed class MTTRProxy : ModelPropertyChange<IReliabilityInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MTTRProxy(IReliabilityInfo modelElement) : 
                    base(modelElement, "mTTR")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MTTR;
                }
                set
                {
                    this.ModelElement.MTTR = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Specification property
        /// </summary>
        private sealed class SpecificationProxy : ModelPropertyChange<IReliabilityInfo, ISpecification>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SpecificationProxy(IReliabilityInfo modelElement) : 
                    base(modelElement, "Specification")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISpecification Value
            {
                get
                {
                    return this.ModelElement.Specification;
                }
                set
                {
                    this.ModelElement.Specification = value;
                }
            }
        }
    }
}
