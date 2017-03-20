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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupT
{
    
    
    /// <summary>
    /// The default implementation of the TVTR class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pT")]
    [XmlNamespacePrefixAttribute("groupt")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupT/TVTR")]
    public partial class TVTR : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupT.GroupT, ITVTR, IModelElement
    {
        
        private static Lazy<ITypedElement> _volReference = new Lazy<ITypedElement>(RetrieveVolReference);
        
        /// <summary>
        /// The backing field for the Vol property
        /// </summary>
        private ISAV _vol;
        
        private static Lazy<ITypedElement> _fuFailReference = new Lazy<ITypedElement>(RetrieveFuFailReference);
        
        /// <summary>
        /// The backing field for the FuFail property
        /// </summary>
        private ISPS _fuFail;
        
        private static Lazy<ITypedElement> _vRtgReference = new Lazy<ITypedElement>(RetrieveVRtgReference);
        
        /// <summary>
        /// The backing field for the VRtg property
        /// </summary>
        private IASG _vRtg;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Vol property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISAV Vol
        {
            get
            {
                return this._vol;
            }
            set
            {
                if ((this._vol != value))
                {
                    ISAV old = this._vol;
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
        /// The FuFail property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS FuFail
        {
            get
            {
                return this._fuFail;
            }
            set
            {
                if ((this._fuFail != value))
                {
                    ISPS old = this._fuFail;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFuFailChanging(e);
                    this.OnPropertyChanging("FuFail", e, _fuFailReference);
                    this._fuFail = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetFuFail;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetFuFail;
                    }
                    this.OnFuFailChanged(e);
                    this.OnPropertyChanged("FuFail", e, _fuFailReference);
                }
            }
        }
        
        /// <summary>
        /// The VRtg property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IASG VRtg
        {
            get
            {
                return this._vRtg;
            }
            set
            {
                if ((this._vRtg != value))
                {
                    IASG old = this._vRtg;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVRtgChanging(e);
                    this.OnPropertyChanging("VRtg", e, _vRtgReference);
                    this._vRtg = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetVRtg;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetVRtg;
                    }
                    this.OnVRtgChanged(e);
                    this.OnPropertyChanged("VRtg", e, _vRtgReference);
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
                return base.ReferencedElements.Concat(new TVTRReferencedElementsCollection(this));
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
                            "Nodes/LNGroupT/TVTR")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Vol property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VolChanging;
        
        /// <summary>
        /// Gets fired when the Vol property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VolChanged;
        
        /// <summary>
        /// Gets fired before the FuFail property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FuFailChanging;
        
        /// <summary>
        /// Gets fired when the FuFail property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FuFailChanged;
        
        /// <summary>
        /// Gets fired before the VRtg property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VRtgChanging;
        
        /// <summary>
        /// Gets fired when the VRtg property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VRtgChanged;
        
        private static ITypedElement RetrieveVolReference()
        {
            return ((ITypedElement)(((ModelElement)(TVTR.ClassInstance)).Resolve("Vol")));
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
        
        private static ITypedElement RetrieveFuFailReference()
        {
            return ((ITypedElement)(((ModelElement)(TVTR.ClassInstance)).Resolve("FuFail")));
        }
        
        /// <summary>
        /// Raises the FuFailChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFuFailChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FuFailChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FuFailChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFuFailChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FuFailChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the FuFail property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetFuFail(object sender, System.EventArgs eventArgs)
        {
            this.FuFail = null;
        }
        
        private static ITypedElement RetrieveVRtgReference()
        {
            return ((ITypedElement)(((ModelElement)(TVTR.ClassInstance)).Resolve("VRtg")));
        }
        
        /// <summary>
        /// Raises the VRtgChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVRtgChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VRtgChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VRtgChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVRtgChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VRtgChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the VRtg property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetVRtg(object sender, System.EventArgs eventArgs)
        {
            this.VRtg = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "VOL"))
            {
                this.Vol = ((ISAV)(value));
                return;
            }
            if ((feature == "FUFAIL"))
            {
                this.FuFail = ((ISPS)(value));
                return;
            }
            if ((feature == "VRTG"))
            {
                this.VRtg = ((IASG)(value));
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
            if ((attribute == "Vol"))
            {
                return new VolProxy(this);
            }
            if ((attribute == "FuFail"))
            {
                return new FuFailProxy(this);
            }
            if ((attribute == "VRtg"))
            {
                return new VRtgProxy(this);
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
            if ((reference == "Vol"))
            {
                return new VolProxy(this);
            }
            if ((reference == "FuFail"))
            {
                return new FuFailProxy(this);
            }
            if ((reference == "VRtg"))
            {
                return new VRtgProxy(this);
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
                        "Nodes/LNGroupT/TVTR")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TVTR class
        /// </summary>
        public class TVTRReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TVTR _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TVTRReferencedElementsCollection(TVTR parent)
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
                    if ((this._parent.Vol != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.FuFail != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.VRtg != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.VolChanged += this.PropagateValueChanges;
                this._parent.FuFailChanged += this.PropagateValueChanges;
                this._parent.VRtgChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.VolChanged -= this.PropagateValueChanges;
                this._parent.FuFailChanged -= this.PropagateValueChanges;
                this._parent.VRtgChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Vol == null))
                {
                    ISAV volCasted = item.As<ISAV>();
                    if ((volCasted != null))
                    {
                        this._parent.Vol = volCasted;
                        return;
                    }
                }
                if ((this._parent.FuFail == null))
                {
                    ISPS fuFailCasted = item.As<ISPS>();
                    if ((fuFailCasted != null))
                    {
                        this._parent.FuFail = fuFailCasted;
                        return;
                    }
                }
                if ((this._parent.VRtg == null))
                {
                    IASG vRtgCasted = item.As<IASG>();
                    if ((vRtgCasted != null))
                    {
                        this._parent.VRtg = vRtgCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Vol = null;
                this._parent.FuFail = null;
                this._parent.VRtg = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Vol))
                {
                    return true;
                }
                if ((item == this._parent.FuFail))
                {
                    return true;
                }
                if ((item == this._parent.VRtg))
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
                if ((this._parent.Vol != null))
                {
                    array[arrayIndex] = this._parent.Vol;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.FuFail != null))
                {
                    array[arrayIndex] = this._parent.FuFail;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.VRtg != null))
                {
                    array[arrayIndex] = this._parent.VRtg;
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
                if ((this._parent.Vol == item))
                {
                    this._parent.Vol = null;
                    return true;
                }
                if ((this._parent.FuFail == item))
                {
                    this._parent.FuFail = null;
                    return true;
                }
                if ((this._parent.VRtg == item))
                {
                    this._parent.VRtg = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Vol).Concat(this._parent.FuFail).Concat(this._parent.VRtg).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Vol property
        /// </summary>
        private sealed class VolProxy : ModelPropertyChange<ITVTR, ISAV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VolProxy(ITVTR modelElement) : 
                    base(modelElement, "Vol")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISAV Value
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
        /// Represents a proxy to represent an incremental access to the FuFail property
        /// </summary>
        private sealed class FuFailProxy : ModelPropertyChange<ITVTR, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FuFailProxy(ITVTR modelElement) : 
                    base(modelElement, "FuFail")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.FuFail;
                }
                set
                {
                    this.ModelElement.FuFail = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the VRtg property
        /// </summary>
        private sealed class VRtgProxy : ModelPropertyChange<ITVTR, IASG>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VRtgProxy(ITVTR modelElement) : 
                    base(modelElement, "VRtg")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IASG Value
            {
                get
                {
                    return this.ModelElement.VRtg;
                }
                set
                {
                    this.ModelElement.VRtg = value;
                }
            }
        }
    }
}

