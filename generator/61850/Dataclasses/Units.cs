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
    /// The default implementation of the Units class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/Units")]
    public partial class Units : ModelElement, IUnits, IModelElement
    {
        
        private static Lazy<ITypedElement> _slUnitsReference = new Lazy<ITypedElement>(RetrieveSlUnitsReference);
        
        /// <summary>
        /// The backing field for the SlUnits property
        /// </summary>
        private ISlUnits _slUnits;
        
        private static Lazy<ITypedElement> _multiplierReference = new Lazy<ITypedElement>(RetrieveMultiplierReference);
        
        /// <summary>
        /// The backing field for the Multiplier property
        /// </summary>
        private IMultiplier _multiplier;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The SlUnits property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISlUnits SlUnits
        {
            get
            {
                return this._slUnits;
            }
            set
            {
                if ((this._slUnits != value))
                {
                    ISlUnits old = this._slUnits;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSlUnitsChanging(e);
                    this.OnPropertyChanging("SlUnits", e, _slUnitsReference);
                    this._slUnits = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSlUnits;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSlUnits;
                    }
                    this.OnSlUnitsChanged(e);
                    this.OnPropertyChanged("SlUnits", e, _slUnitsReference);
                }
            }
        }
        
        /// <summary>
        /// The multiplier property
        /// </summary>
        [XmlElementNameAttribute("multiplier")]
        [XmlAttributeAttribute(true)]
        public virtual IMultiplier Multiplier
        {
            get
            {
                return this._multiplier;
            }
            set
            {
                if ((this._multiplier != value))
                {
                    IMultiplier old = this._multiplier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMultiplierChanging(e);
                    this.OnPropertyChanging("Multiplier", e, _multiplierReference);
                    this._multiplier = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetMultiplier;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetMultiplier;
                    }
                    this.OnMultiplierChanged(e);
                    this.OnPropertyChanged("Multiplier", e, _multiplierReference);
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
                return base.ReferencedElements.Concat(new UnitsReferencedElementsCollection(this));
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
                            "taclasses/Units")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SlUnits property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SlUnitsChanging;
        
        /// <summary>
        /// Gets fired when the SlUnits property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SlUnitsChanged;
        
        /// <summary>
        /// Gets fired before the Multiplier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MultiplierChanging;
        
        /// <summary>
        /// Gets fired when the Multiplier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MultiplierChanged;
        
        private static ITypedElement RetrieveSlUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(Units.ClassInstance)).Resolve("SlUnits")));
        }
        
        /// <summary>
        /// Raises the SlUnitsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSlUnitsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SlUnitsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SlUnitsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSlUnitsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SlUnitsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SlUnits property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSlUnits(object sender, System.EventArgs eventArgs)
        {
            this.SlUnits = null;
        }
        
        private static ITypedElement RetrieveMultiplierReference()
        {
            return ((ITypedElement)(((ModelElement)(Units.ClassInstance)).Resolve("multiplier")));
        }
        
        /// <summary>
        /// Raises the MultiplierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMultiplierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MultiplierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MultiplierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMultiplierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MultiplierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Multiplier property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetMultiplier(object sender, System.EventArgs eventArgs)
        {
            this.Multiplier = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SLUNITS"))
            {
                this.SlUnits = ((ISlUnits)(value));
                return;
            }
            if ((feature == "MULTIPLIER"))
            {
                this.Multiplier = ((IMultiplier)(value));
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
            if ((attribute == "SlUnits"))
            {
                return new SlUnitsProxy(this);
            }
            if ((attribute == "Multiplier"))
            {
                return new MultiplierProxy(this);
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
            if ((reference == "SlUnits"))
            {
                return new SlUnitsProxy(this);
            }
            if ((reference == "Multiplier"))
            {
                return new MultiplierProxy(this);
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
                        "taclasses/Units")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Units class
        /// </summary>
        public class UnitsReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Units _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public UnitsReferencedElementsCollection(Units parent)
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
                    if ((this._parent.SlUnits != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Multiplier != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SlUnitsChanged += this.PropagateValueChanges;
                this._parent.MultiplierChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SlUnitsChanged -= this.PropagateValueChanges;
                this._parent.MultiplierChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.SlUnits == null))
                {
                    ISlUnits slUnitsCasted = item.As<ISlUnits>();
                    if ((slUnitsCasted != null))
                    {
                        this._parent.SlUnits = slUnitsCasted;
                        return;
                    }
                }
                if ((this._parent.Multiplier == null))
                {
                    IMultiplier multiplierCasted = item.As<IMultiplier>();
                    if ((multiplierCasted != null))
                    {
                        this._parent.Multiplier = multiplierCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SlUnits = null;
                this._parent.Multiplier = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.SlUnits))
                {
                    return true;
                }
                if ((item == this._parent.Multiplier))
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
                if ((this._parent.SlUnits != null))
                {
                    array[arrayIndex] = this._parent.SlUnits;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Multiplier != null))
                {
                    array[arrayIndex] = this._parent.Multiplier;
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
                if ((this._parent.SlUnits == item))
                {
                    this._parent.SlUnits = null;
                    return true;
                }
                if ((this._parent.Multiplier == item))
                {
                    this._parent.Multiplier = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SlUnits).Concat(this._parent.Multiplier).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the SlUnits property
        /// </summary>
        private sealed class SlUnitsProxy : ModelPropertyChange<IUnits, ISlUnits>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SlUnitsProxy(IUnits modelElement) : 
                    base(modelElement, "SlUnits")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISlUnits Value
            {
                get
                {
                    return this.ModelElement.SlUnits;
                }
                set
                {
                    this.ModelElement.SlUnits = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the multiplier property
        /// </summary>
        private sealed class MultiplierProxy : ModelPropertyChange<IUnits, IMultiplier>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MultiplierProxy(IUnits modelElement) : 
                    base(modelElement, "multiplier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IMultiplier Value
            {
                get
                {
                    return this.ModelElement.Multiplier;
                }
                set
                {
                    this.ModelElement.Multiplier = value;
                }
            }
        }
    }
}

