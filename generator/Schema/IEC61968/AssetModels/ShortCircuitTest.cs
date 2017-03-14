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
    /// The default implementation of the ShortCircuitTest class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#AssetModels")]
    [XmlNamespacePrefixAttribute("cimAssetModels")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/ShortCircuitTest")]
    [DebuggerDisplayAttribute("ShortCircuitTest {UUID}")]
    public class ShortCircuitTest : DistributionWindingTest, IShortCircuitTest, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LoadLoss property
        /// </summary>
        private float _loadLoss;
        
        /// <summary>
        /// The backing field for the LoadLossZero property
        /// </summary>
        private float _loadLossZero;
        
        /// <summary>
        /// The backing field for the LeakageImpedance property
        /// </summary>
        private float _leakageImpedance;
        
        /// <summary>
        /// The backing field for the LeakageImpedanceZero property
        /// </summary>
        private float _leakageImpedanceZero;
        
        /// <summary>
        /// The backing field for the ShortedWindingSpecs property
        /// </summary>
        private ShortCircuitTestShortedWindingSpecsCollection _shortedWindingSpecs;
        
        private static IClass _classInstance;
        
        public ShortCircuitTest()
        {
            this._shortedWindingSpecs = new ShortCircuitTestShortedWindingSpecsCollection(this);
            this._shortedWindingSpecs.CollectionChanging += this.ShortedWindingSpecsCollectionChanging;
            this._shortedWindingSpecs.CollectionChanged += this.ShortedWindingSpecsCollectionChanged;
        }
        
        /// <summary>
        /// The loadLoss property
        /// </summary>
        [XmlElementNameAttribute("loadLoss")]
        [XmlAttributeAttribute(true)]
        public virtual float LoadLoss
        {
            get
            {
                return this._loadLoss;
            }
            set
            {
                if ((this._loadLoss != value))
                {
                    float old = this._loadLoss;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLoadLossChanging(e);
                    this.OnPropertyChanging("LoadLoss", e);
                    this._loadLoss = value;
                    this.OnLoadLossChanged(e);
                    this.OnPropertyChanged("LoadLoss", e);
                }
            }
        }
        
        /// <summary>
        /// The loadLossZero property
        /// </summary>
        [XmlElementNameAttribute("loadLossZero")]
        [XmlAttributeAttribute(true)]
        public virtual float LoadLossZero
        {
            get
            {
                return this._loadLossZero;
            }
            set
            {
                if ((this._loadLossZero != value))
                {
                    float old = this._loadLossZero;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLoadLossZeroChanging(e);
                    this.OnPropertyChanging("LoadLossZero", e);
                    this._loadLossZero = value;
                    this.OnLoadLossZeroChanged(e);
                    this.OnPropertyChanged("LoadLossZero", e);
                }
            }
        }
        
        /// <summary>
        /// The leakageImpedance property
        /// </summary>
        [XmlElementNameAttribute("leakageImpedance")]
        [XmlAttributeAttribute(true)]
        public virtual float LeakageImpedance
        {
            get
            {
                return this._leakageImpedance;
            }
            set
            {
                if ((this._leakageImpedance != value))
                {
                    float old = this._leakageImpedance;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLeakageImpedanceChanging(e);
                    this.OnPropertyChanging("LeakageImpedance", e);
                    this._leakageImpedance = value;
                    this.OnLeakageImpedanceChanged(e);
                    this.OnPropertyChanged("LeakageImpedance", e);
                }
            }
        }
        
        /// <summary>
        /// The leakageImpedanceZero property
        /// </summary>
        [XmlElementNameAttribute("leakageImpedanceZero")]
        [XmlAttributeAttribute(true)]
        public virtual float LeakageImpedanceZero
        {
            get
            {
                return this._leakageImpedanceZero;
            }
            set
            {
                if ((this._leakageImpedanceZero != value))
                {
                    float old = this._leakageImpedanceZero;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLeakageImpedanceZeroChanging(e);
                    this.OnPropertyChanging("LeakageImpedanceZero", e);
                    this._leakageImpedanceZero = value;
                    this.OnLeakageImpedanceZeroChanged(e);
                    this.OnPropertyChanged("LeakageImpedanceZero", e);
                }
            }
        }
        
        /// <summary>
        /// The ShortedWindingSpecs property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ShortCircuitTests")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IToWindingSpec> ShortedWindingSpecs
        {
            get
            {
                return this._shortedWindingSpecs;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ShortCircuitTestReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/ShortCircuitTest")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LoadLoss property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoadLossChanging;
        
        /// <summary>
        /// Gets fired when the LoadLoss property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoadLossChanged;
        
        /// <summary>
        /// Gets fired before the LoadLossZero property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoadLossZeroChanging;
        
        /// <summary>
        /// Gets fired when the LoadLossZero property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoadLossZeroChanged;
        
        /// <summary>
        /// Gets fired before the LeakageImpedance property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeakageImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the LeakageImpedance property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeakageImpedanceChanged;
        
        /// <summary>
        /// Gets fired before the LeakageImpedanceZero property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeakageImpedanceZeroChanging;
        
        /// <summary>
        /// Gets fired when the LeakageImpedanceZero property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeakageImpedanceZeroChanged;
        
        /// <summary>
        /// Raises the LoadLossChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoadLossChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoadLossChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LoadLossChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoadLossChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoadLossChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LoadLossZeroChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoadLossZeroChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoadLossZeroChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LoadLossZeroChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoadLossZeroChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoadLossZeroChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeakageImpedanceChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeakageImpedanceChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeakageImpedanceChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeakageImpedanceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeakageImpedanceChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeakageImpedanceChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeakageImpedanceZeroChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeakageImpedanceZeroChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeakageImpedanceZeroChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeakageImpedanceZeroChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeakageImpedanceZeroChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeakageImpedanceZeroChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ShortedWindingSpecs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ShortedWindingSpecsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ShortedWindingSpecs", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ShortedWindingSpecs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ShortedWindingSpecsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ShortedWindingSpecs", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "LOADLOSS"))
            {
                return this.LoadLoss;
            }
            if ((attribute == "LOADLOSSZERO"))
            {
                return this.LoadLossZero;
            }
            if ((attribute == "LEAKAGEIMPEDANCE"))
            {
                return this.LeakageImpedance;
            }
            if ((attribute == "LEAKAGEIMPEDANCEZERO"))
            {
                return this.LeakageImpedanceZero;
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
            if ((feature == "SHORTEDWINDINGSPECS"))
            {
                return this._shortedWindingSpecs;
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
            if ((feature == "LOADLOSS"))
            {
                this.LoadLoss = ((float)(value));
                return;
            }
            if ((feature == "LOADLOSSZERO"))
            {
                this.LoadLossZero = ((float)(value));
                return;
            }
            if ((feature == "LEAKAGEIMPEDANCE"))
            {
                this.LeakageImpedance = ((float)(value));
                return;
            }
            if ((feature == "LEAKAGEIMPEDANCEZERO"))
            {
                this.LeakageImpedanceZero = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/ShortCircuitTest")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ShortCircuitTest class
        /// </summary>
        public class ShortCircuitTestReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ShortCircuitTest _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ShortCircuitTestReferencedElementsCollection(ShortCircuitTest parent)
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
                    count = (count + this._parent.ShortedWindingSpecs.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ShortedWindingSpecs.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ShortedWindingSpecs.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IToWindingSpec shortedWindingSpecsCasted = item.As<IToWindingSpec>();
                if ((shortedWindingSpecsCasted != null))
                {
                    this._parent.ShortedWindingSpecs.Add(shortedWindingSpecsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ShortedWindingSpecs.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ShortedWindingSpecs.Contains(item))
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
                IEnumerator<IModelElement> shortedWindingSpecsEnumerator = this._parent.ShortedWindingSpecs.GetEnumerator();
                try
                {
                    for (
                    ; shortedWindingSpecsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = shortedWindingSpecsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    shortedWindingSpecsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IToWindingSpec toWindingSpecItem = item.As<IToWindingSpec>();
                if (((toWindingSpecItem != null) 
                            && this._parent.ShortedWindingSpecs.Remove(toWindingSpecItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ShortedWindingSpecs).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the loadLoss property
        /// </summary>
        private sealed class LoadLossProxy : ModelPropertyChange<IShortCircuitTest, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LoadLossProxy(IShortCircuitTest modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LoadLoss;
                }
                set
                {
                    this.ModelElement.LoadLoss = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LoadLossChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LoadLossChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the loadLossZero property
        /// </summary>
        private sealed class LoadLossZeroProxy : ModelPropertyChange<IShortCircuitTest, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LoadLossZeroProxy(IShortCircuitTest modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LoadLossZero;
                }
                set
                {
                    this.ModelElement.LoadLossZero = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LoadLossZeroChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LoadLossZeroChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the leakageImpedance property
        /// </summary>
        private sealed class LeakageImpedanceProxy : ModelPropertyChange<IShortCircuitTest, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LeakageImpedanceProxy(IShortCircuitTest modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LeakageImpedance;
                }
                set
                {
                    this.ModelElement.LeakageImpedance = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeakageImpedanceChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeakageImpedanceChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the leakageImpedanceZero property
        /// </summary>
        private sealed class LeakageImpedanceZeroProxy : ModelPropertyChange<IShortCircuitTest, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LeakageImpedanceZeroProxy(IShortCircuitTest modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LeakageImpedanceZero;
                }
                set
                {
                    this.ModelElement.LeakageImpedanceZero = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeakageImpedanceZeroChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeakageImpedanceZeroChanged -= handler;
            }
        }
    }
}

