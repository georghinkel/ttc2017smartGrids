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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The default implementation of the PsrList class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Core")]
    [XmlNamespacePrefixAttribute("cimCore")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/PsrList")]
    [DebuggerDisplayAttribute("PsrList {UUID}")]
    public partial class PsrList : IdentifiedObject, IPsrList, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TypePSRList property
        /// </summary>
        private string _typePSRList;
        
        private static Lazy<ITypedElement> _typePSRListAttribute = new Lazy<ITypedElement>(RetrieveTypePSRListAttribute);
        
        private static Lazy<ITypedElement> _powerSystemResourcesReference = new Lazy<ITypedElement>(RetrievePowerSystemResourcesReference);
        
        /// <summary>
        /// The backing field for the PowerSystemResources property
        /// </summary>
        private PsrListPowerSystemResourcesCollection _powerSystemResources;
        
        private static IClass _classInstance;
        
        public PsrList()
        {
            this._powerSystemResources = new PsrListPowerSystemResourcesCollection(this);
            this._powerSystemResources.CollectionChanging += this.PowerSystemResourcesCollectionChanging;
            this._powerSystemResources.CollectionChanged += this.PowerSystemResourcesCollectionChanged;
        }
        
        /// <summary>
        /// The typePSRList property
        /// </summary>
        [XmlElementNameAttribute("typePSRList")]
        [XmlAttributeAttribute(true)]
        public virtual string TypePSRList
        {
            get
            {
                return this._typePSRList;
            }
            set
            {
                if ((this._typePSRList != value))
                {
                    string old = this._typePSRList;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypePSRListChanging(e);
                    this.OnPropertyChanging("TypePSRList", e, _typePSRListAttribute);
                    this._typePSRList = value;
                    this.OnTypePSRListChanged(e);
                    this.OnPropertyChanged("TypePSRList", e, _typePSRListAttribute);
                }
            }
        }
        
        /// <summary>
        /// The PowerSystemResources property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PsrLists")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IPowerSystemResource> PowerSystemResources
        {
            get
            {
                return this._powerSystemResources;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new PsrListReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/PsrList")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TypePSRList property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypePSRListChanging;
        
        /// <summary>
        /// Gets fired when the TypePSRList property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypePSRListChanged;
        
        private static ITypedElement RetrieveTypePSRListAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PsrList.ClassInstance)).Resolve("typePSRList")));
        }
        
        /// <summary>
        /// Raises the TypePSRListChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypePSRListChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypePSRListChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypePSRListChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypePSRListChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypePSRListChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePowerSystemResourcesReference()
        {
            return ((ITypedElement)(((ModelElement)(PsrList.ClassInstance)).Resolve("PowerSystemResources")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the PowerSystemResources property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PowerSystemResourcesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("PowerSystemResources", e, _powerSystemResourcesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the PowerSystemResources property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PowerSystemResourcesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("PowerSystemResources", e, _powerSystemResourcesReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TYPEPSRLIST"))
            {
                return this.TypePSRList;
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
            if ((feature == "POWERSYSTEMRESOURCES"))
            {
                return this._powerSystemResources;
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
            if ((feature == "TYPEPSRLIST"))
            {
                this.TypePSRList = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/PsrList")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PsrList class
        /// </summary>
        public class PsrListReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PsrList _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PsrListReferencedElementsCollection(PsrList parent)
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
                    count = (count + this._parent.PowerSystemResources.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PowerSystemResources.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PowerSystemResources.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPowerSystemResource powerSystemResourcesCasted = item.As<IPowerSystemResource>();
                if ((powerSystemResourcesCasted != null))
                {
                    this._parent.PowerSystemResources.Add(powerSystemResourcesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PowerSystemResources.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.PowerSystemResources.Contains(item))
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
                IEnumerator<IModelElement> powerSystemResourcesEnumerator = this._parent.PowerSystemResources.GetEnumerator();
                try
                {
                    for (
                    ; powerSystemResourcesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = powerSystemResourcesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    powerSystemResourcesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IPowerSystemResource powerSystemResourceItem = item.As<IPowerSystemResource>();
                if (((powerSystemResourceItem != null) 
                            && this._parent.PowerSystemResources.Remove(powerSystemResourceItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PowerSystemResources).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the typePSRList property
        /// </summary>
        private sealed class TypePSRListProxy : ModelPropertyChange<IPsrList, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypePSRListProxy(IPsrList modelElement) : 
                    base(modelElement, "typePSRList")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.TypePSRList;
                }
                set
                {
                    this.ModelElement.TypePSRList = value;
                }
            }
        }
    }
}

