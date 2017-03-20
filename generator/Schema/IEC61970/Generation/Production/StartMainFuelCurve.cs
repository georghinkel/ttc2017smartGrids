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
    /// The default implementation of the StartMainFuelCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/StartMa" +
        "inFuelCurve")]
    [DebuggerDisplayAttribute("StartMainFuelCurve {UUID}")]
    public partial class StartMainFuelCurve : Curve, IStartMainFuelCurve, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MainFuelType property
        /// </summary>
        private Nullable<FuelType> _mainFuelType;
        
        private static Lazy<ITypedElement> _mainFuelTypeAttribute = new Lazy<ITypedElement>(RetrieveMainFuelTypeAttribute);
        
        private static Lazy<ITypedElement> _startupModelReference = new Lazy<ITypedElement>(RetrieveStartupModelReference);
        
        /// <summary>
        /// The backing field for the StartupModel property
        /// </summary>
        private IStartupModel _startupModel;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The mainFuelType property
        /// </summary>
        [XmlElementNameAttribute("mainFuelType")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<FuelType> MainFuelType
        {
            get
            {
                return this._mainFuelType;
            }
            set
            {
                if ((this._mainFuelType != value))
                {
                    Nullable<FuelType> old = this._mainFuelType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMainFuelTypeChanging(e);
                    this.OnPropertyChanging("MainFuelType", e, _mainFuelTypeAttribute);
                    this._mainFuelType = value;
                    this.OnMainFuelTypeChanged(e);
                    this.OnPropertyChanged("MainFuelType", e, _mainFuelTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The StartupModel property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("StartMainFuelCurve")]
        public virtual IStartupModel StartupModel
        {
            get
            {
                return this._startupModel;
            }
            set
            {
                if ((this._startupModel != value))
                {
                    IStartupModel old = this._startupModel;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartupModelChanging(e);
                    this.OnPropertyChanging("StartupModel", e, _startupModelReference);
                    this._startupModel = value;
                    if ((old != null))
                    {
                        old.StartMainFuelCurve = null;
                        old.Deleted -= this.OnResetStartupModel;
                    }
                    if ((value != null))
                    {
                        value.StartMainFuelCurve = this;
                        value.Deleted += this.OnResetStartupModel;
                    }
                    this.OnStartupModelChanged(e);
                    this.OnPropertyChanged("StartupModel", e, _startupModelReference);
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
                return base.ReferencedElements.Concat(new StartMainFuelCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/StartMa" +
                            "inFuelCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MainFuelType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MainFuelTypeChanging;
        
        /// <summary>
        /// Gets fired when the MainFuelType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MainFuelTypeChanged;
        
        /// <summary>
        /// Gets fired before the StartupModel property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartupModelChanging;
        
        /// <summary>
        /// Gets fired when the StartupModel property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartupModelChanged;
        
        private static ITypedElement RetrieveMainFuelTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StartMainFuelCurve.ClassInstance)).Resolve("mainFuelType")));
        }
        
        /// <summary>
        /// Raises the MainFuelTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMainFuelTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MainFuelTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MainFuelTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMainFuelTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MainFuelTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveStartupModelReference()
        {
            return ((ITypedElement)(((ModelElement)(StartMainFuelCurve.ClassInstance)).Resolve("StartupModel")));
        }
        
        /// <summary>
        /// Raises the StartupModelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartupModelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartupModelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartupModelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartupModelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartupModelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the StartupModel property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStartupModel(object sender, System.EventArgs eventArgs)
        {
            this.StartupModel = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MAINFUELTYPE"))
            {
                return this.MainFuelType;
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
            if ((feature == "STARTUPMODEL"))
            {
                this.StartupModel = ((IStartupModel)(value));
                return;
            }
            if ((feature == "MAINFUELTYPE"))
            {
                this.MainFuelType = ((FuelType)(value));
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
            if ((attribute == "StartupModel"))
            {
                return new StartupModelProxy(this);
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
            if ((reference == "StartupModel"))
            {
                return new StartupModelProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/StartMa" +
                        "inFuelCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StartMainFuelCurve class
        /// </summary>
        public class StartMainFuelCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StartMainFuelCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StartMainFuelCurveReferencedElementsCollection(StartMainFuelCurve parent)
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
                    if ((this._parent.StartupModel != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StartupModelChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StartupModelChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.StartupModel == null))
                {
                    IStartupModel startupModelCasted = item.As<IStartupModel>();
                    if ((startupModelCasted != null))
                    {
                        this._parent.StartupModel = startupModelCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.StartupModel = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.StartupModel))
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
                if ((this._parent.StartupModel != null))
                {
                    array[arrayIndex] = this._parent.StartupModel;
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
                if ((this._parent.StartupModel == item))
                {
                    this._parent.StartupModel = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.StartupModel).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the mainFuelType property
        /// </summary>
        private sealed class MainFuelTypeProxy : ModelPropertyChange<IStartMainFuelCurve, Nullable<FuelType>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MainFuelTypeProxy(IStartMainFuelCurve modelElement) : 
                    base(modelElement, "mainFuelType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<FuelType> Value
            {
                get
                {
                    return this.ModelElement.MainFuelType;
                }
                set
                {
                    this.ModelElement.MainFuelType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the StartupModel property
        /// </summary>
        private sealed class StartupModelProxy : ModelPropertyChange<IStartMainFuelCurve, IStartupModel>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartupModelProxy(IStartMainFuelCurve modelElement) : 
                    base(modelElement, "StartupModel")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IStartupModel Value
            {
                get
                {
                    return this.ModelElement.StartupModel;
                }
                set
                {
                    this.ModelElement.StartupModel = value;
                }
            }
        }
    }
}

