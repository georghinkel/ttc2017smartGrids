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
    /// The default implementation of the SubLoadArea class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#LoadModel")]
    [XmlNamespacePrefixAttribute("cimLoadModel")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/SubLoadArea")]
    [DebuggerDisplayAttribute("SubLoadArea {UUID}")]
    public class SubLoadArea : EnergyArea, ISubLoadArea, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LoadArea property
        /// </summary>
        private ILoadArea _loadArea;
        
        /// <summary>
        /// The backing field for the LoadGroups property
        /// </summary>
        private SubLoadAreaLoadGroupsCollection _loadGroups;
        
        private static IClass _classInstance;
        
        public SubLoadArea()
        {
            this._loadGroups = new SubLoadAreaLoadGroupsCollection(this);
            this._loadGroups.CollectionChanging += this.LoadGroupsCollectionChanging;
            this._loadGroups.CollectionChanged += this.LoadGroupsCollectionChanged;
        }
        
        /// <summary>
        /// The LoadArea property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SubLoadAreas")]
        public virtual ILoadArea LoadArea
        {
            get
            {
                return this._loadArea;
            }
            set
            {
                if ((this._loadArea != value))
                {
                    ILoadArea old = this._loadArea;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLoadAreaChanging(e);
                    this.OnPropertyChanging("LoadArea", e);
                    this._loadArea = value;
                    if ((old != null))
                    {
                        old.SubLoadAreas.Remove(this);
                        old.Deleted -= this.OnResetLoadArea;
                    }
                    if ((value != null))
                    {
                        value.SubLoadAreas.Add(this);
                        value.Deleted += this.OnResetLoadArea;
                    }
                    this.OnLoadAreaChanged(e);
                    this.OnPropertyChanged("LoadArea", e);
                }
            }
        }
        
        /// <summary>
        /// The LoadGroups property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SubLoadArea")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ILoadGroup> LoadGroups
        {
            get
            {
                return this._loadGroups;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SubLoadAreaReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/SubLoadArea")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LoadArea property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoadAreaChanging;
        
        /// <summary>
        /// Gets fired when the LoadArea property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoadAreaChanged;
        
        /// <summary>
        /// Raises the LoadAreaChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoadAreaChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoadAreaChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LoadAreaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoadAreaChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoadAreaChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the LoadArea property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLoadArea(object sender, System.EventArgs eventArgs)
        {
            this.LoadArea = null;
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LoadGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LoadGroupsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("LoadGroups", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LoadGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LoadGroupsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LoadGroups", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LOADGROUPS"))
            {
                return this._loadGroups;
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
            if ((feature == "LOADAREA"))
            {
                this.LoadArea = ((ILoadArea)(value));
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
            if ((attribute == "LoadArea"))
            {
                return new LoadAreaProxy(this);
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
            if ((reference == "LoadArea"))
            {
                return new LoadAreaProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/SubLoadArea")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SubLoadArea class
        /// </summary>
        public class SubLoadAreaReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SubLoadArea _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SubLoadAreaReferencedElementsCollection(SubLoadArea parent)
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
                    if ((this._parent.LoadArea != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.LoadGroups.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LoadAreaChanged += this.PropagateValueChanges;
                this._parent.LoadGroups.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LoadAreaChanged -= this.PropagateValueChanges;
                this._parent.LoadGroups.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.LoadArea == null))
                {
                    ILoadArea loadAreaCasted = item.As<ILoadArea>();
                    if ((loadAreaCasted != null))
                    {
                        this._parent.LoadArea = loadAreaCasted;
                        return;
                    }
                }
                ILoadGroup loadGroupsCasted = item.As<ILoadGroup>();
                if ((loadGroupsCasted != null))
                {
                    this._parent.LoadGroups.Add(loadGroupsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LoadArea = null;
                this._parent.LoadGroups.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.LoadArea))
                {
                    return true;
                }
                if (this._parent.LoadGroups.Contains(item))
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
                if ((this._parent.LoadArea != null))
                {
                    array[arrayIndex] = this._parent.LoadArea;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> loadGroupsEnumerator = this._parent.LoadGroups.GetEnumerator();
                try
                {
                    for (
                    ; loadGroupsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = loadGroupsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    loadGroupsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.LoadArea == item))
                {
                    this._parent.LoadArea = null;
                    return true;
                }
                ILoadGroup loadGroupItem = item.As<ILoadGroup>();
                if (((loadGroupItem != null) 
                            && this._parent.LoadGroups.Remove(loadGroupItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LoadArea).Concat(this._parent.LoadGroups).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LoadArea property
        /// </summary>
        private sealed class LoadAreaProxy : ModelPropertyChange<ISubLoadArea, ILoadArea>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LoadAreaProxy(ISubLoadArea modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ILoadArea Value
            {
                get
                {
                    return this.ModelElement.LoadArea;
                }
                set
                {
                    this.ModelElement.LoadArea = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LoadAreaChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LoadAreaChanged -= handler;
            }
        }
    }
}

