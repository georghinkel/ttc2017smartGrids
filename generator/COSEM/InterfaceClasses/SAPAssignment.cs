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
using TTC2017.SmartGrids.COSEM;
using TTC2017.SmartGrids.COSEM.Datatypes;

namespace TTC2017.SmartGrids.COSEM.InterfaceClasses
{
    
    
    /// <summary>
    /// The default implementation of the SAPAssignment class
    /// </summary>
    [XmlNamespaceAttribute("interface")]
    [XmlNamespacePrefixAttribute("inter")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
        "s/SAPAssignment")]
    public class SAPAssignment : Base, ISAPAssignment, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Ldnname property
        /// </summary>
        private ILogicalDeviceName _ldnname;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ldnname property
        /// </summary>
        [XmlElementNameAttribute("ldnname")]
        [XmlAttributeAttribute(true)]
        public virtual ILogicalDeviceName Ldnname
        {
            get
            {
                return this._ldnname;
            }
            set
            {
                if ((this._ldnname != value))
                {
                    ILogicalDeviceName old = this._ldnname;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLdnnameChanging(e);
                    this.OnPropertyChanging("Ldnname", e);
                    this._ldnname = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetLdnname;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetLdnname;
                    }
                    this.OnLdnnameChanged(e);
                    this.OnPropertyChanged("Ldnname", e);
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
                return base.ReferencedElements.Concat(new SAPAssignmentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                            "s/SAPAssignment")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Ldnname property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LdnnameChanging;
        
        /// <summary>
        /// Gets fired when the Ldnname property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LdnnameChanged;
        
        /// <summary>
        /// Raises the LdnnameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLdnnameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LdnnameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LdnnameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLdnnameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LdnnameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Ldnname property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLdnname(object sender, System.EventArgs eventArgs)
        {
            this.Ldnname = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "LDNNAME"))
            {
                this.Ldnname = ((ILogicalDeviceName)(value));
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
            if ((attribute == "Ldnname"))
            {
                return new LdnnameProxy(this);
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
            if ((reference == "Ldnname"))
            {
                return new LdnnameProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                        "s/SAPAssignment")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SAPAssignment class
        /// </summary>
        public class SAPAssignmentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SAPAssignment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SAPAssignmentReferencedElementsCollection(SAPAssignment parent)
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
                    if ((this._parent.Ldnname != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LdnnameChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LdnnameChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Ldnname == null))
                {
                    ILogicalDeviceName ldnnameCasted = item.As<ILogicalDeviceName>();
                    if ((ldnnameCasted != null))
                    {
                        this._parent.Ldnname = ldnnameCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Ldnname = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Ldnname))
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
                if ((this._parent.Ldnname != null))
                {
                    array[arrayIndex] = this._parent.Ldnname;
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
                if ((this._parent.Ldnname == item))
                {
                    this._parent.Ldnname = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Ldnname).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ldnname property
        /// </summary>
        private sealed class LdnnameProxy : ModelPropertyChange<ISAPAssignment, ILogicalDeviceName>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LdnnameProxy(ISAPAssignment modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ILogicalDeviceName Value
            {
                get
                {
                    return this.ModelElement.Ldnname;
                }
                set
                {
                    this.ModelElement.Ldnname = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LdnnameChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LdnnameChanged -= handler;
            }
        }
    }
}

