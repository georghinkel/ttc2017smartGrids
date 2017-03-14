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
    /// The default implementation of the BusinessRole class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfCommon")]
    [XmlNamespacePrefixAttribute("cimInfCommon")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCommon/Busines" +
        "sRole")]
    [DebuggerDisplayAttribute("BusinessRole {UUID}")]
    public class BusinessRole : IdentifiedObject, IBusinessRole, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Category property
        /// </summary>
        private string _category;
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        /// <summary>
        /// The backing field for the Organisations property
        /// </summary>
        private BusinessRoleOrganisationsCollection _organisations;
        
        private static IClass _classInstance;
        
        public BusinessRole()
        {
            this._organisations = new BusinessRoleOrganisationsCollection(this);
            this._organisations.CollectionChanging += this.OrganisationsCollectionChanging;
            this._organisations.CollectionChanged += this.OrganisationsCollectionChanged;
        }
        
        /// <summary>
        /// The category property
        /// </summary>
        [XmlElementNameAttribute("category")]
        [XmlAttributeAttribute(true)]
        public virtual string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                if ((this._category != value))
                {
                    string old = this._category;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCategoryChanging(e);
                    this.OnPropertyChanging("Category", e);
                    this._category = value;
                    this.OnCategoryChanged(e);
                    this.OnPropertyChanged("Category", e);
                }
            }
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        [XmlElementNameAttribute("status")]
        [XmlAttributeAttribute(true)]
        public virtual IStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                if ((this._status != value))
                {
                    IStatus old = this._status;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStatusChanging(e);
                    this.OnPropertyChanging("Status", e);
                    this._status = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetStatus;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetStatus;
                    }
                    this.OnStatusChanged(e);
                    this.OnPropertyChanged("Status", e);
                }
            }
        }
        
        /// <summary>
        /// The Organisations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("BusinessRoles")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOrganisation> Organisations
        {
            get
            {
                return this._organisations;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new BusinessRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCommon/Busines" +
                            "sRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Category property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CategoryChanging;
        
        /// <summary>
        /// Gets fired when the Category property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CategoryChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Raises the CategoryChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCategoryChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CategoryChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CategoryChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCategoryChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CategoryChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StatusChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StatusChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Status property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStatus(object sender, System.EventArgs eventArgs)
        {
            this.Status = null;
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Organisations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OrganisationsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Organisations", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Organisations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OrganisationsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Organisations", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CATEGORY"))
            {
                return this.Category;
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
            if ((feature == "ORGANISATIONS"))
            {
                return this._organisations;
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
            if ((feature == "STATUS"))
            {
                this.Status = ((IStatus)(value));
                return;
            }
            if ((feature == "CATEGORY"))
            {
                this.Category = ((string)(value));
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
            if ((attribute == "Status"))
            {
                return new StatusProxy(this);
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
            if ((reference == "Status"))
            {
                return new StatusProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCommon/Busines" +
                        "sRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BusinessRole class
        /// </summary>
        public class BusinessRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BusinessRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BusinessRoleReferencedElementsCollection(BusinessRole parent)
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
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Organisations.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StatusChanged += this.PropagateValueChanges;
                this._parent.Organisations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StatusChanged -= this.PropagateValueChanges;
                this._parent.Organisations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Status == null))
                {
                    IStatus statusCasted = item.As<IStatus>();
                    if ((statusCasted != null))
                    {
                        this._parent.Status = statusCasted;
                        return;
                    }
                }
                IOrganisation organisationsCasted = item.As<IOrganisation>();
                if ((organisationsCasted != null))
                {
                    this._parent.Organisations.Add(organisationsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Status = null;
                this._parent.Organisations.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Status))
                {
                    return true;
                }
                if (this._parent.Organisations.Contains(item))
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
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> organisationsEnumerator = this._parent.Organisations.GetEnumerator();
                try
                {
                    for (
                    ; organisationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = organisationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    organisationsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
                    return true;
                }
                IOrganisation organisationItem = item.As<IOrganisation>();
                if (((organisationItem != null) 
                            && this._parent.Organisations.Remove(organisationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Status).Concat(this._parent.Organisations).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the category property
        /// </summary>
        private sealed class CategoryProxy : ModelPropertyChange<IBusinessRole, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CategoryProxy(IBusinessRole modelElement) : 
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
                    return this.ModelElement.Category;
                }
                set
                {
                    this.ModelElement.Category = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CategoryChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CategoryChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<IBusinessRole, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(IBusinessRole modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IStatus Value
            {
                get
                {
                    return this.ModelElement.Status;
                }
                set
                {
                    this.ModelElement.Status = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StatusChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StatusChanged -= handler;
            }
        }
    }
}
