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
    /// The default implementation of the TransformerBank class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#WiresExt")]
    [XmlNamespacePrefixAttribute("cimWiresExt")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/TransformerBank")]
    [DebuggerDisplayAttribute("TransformerBank {UUID}")]
    public class TransformerBank : Equipment, ITransformerBank, IModelElement
    {
        
        /// <summary>
        /// The backing field for the VectorGroup property
        /// </summary>
        private string _vectorGroup;
        
        /// <summary>
        /// The backing field for the Transformers property
        /// </summary>
        private TransformerBankTransformersCollection _transformers;
        
        private static IClass _classInstance;
        
        public TransformerBank()
        {
            this._transformers = new TransformerBankTransformersCollection(this);
            this._transformers.CollectionChanging += this.TransformersCollectionChanging;
            this._transformers.CollectionChanged += this.TransformersCollectionChanged;
        }
        
        /// <summary>
        /// The vectorGroup property
        /// </summary>
        [XmlElementNameAttribute("vectorGroup")]
        [XmlAttributeAttribute(true)]
        public virtual string VectorGroup
        {
            get
            {
                return this._vectorGroup;
            }
            set
            {
                if ((this._vectorGroup != value))
                {
                    string old = this._vectorGroup;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVectorGroupChanging(e);
                    this.OnPropertyChanging("VectorGroup", e);
                    this._vectorGroup = value;
                    this.OnVectorGroupChanged(e);
                    this.OnPropertyChanged("VectorGroup", e);
                }
            }
        }
        
        /// <summary>
        /// The Transformers property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerBank")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDistributionTransformer> Transformers
        {
            get
            {
                return this._transformers;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TransformerBankReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/TransformerBank")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the VectorGroup property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VectorGroupChanging;
        
        /// <summary>
        /// Gets fired when the VectorGroup property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VectorGroupChanged;
        
        /// <summary>
        /// Raises the VectorGroupChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVectorGroupChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VectorGroupChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VectorGroupChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVectorGroupChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VectorGroupChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Transformers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformersCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Transformers", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Transformers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformersCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Transformers", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VECTORGROUP"))
            {
                return this.VectorGroup;
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
            if ((feature == "TRANSFORMERS"))
            {
                return this._transformers;
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
            if ((feature == "VECTORGROUP"))
            {
                this.VectorGroup = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/TransformerBank")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransformerBank class
        /// </summary>
        public class TransformerBankReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransformerBank _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransformerBankReferencedElementsCollection(TransformerBank parent)
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
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Transformers.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Transformers.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
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
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Transformers.Clear();
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
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Transformers).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the vectorGroup property
        /// </summary>
        private sealed class VectorGroupProxy : ModelPropertyChange<ITransformerBank, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VectorGroupProxy(ITransformerBank modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.VectorGroup;
                }
                set
                {
                    this.ModelElement.VectorGroup = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.VectorGroupChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.VectorGroupChanged -= handler;
            }
        }
    }
}

