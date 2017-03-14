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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The default implementation of the ValueToAlias class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Meas")]
    [XmlNamespacePrefixAttribute("cimMeas")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/ValueToAlias")]
    [DebuggerDisplayAttribute("ValueToAlias {UUID}")]
    public class ValueToAlias : IdentifiedObject, IValueToAlias, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Value property
        /// </summary>
        private int _value;
        
        /// <summary>
        /// The backing field for the ValueAliasSet property
        /// </summary>
        private IValueAliasSet _valueAliasSet;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The value property
        /// </summary>
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(true)]
        public virtual int Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((this._value != value))
                {
                    int old = this._value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValueChanging(e);
                    this.OnPropertyChanging("Value", e);
                    this._value = value;
                    this.OnValueChanged(e);
                    this.OnPropertyChanged("Value", e);
                }
            }
        }
        
        /// <summary>
        /// The ValueAliasSet property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Values")]
        public virtual IValueAliasSet ValueAliasSet
        {
            get
            {
                return this._valueAliasSet;
            }
            set
            {
                if ((this._valueAliasSet != value))
                {
                    IValueAliasSet old = this._valueAliasSet;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValueAliasSetChanging(e);
                    this.OnPropertyChanging("ValueAliasSet", e);
                    this._valueAliasSet = value;
                    if ((old != null))
                    {
                        old.Values.Remove(this);
                        old.Deleted -= this.OnResetValueAliasSet;
                    }
                    if ((value != null))
                    {
                        value.Values.Add(this);
                        value.Deleted += this.OnResetValueAliasSet;
                    }
                    this.OnValueAliasSetChanged(e);
                    this.OnPropertyChanged("ValueAliasSet", e);
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
                return base.ReferencedElements.Concat(new ValueToAliasReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/ValueToAlias")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the ValueAliasSet property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueAliasSetChanging;
        
        /// <summary>
        /// Gets fired when the ValueAliasSet property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueAliasSetChanged;
        
        /// <summary>
        /// Raises the ValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValueAliasSetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueAliasSetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueAliasSetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValueAliasSetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueAliasSetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueAliasSetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ValueAliasSet property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetValueAliasSet(object sender, System.EventArgs eventArgs)
        {
            this.ValueAliasSet = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VALUE"))
            {
                return this.Value;
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
            if ((feature == "VALUEALIASSET"))
            {
                this.ValueAliasSet = ((IValueAliasSet)(value));
                return;
            }
            if ((feature == "VALUE"))
            {
                this.Value = ((int)(value));
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
            if ((attribute == "ValueAliasSet"))
            {
                return new ValueAliasSetProxy(this);
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
            if ((reference == "ValueAliasSet"))
            {
                return new ValueAliasSetProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/ValueToAlias")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ValueToAlias class
        /// </summary>
        public class ValueToAliasReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ValueToAlias _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ValueToAliasReferencedElementsCollection(ValueToAlias parent)
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
                    if ((this._parent.ValueAliasSet != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ValueAliasSetChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ValueAliasSetChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ValueAliasSet == null))
                {
                    IValueAliasSet valueAliasSetCasted = item.As<IValueAliasSet>();
                    if ((valueAliasSetCasted != null))
                    {
                        this._parent.ValueAliasSet = valueAliasSetCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ValueAliasSet = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ValueAliasSet))
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
                if ((this._parent.ValueAliasSet != null))
                {
                    array[arrayIndex] = this._parent.ValueAliasSet;
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
                if ((this._parent.ValueAliasSet == item))
                {
                    this._parent.ValueAliasSet = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ValueAliasSet).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value property
        /// </summary>
        private sealed class ValueProxy : ModelPropertyChange<IValueToAlias, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValueProxy(IValueToAlias modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.Value;
                }
                set
                {
                    this.ModelElement.Value = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ValueChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ValueChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ValueAliasSet property
        /// </summary>
        private sealed class ValueAliasSetProxy : ModelPropertyChange<IValueToAlias, IValueAliasSet>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValueAliasSetProxy(IValueToAlias modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IValueAliasSet Value
            {
                get
                {
                    return this.ModelElement.ValueAliasSet;
                }
                set
                {
                    this.ModelElement.ValueAliasSet = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ValueAliasSetChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ValueAliasSetChanged -= handler;
            }
        }
    }
}
