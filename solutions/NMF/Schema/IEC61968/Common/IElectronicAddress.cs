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
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Common
{
    
    
    /// <summary>
    /// The public interface for ElectronicAddress
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ElectronicAddress))]
    [XmlDefaultImplementationTypeAttribute(typeof(ElectronicAddress))]
    public interface IElectronicAddress : IModelElement, IElement
    {
        
        /// <summary>
        /// The lan property
        /// </summary>
        string Lan
        {
            get;
            set;
        }
        
        /// <summary>
        /// The email property
        /// </summary>
        string Email
        {
            get;
            set;
        }
        
        /// <summary>
        /// The userID property
        /// </summary>
        string UserID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The web property
        /// </summary>
        string Web
        {
            get;
            set;
        }
        
        /// <summary>
        /// The password property
        /// </summary>
        string Password
        {
            get;
            set;
        }
        
        /// <summary>
        /// The radio property
        /// </summary>
        string Radio
        {
            get;
            set;
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        IStatus Status
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Lan property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LanChanging;
        
        /// <summary>
        /// Gets fired when the Lan property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LanChanged;
        
        /// <summary>
        /// Gets fired before the Email property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmailChanging;
        
        /// <summary>
        /// Gets fired when the Email property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmailChanged;
        
        /// <summary>
        /// Gets fired before the UserID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserIDChanging;
        
        /// <summary>
        /// Gets fired when the UserID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserIDChanged;
        
        /// <summary>
        /// Gets fired before the Web property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WebChanging;
        
        /// <summary>
        /// Gets fired when the Web property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WebChanged;
        
        /// <summary>
        /// Gets fired before the Password property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PasswordChanging;
        
        /// <summary>
        /// Gets fired when the Password property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PasswordChanged;
        
        /// <summary>
        /// Gets fired before the Radio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RadioChanging;
        
        /// <summary>
        /// Gets fired when the Radio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RadioChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
    }
}
