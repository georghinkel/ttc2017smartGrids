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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The default implementation of the PulseConfig class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/PulseConfig")]
    public class PulseConfig : ModelElement, IPulseConfig, IModelElement
    {
        
        /// <summary>
        /// The backing field for the OnDur property
        /// </summary>
        private Nullable<int> _onDur;
        
        /// <summary>
        /// The backing field for the OffDur property
        /// </summary>
        private Nullable<int> _offDur;
        
        /// <summary>
        /// The backing field for the NumPls property
        /// </summary>
        private Nullable<int> _numPls;
        
        /// <summary>
        /// The backing field for the CmdQual property
        /// </summary>
        private IControlOutput _cmdQual;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The onDur property
        /// </summary>
        [XmlElementNameAttribute("onDur")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<int> OnDur
        {
            get
            {
                return this._onDur;
            }
            set
            {
                if ((this._onDur != value))
                {
                    Nullable<int> old = this._onDur;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOnDurChanging(e);
                    this.OnPropertyChanging("OnDur", e);
                    this._onDur = value;
                    this.OnOnDurChanged(e);
                    this.OnPropertyChanged("OnDur", e);
                }
            }
        }
        
        /// <summary>
        /// The offDur property
        /// </summary>
        [XmlElementNameAttribute("offDur")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<int> OffDur
        {
            get
            {
                return this._offDur;
            }
            set
            {
                if ((this._offDur != value))
                {
                    Nullable<int> old = this._offDur;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOffDurChanging(e);
                    this.OnPropertyChanging("OffDur", e);
                    this._offDur = value;
                    this.OnOffDurChanged(e);
                    this.OnPropertyChanged("OffDur", e);
                }
            }
        }
        
        /// <summary>
        /// The numPls property
        /// </summary>
        [XmlElementNameAttribute("numPls")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<int> NumPls
        {
            get
            {
                return this._numPls;
            }
            set
            {
                if ((this._numPls != value))
                {
                    Nullable<int> old = this._numPls;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNumPlsChanging(e);
                    this.OnPropertyChanging("NumPls", e);
                    this._numPls = value;
                    this.OnNumPlsChanged(e);
                    this.OnPropertyChanged("NumPls", e);
                }
            }
        }
        
        /// <summary>
        /// The cmdQual property
        /// </summary>
        [XmlElementNameAttribute("cmdQual")]
        [XmlAttributeAttribute(true)]
        public virtual IControlOutput CmdQual
        {
            get
            {
                return this._cmdQual;
            }
            set
            {
                if ((this._cmdQual != value))
                {
                    IControlOutput old = this._cmdQual;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCmdQualChanging(e);
                    this.OnPropertyChanging("CmdQual", e);
                    this._cmdQual = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetCmdQual;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetCmdQual;
                    }
                    this.OnCmdQualChanged(e);
                    this.OnPropertyChanged("CmdQual", e);
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
                return base.ReferencedElements.Concat(new PulseConfigReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                            "taclasses/PulseConfig")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OnDur property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OnDurChanging;
        
        /// <summary>
        /// Gets fired when the OnDur property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OnDurChanged;
        
        /// <summary>
        /// Gets fired before the OffDur property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OffDurChanging;
        
        /// <summary>
        /// Gets fired when the OffDur property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OffDurChanged;
        
        /// <summary>
        /// Gets fired before the NumPls property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NumPlsChanging;
        
        /// <summary>
        /// Gets fired when the NumPls property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NumPlsChanged;
        
        /// <summary>
        /// Gets fired before the CmdQual property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CmdQualChanging;
        
        /// <summary>
        /// Gets fired when the CmdQual property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CmdQualChanged;
        
        /// <summary>
        /// Raises the OnDurChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOnDurChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OnDurChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OnDurChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOnDurChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OnDurChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OffDurChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOffDurChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OffDurChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OffDurChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOffDurChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OffDurChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NumPlsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNumPlsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NumPlsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NumPlsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNumPlsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NumPlsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CmdQualChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCmdQualChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CmdQualChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CmdQualChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCmdQualChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CmdQualChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the CmdQual property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCmdQual(object sender, System.EventArgs eventArgs)
        {
            this.CmdQual = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ONDUR"))
            {
                return this.OnDur;
            }
            if ((attribute == "OFFDUR"))
            {
                return this.OffDur;
            }
            if ((attribute == "NUMPLS"))
            {
                return this.NumPls;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "CMDQUAL"))
            {
                this.CmdQual = ((IControlOutput)(value));
                return;
            }
            if ((feature == "ONDUR"))
            {
                this.OnDur = ((int)(value));
                return;
            }
            if ((feature == "OFFDUR"))
            {
                this.OffDur = ((int)(value));
                return;
            }
            if ((feature == "NUMPLS"))
            {
                this.NumPls = ((int)(value));
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
            if ((attribute == "CmdQual"))
            {
                return new CmdQualProxy(this);
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
            if ((reference == "CmdQual"))
            {
                return new CmdQualProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/PulseConfig")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PulseConfig class
        /// </summary>
        public class PulseConfigReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PulseConfig _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PulseConfigReferencedElementsCollection(PulseConfig parent)
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
                    if ((this._parent.CmdQual != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CmdQualChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CmdQualChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.CmdQual == null))
                {
                    IControlOutput cmdQualCasted = item.As<IControlOutput>();
                    if ((cmdQualCasted != null))
                    {
                        this._parent.CmdQual = cmdQualCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CmdQual = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.CmdQual))
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
                if ((this._parent.CmdQual != null))
                {
                    array[arrayIndex] = this._parent.CmdQual;
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
                if ((this._parent.CmdQual == item))
                {
                    this._parent.CmdQual = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CmdQual).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the onDur property
        /// </summary>
        private sealed class OnDurProxy : ModelPropertyChange<IPulseConfig, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OnDurProxy(IPulseConfig modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.OnDur;
                }
                set
                {
                    this.ModelElement.OnDur = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OnDurChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OnDurChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the offDur property
        /// </summary>
        private sealed class OffDurProxy : ModelPropertyChange<IPulseConfig, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OffDurProxy(IPulseConfig modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.OffDur;
                }
                set
                {
                    this.ModelElement.OffDur = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OffDurChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OffDurChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the numPls property
        /// </summary>
        private sealed class NumPlsProxy : ModelPropertyChange<IPulseConfig, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NumPlsProxy(IPulseConfig modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.NumPls;
                }
                set
                {
                    this.ModelElement.NumPls = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.NumPlsChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.NumPlsChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the cmdQual property
        /// </summary>
        private sealed class CmdQualProxy : ModelPropertyChange<IPulseConfig, IControlOutput>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CmdQualProxy(IPulseConfig modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IControlOutput Value
            {
                get
                {
                    return this.ModelElement.CmdQual;
                }
                set
                {
                    this.ModelElement.CmdQual = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CmdQualChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CmdQualChanged -= handler;
            }
        }
    }
}

