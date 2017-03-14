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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling
{
    
    
    /// <summary>
    /// The public interface for EnergyTransaction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EnergyTransaction))]
    [XmlDefaultImplementationTypeAttribute(typeof(EnergyTransaction))]
    public interface IEnergyTransaction : IModelElement, IDocument
    {
        
        /// <summary>
        /// The state property
        /// </summary>
        object State
        {
            get;
            set;
        }
        
        /// <summary>
        /// The firmInterchangeFlag property
        /// </summary>
        bool FirmInterchangeFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The deliveryPointP property
        /// </summary>
        float DeliveryPointP
        {
            get;
            set;
        }
        
        /// <summary>
        /// The receiptPointP property
        /// </summary>
        float ReceiptPointP
        {
            get;
            set;
        }
        
        /// <summary>
        /// The congestChargeMax property
        /// </summary>
        float CongestChargeMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// The energyMin property
        /// </summary>
        float EnergyMin
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reason property
        /// </summary>
        string Reason
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EnergyPriceCurves property
        /// </summary>
        IOrderedSetExpression<IEnergyPriceCurve> EnergyPriceCurves
        {
            get;
        }
        
        /// <summary>
        /// The EnergyTransId property
        /// </summary>
        IOrderedSetExpression<ITransactionBid> EnergyTransId
        {
            get;
        }
        
        /// <summary>
        /// The EnergyProduct property
        /// </summary>
        IEnergyProduct EnergyProduct
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Export_SubControlArea property
        /// </summary>
        ISubControlArea Export_SubControlArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Import_SubControlArea property
        /// </summary>
        ISubControlArea Import_SubControlArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EnergyProfiles property
        /// </summary>
        IOrderedSetExpression<IEnergyProfile> EnergyProfiles
        {
            get;
        }
        
        /// <summary>
        /// The CurtailmentProfiles property
        /// </summary>
        IOrderedSetExpression<ICurtailmentProfile> CurtailmentProfiles
        {
            get;
        }
        
        /// <summary>
        /// The LossProfiles property
        /// </summary>
        IOrderedSetExpression<ILossProfile> LossProfiles
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the State property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StateChanging;
        
        /// <summary>
        /// Gets fired when the State property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StateChanged;
        
        /// <summary>
        /// Gets fired before the FirmInterchangeFlag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FirmInterchangeFlagChanging;
        
        /// <summary>
        /// Gets fired when the FirmInterchangeFlag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FirmInterchangeFlagChanged;
        
        /// <summary>
        /// Gets fired before the DeliveryPointP property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeliveryPointPChanging;
        
        /// <summary>
        /// Gets fired when the DeliveryPointP property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeliveryPointPChanged;
        
        /// <summary>
        /// Gets fired before the ReceiptPointP property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceiptPointPChanging;
        
        /// <summary>
        /// Gets fired when the ReceiptPointP property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceiptPointPChanged;
        
        /// <summary>
        /// Gets fired before the CongestChargeMax property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CongestChargeMaxChanging;
        
        /// <summary>
        /// Gets fired when the CongestChargeMax property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CongestChargeMaxChanged;
        
        /// <summary>
        /// Gets fired before the EnergyMin property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyMinChanging;
        
        /// <summary>
        /// Gets fired when the EnergyMin property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyMinChanged;
        
        /// <summary>
        /// Gets fired before the Reason property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanging;
        
        /// <summary>
        /// Gets fired when the Reason property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanged;
        
        /// <summary>
        /// Gets fired before the EnergyProduct property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyProductChanging;
        
        /// <summary>
        /// Gets fired when the EnergyProduct property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyProductChanged;
        
        /// <summary>
        /// Gets fired before the Export_SubControlArea property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Export_SubControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the Export_SubControlArea property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Export_SubControlAreaChanged;
        
        /// <summary>
        /// Gets fired before the Import_SubControlArea property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Import_SubControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the Import_SubControlArea property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Import_SubControlAreaChanged;
    }
}

