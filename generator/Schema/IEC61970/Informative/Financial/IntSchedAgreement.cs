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
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial
{
    
    
    /// <summary>
    /// The default implementation of the IntSchedAgreement class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Financial")]
    [XmlNamespacePrefixAttribute("cimFinancial")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/IntSche" +
        "dAgreement")]
    [DebuggerDisplayAttribute("IntSchedAgreement {UUID}")]
    public class IntSchedAgreement : Agreement, IIntSchedAgreement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the DefaultIntegrationMethod property
        /// </summary>
        private object _defaultIntegrationMethod;
        
        /// <summary>
        /// The backing field for the Organisations property
        /// </summary>
        private IntSchedAgreementOrganisationsCollection _organisations;
        
        private static IClass _classInstance;
        
        public IntSchedAgreement()
        {
            this._organisations = new IntSchedAgreementOrganisationsCollection(this);
            this._organisations.CollectionChanging += this.OrganisationsCollectionChanging;
            this._organisations.CollectionChanged += this.OrganisationsCollectionChanged;
        }
        
        /// <summary>
        /// The defaultIntegrationMethod property
        /// </summary>
        [XmlElementNameAttribute("defaultIntegrationMethod")]
        [XmlAttributeAttribute(true)]
        public virtual object DefaultIntegrationMethod
        {
            get
            {
                return this._defaultIntegrationMethod;
            }
            set
            {
                if ((this._defaultIntegrationMethod != value))
                {
                    object old = this._defaultIntegrationMethod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDefaultIntegrationMethodChanging(e);
                    this.OnPropertyChanging("DefaultIntegrationMethod", e);
                    this._defaultIntegrationMethod = value;
                    this.OnDefaultIntegrationMethodChanged(e);
                    this.OnPropertyChanged("DefaultIntegrationMethod", e);
                }
            }
        }
        
        /// <summary>
        /// The Organisations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("IntSchedAgreement")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IErpOrganisation> Organisations
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
                return base.ReferencedElements.Concat(new IntSchedAgreementReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/IntSche" +
                            "dAgreement")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DefaultIntegrationMethod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DefaultIntegrationMethodChanging;
        
        /// <summary>
        /// Gets fired when the DefaultIntegrationMethod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DefaultIntegrationMethodChanged;
        
        /// <summary>
        /// Raises the DefaultIntegrationMethodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDefaultIntegrationMethodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DefaultIntegrationMethodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DefaultIntegrationMethodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDefaultIntegrationMethodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DefaultIntegrationMethodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
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
            if ((attribute == "DEFAULTINTEGRATIONMETHOD"))
            {
                return this.DefaultIntegrationMethod;
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
            if ((feature == "DEFAULTINTEGRATIONMETHOD"))
            {
                this.DefaultIntegrationMethod = ((object)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/IntSche" +
                        "dAgreement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the IntSchedAgreement class
        /// </summary>
        public class IntSchedAgreementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private IntSchedAgreement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public IntSchedAgreementReferencedElementsCollection(IntSchedAgreement parent)
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
                    count = (count + this._parent.Organisations.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Organisations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Organisations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IErpOrganisation organisationsCasted = item.As<IErpOrganisation>();
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
                this._parent.Organisations.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
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
                IErpOrganisation erpOrganisationItem = item.As<IErpOrganisation>();
                if (((erpOrganisationItem != null) 
                            && this._parent.Organisations.Remove(erpOrganisationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Organisations).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the defaultIntegrationMethod property
        /// </summary>
        private sealed class DefaultIntegrationMethodProxy : ModelPropertyChange<IIntSchedAgreement, object>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DefaultIntegrationMethodProxy(IIntSchedAgreement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override object Value
            {
                get
                {
                    return this.ModelElement.DefaultIntegrationMethod;
                }
                set
                {
                    this.ModelElement.DefaultIntegrationMethod = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.DefaultIntegrationMethodChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.DefaultIntegrationMethodChanged -= handler;
            }
        }
    }
}

