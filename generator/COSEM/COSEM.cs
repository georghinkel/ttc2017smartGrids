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
using TTC2017.SmartGrids.COSEM.COSEMObjects;

namespace TTC2017.SmartGrids.COSEM
{
    
    
    /// <summary>
    /// The default implementation of the COSEM class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem")]
    [XmlNamespacePrefixAttribute("cosem")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEM")]
    public partial class COSEM : ModelElement, ICOSEM, IModelElement
    {
        
        private static Lazy<ITypedElement> _physicalDeviceReference = new Lazy<ITypedElement>(RetrievePhysicalDeviceReference);
        
        /// <summary>
        /// The backing field for the PhysicalDevice property
        /// </summary>
        private ObservableCompositionOrderedSet<IPhysicalDevice> _physicalDevice;
        
        private static Lazy<ITypedElement> _logicalDeviceReference = new Lazy<ITypedElement>(RetrieveLogicalDeviceReference);
        
        /// <summary>
        /// The backing field for the LogicalDevice property
        /// </summary>
        private ObservableCompositionOrderedSet<ILogicalDevice> _logicalDevice;
        
        private static IClass _classInstance;
        
        public COSEM()
        {
            this._physicalDevice = new ObservableCompositionOrderedSet<IPhysicalDevice>(this);
            this._physicalDevice.CollectionChanging += this.PhysicalDeviceCollectionChanging;
            this._physicalDevice.CollectionChanged += this.PhysicalDeviceCollectionChanged;
            this._logicalDevice = new ObservableCompositionOrderedSet<ILogicalDevice>(this);
            this._logicalDevice.CollectionChanging += this.LogicalDeviceCollectionChanging;
            this._logicalDevice.CollectionChanged += this.LogicalDeviceCollectionChanged;
        }
        
        /// <summary>
        /// The PhysicalDevice property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IPhysicalDevice> PhysicalDevice
        {
            get
            {
                return this._physicalDevice;
            }
        }
        
        /// <summary>
        /// The LogicalDevice property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ILogicalDevice> LogicalDevice
        {
            get
            {
                return this._logicalDevice;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new COSEMChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new COSEMReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEM")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrievePhysicalDeviceReference()
        {
            return ((ITypedElement)(((ModelElement)(COSEM.ClassInstance)).Resolve("PhysicalDevice")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the PhysicalDevice property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PhysicalDeviceCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("PhysicalDevice", e, _physicalDeviceReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the PhysicalDevice property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PhysicalDeviceCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("PhysicalDevice", e, _physicalDeviceReference);
        }
        
        private static ITypedElement RetrieveLogicalDeviceReference()
        {
            return ((ITypedElement)(((ModelElement)(COSEM.ClassInstance)).Resolve("LogicalDevice")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LogicalDevice property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LogicalDeviceCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("LogicalDevice", e, _logicalDeviceReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LogicalDevice property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LogicalDeviceCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LogicalDevice", e, _logicalDeviceReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int physicalDeviceIndex = ModelHelper.IndexOfReference(this.PhysicalDevice, element);
            if ((physicalDeviceIndex != -1))
            {
                return ModelHelper.CreatePath("PhysicalDevice", physicalDeviceIndex);
            }
            int logicalDeviceIndex = ModelHelper.IndexOfReference(this.LogicalDevice, element);
            if ((logicalDeviceIndex != -1))
            {
                return ModelHelper.CreatePath("LogicalDevice", logicalDeviceIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "PHYSICALDEVICE"))
            {
                if ((index < this.PhysicalDevice.Count))
                {
                    return this.PhysicalDevice[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "LOGICALDEVICE"))
            {
                if ((index < this.LogicalDevice.Count))
                {
                    return this.LogicalDevice[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "PHYSICALDEVICE"))
            {
                return this._physicalDevice;
            }
            if ((feature == "LOGICALDEVICE"))
            {
                return this._logicalDevice;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._physicalDevice))
            {
                return "PhysicalDevice";
            }
            if ((container == this._logicalDevice))
            {
                return "LogicalDevice";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEM")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the COSEM class
        /// </summary>
        public class COSEMChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private COSEM _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public COSEMChildrenCollection(COSEM parent)
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
                    count = (count + this._parent.PhysicalDevice.Count);
                    count = (count + this._parent.LogicalDevice.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PhysicalDevice.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.LogicalDevice.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PhysicalDevice.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.LogicalDevice.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPhysicalDevice physicalDeviceCasted = item.As<IPhysicalDevice>();
                if ((physicalDeviceCasted != null))
                {
                    this._parent.PhysicalDevice.Add(physicalDeviceCasted);
                }
                ILogicalDevice logicalDeviceCasted = item.As<ILogicalDevice>();
                if ((logicalDeviceCasted != null))
                {
                    this._parent.LogicalDevice.Add(logicalDeviceCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PhysicalDevice.Clear();
                this._parent.LogicalDevice.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.PhysicalDevice.Contains(item))
                {
                    return true;
                }
                if (this._parent.LogicalDevice.Contains(item))
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
                IEnumerator<IModelElement> physicalDeviceEnumerator = this._parent.PhysicalDevice.GetEnumerator();
                try
                {
                    for (
                    ; physicalDeviceEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = physicalDeviceEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    physicalDeviceEnumerator.Dispose();
                }
                IEnumerator<IModelElement> logicalDeviceEnumerator = this._parent.LogicalDevice.GetEnumerator();
                try
                {
                    for (
                    ; logicalDeviceEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = logicalDeviceEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    logicalDeviceEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IPhysicalDevice physicalDeviceItem = item.As<IPhysicalDevice>();
                if (((physicalDeviceItem != null) 
                            && this._parent.PhysicalDevice.Remove(physicalDeviceItem)))
                {
                    return true;
                }
                ILogicalDevice logicalDeviceItem = item.As<ILogicalDevice>();
                if (((logicalDeviceItem != null) 
                            && this._parent.LogicalDevice.Remove(logicalDeviceItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PhysicalDevice).Concat(this._parent.LogicalDevice).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the COSEM class
        /// </summary>
        public class COSEMReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private COSEM _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public COSEMReferencedElementsCollection(COSEM parent)
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
                    count = (count + this._parent.PhysicalDevice.Count);
                    count = (count + this._parent.LogicalDevice.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PhysicalDevice.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.LogicalDevice.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PhysicalDevice.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.LogicalDevice.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPhysicalDevice physicalDeviceCasted = item.As<IPhysicalDevice>();
                if ((physicalDeviceCasted != null))
                {
                    this._parent.PhysicalDevice.Add(physicalDeviceCasted);
                }
                ILogicalDevice logicalDeviceCasted = item.As<ILogicalDevice>();
                if ((logicalDeviceCasted != null))
                {
                    this._parent.LogicalDevice.Add(logicalDeviceCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PhysicalDevice.Clear();
                this._parent.LogicalDevice.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.PhysicalDevice.Contains(item))
                {
                    return true;
                }
                if (this._parent.LogicalDevice.Contains(item))
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
                IEnumerator<IModelElement> physicalDeviceEnumerator = this._parent.PhysicalDevice.GetEnumerator();
                try
                {
                    for (
                    ; physicalDeviceEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = physicalDeviceEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    physicalDeviceEnumerator.Dispose();
                }
                IEnumerator<IModelElement> logicalDeviceEnumerator = this._parent.LogicalDevice.GetEnumerator();
                try
                {
                    for (
                    ; logicalDeviceEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = logicalDeviceEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    logicalDeviceEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IPhysicalDevice physicalDeviceItem = item.As<IPhysicalDevice>();
                if (((physicalDeviceItem != null) 
                            && this._parent.PhysicalDevice.Remove(physicalDeviceItem)))
                {
                    return true;
                }
                ILogicalDevice logicalDeviceItem = item.As<ILogicalDevice>();
                if (((logicalDeviceItem != null) 
                            && this._parent.LogicalDevice.Remove(logicalDeviceItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PhysicalDevice).Concat(this._parent.LogicalDevice).GetEnumerator();
            }
        }
    }
}

