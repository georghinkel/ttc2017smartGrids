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
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon
{
    
    
    /// <summary>
    /// The default implementation of the DocPsrRole class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfCommon")]
    [XmlNamespacePrefixAttribute("cimInfCommon")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCommon/DocPsrR" +
        "ole")]
    [DebuggerDisplayAttribute("DocPsrRole {UUID}")]
    public class DocPsrRole : Role, IDocPsrRole, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Document property
        /// </summary>
        private IDocument _document;
        
        /// <summary>
        /// The backing field for the PowerSystemResource property
        /// </summary>
        private IPowerSystemResource _powerSystemResource;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Document property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PowerSystemResourceRoles")]
        public virtual IDocument Document
        {
            get
            {
                return this._document;
            }
            set
            {
                if ((this._document != value))
                {
                    IDocument old = this._document;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDocumentChanging(e);
                    this.OnPropertyChanging("Document", e);
                    this._document = value;
                    if ((old != null))
                    {
                        old.PowerSystemResourceRoles.Remove(this);
                        old.Deleted -= this.OnResetDocument;
                    }
                    if ((value != null))
                    {
                        value.PowerSystemResourceRoles.Add(this);
                        value.Deleted += this.OnResetDocument;
                    }
                    this.OnDocumentChanged(e);
                    this.OnPropertyChanged("Document", e);
                }
            }
        }
        
        /// <summary>
        /// The PowerSystemResource property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DocumentRoles")]
        public virtual IPowerSystemResource PowerSystemResource
        {
            get
            {
                return this._powerSystemResource;
            }
            set
            {
                if ((this._powerSystemResource != value))
                {
                    IPowerSystemResource old = this._powerSystemResource;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPowerSystemResourceChanging(e);
                    this.OnPropertyChanging("PowerSystemResource", e);
                    this._powerSystemResource = value;
                    if ((old != null))
                    {
                        old.DocumentRoles.Remove(this);
                        old.Deleted -= this.OnResetPowerSystemResource;
                    }
                    if ((value != null))
                    {
                        value.DocumentRoles.Add(this);
                        value.Deleted += this.OnResetPowerSystemResource;
                    }
                    this.OnPowerSystemResourceChanged(e);
                    this.OnPropertyChanged("PowerSystemResource", e);
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
                return base.ReferencedElements.Concat(new DocPsrRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCommon/DocPsrR" +
                            "ole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Document property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DocumentChanging;
        
        /// <summary>
        /// Gets fired when the Document property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DocumentChanged;
        
        /// <summary>
        /// Gets fired before the PowerSystemResource property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerSystemResourceChanging;
        
        /// <summary>
        /// Gets fired when the PowerSystemResource property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerSystemResourceChanged;
        
        /// <summary>
        /// Raises the DocumentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDocumentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DocumentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DocumentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDocumentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DocumentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Document property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetDocument(object sender, System.EventArgs eventArgs)
        {
            this.Document = null;
        }
        
        /// <summary>
        /// Raises the PowerSystemResourceChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerSystemResourceChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerSystemResourceChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PowerSystemResourceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerSystemResourceChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerSystemResourceChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PowerSystemResource property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPowerSystemResource(object sender, System.EventArgs eventArgs)
        {
            this.PowerSystemResource = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "DOCUMENT"))
            {
                this.Document = ((IDocument)(value));
                return;
            }
            if ((feature == "POWERSYSTEMRESOURCE"))
            {
                this.PowerSystemResource = ((IPowerSystemResource)(value));
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
            if ((attribute == "Document"))
            {
                return new DocumentProxy(this);
            }
            if ((attribute == "PowerSystemResource"))
            {
                return new PowerSystemResourceProxy(this);
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
            if ((reference == "Document"))
            {
                return new DocumentProxy(this);
            }
            if ((reference == "PowerSystemResource"))
            {
                return new PowerSystemResourceProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCommon/DocPsrR" +
                        "ole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DocPsrRole class
        /// </summary>
        public class DocPsrRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DocPsrRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DocPsrRoleReferencedElementsCollection(DocPsrRole parent)
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
                    if ((this._parent.Document != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.PowerSystemResource != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DocumentChanged += this.PropagateValueChanges;
                this._parent.PowerSystemResourceChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DocumentChanged -= this.PropagateValueChanges;
                this._parent.PowerSystemResourceChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Document == null))
                {
                    IDocument documentCasted = item.As<IDocument>();
                    if ((documentCasted != null))
                    {
                        this._parent.Document = documentCasted;
                        return;
                    }
                }
                if ((this._parent.PowerSystemResource == null))
                {
                    IPowerSystemResource powerSystemResourceCasted = item.As<IPowerSystemResource>();
                    if ((powerSystemResourceCasted != null))
                    {
                        this._parent.PowerSystemResource = powerSystemResourceCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Document = null;
                this._parent.PowerSystemResource = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Document))
                {
                    return true;
                }
                if ((item == this._parent.PowerSystemResource))
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
                if ((this._parent.Document != null))
                {
                    array[arrayIndex] = this._parent.Document;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.PowerSystemResource != null))
                {
                    array[arrayIndex] = this._parent.PowerSystemResource;
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
                if ((this._parent.Document == item))
                {
                    this._parent.Document = null;
                    return true;
                }
                if ((this._parent.PowerSystemResource == item))
                {
                    this._parent.PowerSystemResource = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Document).Concat(this._parent.PowerSystemResource).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Document property
        /// </summary>
        private sealed class DocumentProxy : ModelPropertyChange<IDocPsrRole, IDocument>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DocumentProxy(IDocPsrRole modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDocument Value
            {
                get
                {
                    return this.ModelElement.Document;
                }
                set
                {
                    this.ModelElement.Document = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.DocumentChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.DocumentChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PowerSystemResource property
        /// </summary>
        private sealed class PowerSystemResourceProxy : ModelPropertyChange<IDocPsrRole, IPowerSystemResource>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PowerSystemResourceProxy(IDocPsrRole modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPowerSystemResource Value
            {
                get
                {
                    return this.ModelElement.PowerSystemResource;
                }
                set
                {
                    this.ModelElement.PowerSystemResource = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PowerSystemResourceChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PowerSystemResourceChanged -= handler;
            }
        }
    }
}

