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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The default implementation of the ShuntCompensatorInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/ShuntCo" +
        "mpensatorInfo")]
    [DebuggerDisplayAttribute("ShuntCompensatorInfo {UUID}")]
    public class ShuntCompensatorInfo : ElectricalInfo, IShuntCompensatorInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MaxPowerLoss property
        /// </summary>
        private float _maxPowerLoss;
        
        /// <summary>
        /// The backing field for the ShuntImpedanceInfo property
        /// </summary>
        private IShuntImpedanceInfo _shuntImpedanceInfo;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The maxPowerLoss property
        /// </summary>
        [XmlElementNameAttribute("maxPowerLoss")]
        [XmlAttributeAttribute(true)]
        public virtual float MaxPowerLoss
        {
            get
            {
                return this._maxPowerLoss;
            }
            set
            {
                if ((this._maxPowerLoss != value))
                {
                    float old = this._maxPowerLoss;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxPowerLossChanging(e);
                    this.OnPropertyChanging("MaxPowerLoss", e);
                    this._maxPowerLoss = value;
                    this.OnMaxPowerLossChanged(e);
                    this.OnPropertyChanged("MaxPowerLoss", e);
                }
            }
        }
        
        /// <summary>
        /// The ShuntImpedanceInfo property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ShuntCompensatorInfos")]
        public virtual IShuntImpedanceInfo ShuntImpedanceInfo
        {
            get
            {
                return this._shuntImpedanceInfo;
            }
            set
            {
                if ((this._shuntImpedanceInfo != value))
                {
                    IShuntImpedanceInfo old = this._shuntImpedanceInfo;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnShuntImpedanceInfoChanging(e);
                    this.OnPropertyChanging("ShuntImpedanceInfo", e);
                    this._shuntImpedanceInfo = value;
                    if ((old != null))
                    {
                        old.ShuntCompensatorInfos.Remove(this);
                        old.Deleted -= this.OnResetShuntImpedanceInfo;
                    }
                    if ((value != null))
                    {
                        value.ShuntCompensatorInfos.Add(this);
                        value.Deleted += this.OnResetShuntImpedanceInfo;
                    }
                    this.OnShuntImpedanceInfoChanged(e);
                    this.OnPropertyChanged("ShuntImpedanceInfo", e);
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
                return base.ReferencedElements.Concat(new ShuntCompensatorInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/ShuntCo" +
                            "mpensatorInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MaxPowerLoss property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxPowerLossChanging;
        
        /// <summary>
        /// Gets fired when the MaxPowerLoss property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxPowerLossChanged;
        
        /// <summary>
        /// Gets fired before the ShuntImpedanceInfo property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShuntImpedanceInfoChanging;
        
        /// <summary>
        /// Gets fired when the ShuntImpedanceInfo property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShuntImpedanceInfoChanged;
        
        /// <summary>
        /// Raises the MaxPowerLossChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxPowerLossChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxPowerLossChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxPowerLossChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxPowerLossChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxPowerLossChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ShuntImpedanceInfoChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShuntImpedanceInfoChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShuntImpedanceInfoChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ShuntImpedanceInfoChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShuntImpedanceInfoChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShuntImpedanceInfoChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ShuntImpedanceInfo property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetShuntImpedanceInfo(object sender, System.EventArgs eventArgs)
        {
            this.ShuntImpedanceInfo = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MAXPOWERLOSS"))
            {
                return this.MaxPowerLoss;
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
            if ((feature == "SHUNTIMPEDANCEINFO"))
            {
                this.ShuntImpedanceInfo = ((IShuntImpedanceInfo)(value));
                return;
            }
            if ((feature == "MAXPOWERLOSS"))
            {
                this.MaxPowerLoss = ((float)(value));
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
            if ((attribute == "ShuntImpedanceInfo"))
            {
                return new ShuntImpedanceInfoProxy(this);
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
            if ((reference == "ShuntImpedanceInfo"))
            {
                return new ShuntImpedanceInfoProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/ShuntCo" +
                        "mpensatorInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ShuntCompensatorInfo class
        /// </summary>
        public class ShuntCompensatorInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ShuntCompensatorInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ShuntCompensatorInfoReferencedElementsCollection(ShuntCompensatorInfo parent)
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
                    if ((this._parent.ShuntImpedanceInfo != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ShuntImpedanceInfoChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ShuntImpedanceInfoChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ShuntImpedanceInfo == null))
                {
                    IShuntImpedanceInfo shuntImpedanceInfoCasted = item.As<IShuntImpedanceInfo>();
                    if ((shuntImpedanceInfoCasted != null))
                    {
                        this._parent.ShuntImpedanceInfo = shuntImpedanceInfoCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ShuntImpedanceInfo = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ShuntImpedanceInfo))
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
                if ((this._parent.ShuntImpedanceInfo != null))
                {
                    array[arrayIndex] = this._parent.ShuntImpedanceInfo;
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
                if ((this._parent.ShuntImpedanceInfo == item))
                {
                    this._parent.ShuntImpedanceInfo = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ShuntImpedanceInfo).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the maxPowerLoss property
        /// </summary>
        private sealed class MaxPowerLossProxy : ModelPropertyChange<IShuntCompensatorInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxPowerLossProxy(IShuntCompensatorInfo modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MaxPowerLoss;
                }
                set
                {
                    this.ModelElement.MaxPowerLoss = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxPowerLossChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MaxPowerLossChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ShuntImpedanceInfo property
        /// </summary>
        private sealed class ShuntImpedanceInfoProxy : ModelPropertyChange<IShuntCompensatorInfo, IShuntImpedanceInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ShuntImpedanceInfoProxy(IShuntCompensatorInfo modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IShuntImpedanceInfo Value
            {
                get
                {
                    return this.ModelElement.ShuntImpedanceInfo;
                }
                set
                {
                    this.ModelElement.ShuntImpedanceInfo = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ShuntImpedanceInfoChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ShuntImpedanceInfoChanged -= handler;
            }
        }
    }
}

