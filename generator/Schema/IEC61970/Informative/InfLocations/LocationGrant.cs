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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations
{
    
    
    /// <summary>
    /// The default implementation of the LocationGrant class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfLocations")]
    [XmlNamespacePrefixAttribute("cimInfLocations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/Loca" +
        "tionGrant")]
    [DebuggerDisplayAttribute("LocationGrant {UUID}")]
    public class LocationGrant : Agreement, ILocationGrant, IModelElement
    {
        
        /// <summary>
        /// The backing field for the PropertyData property
        /// </summary>
        private string _propertyData;
        
        /// <summary>
        /// The backing field for the LandProperty property
        /// </summary>
        private ILandProperty _landProperty;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The propertyData property
        /// </summary>
        [XmlElementNameAttribute("propertyData")]
        [XmlAttributeAttribute(true)]
        public virtual string PropertyData
        {
            get
            {
                return this._propertyData;
            }
            set
            {
                if ((this._propertyData != value))
                {
                    string old = this._propertyData;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPropertyDataChanging(e);
                    this.OnPropertyChanging("PropertyData", e);
                    this._propertyData = value;
                    this.OnPropertyDataChanged(e);
                    this.OnPropertyChanged("PropertyData", e);
                }
            }
        }
        
        /// <summary>
        /// The LandProperty property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("LocationGrants")]
        public virtual ILandProperty LandProperty
        {
            get
            {
                return this._landProperty;
            }
            set
            {
                if ((this._landProperty != value))
                {
                    ILandProperty old = this._landProperty;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLandPropertyChanging(e);
                    this.OnPropertyChanging("LandProperty", e);
                    this._landProperty = value;
                    if ((old != null))
                    {
                        old.LocationGrants.Remove(this);
                        old.Deleted -= this.OnResetLandProperty;
                    }
                    if ((value != null))
                    {
                        value.LocationGrants.Add(this);
                        value.Deleted += this.OnResetLandProperty;
                    }
                    this.OnLandPropertyChanged(e);
                    this.OnPropertyChanged("LandProperty", e);
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
                return base.ReferencedElements.Concat(new LocationGrantReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/Loca" +
                            "tionGrant")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PropertyData property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PropertyDataChanging;
        
        /// <summary>
        /// Gets fired when the PropertyData property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PropertyDataChanged;
        
        /// <summary>
        /// Gets fired before the LandProperty property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LandPropertyChanging;
        
        /// <summary>
        /// Gets fired when the LandProperty property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LandPropertyChanged;
        
        /// <summary>
        /// Raises the PropertyDataChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPropertyDataChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PropertyDataChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PropertyDataChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPropertyDataChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PropertyDataChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LandPropertyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLandPropertyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LandPropertyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LandPropertyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLandPropertyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LandPropertyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the LandProperty property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLandProperty(object sender, System.EventArgs eventArgs)
        {
            this.LandProperty = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "PROPERTYDATA"))
            {
                return this.PropertyData;
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
            if ((feature == "LANDPROPERTY"))
            {
                this.LandProperty = ((ILandProperty)(value));
                return;
            }
            if ((feature == "PROPERTYDATA"))
            {
                this.PropertyData = ((string)(value));
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
            if ((attribute == "LandProperty"))
            {
                return new LandPropertyProxy(this);
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
            if ((reference == "LandProperty"))
            {
                return new LandPropertyProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/Loca" +
                        "tionGrant")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the LocationGrant class
        /// </summary>
        public class LocationGrantReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private LocationGrant _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LocationGrantReferencedElementsCollection(LocationGrant parent)
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
                    if ((this._parent.LandProperty != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LandPropertyChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LandPropertyChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.LandProperty == null))
                {
                    ILandProperty landPropertyCasted = item.As<ILandProperty>();
                    if ((landPropertyCasted != null))
                    {
                        this._parent.LandProperty = landPropertyCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LandProperty = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.LandProperty))
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
                if ((this._parent.LandProperty != null))
                {
                    array[arrayIndex] = this._parent.LandProperty;
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
                if ((this._parent.LandProperty == item))
                {
                    this._parent.LandProperty = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LandProperty).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the propertyData property
        /// </summary>
        private sealed class PropertyDataProxy : ModelPropertyChange<ILocationGrant, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PropertyDataProxy(ILocationGrant modelElement) : 
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
                    return this.ModelElement.PropertyData;
                }
                set
                {
                    this.ModelElement.PropertyData = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PropertyDataChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PropertyDataChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LandProperty property
        /// </summary>
        private sealed class LandPropertyProxy : ModelPropertyChange<ILocationGrant, ILandProperty>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LandPropertyProxy(ILocationGrant modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ILandProperty Value
            {
                get
                {
                    return this.ModelElement.LandProperty;
                }
                set
                {
                    this.ModelElement.LandProperty = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LandPropertyChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LandPropertyChanged -= handler;
            }
        }
    }
}

