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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The default implementation of the HeatExchanger class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/HeatExchanger")]
    [DebuggerDisplayAttribute("HeatExchanger {UUID}")]
    public class HeatExchanger : Equipment, IHeatExchanger, IModelElement
    {
        
        /// <summary>
        /// The backing field for the PowerTransformer property
        /// </summary>
        private IPowerTransformer _powerTransformer;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The PowerTransformer property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("HeatExchanger")]
        public virtual IPowerTransformer PowerTransformer
        {
            get
            {
                return this._powerTransformer;
            }
            set
            {
                if ((this._powerTransformer != value))
                {
                    IPowerTransformer old = this._powerTransformer;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPowerTransformerChanging(e);
                    this.OnPropertyChanging("PowerTransformer", e);
                    this._powerTransformer = value;
                    if ((old != null))
                    {
                        old.HeatExchanger = null;
                        old.Deleted -= this.OnResetPowerTransformer;
                    }
                    if ((value != null))
                    {
                        value.HeatExchanger = this;
                        value.Deleted += this.OnResetPowerTransformer;
                    }
                    this.OnPowerTransformerChanged(e);
                    this.OnPropertyChanged("PowerTransformer", e);
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
                return base.ReferencedElements.Concat(new HeatExchangerReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/HeatExchanger")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PowerTransformer property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerTransformerChanging;
        
        /// <summary>
        /// Gets fired when the PowerTransformer property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerTransformerChanged;
        
        /// <summary>
        /// Raises the PowerTransformerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerTransformerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerTransformerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PowerTransformerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerTransformerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerTransformerChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PowerTransformer property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPowerTransformer(object sender, System.EventArgs eventArgs)
        {
            this.PowerTransformer = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "POWERTRANSFORMER"))
            {
                this.PowerTransformer = ((IPowerTransformer)(value));
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
            if ((attribute == "PowerTransformer"))
            {
                return new PowerTransformerProxy(this);
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
            if ((reference == "PowerTransformer"))
            {
                return new PowerTransformerProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/HeatExchanger")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the HeatExchanger class
        /// </summary>
        public class HeatExchangerReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private HeatExchanger _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public HeatExchangerReferencedElementsCollection(HeatExchanger parent)
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
                    if ((this._parent.PowerTransformer != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PowerTransformerChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PowerTransformerChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.PowerTransformer == null))
                {
                    IPowerTransformer powerTransformerCasted = item.As<IPowerTransformer>();
                    if ((powerTransformerCasted != null))
                    {
                        this._parent.PowerTransformer = powerTransformerCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PowerTransformer = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.PowerTransformer))
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
                if ((this._parent.PowerTransformer != null))
                {
                    array[arrayIndex] = this._parent.PowerTransformer;
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
                if ((this._parent.PowerTransformer == item))
                {
                    this._parent.PowerTransformer = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PowerTransformer).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PowerTransformer property
        /// </summary>
        private sealed class PowerTransformerProxy : ModelPropertyChange<IHeatExchanger, IPowerTransformer>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PowerTransformerProxy(IHeatExchanger modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPowerTransformer Value
            {
                get
                {
                    return this.ModelElement.PowerTransformer;
                }
                set
                {
                    this.ModelElement.PowerTransformer = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PowerTransformerChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PowerTransformerChanged -= handler;
            }
        }
    }
}

