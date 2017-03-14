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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.Enumerations;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupM
{
    
    
    /// <summary>
    /// The default implementation of the MDIF class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pM")]
    [XmlNamespacePrefixAttribute("groupm")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupM/MDIF")]
    public class MDIF : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupM.GroupM, IMDIF, IModelElement
    {
        
        /// <summary>
        /// The backing field for the OpARem property
        /// </summary>
        private IWYE _opARem;
        
        /// <summary>
        /// The backing field for the Amp1 property
        /// </summary>
        private ISAV _amp1;
        
        /// <summary>
        /// The backing field for the Amp2 property
        /// </summary>
        private ISAV _amp2;
        
        /// <summary>
        /// The backing field for the Amp3 property
        /// </summary>
        private ISAV _amp3;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The OpARem property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IWYE OpARem
        {
            get
            {
                return this._opARem;
            }
            set
            {
                if ((this._opARem != value))
                {
                    IWYE old = this._opARem;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpARemChanging(e);
                    this.OnPropertyChanging("OpARem", e);
                    this._opARem = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOpARem;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOpARem;
                    }
                    this.OnOpARemChanged(e);
                    this.OnPropertyChanged("OpARem", e);
                }
            }
        }
        
        /// <summary>
        /// The Amp1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISAV Amp1
        {
            get
            {
                return this._amp1;
            }
            set
            {
                if ((this._amp1 != value))
                {
                    ISAV old = this._amp1;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAmp1Changing(e);
                    this.OnPropertyChanging("Amp1", e);
                    this._amp1 = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAmp1;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAmp1;
                    }
                    this.OnAmp1Changed(e);
                    this.OnPropertyChanged("Amp1", e);
                }
            }
        }
        
        /// <summary>
        /// The Amp2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISAV Amp2
        {
            get
            {
                return this._amp2;
            }
            set
            {
                if ((this._amp2 != value))
                {
                    ISAV old = this._amp2;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAmp2Changing(e);
                    this.OnPropertyChanging("Amp2", e);
                    this._amp2 = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAmp2;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAmp2;
                    }
                    this.OnAmp2Changed(e);
                    this.OnPropertyChanged("Amp2", e);
                }
            }
        }
        
        /// <summary>
        /// The Amp3 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISAV Amp3
        {
            get
            {
                return this._amp3;
            }
            set
            {
                if ((this._amp3 != value))
                {
                    ISAV old = this._amp3;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAmp3Changing(e);
                    this.OnPropertyChanging("Amp3", e);
                    this._amp3 = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAmp3;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAmp3;
                    }
                    this.OnAmp3Changed(e);
                    this.OnPropertyChanged("Amp3", e);
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
                return base.ReferencedElements.Concat(new MDIFReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                            "Nodes/LNGroupM/MDIF")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OpARem property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpARemChanging;
        
        /// <summary>
        /// Gets fired when the OpARem property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpARemChanged;
        
        /// <summary>
        /// Gets fired before the Amp1 property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Amp1Changing;
        
        /// <summary>
        /// Gets fired when the Amp1 property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Amp1Changed;
        
        /// <summary>
        /// Gets fired before the Amp2 property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Amp2Changing;
        
        /// <summary>
        /// Gets fired when the Amp2 property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Amp2Changed;
        
        /// <summary>
        /// Gets fired before the Amp3 property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Amp3Changing;
        
        /// <summary>
        /// Gets fired when the Amp3 property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Amp3Changed;
        
        /// <summary>
        /// Raises the OpARemChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpARemChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpARemChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpARemChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpARemChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpARemChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OpARem property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOpARem(object sender, System.EventArgs eventArgs)
        {
            this.OpARem = null;
        }
        
        /// <summary>
        /// Raises the Amp1Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmp1Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Amp1Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Amp1Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmp1Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Amp1Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Amp1 property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAmp1(object sender, System.EventArgs eventArgs)
        {
            this.Amp1 = null;
        }
        
        /// <summary>
        /// Raises the Amp2Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmp2Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Amp2Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Amp2Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmp2Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Amp2Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Amp2 property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAmp2(object sender, System.EventArgs eventArgs)
        {
            this.Amp2 = null;
        }
        
        /// <summary>
        /// Raises the Amp3Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmp3Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Amp3Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Amp3Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmp3Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Amp3Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Amp3 property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAmp3(object sender, System.EventArgs eventArgs)
        {
            this.Amp3 = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "OPAREM"))
            {
                this.OpARem = ((IWYE)(value));
                return;
            }
            if ((feature == "AMP1"))
            {
                this.Amp1 = ((ISAV)(value));
                return;
            }
            if ((feature == "AMP2"))
            {
                this.Amp2 = ((ISAV)(value));
                return;
            }
            if ((feature == "AMP3"))
            {
                this.Amp3 = ((ISAV)(value));
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
            if ((attribute == "OpARem"))
            {
                return new OpARemProxy(this);
            }
            if ((attribute == "Amp1"))
            {
                return new Amp1Proxy(this);
            }
            if ((attribute == "Amp2"))
            {
                return new Amp2Proxy(this);
            }
            if ((attribute == "Amp3"))
            {
                return new Amp3Proxy(this);
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
            if ((reference == "OpARem"))
            {
                return new OpARemProxy(this);
            }
            if ((reference == "Amp1"))
            {
                return new Amp1Proxy(this);
            }
            if ((reference == "Amp2"))
            {
                return new Amp2Proxy(this);
            }
            if ((reference == "Amp3"))
            {
                return new Amp3Proxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                        "Nodes/LNGroupM/MDIF")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MDIF class
        /// </summary>
        public class MDIFReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MDIF _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MDIFReferencedElementsCollection(MDIF parent)
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
                    if ((this._parent.OpARem != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Amp1 != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Amp2 != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Amp3 != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OpARemChanged += this.PropagateValueChanges;
                this._parent.Amp1Changed += this.PropagateValueChanges;
                this._parent.Amp2Changed += this.PropagateValueChanges;
                this._parent.Amp3Changed += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OpARemChanged -= this.PropagateValueChanges;
                this._parent.Amp1Changed -= this.PropagateValueChanges;
                this._parent.Amp2Changed -= this.PropagateValueChanges;
                this._parent.Amp3Changed -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.OpARem == null))
                {
                    IWYE opARemCasted = item.As<IWYE>();
                    if ((opARemCasted != null))
                    {
                        this._parent.OpARem = opARemCasted;
                        return;
                    }
                }
                if ((this._parent.Amp1 == null))
                {
                    ISAV amp1Casted = item.As<ISAV>();
                    if ((amp1Casted != null))
                    {
                        this._parent.Amp1 = amp1Casted;
                        return;
                    }
                }
                if ((this._parent.Amp2 == null))
                {
                    ISAV amp2Casted = item.As<ISAV>();
                    if ((amp2Casted != null))
                    {
                        this._parent.Amp2 = amp2Casted;
                        return;
                    }
                }
                if ((this._parent.Amp3 == null))
                {
                    ISAV amp3Casted = item.As<ISAV>();
                    if ((amp3Casted != null))
                    {
                        this._parent.Amp3 = amp3Casted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OpARem = null;
                this._parent.Amp1 = null;
                this._parent.Amp2 = null;
                this._parent.Amp3 = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.OpARem))
                {
                    return true;
                }
                if ((item == this._parent.Amp1))
                {
                    return true;
                }
                if ((item == this._parent.Amp2))
                {
                    return true;
                }
                if ((item == this._parent.Amp3))
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
                if ((this._parent.OpARem != null))
                {
                    array[arrayIndex] = this._parent.OpARem;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Amp1 != null))
                {
                    array[arrayIndex] = this._parent.Amp1;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Amp2 != null))
                {
                    array[arrayIndex] = this._parent.Amp2;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Amp3 != null))
                {
                    array[arrayIndex] = this._parent.Amp3;
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
                if ((this._parent.OpARem == item))
                {
                    this._parent.OpARem = null;
                    return true;
                }
                if ((this._parent.Amp1 == item))
                {
                    this._parent.Amp1 = null;
                    return true;
                }
                if ((this._parent.Amp2 == item))
                {
                    this._parent.Amp2 = null;
                    return true;
                }
                if ((this._parent.Amp3 == item))
                {
                    this._parent.Amp3 = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OpARem).Concat(this._parent.Amp1).Concat(this._parent.Amp2).Concat(this._parent.Amp3).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OpARem property
        /// </summary>
        private sealed class OpARemProxy : ModelPropertyChange<IMDIF, IWYE>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpARemProxy(IMDIF modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IWYE Value
            {
                get
                {
                    return this.ModelElement.OpARem;
                }
                set
                {
                    this.ModelElement.OpARem = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OpARemChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OpARemChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Amp1 property
        /// </summary>
        private sealed class Amp1Proxy : ModelPropertyChange<IMDIF, ISAV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Amp1Proxy(IMDIF modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISAV Value
            {
                get
                {
                    return this.ModelElement.Amp1;
                }
                set
                {
                    this.ModelElement.Amp1 = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Amp1Changed += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Amp1Changed -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Amp2 property
        /// </summary>
        private sealed class Amp2Proxy : ModelPropertyChange<IMDIF, ISAV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Amp2Proxy(IMDIF modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISAV Value
            {
                get
                {
                    return this.ModelElement.Amp2;
                }
                set
                {
                    this.ModelElement.Amp2 = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Amp2Changed += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Amp2Changed -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Amp3 property
        /// </summary>
        private sealed class Amp3Proxy : ModelPropertyChange<IMDIF, ISAV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Amp3Proxy(IMDIF modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISAV Value
            {
                get
                {
                    return this.ModelElement.Amp3;
                }
                set
                {
                    this.ModelElement.Amp3 = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Amp3Changed += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Amp3Changed -= handler;
            }
        }
    }
}

