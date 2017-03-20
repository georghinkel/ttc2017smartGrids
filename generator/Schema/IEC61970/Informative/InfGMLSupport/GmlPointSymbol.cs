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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The default implementation of the GmlPointSymbol class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfGMLSupport")]
    [XmlNamespacePrefixAttribute("cimInfGMLSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
        "PointSymbol")]
    [DebuggerDisplayAttribute("GmlPointSymbol {UUID}")]
    public partial class GmlPointSymbol : GmlSymbol, IGmlPointSymbol, IModelElement
    {
        
        private static Lazy<ITypedElement> _gmlGraphicReference = new Lazy<ITypedElement>(RetrieveGmlGraphicReference);
        
        /// <summary>
        /// The backing field for the GmlGraphic property
        /// </summary>
        private IGmlGraphic _gmlGraphic;
        
        private static Lazy<ITypedElement> _gmlDiagramObjectReference = new Lazy<ITypedElement>(RetrieveGmlDiagramObjectReference);
        
        /// <summary>
        /// The backing field for the GmlDiagramObject property
        /// </summary>
        private IGmlDiagramObject _gmlDiagramObject;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The GmlGraphic property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlPointSymbols")]
        public virtual IGmlGraphic GmlGraphic
        {
            get
            {
                return this._gmlGraphic;
            }
            set
            {
                if ((this._gmlGraphic != value))
                {
                    IGmlGraphic old = this._gmlGraphic;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGmlGraphicChanging(e);
                    this.OnPropertyChanging("GmlGraphic", e, _gmlGraphicReference);
                    this._gmlGraphic = value;
                    if ((old != null))
                    {
                        old.GmlPointSymbols.Remove(this);
                        old.Deleted -= this.OnResetGmlGraphic;
                    }
                    if ((value != null))
                    {
                        value.GmlPointSymbols.Add(this);
                        value.Deleted += this.OnResetGmlGraphic;
                    }
                    this.OnGmlGraphicChanged(e);
                    this.OnPropertyChanged("GmlGraphic", e, _gmlGraphicReference);
                }
            }
        }
        
        /// <summary>
        /// The GmlDiagramObject property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlPointSymbols")]
        public virtual IGmlDiagramObject GmlDiagramObject
        {
            get
            {
                return this._gmlDiagramObject;
            }
            set
            {
                if ((this._gmlDiagramObject != value))
                {
                    IGmlDiagramObject old = this._gmlDiagramObject;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGmlDiagramObjectChanging(e);
                    this.OnPropertyChanging("GmlDiagramObject", e, _gmlDiagramObjectReference);
                    this._gmlDiagramObject = value;
                    if ((old != null))
                    {
                        old.GmlPointSymbols.Remove(this);
                        old.Deleted -= this.OnResetGmlDiagramObject;
                    }
                    if ((value != null))
                    {
                        value.GmlPointSymbols.Add(this);
                        value.Deleted += this.OnResetGmlDiagramObject;
                    }
                    this.OnGmlDiagramObjectChanged(e);
                    this.OnPropertyChanged("GmlDiagramObject", e, _gmlDiagramObjectReference);
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
                return base.ReferencedElements.Concat(new GmlPointSymbolReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                            "PointSymbol")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the GmlGraphic property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GmlGraphicChanging;
        
        /// <summary>
        /// Gets fired when the GmlGraphic property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GmlGraphicChanged;
        
        /// <summary>
        /// Gets fired before the GmlDiagramObject property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GmlDiagramObjectChanging;
        
        /// <summary>
        /// Gets fired when the GmlDiagramObject property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GmlDiagramObjectChanged;
        
        private static ITypedElement RetrieveGmlGraphicReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlPointSymbol.ClassInstance)).Resolve("GmlGraphic")));
        }
        
        /// <summary>
        /// Raises the GmlGraphicChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGmlGraphicChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GmlGraphicChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GmlGraphicChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGmlGraphicChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GmlGraphicChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GmlGraphic property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGmlGraphic(object sender, System.EventArgs eventArgs)
        {
            this.GmlGraphic = null;
        }
        
        private static ITypedElement RetrieveGmlDiagramObjectReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlPointSymbol.ClassInstance)).Resolve("GmlDiagramObject")));
        }
        
        /// <summary>
        /// Raises the GmlDiagramObjectChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGmlDiagramObjectChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GmlDiagramObjectChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GmlDiagramObjectChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGmlDiagramObjectChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GmlDiagramObjectChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GmlDiagramObject property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGmlDiagramObject(object sender, System.EventArgs eventArgs)
        {
            this.GmlDiagramObject = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "GMLGRAPHIC"))
            {
                this.GmlGraphic = ((IGmlGraphic)(value));
                return;
            }
            if ((feature == "GMLDIAGRAMOBJECT"))
            {
                this.GmlDiagramObject = ((IGmlDiagramObject)(value));
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
            if ((attribute == "GmlGraphic"))
            {
                return new GmlGraphicProxy(this);
            }
            if ((attribute == "GmlDiagramObject"))
            {
                return new GmlDiagramObjectProxy(this);
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
            if ((reference == "GmlGraphic"))
            {
                return new GmlGraphicProxy(this);
            }
            if ((reference == "GmlDiagramObject"))
            {
                return new GmlDiagramObjectProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                        "PointSymbol")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GmlPointSymbol class
        /// </summary>
        public class GmlPointSymbolReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GmlPointSymbol _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GmlPointSymbolReferencedElementsCollection(GmlPointSymbol parent)
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
                    if ((this._parent.GmlGraphic != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.GmlDiagramObject != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GmlGraphicChanged += this.PropagateValueChanges;
                this._parent.GmlDiagramObjectChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GmlGraphicChanged -= this.PropagateValueChanges;
                this._parent.GmlDiagramObjectChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.GmlGraphic == null))
                {
                    IGmlGraphic gmlGraphicCasted = item.As<IGmlGraphic>();
                    if ((gmlGraphicCasted != null))
                    {
                        this._parent.GmlGraphic = gmlGraphicCasted;
                        return;
                    }
                }
                if ((this._parent.GmlDiagramObject == null))
                {
                    IGmlDiagramObject gmlDiagramObjectCasted = item.As<IGmlDiagramObject>();
                    if ((gmlDiagramObjectCasted != null))
                    {
                        this._parent.GmlDiagramObject = gmlDiagramObjectCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GmlGraphic = null;
                this._parent.GmlDiagramObject = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.GmlGraphic))
                {
                    return true;
                }
                if ((item == this._parent.GmlDiagramObject))
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
                if ((this._parent.GmlGraphic != null))
                {
                    array[arrayIndex] = this._parent.GmlGraphic;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.GmlDiagramObject != null))
                {
                    array[arrayIndex] = this._parent.GmlDiagramObject;
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
                if ((this._parent.GmlGraphic == item))
                {
                    this._parent.GmlGraphic = null;
                    return true;
                }
                if ((this._parent.GmlDiagramObject == item))
                {
                    this._parent.GmlDiagramObject = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GmlGraphic).Concat(this._parent.GmlDiagramObject).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GmlGraphic property
        /// </summary>
        private sealed class GmlGraphicProxy : ModelPropertyChange<IGmlPointSymbol, IGmlGraphic>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GmlGraphicProxy(IGmlPointSymbol modelElement) : 
                    base(modelElement, "GmlGraphic")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IGmlGraphic Value
            {
                get
                {
                    return this.ModelElement.GmlGraphic;
                }
                set
                {
                    this.ModelElement.GmlGraphic = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GmlDiagramObject property
        /// </summary>
        private sealed class GmlDiagramObjectProxy : ModelPropertyChange<IGmlPointSymbol, IGmlDiagramObject>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GmlDiagramObjectProxy(IGmlPointSymbol modelElement) : 
                    base(modelElement, "GmlDiagramObject")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IGmlDiagramObject Value
            {
                get
                {
                    return this.ModelElement.GmlDiagramObject;
                }
                set
                {
                    this.ModelElement.GmlDiagramObject = value;
                }
            }
        }
    }
}

