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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling
{
    
    
    /// <summary>
    /// The default implementation of the ProfileData class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#EnergyScheduling")]
    [XmlNamespacePrefixAttribute("cimEnergyScheduling")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
        "ProfileData")]
    [DebuggerDisplayAttribute("ProfileData {UUID}")]
    public class ProfileData : Element, IProfileData, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CapacityLevel property
        /// </summary>
        private float _capacityLevel;
        
        /// <summary>
        /// The backing field for the StartDateTime property
        /// </summary>
        private DateTime _startDateTime;
        
        /// <summary>
        /// The backing field for the SequenceNumber property
        /// </summary>
        private int _sequenceNumber;
        
        /// <summary>
        /// The backing field for the StopDateTime property
        /// </summary>
        private DateTime _stopDateTime;
        
        /// <summary>
        /// The backing field for the EnergyLevel property
        /// </summary>
        private float _energyLevel;
        
        /// <summary>
        /// The backing field for the Profile property
        /// </summary>
        private ProfileDataProfileCollection _profile;
        
        private static IClass _classInstance;
        
        public ProfileData()
        {
            this._profile = new ProfileDataProfileCollection(this);
            this._profile.CollectionChanging += this.ProfileCollectionChanging;
            this._profile.CollectionChanged += this.ProfileCollectionChanged;
        }
        
        /// <summary>
        /// The capacityLevel property
        /// </summary>
        [XmlElementNameAttribute("capacityLevel")]
        [XmlAttributeAttribute(true)]
        public virtual float CapacityLevel
        {
            get
            {
                return this._capacityLevel;
            }
            set
            {
                if ((this._capacityLevel != value))
                {
                    float old = this._capacityLevel;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCapacityLevelChanging(e);
                    this.OnPropertyChanging("CapacityLevel", e);
                    this._capacityLevel = value;
                    this.OnCapacityLevelChanged(e);
                    this.OnPropertyChanged("CapacityLevel", e);
                }
            }
        }
        
        /// <summary>
        /// The startDateTime property
        /// </summary>
        [XmlElementNameAttribute("startDateTime")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime StartDateTime
        {
            get
            {
                return this._startDateTime;
            }
            set
            {
                if ((this._startDateTime != value))
                {
                    DateTime old = this._startDateTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartDateTimeChanging(e);
                    this.OnPropertyChanging("StartDateTime", e);
                    this._startDateTime = value;
                    this.OnStartDateTimeChanged(e);
                    this.OnPropertyChanged("StartDateTime", e);
                }
            }
        }
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        [XmlElementNameAttribute("sequenceNumber")]
        [XmlAttributeAttribute(true)]
        public virtual int SequenceNumber
        {
            get
            {
                return this._sequenceNumber;
            }
            set
            {
                if ((this._sequenceNumber != value))
                {
                    int old = this._sequenceNumber;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSequenceNumberChanging(e);
                    this.OnPropertyChanging("SequenceNumber", e);
                    this._sequenceNumber = value;
                    this.OnSequenceNumberChanged(e);
                    this.OnPropertyChanged("SequenceNumber", e);
                }
            }
        }
        
        /// <summary>
        /// The stopDateTime property
        /// </summary>
        [XmlElementNameAttribute("stopDateTime")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime StopDateTime
        {
            get
            {
                return this._stopDateTime;
            }
            set
            {
                if ((this._stopDateTime != value))
                {
                    DateTime old = this._stopDateTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStopDateTimeChanging(e);
                    this.OnPropertyChanging("StopDateTime", e);
                    this._stopDateTime = value;
                    this.OnStopDateTimeChanged(e);
                    this.OnPropertyChanged("StopDateTime", e);
                }
            }
        }
        
        /// <summary>
        /// The energyLevel property
        /// </summary>
        [XmlElementNameAttribute("energyLevel")]
        [XmlAttributeAttribute(true)]
        public virtual float EnergyLevel
        {
            get
            {
                return this._energyLevel;
            }
            set
            {
                if ((this._energyLevel != value))
                {
                    float old = this._energyLevel;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnergyLevelChanging(e);
                    this.OnPropertyChanging("EnergyLevel", e);
                    this._energyLevel = value;
                    this.OnEnergyLevelChanged(e);
                    this.OnPropertyChanged("EnergyLevel", e);
                }
            }
        }
        
        /// <summary>
        /// The Profile property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProfileDatas")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IProfile> Profile
        {
            get
            {
                return this._profile;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ProfileDataReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                            "ProfileData")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CapacityLevel property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CapacityLevelChanging;
        
        /// <summary>
        /// Gets fired when the CapacityLevel property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CapacityLevelChanged;
        
        /// <summary>
        /// Gets fired before the StartDateTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the StartDateTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the StopDateTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StopDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the StopDateTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StopDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the EnergyLevel property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyLevelChanging;
        
        /// <summary>
        /// Gets fired when the EnergyLevel property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyLevelChanged;
        
        /// <summary>
        /// Raises the CapacityLevelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCapacityLevelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CapacityLevelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CapacityLevelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCapacityLevelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CapacityLevelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartDateTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartDateTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartDateTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartDateTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartDateTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartDateTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SequenceNumberChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceNumberChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceNumberChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SequenceNumberChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceNumberChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceNumberChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StopDateTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStopDateTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StopDateTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StopDateTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStopDateTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StopDateTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyLevelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyLevelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyLevelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyLevelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyLevelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyLevelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Profile property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ProfileCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Profile", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Profile property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ProfileCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Profile", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CAPACITYLEVEL"))
            {
                return this.CapacityLevel;
            }
            if ((attribute == "STARTDATETIME"))
            {
                return this.StartDateTime;
            }
            if ((attribute == "SEQUENCENUMBER"))
            {
                return this.SequenceNumber;
            }
            if ((attribute == "STOPDATETIME"))
            {
                return this.StopDateTime;
            }
            if ((attribute == "ENERGYLEVEL"))
            {
                return this.EnergyLevel;
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
            if ((feature == "PROFILE"))
            {
                return this._profile;
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
            if ((feature == "CAPACITYLEVEL"))
            {
                this.CapacityLevel = ((float)(value));
                return;
            }
            if ((feature == "STARTDATETIME"))
            {
                this.StartDateTime = ((DateTime)(value));
                return;
            }
            if ((feature == "SEQUENCENUMBER"))
            {
                this.SequenceNumber = ((int)(value));
                return;
            }
            if ((feature == "STOPDATETIME"))
            {
                this.StopDateTime = ((DateTime)(value));
                return;
            }
            if ((feature == "ENERGYLEVEL"))
            {
                this.EnergyLevel = ((float)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                        "ProfileData")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProfileData class
        /// </summary>
        public class ProfileDataReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProfileData _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProfileDataReferencedElementsCollection(ProfileData parent)
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
                    count = (count + this._parent.Profile.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Profile.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Profile.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IProfile profileCasted = item.As<IProfile>();
                if ((profileCasted != null))
                {
                    this._parent.Profile.Add(profileCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Profile.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Profile.Contains(item))
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
                IEnumerator<IModelElement> profileEnumerator = this._parent.Profile.GetEnumerator();
                try
                {
                    for (
                    ; profileEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = profileEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    profileEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IProfile profileItem = item.As<IProfile>();
                if (((profileItem != null) 
                            && this._parent.Profile.Remove(profileItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Profile).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the capacityLevel property
        /// </summary>
        private sealed class CapacityLevelProxy : ModelPropertyChange<IProfileData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CapacityLevelProxy(IProfileData modelElement) : 
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
                    return this.ModelElement.CapacityLevel;
                }
                set
                {
                    this.ModelElement.CapacityLevel = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CapacityLevelChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CapacityLevelChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the startDateTime property
        /// </summary>
        private sealed class StartDateTimeProxy : ModelPropertyChange<IProfileData, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartDateTimeProxy(IProfileData modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.StartDateTime;
                }
                set
                {
                    this.ModelElement.StartDateTime = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StartDateTimeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StartDateTimeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the sequenceNumber property
        /// </summary>
        private sealed class SequenceNumberProxy : ModelPropertyChange<IProfileData, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SequenceNumberProxy(IProfileData modelElement) : 
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
                    return this.ModelElement.SequenceNumber;
                }
                set
                {
                    this.ModelElement.SequenceNumber = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SequenceNumberChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SequenceNumberChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the stopDateTime property
        /// </summary>
        private sealed class StopDateTimeProxy : ModelPropertyChange<IProfileData, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StopDateTimeProxy(IProfileData modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.StopDateTime;
                }
                set
                {
                    this.ModelElement.StopDateTime = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StopDateTimeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StopDateTimeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the energyLevel property
        /// </summary>
        private sealed class EnergyLevelProxy : ModelPropertyChange<IProfileData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnergyLevelProxy(IProfileData modelElement) : 
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
                    return this.ModelElement.EnergyLevel;
                }
                set
                {
                    this.ModelElement.EnergyLevel = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EnergyLevelChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EnergyLevelChanged -= handler;
            }
        }
    }
}

