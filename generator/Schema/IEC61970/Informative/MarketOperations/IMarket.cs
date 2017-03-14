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
    /// The public interface for Market
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Market))]
    [XmlDefaultImplementationTypeAttribute(typeof(Market))]
    public interface IMarket : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The type property
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The start property
        /// </summary>
        DateTime Start
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rampIntervalNonSpinRes property
        /// </summary>
        float RampIntervalNonSpinRes
        {
            get;
            set;
        }
        
        /// <summary>
        /// The end property
        /// </summary>
        DateTime End
        {
            get;
            set;
        }
        
        /// <summary>
        /// The timeIntervalLength property
        /// </summary>
        float TimeIntervalLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rampIntervalReg property
        /// </summary>
        float RampIntervalReg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rampIntervalSpinRes property
        /// </summary>
        float RampIntervalSpinRes
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dst property
        /// </summary>
        bool Dst
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rampIntervalEnergy property
        /// </summary>
        float RampIntervalEnergy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The localTimeZone property
        /// </summary>
        string LocalTimeZone
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MarketFactors property
        /// </summary>
        IOrderedSetExpression<IMarketFactors> MarketFactors
        {
            get;
        }
        
        /// <summary>
        /// The MarketProducts property
        /// </summary>
        IOrderedSetExpression<IMarketProduct> MarketProducts
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
        /// The Settlements property
        /// </summary>
        IOrderedSetExpression<ISettlement> Settlements
        {
            get;
        }
        
        /// <summary>
        /// The Bids property
        /// </summary>
        IOrderedSetExpression<IBid> Bids
        {
            get;
        }
        
        /// <summary>
        /// The RegisteredResources property
        /// </summary>
        IOrderedSetExpression<IRegisteredResource> RegisteredResources
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the Start property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StartChanging;
        
        /// <summary>
        /// Gets fired when the Start property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StartChanged;
        
        /// <summary>
        /// Gets fired before the RampIntervalNonSpinRes property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalNonSpinResChanging;
        
        /// <summary>
        /// Gets fired when the RampIntervalNonSpinRes property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalNonSpinResChanged;
        
        /// <summary>
        /// Gets fired before the End property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndChanging;
        
        /// <summary>
        /// Gets fired when the End property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndChanged;
        
        /// <summary>
        /// Gets fired before the TimeIntervalLength property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeIntervalLengthChanging;
        
        /// <summary>
        /// Gets fired when the TimeIntervalLength property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeIntervalLengthChanged;
        
        /// <summary>
        /// Gets fired before the RampIntervalReg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalRegChanging;
        
        /// <summary>
        /// Gets fired when the RampIntervalReg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalRegChanged;
        
        /// <summary>
        /// Gets fired before the RampIntervalSpinRes property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalSpinResChanging;
        
        /// <summary>
        /// Gets fired when the RampIntervalSpinRes property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalSpinResChanged;
        
        /// <summary>
        /// Gets fired before the Dst property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DstChanging;
        
        /// <summary>
        /// Gets fired when the Dst property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DstChanged;
        
        /// <summary>
        /// Gets fired before the RampIntervalEnergy property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalEnergyChanging;
        
        /// <summary>
        /// Gets fired when the RampIntervalEnergy property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RampIntervalEnergyChanged;
        
        /// <summary>
        /// Gets fired before the LocalTimeZone property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalTimeZoneChanging;
        
        /// <summary>
        /// Gets fired when the LocalTimeZone property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalTimeZoneChanged;
        
        /// <summary>
        /// Gets fired before the RTO property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RTOChanging;
        
        /// <summary>
        /// Gets fired when the RTO property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RTOChanged;
    }
}

