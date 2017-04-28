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
    /// The default implementation of the INS class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/INS")]
    public partial class INS : ModelElement, IINS, IModelElement
    {
        
        /// <summary>
        /// The backing field for the StVal property
        /// </summary>
        private Nullable<int> _stVal;
        
        private static Lazy<ITypedElement> _stValAttribute = new Lazy<ITypedElement>(RetrieveStValAttribute);
        
        /// <summary>
        /// The backing field for the SubEna property
        /// </summary>
        private Nullable<bool> _subEna;
        
        private static Lazy<ITypedElement> _subEnaAttribute = new Lazy<ITypedElement>(RetrieveSubEnaAttribute);
        
        /// <summary>
        /// The backing field for the SubVal property
        /// </summary>
        private Nullable<int> _subVal;
        
        private static Lazy<ITypedElement> _subValAttribute = new Lazy<ITypedElement>(RetrieveSubValAttribute);
        
        /// <summary>
        /// The backing field for the SubID property
        /// </summary>
        private string _subID;
        
        private static Lazy<ITypedElement> _subIDAttribute = new Lazy<ITypedElement>(RetrieveSubIDAttribute);
        
        private static Lazy<ITypedElement> _qReference = new Lazy<ITypedElement>(RetrieveQReference);
        
        /// <summary>
        /// The backing field for the Q property
        /// </summary>
        private IQuality _q;
        
        private static Lazy<ITypedElement> _subQReference = new Lazy<ITypedElement>(RetrieveSubQReference);
        
        /// <summary>
        /// The backing field for the SubQ property
        /// </summary>
        private IQuality _subQ;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The stVal property
        /// </summary>
        [XmlElementNameAttribute("stVal")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<int> StVal
        {
            get
            {
                return this._stVal;
            }
            set
            {
                if ((this._stVal != value))
                {
                    Nullable<int> old = this._stVal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStValChanging(e);
                    this.OnPropertyChanging("StVal", e, _stValAttribute);
                    this._stVal = value;
                    this.OnStValChanged(e);
                    this.OnPropertyChanged("StVal", e, _stValAttribute);
                }
            }
        }
        
        /// <summary>
        /// The subEna property
        /// </summary>
        [XmlElementNameAttribute("subEna")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> SubEna
        {
            get
            {
                return this._subEna;
            }
            set
            {
                if ((this._subEna != value))
                {
                    Nullable<bool> old = this._subEna;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSubEnaChanging(e);
                    this.OnPropertyChanging("SubEna", e, _subEnaAttribute);
                    this._subEna = value;
                    this.OnSubEnaChanged(e);
                    this.OnPropertyChanged("SubEna", e, _subEnaAttribute);
                }
            }
        }
        
        /// <summary>
        /// The subVal property
        /// </summary>
        [XmlElementNameAttribute("subVal")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<int> SubVal
        {
            get
            {
                return this._subVal;
            }
            set
            {
                if ((this._subVal != value))
                {
                    Nullable<int> old = this._subVal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSubValChanging(e);
                    this.OnPropertyChanging("SubVal", e, _subValAttribute);
                    this._subVal = value;
                    this.OnSubValChanged(e);
                    this.OnPropertyChanged("SubVal", e, _subValAttribute);
                }
            }
        }
        
        /// <summary>
        /// The subID property
        /// </summary>
        [XmlElementNameAttribute("subID")]
        [XmlAttributeAttribute(true)]
        public virtual string SubID
        {
            get
            {
                return this._subID;
            }
            set
            {
                if ((this._subID != value))
                {
                    string old = this._subID;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSubIDChanging(e);
                    this.OnPropertyChanging("SubID", e, _subIDAttribute);
                    this._subID = value;
                    this.OnSubIDChanged(e);
                    this.OnPropertyChanged("SubID", e, _subIDAttribute);
                }
            }
        }
        
        /// <summary>
        /// The q property
        /// </summary>
        [XmlElementNameAttribute("q")]
        [XmlAttributeAttribute(true)]
        public virtual IQuality Q
        {
            get
            {
                return this._q;
            }
            set
            {
                if ((this._q != value))
                {
                    IQuality old = this._q;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnQChanging(e);
                    this.OnPropertyChanging("Q", e, _qReference);
                    this._q = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetQ;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetQ;
                    }
                    this.OnQChanged(e);
                    this.OnPropertyChanged("Q", e, _qReference);
                }
            }
        }
        
        /// <summary>
        /// The subQ property
        /// </summary>
        [XmlElementNameAttribute("subQ")]
        [XmlAttributeAttribute(true)]
        public virtual IQuality SubQ
        {
            get
            {
                return this._subQ;
            }
            set
            {
                if ((this._subQ != value))
                {
                    IQuality old = this._subQ;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSubQChanging(e);
                    this.OnPropertyChanging("SubQ", e, _subQReference);
                    this._subQ = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSubQ;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSubQ;
                    }
                    this.OnSubQChanged(e);
                    this.OnPropertyChanged("SubQ", e, _subQReference);
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
                return base.ReferencedElements.Concat(new INSReferencedElementsCollection(this));
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
                            "taclasses/INS")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the StVal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StValChanging;
        
        /// <summary>
        /// Gets fired when the StVal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StValChanged;
        
        /// <summary>
        /// Gets fired before the SubEna property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubEnaChanging;
        
        /// <summary>
        /// Gets fired when the SubEna property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubEnaChanged;
        
        /// <summary>
        /// Gets fired before the SubVal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubValChanging;
        
        /// <summary>
        /// Gets fired when the SubVal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubValChanged;
        
        /// <summary>
        /// Gets fired before the SubID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubIDChanging;
        
        /// <summary>
        /// Gets fired when the SubID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubIDChanged;
        
        /// <summary>
        /// Gets fired before the Q property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QChanging;
        
        /// <summary>
        /// Gets fired when the Q property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QChanged;
        
        /// <summary>
        /// Gets fired before the SubQ property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubQChanging;
        
        /// <summary>
        /// Gets fired when the SubQ property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubQChanged;
        
        private static ITypedElement RetrieveStValAttribute()
        {
            return ((ITypedElement)(((ModelElement)(INS.ClassInstance)).Resolve("stVal")));
        }
        
        /// <summary>
        /// Raises the StValChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStValChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StValChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StValChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStValChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StValChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSubEnaAttribute()
        {
            return ((ITypedElement)(((ModelElement)(INS.ClassInstance)).Resolve("subEna")));
        }
        
        /// <summary>
        /// Raises the SubEnaChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubEnaChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubEnaChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SubEnaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubEnaChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubEnaChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSubValAttribute()
        {
            return ((ITypedElement)(((ModelElement)(INS.ClassInstance)).Resolve("subVal")));
        }
        
        /// <summary>
        /// Raises the SubValChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubValChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubValChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SubValChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubValChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubValChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSubIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(INS.ClassInstance)).Resolve("subID")));
        }
        
        /// <summary>
        /// Raises the SubIDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubIDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SubIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubIDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveQReference()
        {
            return ((ITypedElement)(((ModelElement)(INS.ClassInstance)).Resolve("q")));
        }
        
        /// <summary>
        /// Raises the QChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the QChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Q property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetQ(object sender, System.EventArgs eventArgs)
        {
            this.Q = null;
        }
        
        private static ITypedElement RetrieveSubQReference()
        {
            return ((ITypedElement)(((ModelElement)(INS.ClassInstance)).Resolve("subQ")));
        }
        
        /// <summary>
        /// Raises the SubQChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubQChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubQChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SubQChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubQChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubQChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SubQ property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSubQ(object sender, System.EventArgs eventArgs)
        {
            this.SubQ = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "STVAL"))
            {
                return this.StVal;
            }
            if ((attribute == "SUBENA"))
            {
                return this.SubEna;
            }
            if ((attribute == "SUBVAL"))
            {
                return this.SubVal;
            }
            if ((attribute == "SUBID"))
            {
                return this.SubID;
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
            if ((feature == "Q"))
            {
                this.Q = ((IQuality)(value));
                return;
            }
            if ((feature == "SUBQ"))
            {
                this.SubQ = ((IQuality)(value));
                return;
            }
            if ((feature == "STVAL"))
            {
                this.StVal = ((int)(value));
                return;
            }
            if ((feature == "SUBENA"))
            {
                this.SubEna = ((bool)(value));
                return;
            }
            if ((feature == "SUBVAL"))
            {
                this.SubVal = ((int)(value));
                return;
            }
            if ((feature == "SUBID"))
            {
                this.SubID = ((string)(value));
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
            if ((attribute == "Q"))
            {
                return new QProxy(this);
            }
            if ((attribute == "SubQ"))
            {
                return new SubQProxy(this);
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
            if ((reference == "Q"))
            {
                return new QProxy(this);
            }
            if ((reference == "SubQ"))
            {
                return new SubQProxy(this);
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
                        "taclasses/INS")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the INS class
        /// </summary>
        public class INSReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private INS _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public INSReferencedElementsCollection(INS parent)
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
                    if ((this._parent.Q != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.SubQ != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.QChanged += this.PropagateValueChanges;
                this._parent.SubQChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.QChanged -= this.PropagateValueChanges;
                this._parent.SubQChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Q == null))
                {
                    IQuality qCasted = item.As<IQuality>();
                    if ((qCasted != null))
                    {
                        this._parent.Q = qCasted;
                        return;
                    }
                }
                if ((this._parent.SubQ == null))
                {
                    IQuality subQCasted = item.As<IQuality>();
                    if ((subQCasted != null))
                    {
                        this._parent.SubQ = subQCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Q = null;
                this._parent.SubQ = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Q))
                {
                    return true;
                }
                if ((item == this._parent.SubQ))
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
                if ((this._parent.Q != null))
                {
                    array[arrayIndex] = this._parent.Q;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.SubQ != null))
                {
                    array[arrayIndex] = this._parent.SubQ;
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
                if ((this._parent.Q == item))
                {
                    this._parent.Q = null;
                    return true;
                }
                if ((this._parent.SubQ == item))
                {
                    this._parent.SubQ = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Q).Concat(this._parent.SubQ).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the stVal property
        /// </summary>
        private sealed class StValProxy : ModelPropertyChange<IINS, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StValProxy(IINS modelElement) : 
                    base(modelElement, "stVal")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.StVal;
                }
                set
                {
                    this.ModelElement.StVal = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the subEna property
        /// </summary>
        private sealed class SubEnaProxy : ModelPropertyChange<IINS, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SubEnaProxy(IINS modelElement) : 
                    base(modelElement, "subEna")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.SubEna;
                }
                set
                {
                    this.ModelElement.SubEna = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the subVal property
        /// </summary>
        private sealed class SubValProxy : ModelPropertyChange<IINS, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SubValProxy(IINS modelElement) : 
                    base(modelElement, "subVal")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.SubVal;
                }
                set
                {
                    this.ModelElement.SubVal = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the subID property
        /// </summary>
        private sealed class SubIDProxy : ModelPropertyChange<IINS, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SubIDProxy(IINS modelElement) : 
                    base(modelElement, "subID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SubID;
                }
                set
                {
                    this.ModelElement.SubID = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the q property
        /// </summary>
        private sealed class QProxy : ModelPropertyChange<IINS, IQuality>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public QProxy(IINS modelElement) : 
                    base(modelElement, "q")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IQuality Value
            {
                get
                {
                    return this.ModelElement.Q;
                }
                set
                {
                    this.ModelElement.Q = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the subQ property
        /// </summary>
        private sealed class SubQProxy : ModelPropertyChange<IINS, IQuality>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SubQProxy(IINS modelElement) : 
                    base(modelElement, "subQ")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IQuality Value
            {
                get
                {
                    return this.ModelElement.SubQ;
                }
                set
                {
                    this.ModelElement.SubQ = value;
                }
            }
        }
    }
}
