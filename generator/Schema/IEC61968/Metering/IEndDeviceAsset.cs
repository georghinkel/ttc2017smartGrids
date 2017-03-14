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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The public interface for EndDeviceAsset
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EndDeviceAsset))]
    [XmlDefaultImplementationTypeAttribute(typeof(EndDeviceAsset))]
    public interface IEndDeviceAsset : IModelElement, IAssetContainer
    {
        
        /// <summary>
        /// The disconnect property
        /// </summary>
        bool Disconnect
        {
            get;
            set;
        }
        
        /// <summary>
        /// The relayCapable property
        /// </summary>
        bool RelayCapable
        {
            get;
            set;
        }
        
        /// <summary>
        /// The metrology property
        /// </summary>
        bool Metrology
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ratedVoltage property
        /// </summary>
        float RatedVoltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ratedCurrent property
        /// </summary>
        float RatedCurrent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The timeZoneOffset property
        /// </summary>
        float TimeZoneOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The readRequest property
        /// </summary>
        bool ReadRequest
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dstEnabled property
        /// </summary>
        bool DstEnabled
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseCount property
        /// </summary>
        int PhaseCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reverseFlowHandling property
        /// </summary>
        bool ReverseFlowHandling
        {
            get;
            set;
        }
        
        /// <summary>
        /// The demandResponse property
        /// </summary>
        bool DemandResponse
        {
            get;
            set;
        }
        
        /// <summary>
        /// The amrSystem property
        /// </summary>
        string AmrSystem
        {
            get;
            set;
        }
        
        /// <summary>
        /// The loadControl property
        /// </summary>
        bool LoadControl
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outageReport property
        /// </summary>
        bool OutageReport
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Readings property
        /// </summary>
        IOrderedSetExpression<IReading> Readings
        {
            get;
        }
        
        /// <summary>
        /// The ServiceDeliveryPoint property
        /// </summary>
        IServiceDeliveryPoint ServiceDeliveryPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ServiceLocation property
        /// </summary>
        IServiceLocation ServiceLocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EndDeviceControls property
        /// </summary>
        IOrderedSetExpression<IEndDeviceControl> EndDeviceControls
        {
            get;
        }
        
        /// <summary>
        /// The EndDeviceModel property
        /// </summary>
        IEndDeviceModel EndDeviceModel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DeviceFunctions property
        /// </summary>
        IOrderedSetExpression<IDeviceFunction> DeviceFunctions
        {
            get;
        }
        
        /// <summary>
        /// The Customer property
        /// </summary>
        ICustomer Customer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EndDeviceGroups property
        /// </summary>
        IOrderedSetExpression<IEndDeviceGroup> EndDeviceGroups
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Disconnect property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DisconnectChanging;
        
        /// <summary>
        /// Gets fired when the Disconnect property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DisconnectChanged;
        
        /// <summary>
        /// Gets fired before the RelayCapable property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RelayCapableChanging;
        
        /// <summary>
        /// Gets fired when the RelayCapable property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RelayCapableChanged;
        
        /// <summary>
        /// Gets fired before the Metrology property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MetrologyChanging;
        
        /// <summary>
        /// Gets fired when the Metrology property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MetrologyChanged;
        
        /// <summary>
        /// Gets fired before the RatedVoltage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedVoltageChanging;
        
        /// <summary>
        /// Gets fired when the RatedVoltage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedVoltageChanged;
        
        /// <summary>
        /// Gets fired before the RatedCurrent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedCurrentChanging;
        
        /// <summary>
        /// Gets fired when the RatedCurrent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedCurrentChanged;
        
        /// <summary>
        /// Gets fired before the TimeZoneOffset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeZoneOffsetChanging;
        
        /// <summary>
        /// Gets fired when the TimeZoneOffset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeZoneOffsetChanged;
        
        /// <summary>
        /// Gets fired before the ReadRequest property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadRequestChanging;
        
        /// <summary>
        /// Gets fired when the ReadRequest property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadRequestChanged;
        
        /// <summary>
        /// Gets fired before the DstEnabled property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DstEnabledChanging;
        
        /// <summary>
        /// Gets fired when the DstEnabled property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DstEnabledChanged;
        
        /// <summary>
        /// Gets fired before the PhaseCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseCountChanging;
        
        /// <summary>
        /// Gets fired when the PhaseCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseCountChanged;
        
        /// <summary>
        /// Gets fired before the ReverseFlowHandling property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReverseFlowHandlingChanging;
        
        /// <summary>
        /// Gets fired when the ReverseFlowHandling property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReverseFlowHandlingChanged;
        
        /// <summary>
        /// Gets fired before the DemandResponse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DemandResponseChanging;
        
        /// <summary>
        /// Gets fired when the DemandResponse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DemandResponseChanged;
        
        /// <summary>
        /// Gets fired before the AmrSystem property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmrSystemChanging;
        
        /// <summary>
        /// Gets fired when the AmrSystem property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmrSystemChanged;
        
        /// <summary>
        /// Gets fired before the LoadControl property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadControlChanging;
        
        /// <summary>
        /// Gets fired when the LoadControl property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadControlChanged;
        
        /// <summary>
        /// Gets fired before the OutageReport property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageReportChanging;
        
        /// <summary>
        /// Gets fired when the OutageReport property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageReportChanged;
        
        /// <summary>
        /// Gets fired before the ServiceDeliveryPoint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceDeliveryPointChanging;
        
        /// <summary>
        /// Gets fired when the ServiceDeliveryPoint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceDeliveryPointChanged;
        
        /// <summary>
        /// Gets fired before the ServiceLocation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceLocationChanging;
        
        /// <summary>
        /// Gets fired when the ServiceLocation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceLocationChanged;
        
        /// <summary>
        /// Gets fired before the EndDeviceModel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDeviceModelChanging;
        
        /// <summary>
        /// Gets fired when the EndDeviceModel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDeviceModelChanged;
        
        /// <summary>
        /// Gets fired before the Customer property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerChanging;
        
        /// <summary>
        /// Gets fired when the Customer property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerChanged;
    }
}

