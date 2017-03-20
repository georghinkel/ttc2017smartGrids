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
    /// The default implementation of the BusbarSection class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/BusbarSection")]
    [DebuggerDisplayAttribute("BusbarSection {UUID}")]
    public partial class BusbarSection : Connector, IBusbarSection, IModelElement
    {
        
        private static Lazy<ITypedElement> _voltageControlZoneReference = new Lazy<ITypedElement>(RetrieveVoltageControlZoneReference);
        
        /// <summary>
        /// The backing field for the VoltageControlZone property
        /// </summary>
        private IVoltageControlZone _voltageControlZone;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The VoltageControlZone property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("BusbarSection")]
        public virtual IVoltageControlZone VoltageControlZone
        {
            get
            {
                return this._voltageControlZone;
            }
            set
            {
                if ((this._voltageControlZone != value))
                {
                    IVoltageControlZone old = this._voltageControlZone;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVoltageControlZoneChanging(e);
                    this.OnPropertyChanging("VoltageControlZone", e, _voltageControlZoneReference);
                    this._voltageControlZone = value;
                    if ((old != null))
                    {
                        old.BusbarSection = null;
                        old.Deleted -= this.OnResetVoltageControlZone;
                    }
                    if ((value != null))
                    {
                        value.BusbarSection = this;
                        value.Deleted += this.OnResetVoltageControlZone;
                    }
                    this.OnVoltageControlZoneChanged(e);
                    this.OnPropertyChanged("VoltageControlZone", e, _voltageControlZoneReference);
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
                return base.ReferencedElements.Concat(new BusbarSectionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/BusbarSection")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the VoltageControlZone property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageControlZoneChanging;
        
        /// <summary>
        /// Gets fired when the VoltageControlZone property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageControlZoneChanged;
        
        private static ITypedElement RetrieveVoltageControlZoneReference()
        {
            return ((ITypedElement)(((ModelElement)(BusbarSection.ClassInstance)).Resolve("VoltageControlZone")));
        }
        
        /// <summary>
        /// Raises the VoltageControlZoneChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageControlZoneChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageControlZoneChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VoltageControlZoneChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageControlZoneChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageControlZoneChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the VoltageControlZone property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetVoltageControlZone(object sender, System.EventArgs eventArgs)
        {
            this.VoltageControlZone = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "VOLTAGECONTROLZONE"))
            {
                this.VoltageControlZone = ((IVoltageControlZone)(value));
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
            if ((attribute == "VoltageControlZone"))
            {
                return new VoltageControlZoneProxy(this);
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
            if ((reference == "VoltageControlZone"))
            {
                return new VoltageControlZoneProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/BusbarSection")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BusbarSection class
        /// </summary>
        public class BusbarSectionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BusbarSection _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BusbarSectionReferencedElementsCollection(BusbarSection parent)
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
                    if ((this._parent.VoltageControlZone != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.VoltageControlZoneChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.VoltageControlZoneChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.VoltageControlZone == null))
                {
                    IVoltageControlZone voltageControlZoneCasted = item.As<IVoltageControlZone>();
                    if ((voltageControlZoneCasted != null))
                    {
                        this._parent.VoltageControlZone = voltageControlZoneCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.VoltageControlZone = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.VoltageControlZone))
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
                if ((this._parent.VoltageControlZone != null))
                {
                    array[arrayIndex] = this._parent.VoltageControlZone;
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
                if ((this._parent.VoltageControlZone == item))
                {
                    this._parent.VoltageControlZone = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.VoltageControlZone).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the VoltageControlZone property
        /// </summary>
        private sealed class VoltageControlZoneProxy : ModelPropertyChange<IBusbarSection, IVoltageControlZone>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VoltageControlZoneProxy(IBusbarSection modelElement) : 
                    base(modelElement, "VoltageControlZone")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IVoltageControlZone Value
            {
                get
                {
                    return this.ModelElement.VoltageControlZone;
                }
                set
                {
                    this.ModelElement.VoltageControlZone = value;
                }
            }
        }
    }
}

