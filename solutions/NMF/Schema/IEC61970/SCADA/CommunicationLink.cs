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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.SCADA
{
    
    
    /// <summary>
    /// The default implementation of the CommunicationLink class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#SCADA")]
    [XmlNamespacePrefixAttribute("cimSCADA")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/SCADA/CommunicationLink")]
    [DebuggerDisplayAttribute("CommunicationLink {UUID}")]
    public partial class CommunicationLink : PowerSystemResource, ICommunicationLink, IModelElement
    {
        
        private static Lazy<ITypedElement> _remoteUnitsReference = new Lazy<ITypedElement>(RetrieveRemoteUnitsReference);
        
        /// <summary>
        /// The backing field for the RemoteUnits property
        /// </summary>
        private CommunicationLinkRemoteUnitsCollection _remoteUnits;
        
        private static IClass _classInstance;
        
        public CommunicationLink()
        {
            this._remoteUnits = new CommunicationLinkRemoteUnitsCollection(this);
            this._remoteUnits.CollectionChanging += this.RemoteUnitsCollectionChanging;
            this._remoteUnits.CollectionChanged += this.RemoteUnitsCollectionChanged;
        }
        
        /// <summary>
        /// The RemoteUnits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CommunicationLinks")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IRemoteUnit> RemoteUnits
        {
            get
            {
                return this._remoteUnits;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CommunicationLinkReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/SCADA/CommunicationLink")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveRemoteUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(CommunicationLink.ClassInstance)).Resolve("RemoteUnits")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the RemoteUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RemoteUnitsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("RemoteUnits", e, _remoteUnitsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the RemoteUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RemoteUnitsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RemoteUnits", e, _remoteUnitsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "REMOTEUNITS"))
            {
                return this._remoteUnits;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/SCADA/CommunicationLink")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CommunicationLink class
        /// </summary>
        public class CommunicationLinkReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CommunicationLink _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CommunicationLinkReferencedElementsCollection(CommunicationLink parent)
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
                    count = (count + this._parent.RemoteUnits.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RemoteUnits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RemoteUnits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRemoteUnit remoteUnitsCasted = item.As<IRemoteUnit>();
                if ((remoteUnitsCasted != null))
                {
                    this._parent.RemoteUnits.Add(remoteUnitsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RemoteUnits.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RemoteUnits.Contains(item))
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
                IEnumerator<IModelElement> remoteUnitsEnumerator = this._parent.RemoteUnits.GetEnumerator();
                try
                {
                    for (
                    ; remoteUnitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = remoteUnitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    remoteUnitsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRemoteUnit remoteUnitItem = item.As<IRemoteUnit>();
                if (((remoteUnitItem != null) 
                            && this._parent.RemoteUnits.Remove(remoteUnitItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RemoteUnits).GetEnumerator();
            }
        }
    }
}
