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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The default implementation of the WorkCostSummary class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/WorkCostS" +
        "ummary")]
    [DebuggerDisplayAttribute("WorkCostSummary {UUID}")]
    public class WorkCostSummary : Document, IWorkCostSummary, IModelElement
    {
        
        /// <summary>
        /// The backing field for the WorkCostDetail property
        /// </summary>
        private IWorkCostDetail _workCostDetail;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The WorkCostDetail property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WorkCostSummary")]
        public virtual IWorkCostDetail WorkCostDetail
        {
            get
            {
                return this._workCostDetail;
            }
            set
            {
                if ((this._workCostDetail != value))
                {
                    IWorkCostDetail old = this._workCostDetail;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWorkCostDetailChanging(e);
                    this.OnPropertyChanging("WorkCostDetail", e);
                    this._workCostDetail = value;
                    if ((old != null))
                    {
                        old.WorkCostSummary = null;
                        old.Deleted -= this.OnResetWorkCostDetail;
                    }
                    if ((value != null))
                    {
                        value.WorkCostSummary = this;
                        value.Deleted += this.OnResetWorkCostDetail;
                    }
                    this.OnWorkCostDetailChanged(e);
                    this.OnPropertyChanged("WorkCostDetail", e);
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
                return base.ReferencedElements.Concat(new WorkCostSummaryReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/WorkCostS" +
                            "ummary")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the WorkCostDetail property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkCostDetailChanging;
        
        /// <summary>
        /// Gets fired when the WorkCostDetail property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkCostDetailChanged;
        
        /// <summary>
        /// Raises the WorkCostDetailChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkCostDetailChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkCostDetailChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WorkCostDetailChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkCostDetailChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkCostDetailChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the WorkCostDetail property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetWorkCostDetail(object sender, System.EventArgs eventArgs)
        {
            this.WorkCostDetail = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "WORKCOSTDETAIL"))
            {
                this.WorkCostDetail = ((IWorkCostDetail)(value));
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
            if ((attribute == "WorkCostDetail"))
            {
                return new WorkCostDetailProxy(this);
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
            if ((reference == "WorkCostDetail"))
            {
                return new WorkCostDetailProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/WorkCostS" +
                        "ummary")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the WorkCostSummary class
        /// </summary>
        public class WorkCostSummaryReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private WorkCostSummary _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WorkCostSummaryReferencedElementsCollection(WorkCostSummary parent)
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
                    if ((this._parent.WorkCostDetail != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.WorkCostDetailChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.WorkCostDetailChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.WorkCostDetail == null))
                {
                    IWorkCostDetail workCostDetailCasted = item.As<IWorkCostDetail>();
                    if ((workCostDetailCasted != null))
                    {
                        this._parent.WorkCostDetail = workCostDetailCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.WorkCostDetail = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.WorkCostDetail))
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
                if ((this._parent.WorkCostDetail != null))
                {
                    array[arrayIndex] = this._parent.WorkCostDetail;
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
                if ((this._parent.WorkCostDetail == item))
                {
                    this._parent.WorkCostDetail = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.WorkCostDetail).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the WorkCostDetail property
        /// </summary>
        private sealed class WorkCostDetailProxy : ModelPropertyChange<IWorkCostSummary, IWorkCostDetail>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WorkCostDetailProxy(IWorkCostSummary modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IWorkCostDetail Value
            {
                get
                {
                    return this.ModelElement.WorkCostDetail;
                }
                set
                {
                    this.ModelElement.WorkCostDetail = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.WorkCostDetailChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.WorkCostDetailChanged -= handler;
            }
        }
    }
}

