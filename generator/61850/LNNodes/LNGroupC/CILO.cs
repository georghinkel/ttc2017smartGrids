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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC
{
    
    
    /// <summary>
    /// The default implementation of the CILO class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pC")]
    [XmlNamespacePrefixAttribute("groupc")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupC/CILO")]
    public partial class CILO : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC.GroupC, ICILO, IModelElement
    {
        
        private static Lazy<ITypedElement> _enaOpnReference = new Lazy<ITypedElement>(RetrieveEnaOpnReference);
        
        /// <summary>
        /// The backing field for the EnaOpn property
        /// </summary>
        private ISPS _enaOpn;
        
        private static Lazy<ITypedElement> _enaClsReference = new Lazy<ITypedElement>(RetrieveEnaClsReference);
        
        /// <summary>
        /// The backing field for the EnaCls property
        /// </summary>
        private ISPS _enaCls;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The EnaOpn property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS EnaOpn
        {
            get
            {
                return this._enaOpn;
            }
            set
            {
                if ((this._enaOpn != value))
                {
                    ISPS old = this._enaOpn;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnaOpnChanging(e);
                    this.OnPropertyChanging("EnaOpn", e, _enaOpnReference);
                    this._enaOpn = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEnaOpn;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEnaOpn;
                    }
                    this.OnEnaOpnChanged(e);
                    this.OnPropertyChanged("EnaOpn", e, _enaOpnReference);
                }
            }
        }
        
        /// <summary>
        /// The EnaCls property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS EnaCls
        {
            get
            {
                return this._enaCls;
            }
            set
            {
                if ((this._enaCls != value))
                {
                    ISPS old = this._enaCls;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnaClsChanging(e);
                    this.OnPropertyChanging("EnaCls", e, _enaClsReference);
                    this._enaCls = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEnaCls;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEnaCls;
                    }
                    this.OnEnaClsChanged(e);
                    this.OnPropertyChanged("EnaCls", e, _enaClsReference);
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
                return base.ReferencedElements.Concat(new CILOReferencedElementsCollection(this));
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
                            "Nodes/LNGroupC/CILO")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EnaOpn property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnaOpnChanging;
        
        /// <summary>
        /// Gets fired when the EnaOpn property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnaOpnChanged;
        
        /// <summary>
        /// Gets fired before the EnaCls property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnaClsChanging;
        
        /// <summary>
        /// Gets fired when the EnaCls property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnaClsChanged;
        
        private static ITypedElement RetrieveEnaOpnReference()
        {
            return ((ITypedElement)(((ModelElement)(CILO.ClassInstance)).Resolve("EnaOpn")));
        }
        
        /// <summary>
        /// Raises the EnaOpnChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnaOpnChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnaOpnChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnaOpnChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnaOpnChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnaOpnChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EnaOpn property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEnaOpn(object sender, System.EventArgs eventArgs)
        {
            this.EnaOpn = null;
        }
        
        private static ITypedElement RetrieveEnaClsReference()
        {
            return ((ITypedElement)(((ModelElement)(CILO.ClassInstance)).Resolve("EnaCls")));
        }
        
        /// <summary>
        /// Raises the EnaClsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnaClsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnaClsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnaClsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnaClsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnaClsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EnaCls property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEnaCls(object sender, System.EventArgs eventArgs)
        {
            this.EnaCls = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ENAOPN"))
            {
                this.EnaOpn = ((ISPS)(value));
                return;
            }
            if ((feature == "ENACLS"))
            {
                this.EnaCls = ((ISPS)(value));
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
            if ((attribute == "EnaOpn"))
            {
                return new EnaOpnProxy(this);
            }
            if ((attribute == "EnaCls"))
            {
                return new EnaClsProxy(this);
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
            if ((reference == "EnaOpn"))
            {
                return new EnaOpnProxy(this);
            }
            if ((reference == "EnaCls"))
            {
                return new EnaClsProxy(this);
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
                        "Nodes/LNGroupC/CILO")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CILO class
        /// </summary>
        public class CILOReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CILO _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CILOReferencedElementsCollection(CILO parent)
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
                    if ((this._parent.EnaOpn != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.EnaCls != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EnaOpnChanged += this.PropagateValueChanges;
                this._parent.EnaClsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EnaOpnChanged -= this.PropagateValueChanges;
                this._parent.EnaClsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EnaOpn == null))
                {
                    ISPS enaOpnCasted = item.As<ISPS>();
                    if ((enaOpnCasted != null))
                    {
                        this._parent.EnaOpn = enaOpnCasted;
                        return;
                    }
                }
                if ((this._parent.EnaCls == null))
                {
                    ISPS enaClsCasted = item.As<ISPS>();
                    if ((enaClsCasted != null))
                    {
                        this._parent.EnaCls = enaClsCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EnaOpn = null;
                this._parent.EnaCls = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EnaOpn))
                {
                    return true;
                }
                if ((item == this._parent.EnaCls))
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
                if ((this._parent.EnaOpn != null))
                {
                    array[arrayIndex] = this._parent.EnaOpn;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.EnaCls != null))
                {
                    array[arrayIndex] = this._parent.EnaCls;
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
                if ((this._parent.EnaOpn == item))
                {
                    this._parent.EnaOpn = null;
                    return true;
                }
                if ((this._parent.EnaCls == item))
                {
                    this._parent.EnaCls = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EnaOpn).Concat(this._parent.EnaCls).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EnaOpn property
        /// </summary>
        private sealed class EnaOpnProxy : ModelPropertyChange<ICILO, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnaOpnProxy(ICILO modelElement) : 
                    base(modelElement, "EnaOpn")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.EnaOpn;
                }
                set
                {
                    this.ModelElement.EnaOpn = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EnaCls property
        /// </summary>
        private sealed class EnaClsProxy : ModelPropertyChange<ICILO, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnaClsProxy(ICILO modelElement) : 
                    base(modelElement, "EnaCls")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.EnaCls;
                }
                set
                {
                    this.ModelElement.EnaCls = value;
                }
            }
        }
    }
}

