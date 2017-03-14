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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits
{
    
    
    /// <summary>
    /// The default implementation of the OperationalLimitSet class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#OperationalLimits")]
    [XmlNamespacePrefixAttribute("cimOperationalLimits")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/OperationalLimits/Operational" +
        "LimitSet")]
    [DebuggerDisplayAttribute("OperationalLimitSet {UUID}")]
    public class OperationalLimitSet : IdentifiedObject, IOperationalLimitSet, IModelElement
    {
        
        /// <summary>
        /// The backing field for the OperationalLimitValue property
        /// </summary>
        private OperationalLimitSetOperationalLimitValueCollection _operationalLimitValue;
        
        /// <summary>
        /// The backing field for the Terminal property
        /// </summary>
        private ITerminal _terminal;
        
        /// <summary>
        /// The backing field for the Equipment property
        /// </summary>
        private IEquipment _equipment;
        
        private static IClass _classInstance;
        
        public OperationalLimitSet()
        {
            this._operationalLimitValue = new OperationalLimitSetOperationalLimitValueCollection(this);
            this._operationalLimitValue.CollectionChanging += this.OperationalLimitValueCollectionChanging;
            this._operationalLimitValue.CollectionChanged += this.OperationalLimitValueCollectionChanged;
        }
        
        /// <summary>
        /// The OperationalLimitValue property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OperationalLimitSet")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOperationalLimit> OperationalLimitValue
        {
            get
            {
                return this._operationalLimitValue;
            }
        }
        
        /// <summary>
        /// The Terminal property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OperationalLimitSet")]
        public virtual ITerminal Terminal
        {
            get
            {
                return this._terminal;
            }
            set
            {
                if ((this._terminal != value))
                {
                    ITerminal old = this._terminal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTerminalChanging(e);
                    this.OnPropertyChanging("Terminal", e);
                    this._terminal = value;
                    if ((old != null))
                    {
                        old.OperationalLimitSet.Remove(this);
                        old.Deleted -= this.OnResetTerminal;
                    }
                    if ((value != null))
                    {
                        value.OperationalLimitSet.Add(this);
                        value.Deleted += this.OnResetTerminal;
                    }
                    this.OnTerminalChanged(e);
                    this.OnPropertyChanged("Terminal", e);
                }
            }
        }
        
        /// <summary>
        /// The Equipment property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OperationalLimitSet")]
        public virtual IEquipment Equipment
        {
            get
            {
                return this._equipment;
            }
            set
            {
                if ((this._equipment != value))
                {
                    IEquipment old = this._equipment;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEquipmentChanging(e);
                    this.OnPropertyChanging("Equipment", e);
                    this._equipment = value;
                    if ((old != null))
                    {
                        old.OperationalLimitSet.Remove(this);
                        old.Deleted -= this.OnResetEquipment;
                    }
                    if ((value != null))
                    {
                        value.OperationalLimitSet.Add(this);
                        value.Deleted += this.OnResetEquipment;
                    }
                    this.OnEquipmentChanged(e);
                    this.OnPropertyChanged("Equipment", e);
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
                return base.ReferencedElements.Concat(new OperationalLimitSetReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/OperationalLimits/Operational" +
                            "LimitSet")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Terminal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TerminalChanging;
        
        /// <summary>
        /// Gets fired when the Terminal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TerminalChanged;
        
        /// <summary>
        /// Gets fired before the Equipment property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EquipmentChanging;
        
        /// <summary>
        /// Gets fired when the Equipment property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EquipmentChanged;
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OperationalLimitValue property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OperationalLimitValueCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("OperationalLimitValue", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OperationalLimitValue property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OperationalLimitValueCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OperationalLimitValue", e);
        }
        
        /// <summary>
        /// Raises the TerminalChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTerminalChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TerminalChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TerminalChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTerminalChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TerminalChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Terminal property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTerminal(object sender, System.EventArgs eventArgs)
        {
            this.Terminal = null;
        }
        
        /// <summary>
        /// Raises the EquipmentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEquipmentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EquipmentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EquipmentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEquipmentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EquipmentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Equipment property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEquipment(object sender, System.EventArgs eventArgs)
        {
            this.Equipment = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "OPERATIONALLIMITVALUE"))
            {
                return this._operationalLimitValue;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TERMINAL"))
            {
                this.Terminal = ((ITerminal)(value));
                return;
            }
            if ((feature == "EQUIPMENT"))
            {
                this.Equipment = ((IEquipment)(value));
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
            if ((attribute == "Terminal"))
            {
                return new TerminalProxy(this);
            }
            if ((attribute == "Equipment"))
            {
                return new EquipmentProxy(this);
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
            if ((reference == "Terminal"))
            {
                return new TerminalProxy(this);
            }
            if ((reference == "Equipment"))
            {
                return new EquipmentProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/OperationalLimits/Operational" +
                        "LimitSet")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OperationalLimitSet class
        /// </summary>
        public class OperationalLimitSetReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OperationalLimitSet _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OperationalLimitSetReferencedElementsCollection(OperationalLimitSet parent)
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
                    count = (count + this._parent.OperationalLimitValue.Count);
                    if ((this._parent.Terminal != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Equipment != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OperationalLimitValue.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TerminalChanged += this.PropagateValueChanges;
                this._parent.EquipmentChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OperationalLimitValue.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TerminalChanged -= this.PropagateValueChanges;
                this._parent.EquipmentChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IOperationalLimit operationalLimitValueCasted = item.As<IOperationalLimit>();
                if ((operationalLimitValueCasted != null))
                {
                    this._parent.OperationalLimitValue.Add(operationalLimitValueCasted);
                }
                if ((this._parent.Terminal == null))
                {
                    ITerminal terminalCasted = item.As<ITerminal>();
                    if ((terminalCasted != null))
                    {
                        this._parent.Terminal = terminalCasted;
                        return;
                    }
                }
                if ((this._parent.Equipment == null))
                {
                    IEquipment equipmentCasted = item.As<IEquipment>();
                    if ((equipmentCasted != null))
                    {
                        this._parent.Equipment = equipmentCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OperationalLimitValue.Clear();
                this._parent.Terminal = null;
                this._parent.Equipment = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.OperationalLimitValue.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Terminal))
                {
                    return true;
                }
                if ((item == this._parent.Equipment))
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
                IEnumerator<IModelElement> operationalLimitValueEnumerator = this._parent.OperationalLimitValue.GetEnumerator();
                try
                {
                    for (
                    ; operationalLimitValueEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = operationalLimitValueEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    operationalLimitValueEnumerator.Dispose();
                }
                if ((this._parent.Terminal != null))
                {
                    array[arrayIndex] = this._parent.Terminal;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Equipment != null))
                {
                    array[arrayIndex] = this._parent.Equipment;
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
                IOperationalLimit operationalLimitItem = item.As<IOperationalLimit>();
                if (((operationalLimitItem != null) 
                            && this._parent.OperationalLimitValue.Remove(operationalLimitItem)))
                {
                    return true;
                }
                if ((this._parent.Terminal == item))
                {
                    this._parent.Terminal = null;
                    return true;
                }
                if ((this._parent.Equipment == item))
                {
                    this._parent.Equipment = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OperationalLimitValue).Concat(this._parent.Terminal).Concat(this._parent.Equipment).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Terminal property
        /// </summary>
        private sealed class TerminalProxy : ModelPropertyChange<IOperationalLimitSet, ITerminal>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TerminalProxy(IOperationalLimitSet modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITerminal Value
            {
                get
                {
                    return this.ModelElement.Terminal;
                }
                set
                {
                    this.ModelElement.Terminal = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TerminalChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TerminalChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Equipment property
        /// </summary>
        private sealed class EquipmentProxy : ModelPropertyChange<IOperationalLimitSet, IEquipment>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EquipmentProxy(IOperationalLimitSet modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEquipment Value
            {
                get
                {
                    return this.ModelElement.Equipment;
                }
                set
                {
                    this.ModelElement.Equipment = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EquipmentChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EquipmentChanged -= handler;
            }
        }
    }
}

