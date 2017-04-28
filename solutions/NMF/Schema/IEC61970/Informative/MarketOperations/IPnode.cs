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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The public interface for Pnode
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Pnode))]
    [XmlDefaultImplementationTypeAttribute(typeof(Pnode))]
    public interface IPnode : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The beginPeriod property
        /// </summary>
        DateTime BeginPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The type property
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isPublic property
        /// </summary>
        bool IsPublic
        {
            get;
            set;
        }
        
        /// <summary>
        /// The endPeriod property
        /// </summary>
        DateTime EndPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The usage property
        /// </summary>
        string Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReceiptTransactionBids property
        /// </summary>
        IOrderedSetExpression<ITransactionBid> ReceiptTransactionBids
        {
            get;
        }
        
        /// <summary>
        /// The RTO property
        /// </summary>
        IRTO RTO
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RegisteredResources property
        /// </summary>
        IOrderedSetExpression<IRegisteredResource> RegisteredResources
        {
            get;
        }
        
        /// <summary>
        /// The PnodeClearing property
        /// </summary>
        IPnodeClearing PnodeClearing
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DeliveryTransactionBids property
        /// </summary>
        IOrderedSetExpression<ITransactionBid> DeliveryTransactionBids
        {
            get;
        }
        
        /// <summary>
        /// The ConnectivityNode property
        /// </summary>
        IConnectivityNode ConnectivityNode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FTRs property
        /// </summary>
        IOrderedSetExpression<IFTR> FTRs
        {
            get;
        }
        
        /// <summary>
        /// The Measurements property
        /// </summary>
        IOrderedSetExpression<IMeasurement> Measurements
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the BeginPeriod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BeginPeriodChanging;
        
        /// <summary>
        /// Gets fired when the BeginPeriod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BeginPeriodChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the IsPublic property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsPublicChanging;
        
        /// <summary>
        /// Gets fired when the IsPublic property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsPublicChanged;
        
        /// <summary>
        /// Gets fired before the EndPeriod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndPeriodChanging;
        
        /// <summary>
        /// Gets fired when the EndPeriod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndPeriodChanged;
        
        /// <summary>
        /// Gets fired before the Usage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsageChanging;
        
        /// <summary>
        /// Gets fired when the Usage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsageChanged;
        
        /// <summary>
        /// Gets fired before the RTO property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RTOChanging;
        
        /// <summary>
        /// Gets fired when the RTO property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RTOChanged;
        
        /// <summary>
        /// Gets fired before the PnodeClearing property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PnodeClearingChanging;
        
        /// <summary>
        /// Gets fired when the PnodeClearing property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PnodeClearingChanged;
        
        /// <summary>
        /// Gets fired before the ConnectivityNode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectivityNodeChanging;
        
        /// <summary>
        /// Gets fired when the ConnectivityNode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectivityNodeChanged;
    }
}
