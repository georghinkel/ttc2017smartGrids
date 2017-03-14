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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The default implementation of the ResourceGroupReq class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "ResourceGroupReq")]
    [DebuggerDisplayAttribute("ResourceGroupReq {UUID}")]
    public class ResourceGroupReq : IdentifiedObject, IResourceGroupReq, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceGroup property
        /// </summary>
        private IResourceGroup _resourceGroup;
        
        /// <summary>
        /// The backing field for the RTOs property
        /// </summary>
        private ResourceGroupReqRTOsCollection _rTOs;
        
        private static IClass _classInstance;
        
        public ResourceGroupReq()
        {
            this._rTOs = new ResourceGroupReqRTOsCollection(this);
            this._rTOs.CollectionChanging += this.RTOsCollectionChanging;
            this._rTOs.CollectionChanged += this.RTOsCollectionChanged;
        }
        
        /// <summary>
        /// The ResourceGroup property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ResourceGroupReqs")]
        public virtual IResourceGroup ResourceGroup
        {
            get
            {
                return this._resourceGroup;
            }
            set
            {
                if ((this._resourceGroup != value))
                {
                    IResourceGroup old = this._resourceGroup;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnResourceGroupChanging(e);
                    this.OnPropertyChanging("ResourceGroup", e);
                    this._resourceGroup = value;
                    if ((old != null))
                    {
                        old.ResourceGroupReqs.Remove(this);
                        old.Deleted -= this.OnResetResourceGroup;
                    }
                    if ((value != null))
                    {
                        value.ResourceGroupReqs.Add(this);
                        value.Deleted += this.OnResetResourceGroup;
                    }
                    this.OnResourceGroupChanged(e);
                    this.OnPropertyChanged("ResourceGroup", e);
                }
            }
        }
        
        /// <summary>
        /// The RTOs property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ResourceGroupReqs")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IRTO> RTOs
        {
            get
            {
                return this._rTOs;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceGroupReqReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                            "ResourceGroupReq")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ResourceGroup property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ResourceGroupChanging;
        
        /// <summary>
        /// Gets fired when the ResourceGroup property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ResourceGroupChanged;
        
        /// <summary>
        /// Raises the ResourceGroupChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceGroupChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ResourceGroupChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ResourceGroupChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceGroupChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ResourceGroupChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ResourceGroup property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetResourceGroup(object sender, System.EventArgs eventArgs)
        {
            this.ResourceGroup = null;
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the RTOs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RTOsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("RTOs", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the RTOs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RTOsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RTOs", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RTOS"))
            {
                return this._rTOs;
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
            if ((feature == "RESOURCEGROUP"))
            {
                this.ResourceGroup = ((IResourceGroup)(value));
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
            if ((attribute == "ResourceGroup"))
            {
                return new ResourceGroupProxy(this);
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
            if ((reference == "ResourceGroup"))
            {
                return new ResourceGroupProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                        "ResourceGroupReq")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceGroupReq class
        /// </summary>
        public class ResourceGroupReqReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceGroupReq _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceGroupReqReferencedElementsCollection(ResourceGroupReq parent)
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
                    if ((this._parent.ResourceGroup != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.RTOs.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceGroupChanged += this.PropagateValueChanges;
                this._parent.RTOs.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceGroupChanged -= this.PropagateValueChanges;
                this._parent.RTOs.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ResourceGroup == null))
                {
                    IResourceGroup resourceGroupCasted = item.As<IResourceGroup>();
                    if ((resourceGroupCasted != null))
                    {
                        this._parent.ResourceGroup = resourceGroupCasted;
                        return;
                    }
                }
                IRTO rTOsCasted = item.As<IRTO>();
                if ((rTOsCasted != null))
                {
                    this._parent.RTOs.Add(rTOsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceGroup = null;
                this._parent.RTOs.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ResourceGroup))
                {
                    return true;
                }
                if (this._parent.RTOs.Contains(item))
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
                if ((this._parent.ResourceGroup != null))
                {
                    array[arrayIndex] = this._parent.ResourceGroup;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> rTOsEnumerator = this._parent.RTOs.GetEnumerator();
                try
                {
                    for (
                    ; rTOsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = rTOsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    rTOsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ResourceGroup == item))
                {
                    this._parent.ResourceGroup = null;
                    return true;
                }
                IRTO rTOItem = item.As<IRTO>();
                if (((rTOItem != null) 
                            && this._parent.RTOs.Remove(rTOItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceGroup).Concat(this._parent.RTOs).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ResourceGroup property
        /// </summary>
        private sealed class ResourceGroupProxy : ModelPropertyChange<IResourceGroupReq, IResourceGroup>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceGroupProxy(IResourceGroupReq modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceGroup Value
            {
                get
                {
                    return this.ModelElement.ResourceGroup;
                }
                set
                {
                    this.ModelElement.ResourceGroup = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceGroupChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceGroupChanged -= handler;
            }
        }
    }
}

