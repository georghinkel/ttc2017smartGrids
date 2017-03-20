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
    /// The default implementation of the ElectricalAsset class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Electri" +
        "calAsset")]
    [DebuggerDisplayAttribute("ElectricalAsset {UUID}")]
    public partial class ElectricalAsset : Asset, IElectricalAsset, IModelElement
    {
        
        /// <summary>
        /// The backing field for the PhaseCode property
        /// </summary>
        private Nullable<PhaseCode> _phaseCode;
        
        private static Lazy<ITypedElement> _phaseCodeAttribute = new Lazy<ITypedElement>(RetrievePhaseCodeAttribute);
        
        /// <summary>
        /// The backing field for the IsConnected property
        /// </summary>
        private bool _isConnected;
        
        private static Lazy<ITypedElement> _isConnectedAttribute = new Lazy<ITypedElement>(RetrieveIsConnectedAttribute);
        
        private static Lazy<ITypedElement> _conductingEquipmentReference = new Lazy<ITypedElement>(RetrieveConductingEquipmentReference);
        
        /// <summary>
        /// The backing field for the ConductingEquipment property
        /// </summary>
        private IConductingEquipment _conductingEquipment;
        
        private static Lazy<ITypedElement> _electricalInfosReference = new Lazy<ITypedElement>(RetrieveElectricalInfosReference);
        
        /// <summary>
        /// The backing field for the ElectricalInfos property
        /// </summary>
        private ElectricalAssetElectricalInfosCollection _electricalInfos;
        
        private static IClass _classInstance;
        
        public ElectricalAsset()
        {
            this._electricalInfos = new ElectricalAssetElectricalInfosCollection(this);
            this._electricalInfos.CollectionChanging += this.ElectricalInfosCollectionChanging;
            this._electricalInfos.CollectionChanged += this.ElectricalInfosCollectionChanged;
        }
        
        /// <summary>
        /// The phaseCode property
        /// </summary>
        [XmlElementNameAttribute("phaseCode")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<PhaseCode> PhaseCode
        {
            get
            {
                return this._phaseCode;
            }
            set
            {
                if ((this._phaseCode != value))
                {
                    Nullable<PhaseCode> old = this._phaseCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhaseCodeChanging(e);
                    this.OnPropertyChanging("PhaseCode", e, _phaseCodeAttribute);
                    this._phaseCode = value;
                    this.OnPhaseCodeChanged(e);
                    this.OnPropertyChanged("PhaseCode", e, _phaseCodeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The isConnected property
        /// </summary>
        [XmlElementNameAttribute("isConnected")]
        [XmlAttributeAttribute(true)]
        public virtual bool IsConnected
        {
            get
            {
                return this._isConnected;
            }
            set
            {
                if ((this._isConnected != value))
                {
                    bool old = this._isConnected;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsConnectedChanging(e);
                    this.OnPropertyChanging("IsConnected", e, _isConnectedAttribute);
                    this._isConnected = value;
                    this.OnIsConnectedChanged(e);
                    this.OnPropertyChanged("IsConnected", e, _isConnectedAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ConductingEquipment property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ElectricalAssets")]
        public virtual IConductingEquipment ConductingEquipment
        {
            get
            {
                return this._conductingEquipment;
            }
            set
            {
                if ((this._conductingEquipment != value))
                {
                    IConductingEquipment old = this._conductingEquipment;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConductingEquipmentChanging(e);
                    this.OnPropertyChanging("ConductingEquipment", e, _conductingEquipmentReference);
                    this._conductingEquipment = value;
                    if ((old != null))
                    {
                        old.ElectricalAssets.Remove(this);
                        old.Deleted -= this.OnResetConductingEquipment;
                    }
                    if ((value != null))
                    {
                        value.ElectricalAssets.Add(this);
                        value.Deleted += this.OnResetConductingEquipment;
                    }
                    this.OnConductingEquipmentChanged(e);
                    this.OnPropertyChanged("ConductingEquipment", e, _conductingEquipmentReference);
                }
            }
        }
        
        /// <summary>
        /// The ElectricalInfos property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ElectricalAssets")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IElectricalInfo> ElectricalInfos
        {
            get
            {
                return this._electricalInfos;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ElectricalAssetReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Electri" +
                            "calAsset")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PhaseCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseCodeChanging;
        
        /// <summary>
        /// Gets fired when the PhaseCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseCodeChanged;
        
        /// <summary>
        /// Gets fired before the IsConnected property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsConnectedChanging;
        
        /// <summary>
        /// Gets fired when the IsConnected property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsConnectedChanged;
        
        /// <summary>
        /// Gets fired before the ConductingEquipment property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanging;
        
        /// <summary>
        /// Gets fired when the ConductingEquipment property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanged;
        
        private static ITypedElement RetrievePhaseCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ElectricalAsset.ClassInstance)).Resolve("phaseCode")));
        }
        
        /// <summary>
        /// Raises the PhaseCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhaseCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveIsConnectedAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ElectricalAsset.ClassInstance)).Resolve("isConnected")));
        }
        
        /// <summary>
        /// Raises the IsConnectedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsConnectedChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsConnectedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsConnectedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsConnectedChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsConnectedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveConductingEquipmentReference()
        {
            return ((ITypedElement)(((ModelElement)(ElectricalAsset.ClassInstance)).Resolve("ConductingEquipment")));
        }
        
        /// <summary>
        /// Raises the ConductingEquipmentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductingEquipmentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductingEquipmentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConductingEquipmentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductingEquipmentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductingEquipmentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ConductingEquipment property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConductingEquipment(object sender, System.EventArgs eventArgs)
        {
            this.ConductingEquipment = null;
        }
        
        private static ITypedElement RetrieveElectricalInfosReference()
        {
            return ((ITypedElement)(((ModelElement)(ElectricalAsset.ClassInstance)).Resolve("ElectricalInfos")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ElectricalInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ElectricalInfosCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ElectricalInfos", e, _electricalInfosReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ElectricalInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ElectricalInfosCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ElectricalInfos", e, _electricalInfosReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "PHASECODE"))
            {
                return this.PhaseCode;
            }
            if ((attribute == "ISCONNECTED"))
            {
                return this.IsConnected;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ELECTRICALINFOS"))
            {
                return this._electricalInfos;
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
            if ((feature == "CONDUCTINGEQUIPMENT"))
            {
                this.ConductingEquipment = ((IConductingEquipment)(value));
                return;
            }
            if ((feature == "PHASECODE"))
            {
                this.PhaseCode = ((PhaseCode)(value));
                return;
            }
            if ((feature == "ISCONNECTED"))
            {
                this.IsConnected = ((bool)(value));
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
            if ((attribute == "ConductingEquipment"))
            {
                return new ConductingEquipmentProxy(this);
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
            if ((reference == "ConductingEquipment"))
            {
                return new ConductingEquipmentProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Electri" +
                        "calAsset")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ElectricalAsset class
        /// </summary>
        public class ElectricalAssetReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ElectricalAsset _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ElectricalAssetReferencedElementsCollection(ElectricalAsset parent)
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
                    if ((this._parent.ConductingEquipment != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.ElectricalInfos.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConductingEquipmentChanged += this.PropagateValueChanges;
                this._parent.ElectricalInfos.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConductingEquipmentChanged -= this.PropagateValueChanges;
                this._parent.ElectricalInfos.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ConductingEquipment == null))
                {
                    IConductingEquipment conductingEquipmentCasted = item.As<IConductingEquipment>();
                    if ((conductingEquipmentCasted != null))
                    {
                        this._parent.ConductingEquipment = conductingEquipmentCasted;
                        return;
                    }
                }
                IElectricalInfo electricalInfosCasted = item.As<IElectricalInfo>();
                if ((electricalInfosCasted != null))
                {
                    this._parent.ElectricalInfos.Add(electricalInfosCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConductingEquipment = null;
                this._parent.ElectricalInfos.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ConductingEquipment))
                {
                    return true;
                }
                if (this._parent.ElectricalInfos.Contains(item))
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
                if ((this._parent.ConductingEquipment != null))
                {
                    array[arrayIndex] = this._parent.ConductingEquipment;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> electricalInfosEnumerator = this._parent.ElectricalInfos.GetEnumerator();
                try
                {
                    for (
                    ; electricalInfosEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = electricalInfosEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    electricalInfosEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ConductingEquipment == item))
                {
                    this._parent.ConductingEquipment = null;
                    return true;
                }
                IElectricalInfo electricalInfoItem = item.As<IElectricalInfo>();
                if (((electricalInfoItem != null) 
                            && this._parent.ElectricalInfos.Remove(electricalInfoItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConductingEquipment).Concat(this._parent.ElectricalInfos).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the phaseCode property
        /// </summary>
        private sealed class PhaseCodeProxy : ModelPropertyChange<IElectricalAsset, Nullable<PhaseCode>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhaseCodeProxy(IElectricalAsset modelElement) : 
                    base(modelElement, "phaseCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<PhaseCode> Value
            {
                get
                {
                    return this.ModelElement.PhaseCode;
                }
                set
                {
                    this.ModelElement.PhaseCode = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the isConnected property
        /// </summary>
        private sealed class IsConnectedProxy : ModelPropertyChange<IElectricalAsset, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsConnectedProxy(IElectricalAsset modelElement) : 
                    base(modelElement, "isConnected")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsConnected;
                }
                set
                {
                    this.ModelElement.IsConnected = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ConductingEquipment property
        /// </summary>
        private sealed class ConductingEquipmentProxy : ModelPropertyChange<IElectricalAsset, IConductingEquipment>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConductingEquipmentProxy(IElectricalAsset modelElement) : 
                    base(modelElement, "ConductingEquipment")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IConductingEquipment Value
            {
                get
                {
                    return this.ModelElement.ConductingEquipment;
                }
                set
                {
                    this.ModelElement.ConductingEquipment = value;
                }
            }
        }
    }
}

