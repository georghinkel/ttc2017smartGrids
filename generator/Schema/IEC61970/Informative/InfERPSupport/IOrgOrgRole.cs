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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport
{
    
    
    /// <summary>
    /// The public interface for OrgOrgRole
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OrgOrgRole))]
    [XmlDefaultImplementationTypeAttribute(typeof(OrgOrgRole))]
    public interface IOrgOrgRole : IModelElement, IRole
    {
        
        /// <summary>
        /// The clientID property
        /// </summary>
        string ClientID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChildOrganisation property
        /// </summary>
        IErpOrganisation ChildOrganisation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ParentOrganisation property
        /// </summary>
        IErpOrganisation ParentOrganisation
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ClientID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClientIDChanging;
        
        /// <summary>
        /// Gets fired when the ClientID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClientIDChanged;
        
        /// <summary>
        /// Gets fired before the ChildOrganisation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChildOrganisationChanging;
        
        /// <summary>
        /// Gets fired when the ChildOrganisation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChildOrganisationChanged;
        
        /// <summary>
        /// Gets fired before the ParentOrganisation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ParentOrganisationChanging;
        
        /// <summary>
        /// Gets fired when the ParentOrganisation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ParentOrganisationChanged;
    }
}

