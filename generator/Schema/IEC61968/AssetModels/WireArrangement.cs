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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.AssetModels
{
    
    
    /// <summary>
    /// The default implementation of the WireArrangement class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#AssetModels")]
    [XmlNamespacePrefixAttribute("cimAssetModels")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/WireArrangement")]
    [DebuggerDisplayAttribute("WireArrangement {UUID}")]
    public class WireArrangement : IdentifiedObject, IWireArrangement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MountingPointX property
        /// </summary>
        private float _mountingPointX;
        
        /// <summary>
        /// The backing field for the MountingPointY property
        /// </summary>
        private float _mountingPointY;
        
        /// <summary>
        /// The backing field for the Position property
        /// </summary>
        private int _position;
        
        /// <summary>
        /// The backing field for the WireType property
        /// </summary>
        private IWireType _wireType;
        
        /// <summary>
        /// The backing field for the ConductorInfo property
        /// </summary>
        private IConductorInfo _conductorInfo;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The mountingPointX property
        /// </summary>
        [XmlElementNameAttribute("mountingPointX")]
        [XmlAttributeAttribute(true)]
        public virtual float MountingPointX
        {
            get
            {
                return this._mountingPointX;
            }
            set
            {
                if ((this._mountingPointX != value))
                {
                    float old = this._mountingPointX;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMountingPointXChanging(e);
                    this.OnPropertyChanging("MountingPointX", e);
                    this._mountingPointX = value;
                    this.OnMountingPointXChanged(e);
                    this.OnPropertyChanged("MountingPointX", e);
                }
            }
        }
        
        /// <summary>
        /// The mountingPointY property
        /// </summary>
        [XmlElementNameAttribute("mountingPointY")]
        [XmlAttributeAttribute(true)]
        public virtual float MountingPointY
        {
            get
            {
                return this._mountingPointY;
            }
            set
            {
                if ((this._mountingPointY != value))
                {
                    float old = this._mountingPointY;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMountingPointYChanging(e);
                    this.OnPropertyChanging("MountingPointY", e);
                    this._mountingPointY = value;
                    this.OnMountingPointYChanged(e);
                    this.OnPropertyChanged("MountingPointY", e);
                }
            }
        }
        
        /// <summary>
        /// The position property
        /// </summary>
        [XmlElementNameAttribute("position")]
        [XmlAttributeAttribute(true)]
        public virtual int Position
        {
            get
            {
                return this._position;
            }
            set
            {
                if ((this._position != value))
                {
                    int old = this._position;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPositionChanging(e);
                    this.OnPropertyChanging("Position", e);
                    this._position = value;
                    this.OnPositionChanged(e);
                    this.OnPropertyChanged("Position", e);
                }
            }
        }
        
        /// <summary>
        /// The WireType property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WireArrangements")]
        public virtual IWireType WireType
        {
            get
            {
                return this._wireType;
            }
            set
            {
                if ((this._wireType != value))
                {
                    IWireType old = this._wireType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWireTypeChanging(e);
                    this.OnPropertyChanging("WireType", e);
                    this._wireType = value;
                    if ((old != null))
                    {
                        old.WireArrangements.Remove(this);
                        old.Deleted -= this.OnResetWireType;
                    }
                    if ((value != null))
                    {
                        value.WireArrangements.Add(this);
                        value.Deleted += this.OnResetWireType;
                    }
                    this.OnWireTypeChanged(e);
                    this.OnPropertyChanged("WireType", e);
                }
            }
        }
        
        /// <summary>
        /// The ConductorInfo property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WireArrangements")]
        public virtual IConductorInfo ConductorInfo
        {
            get
            {
                return this._conductorInfo;
            }
            set
            {
                if ((this._conductorInfo != value))
                {
                    IConductorInfo old = this._conductorInfo;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConductorInfoChanging(e);
                    this.OnPropertyChanging("ConductorInfo", e);
                    this._conductorInfo = value;
                    if ((old != null))
                    {
                        old.WireArrangements.Remove(this);
                        old.Deleted -= this.OnResetConductorInfo;
                    }
                    if ((value != null))
                    {
                        value.WireArrangements.Add(this);
                        value.Deleted += this.OnResetConductorInfo;
                    }
                    this.OnConductorInfoChanged(e);
                    this.OnPropertyChanged("ConductorInfo", e);
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
                return base.ReferencedElements.Concat(new WireArrangementReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/WireArrangement")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MountingPointX property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MountingPointXChanging;
        
        /// <summary>
        /// Gets fired when the MountingPointX property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MountingPointXChanged;
        
        /// <summary>
        /// Gets fired before the MountingPointY property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MountingPointYChanging;
        
        /// <summary>
        /// Gets fired when the MountingPointY property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MountingPointYChanged;
        
        /// <summary>
        /// Gets fired before the Position property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PositionChanging;
        
        /// <summary>
        /// Gets fired when the Position property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PositionChanged;
        
        /// <summary>
        /// Gets fired before the WireType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WireTypeChanging;
        
        /// <summary>
        /// Gets fired when the WireType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WireTypeChanged;
        
        /// <summary>
        /// Gets fired before the ConductorInfo property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductorInfoChanging;
        
        /// <summary>
        /// Gets fired when the ConductorInfo property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductorInfoChanged;
        
        /// <summary>
        /// Raises the MountingPointXChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMountingPointXChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MountingPointXChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MountingPointXChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMountingPointXChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MountingPointXChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MountingPointYChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMountingPointYChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MountingPointYChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MountingPointYChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMountingPointYChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MountingPointYChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PositionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPositionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PositionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PositionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPositionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PositionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WireTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWireTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WireTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WireTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWireTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WireTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the WireType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetWireType(object sender, System.EventArgs eventArgs)
        {
            this.WireType = null;
        }
        
        /// <summary>
        /// Raises the ConductorInfoChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductorInfoChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductorInfoChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConductorInfoChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductorInfoChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductorInfoChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ConductorInfo property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConductorInfo(object sender, System.EventArgs eventArgs)
        {
            this.ConductorInfo = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MOUNTINGPOINTX"))
            {
                return this.MountingPointX;
            }
            if ((attribute == "MOUNTINGPOINTY"))
            {
                return this.MountingPointY;
            }
            if ((attribute == "POSITION"))
            {
                return this.Position;
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
            if ((feature == "WIRETYPE"))
            {
                this.WireType = ((IWireType)(value));
                return;
            }
            if ((feature == "CONDUCTORINFO"))
            {
                this.ConductorInfo = ((IConductorInfo)(value));
                return;
            }
            if ((feature == "MOUNTINGPOINTX"))
            {
                this.MountingPointX = ((float)(value));
                return;
            }
            if ((feature == "MOUNTINGPOINTY"))
            {
                this.MountingPointY = ((float)(value));
                return;
            }
            if ((feature == "POSITION"))
            {
                this.Position = ((int)(value));
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
            if ((attribute == "WireType"))
            {
                return new WireTypeProxy(this);
            }
            if ((attribute == "ConductorInfo"))
            {
                return new ConductorInfoProxy(this);
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
            if ((reference == "WireType"))
            {
                return new WireTypeProxy(this);
            }
            if ((reference == "ConductorInfo"))
            {
                return new ConductorInfoProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/AssetModels/WireArrangement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the WireArrangement class
        /// </summary>
        public class WireArrangementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private WireArrangement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WireArrangementReferencedElementsCollection(WireArrangement parent)
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
                    if ((this._parent.WireType != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ConductorInfo != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.WireTypeChanged += this.PropagateValueChanges;
                this._parent.ConductorInfoChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.WireTypeChanged -= this.PropagateValueChanges;
                this._parent.ConductorInfoChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.WireType == null))
                {
                    IWireType wireTypeCasted = item.As<IWireType>();
                    if ((wireTypeCasted != null))
                    {
                        this._parent.WireType = wireTypeCasted;
                        return;
                    }
                }
                if ((this._parent.ConductorInfo == null))
                {
                    IConductorInfo conductorInfoCasted = item.As<IConductorInfo>();
                    if ((conductorInfoCasted != null))
                    {
                        this._parent.ConductorInfo = conductorInfoCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.WireType = null;
                this._parent.ConductorInfo = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.WireType))
                {
                    return true;
                }
                if ((item == this._parent.ConductorInfo))
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
                if ((this._parent.WireType != null))
                {
                    array[arrayIndex] = this._parent.WireType;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ConductorInfo != null))
                {
                    array[arrayIndex] = this._parent.ConductorInfo;
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
                if ((this._parent.WireType == item))
                {
                    this._parent.WireType = null;
                    return true;
                }
                if ((this._parent.ConductorInfo == item))
                {
                    this._parent.ConductorInfo = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.WireType).Concat(this._parent.ConductorInfo).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the mountingPointX property
        /// </summary>
        private sealed class MountingPointXProxy : ModelPropertyChange<IWireArrangement, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MountingPointXProxy(IWireArrangement modelElement) : 
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
                    return this.ModelElement.MountingPointX;
                }
                set
                {
                    this.ModelElement.MountingPointX = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MountingPointXChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MountingPointXChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the mountingPointY property
        /// </summary>
        private sealed class MountingPointYProxy : ModelPropertyChange<IWireArrangement, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MountingPointYProxy(IWireArrangement modelElement) : 
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
                    return this.ModelElement.MountingPointY;
                }
                set
                {
                    this.ModelElement.MountingPointY = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MountingPointYChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MountingPointYChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the position property
        /// </summary>
        private sealed class PositionProxy : ModelPropertyChange<IWireArrangement, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PositionProxy(IWireArrangement modelElement) : 
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
                    return this.ModelElement.Position;
                }
                set
                {
                    this.ModelElement.Position = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PositionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PositionChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the WireType property
        /// </summary>
        private sealed class WireTypeProxy : ModelPropertyChange<IWireArrangement, IWireType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WireTypeProxy(IWireArrangement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IWireType Value
            {
                get
                {
                    return this.ModelElement.WireType;
                }
                set
                {
                    this.ModelElement.WireType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.WireTypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.WireTypeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ConductorInfo property
        /// </summary>
        private sealed class ConductorInfoProxy : ModelPropertyChange<IWireArrangement, IConductorInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConductorInfoProxy(IWireArrangement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IConductorInfo Value
            {
                get
                {
                    return this.ModelElement.ConductorInfo;
                }
                set
                {
                    this.ModelElement.ConductorInfo = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConductorInfoChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConductorInfoChanged -= handler;
            }
        }
    }
}

