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
    /// The public interface for ChargeProfile
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ChargeProfile))]
    [XmlDefaultImplementationTypeAttribute(typeof(ChargeProfile))]
    public interface IChargeProfile : IModelElement, IProfile
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
        /// The unitOfMeasure property
        /// </summary>
        string UnitOfMeasure
        {
            get;
            set;
        }
        
        /// <summary>
        /// The frequency property
        /// </summary>
        string Frequency
        {
            get;
            set;
        }
        
        /// <summary>
        /// The numberInterval property
        /// </summary>
        int NumberInterval
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PassTroughBill property
        /// </summary>
        IPassThroughBill PassTroughBill
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChargeProfileData property
        /// </summary>
        IOrderedSetExpression<IChargeProfileData> ChargeProfileData
        {
            get;
        }
        
        /// <summary>
        /// The BillDeterminant property
        /// </summary>
        IBillDeterminant BillDeterminant
        {
            get;
            set;
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
        /// Gets fired before the UnitOfMeasure property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UnitOfMeasureChanging;
        
        /// <summary>
        /// Gets fired when the UnitOfMeasure property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UnitOfMeasureChanged;
        
        /// <summary>
        /// Gets fired before the Frequency property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FrequencyChanging;
        
        /// <summary>
        /// Gets fired when the Frequency property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FrequencyChanged;
        
        /// <summary>
        /// Gets fired before the NumberInterval property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NumberIntervalChanging;
        
        /// <summary>
        /// Gets fired when the NumberInterval property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NumberIntervalChanged;
        
        /// <summary>
        /// Gets fired before the PassTroughBill property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PassTroughBillChanging;
        
        /// <summary>
        /// Gets fired when the PassTroughBill property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PassTroughBillChanged;
        
        /// <summary>
        /// Gets fired before the BillDeterminant property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillDeterminantChanging;
        
        /// <summary>
        /// Gets fired when the BillDeterminant property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillDeterminantChanged;
    }
}
