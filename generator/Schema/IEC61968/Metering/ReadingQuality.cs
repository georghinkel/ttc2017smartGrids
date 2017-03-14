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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The default implementation of the ReadingQuality class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Metering")]
    [XmlNamespacePrefixAttribute("cimMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/ReadingQuality")]
    [DebuggerDisplayAttribute("ReadingQuality {UUID}")]
    public class ReadingQuality : Element, IReadingQuality, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Quality property
        /// </summary>
        private string _quality;
        
        /// <summary>
        /// The backing field for the IntervalReading property
        /// </summary>
        private IIntervalReading _intervalReading;
        
        /// <summary>
        /// The backing field for the Reading property
        /// </summary>
        private IReading _reading;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The quality property
        /// </summary>
        [XmlElementNameAttribute("quality")]
        [XmlAttributeAttribute(true)]
        public virtual string Quality
        {
            get
            {
                return this._quality;
            }
            set
            {
                if ((this._quality != value))
                {
                    string old = this._quality;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnQualityChanging(e);
                    this.OnPropertyChanging("Quality", e);
                    this._quality = value;
                    this.OnQualityChanged(e);
                    this.OnPropertyChanged("Quality", e);
                }
            }
        }
        
        /// <summary>
        /// The IntervalReading property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReadingQualities")]
        public virtual IIntervalReading IntervalReading
        {
            get
            {
                return this._intervalReading;
            }
            set
            {
                if ((this._intervalReading != value))
                {
                    IIntervalReading old = this._intervalReading;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIntervalReadingChanging(e);
                    this.OnPropertyChanging("IntervalReading", e);
                    this._intervalReading = value;
                    if ((old != null))
                    {
                        old.ReadingQualities.Remove(this);
                        old.Deleted -= this.OnResetIntervalReading;
                    }
                    if ((value != null))
                    {
                        value.ReadingQualities.Add(this);
                        value.Deleted += this.OnResetIntervalReading;
                    }
                    this.OnIntervalReadingChanged(e);
                    this.OnPropertyChanged("IntervalReading", e);
                }
            }
        }
        
        /// <summary>
        /// The Reading property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReadingQualities")]
        public virtual IReading Reading
        {
            get
            {
                return this._reading;
            }
            set
            {
                if ((this._reading != value))
                {
                    IReading old = this._reading;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReadingChanging(e);
                    this.OnPropertyChanging("Reading", e);
                    this._reading = value;
                    if ((old != null))
                    {
                        old.ReadingQualities.Remove(this);
                        old.Deleted -= this.OnResetReading;
                    }
                    if ((value != null))
                    {
                        value.ReadingQualities.Add(this);
                        value.Deleted += this.OnResetReading;
                    }
                    this.OnReadingChanged(e);
                    this.OnPropertyChanged("Reading", e);
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
                return base.ReferencedElements.Concat(new ReadingQualityReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/ReadingQuality")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Quality property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QualityChanging;
        
        /// <summary>
        /// Gets fired when the Quality property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QualityChanged;
        
        /// <summary>
        /// Gets fired before the IntervalReading property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IntervalReadingChanging;
        
        /// <summary>
        /// Gets fired when the IntervalReading property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IntervalReadingChanged;
        
        /// <summary>
        /// Gets fired before the Reading property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReadingChanging;
        
        /// <summary>
        /// Gets fired when the Reading property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReadingChanged;
        
        /// <summary>
        /// Raises the QualityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQualityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QualityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the QualityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQualityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QualityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IntervalReadingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIntervalReadingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IntervalReadingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IntervalReadingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIntervalReadingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IntervalReadingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the IntervalReading property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetIntervalReading(object sender, System.EventArgs eventArgs)
        {
            this.IntervalReading = null;
        }
        
        /// <summary>
        /// Raises the ReadingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReadingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReadingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReadingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReadingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReadingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Reading property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReading(object sender, System.EventArgs eventArgs)
        {
            this.Reading = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "QUALITY"))
            {
                return this.Quality;
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
            if ((feature == "INTERVALREADING"))
            {
                this.IntervalReading = ((IIntervalReading)(value));
                return;
            }
            if ((feature == "READING"))
            {
                this.Reading = ((IReading)(value));
                return;
            }
            if ((feature == "QUALITY"))
            {
                this.Quality = ((string)(value));
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
            if ((attribute == "IntervalReading"))
            {
                return new IntervalReadingProxy(this);
            }
            if ((attribute == "Reading"))
            {
                return new ReadingProxy(this);
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
            if ((reference == "IntervalReading"))
            {
                return new IntervalReadingProxy(this);
            }
            if ((reference == "Reading"))
            {
                return new ReadingProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/ReadingQuality")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ReadingQuality class
        /// </summary>
        public class ReadingQualityReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ReadingQuality _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ReadingQualityReferencedElementsCollection(ReadingQuality parent)
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
                    if ((this._parent.IntervalReading != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Reading != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.IntervalReadingChanged += this.PropagateValueChanges;
                this._parent.ReadingChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.IntervalReadingChanged -= this.PropagateValueChanges;
                this._parent.ReadingChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.IntervalReading == null))
                {
                    IIntervalReading intervalReadingCasted = item.As<IIntervalReading>();
                    if ((intervalReadingCasted != null))
                    {
                        this._parent.IntervalReading = intervalReadingCasted;
                        return;
                    }
                }
                if ((this._parent.Reading == null))
                {
                    IReading readingCasted = item.As<IReading>();
                    if ((readingCasted != null))
                    {
                        this._parent.Reading = readingCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.IntervalReading = null;
                this._parent.Reading = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.IntervalReading))
                {
                    return true;
                }
                if ((item == this._parent.Reading))
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
                if ((this._parent.IntervalReading != null))
                {
                    array[arrayIndex] = this._parent.IntervalReading;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Reading != null))
                {
                    array[arrayIndex] = this._parent.Reading;
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
                if ((this._parent.IntervalReading == item))
                {
                    this._parent.IntervalReading = null;
                    return true;
                }
                if ((this._parent.Reading == item))
                {
                    this._parent.Reading = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.IntervalReading).Concat(this._parent.Reading).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the quality property
        /// </summary>
        private sealed class QualityProxy : ModelPropertyChange<IReadingQuality, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public QualityProxy(IReadingQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Quality;
                }
                set
                {
                    this.ModelElement.Quality = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.QualityChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.QualityChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IntervalReading property
        /// </summary>
        private sealed class IntervalReadingProxy : ModelPropertyChange<IReadingQuality, IIntervalReading>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IntervalReadingProxy(IReadingQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IIntervalReading Value
            {
                get
                {
                    return this.ModelElement.IntervalReading;
                }
                set
                {
                    this.ModelElement.IntervalReading = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IntervalReadingChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IntervalReadingChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Reading property
        /// </summary>
        private sealed class ReadingProxy : ModelPropertyChange<IReadingQuality, IReading>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReadingProxy(IReadingQuality modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IReading Value
            {
                get
                {
                    return this.ModelElement.Reading;
                }
                set
                {
                    this.ModelElement.Reading = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReadingChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReadingChanged -= handler;
            }
        }
    }
}
