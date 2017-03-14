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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The default implementation of the HeatRateCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/HeatRat" +
        "eCurve")]
    [DebuggerDisplayAttribute("HeatRateCurve {UUID}")]
    public class HeatRateCurve : Curve, IHeatRateCurve, IModelElement
    {
        
        /// <summary>
        /// The backing field for the IsNetGrossP property
        /// </summary>
        private bool _isNetGrossP;
        
        /// <summary>
        /// The backing field for the ThermalGeneratingUnit property
        /// </summary>
        private IThermalGeneratingUnit _thermalGeneratingUnit;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The isNetGrossP property
        /// </summary>
        [XmlElementNameAttribute("isNetGrossP")]
        [XmlAttributeAttribute(true)]
        public virtual bool IsNetGrossP
        {
            get
            {
                return this._isNetGrossP;
            }
            set
            {
                if ((this._isNetGrossP != value))
                {
                    bool old = this._isNetGrossP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsNetGrossPChanging(e);
                    this.OnPropertyChanging("IsNetGrossP", e);
                    this._isNetGrossP = value;
                    this.OnIsNetGrossPChanged(e);
                    this.OnPropertyChanged("IsNetGrossP", e);
                }
            }
        }
        
        /// <summary>
        /// The ThermalGeneratingUnit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("HeatRateCurve")]
        public virtual IThermalGeneratingUnit ThermalGeneratingUnit
        {
            get
            {
                return this._thermalGeneratingUnit;
            }
            set
            {
                if ((this._thermalGeneratingUnit != value))
                {
                    IThermalGeneratingUnit old = this._thermalGeneratingUnit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnThermalGeneratingUnitChanging(e);
                    this.OnPropertyChanging("ThermalGeneratingUnit", e);
                    this._thermalGeneratingUnit = value;
                    if ((old != null))
                    {
                        old.HeatRateCurve = null;
                        old.Deleted -= this.OnResetThermalGeneratingUnit;
                    }
                    if ((value != null))
                    {
                        value.HeatRateCurve = this;
                        value.Deleted += this.OnResetThermalGeneratingUnit;
                    }
                    this.OnThermalGeneratingUnitChanged(e);
                    this.OnPropertyChanged("ThermalGeneratingUnit", e);
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
                return base.ReferencedElements.Concat(new HeatRateCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/HeatRat" +
                            "eCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the IsNetGrossP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsNetGrossPChanging;
        
        /// <summary>
        /// Gets fired when the IsNetGrossP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsNetGrossPChanged;
        
        /// <summary>
        /// Gets fired before the ThermalGeneratingUnit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the ThermalGeneratingUnit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanged;
        
        /// <summary>
        /// Raises the IsNetGrossPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsNetGrossPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsNetGrossPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsNetGrossPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsNetGrossPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsNetGrossPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThermalGeneratingUnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThermalGeneratingUnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThermalGeneratingUnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThermalGeneratingUnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThermalGeneratingUnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThermalGeneratingUnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ThermalGeneratingUnit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetThermalGeneratingUnit(object sender, System.EventArgs eventArgs)
        {
            this.ThermalGeneratingUnit = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ISNETGROSSP"))
            {
                return this.IsNetGrossP;
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
            if ((feature == "THERMALGENERATINGUNIT"))
            {
                this.ThermalGeneratingUnit = ((IThermalGeneratingUnit)(value));
                return;
            }
            if ((feature == "ISNETGROSSP"))
            {
                this.IsNetGrossP = ((bool)(value));
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
            if ((attribute == "ThermalGeneratingUnit"))
            {
                return new ThermalGeneratingUnitProxy(this);
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
            if ((reference == "ThermalGeneratingUnit"))
            {
                return new ThermalGeneratingUnitProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/HeatRat" +
                        "eCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the HeatRateCurve class
        /// </summary>
        public class HeatRateCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private HeatRateCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public HeatRateCurveReferencedElementsCollection(HeatRateCurve parent)
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
                    if ((this._parent.ThermalGeneratingUnit != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ThermalGeneratingUnitChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ThermalGeneratingUnitChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ThermalGeneratingUnit == null))
                {
                    IThermalGeneratingUnit thermalGeneratingUnitCasted = item.As<IThermalGeneratingUnit>();
                    if ((thermalGeneratingUnitCasted != null))
                    {
                        this._parent.ThermalGeneratingUnit = thermalGeneratingUnitCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ThermalGeneratingUnit = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ThermalGeneratingUnit))
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
                if ((this._parent.ThermalGeneratingUnit != null))
                {
                    array[arrayIndex] = this._parent.ThermalGeneratingUnit;
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
                if ((this._parent.ThermalGeneratingUnit == item))
                {
                    this._parent.ThermalGeneratingUnit = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ThermalGeneratingUnit).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the isNetGrossP property
        /// </summary>
        private sealed class IsNetGrossPProxy : ModelPropertyChange<IHeatRateCurve, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsNetGrossPProxy(IHeatRateCurve modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsNetGrossP;
                }
                set
                {
                    this.ModelElement.IsNetGrossP = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsNetGrossPChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsNetGrossPChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ThermalGeneratingUnit property
        /// </summary>
        private sealed class ThermalGeneratingUnitProxy : ModelPropertyChange<IHeatRateCurve, IThermalGeneratingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ThermalGeneratingUnitProxy(IHeatRateCurve modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IThermalGeneratingUnit Value
            {
                get
                {
                    return this.ModelElement.ThermalGeneratingUnit;
                }
                set
                {
                    this.ModelElement.ThermalGeneratingUnit = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ThermalGeneratingUnitChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ThermalGeneratingUnitChanged -= handler;
            }
        }
    }
}

