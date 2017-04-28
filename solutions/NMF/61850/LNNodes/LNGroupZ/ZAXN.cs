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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ
{
    
    
    /// <summary>
    /// The default implementation of the ZAXN class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pZ")]
    [XmlNamespacePrefixAttribute("groupz")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupZ/ZAXN")]
    public partial class ZAXN : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ.GroupZ, IZAXN, IModelElement
    {
        
        private static Lazy<ITypedElement> _opTmhReference = new Lazy<ITypedElement>(RetrieveOpTmhReference);
        
        /// <summary>
        /// The backing field for the OpTmh property
        /// </summary>
        private IINS _opTmh;
        
        private static Lazy<ITypedElement> _volReference = new Lazy<ITypedElement>(RetrieveVolReference);
        
        /// <summary>
        /// The backing field for the Vol property
        /// </summary>
        private IMV _vol;
        
        private static Lazy<ITypedElement> _ampReference = new Lazy<ITypedElement>(RetrieveAmpReference);
        
        /// <summary>
        /// The backing field for the Amp property
        /// </summary>
        private IMV _amp;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The OpTmh property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IINS OpTmh
        {
            get
            {
                return this._opTmh;
            }
            set
            {
                if ((this._opTmh != value))
                {
                    IINS old = this._opTmh;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpTmhChanging(e);
                    this.OnPropertyChanging("OpTmh", e, _opTmhReference);
                    this._opTmh = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOpTmh;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOpTmh;
                    }
                    this.OnOpTmhChanged(e);
                    this.OnPropertyChanged("OpTmh", e, _opTmhReference);
                }
            }
        }
        
        /// <summary>
        /// The Vol property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IMV Vol
        {
            get
            {
                return this._vol;
            }
            set
            {
                if ((this._vol != value))
                {
                    IMV old = this._vol;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVolChanging(e);
                    this.OnPropertyChanging("Vol", e, _volReference);
                    this._vol = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetVol;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetVol;
                    }
                    this.OnVolChanged(e);
                    this.OnPropertyChanged("Vol", e, _volReference);
                }
            }
        }
        
        /// <summary>
        /// The Amp property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IMV Amp
        {
            get
            {
                return this._amp;
            }
            set
            {
                if ((this._amp != value))
                {
                    IMV old = this._amp;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAmpChanging(e);
                    this.OnPropertyChanging("Amp", e, _ampReference);
                    this._amp = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAmp;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAmp;
                    }
                    this.OnAmpChanged(e);
                    this.OnPropertyChanged("Amp", e, _ampReference);
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
                return base.ReferencedElements.Concat(new ZAXNReferencedElementsCollection(this));
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
                            "Nodes/LNGroupZ/ZAXN")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OpTmh property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpTmhChanging;
        
        /// <summary>
        /// Gets fired when the OpTmh property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpTmhChanged;
        
        /// <summary>
        /// Gets fired before the Vol property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VolChanging;
        
        /// <summary>
        /// Gets fired when the Vol property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VolChanged;
        
        /// <summary>
        /// Gets fired before the Amp property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AmpChanging;
        
        /// <summary>
        /// Gets fired when the Amp property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AmpChanged;
        
        private static ITypedElement RetrieveOpTmhReference()
        {
            return ((ITypedElement)(((ModelElement)(ZAXN.ClassInstance)).Resolve("OpTmh")));
        }
        
        /// <summary>
        /// Raises the OpTmhChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpTmhChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpTmhChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpTmhChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpTmhChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpTmhChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OpTmh property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOpTmh(object sender, System.EventArgs eventArgs)
        {
            this.OpTmh = null;
        }
        
        private static ITypedElement RetrieveVolReference()
        {
            return ((ITypedElement)(((ModelElement)(ZAXN.ClassInstance)).Resolve("Vol")));
        }
        
        /// <summary>
        /// Raises the VolChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVolChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VolChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VolChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVolChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VolChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Vol property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetVol(object sender, System.EventArgs eventArgs)
        {
            this.Vol = null;
        }
        
        private static ITypedElement RetrieveAmpReference()
        {
            return ((ITypedElement)(((ModelElement)(ZAXN.ClassInstance)).Resolve("Amp")));
        }
        
        /// <summary>
        /// Raises the AmpChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmpChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AmpChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AmpChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAmpChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AmpChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Amp property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAmp(object sender, System.EventArgs eventArgs)
        {
            this.Amp = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "OPTMH"))
            {
                this.OpTmh = ((IINS)(value));
                return;
            }
            if ((feature == "VOL"))
            {
                this.Vol = ((IMV)(value));
                return;
            }
            if ((feature == "AMP"))
            {
                this.Amp = ((IMV)(value));
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
            if ((attribute == "OpTmh"))
            {
                return new OpTmhProxy(this);
            }
            if ((attribute == "Vol"))
            {
                return new VolProxy(this);
            }
            if ((attribute == "Amp"))
            {
                return new AmpProxy(this);
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
            if ((reference == "OpTmh"))
            {
                return new OpTmhProxy(this);
            }
            if ((reference == "Vol"))
            {
                return new VolProxy(this);
            }
            if ((reference == "Amp"))
            {
                return new AmpProxy(this);
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
                        "Nodes/LNGroupZ/ZAXN")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ZAXN class
        /// </summary>
        public class ZAXNReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ZAXN _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ZAXNReferencedElementsCollection(ZAXN parent)
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
                    if ((this._parent.OpTmh != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Vol != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Amp != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OpTmhChanged += this.PropagateValueChanges;
                this._parent.VolChanged += this.PropagateValueChanges;
                this._parent.AmpChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OpTmhChanged -= this.PropagateValueChanges;
                this._parent.VolChanged -= this.PropagateValueChanges;
                this._parent.AmpChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.OpTmh == null))
                {
                    IINS opTmhCasted = item.As<IINS>();
                    if ((opTmhCasted != null))
                    {
                        this._parent.OpTmh = opTmhCasted;
                        return;
                    }
                }
                if ((this._parent.Vol == null))
                {
                    IMV volCasted = item.As<IMV>();
                    if ((volCasted != null))
                    {
                        this._parent.Vol = volCasted;
                        return;
                    }
                }
                if ((this._parent.Amp == null))
                {
                    IMV ampCasted = item.As<IMV>();
                    if ((ampCasted != null))
                    {
                        this._parent.Amp = ampCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OpTmh = null;
                this._parent.Vol = null;
                this._parent.Amp = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.OpTmh))
                {
                    return true;
                }
                if ((item == this._parent.Vol))
                {
                    return true;
                }
                if ((item == this._parent.Amp))
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
                if ((this._parent.OpTmh != null))
                {
                    array[arrayIndex] = this._parent.OpTmh;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Vol != null))
                {
                    array[arrayIndex] = this._parent.Vol;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Amp != null))
                {
                    array[arrayIndex] = this._parent.Amp;
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
                if ((this._parent.OpTmh == item))
                {
                    this._parent.OpTmh = null;
                    return true;
                }
                if ((this._parent.Vol == item))
                {
                    this._parent.Vol = null;
                    return true;
                }
                if ((this._parent.Amp == item))
                {
                    this._parent.Amp = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OpTmh).Concat(this._parent.Vol).Concat(this._parent.Amp).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OpTmh property
        /// </summary>
        private sealed class OpTmhProxy : ModelPropertyChange<IZAXN, IINS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpTmhProxy(IZAXN modelElement) : 
                    base(modelElement, "OpTmh")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IINS Value
            {
                get
                {
                    return this.ModelElement.OpTmh;
                }
                set
                {
                    this.ModelElement.OpTmh = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Vol property
        /// </summary>
        private sealed class VolProxy : ModelPropertyChange<IZAXN, IMV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VolProxy(IZAXN modelElement) : 
                    base(modelElement, "Vol")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IMV Value
            {
                get
                {
                    return this.ModelElement.Vol;
                }
                set
                {
                    this.ModelElement.Vol = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Amp property
        /// </summary>
        private sealed class AmpProxy : ModelPropertyChange<IZAXN, IMV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AmpProxy(IZAXN modelElement) : 
                    base(modelElement, "Amp")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IMV Value
            {
                get
                {
                    return this.ModelElement.Amp;
                }
                set
                {
                    this.ModelElement.Amp = value;
                }
            }
        }
    }
}
