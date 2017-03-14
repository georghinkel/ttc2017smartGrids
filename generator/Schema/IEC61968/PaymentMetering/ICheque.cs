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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    /// <summary>
    /// The public interface for Cheque
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Cheque))]
    [XmlDefaultImplementationTypeAttribute(typeof(Cheque))]
    public interface ICheque : IModelElement, IElement
    {
        
        /// <summary>
        /// The micrNumber property
        /// </summary>
        string MicrNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The date property
        /// </summary>
        string Date
        {
            get;
            set;
        }
        
        /// <summary>
        /// The chequeNumber property
        /// </summary>
        string ChequeNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<ChequeKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The bankAccountDetail property
        /// </summary>
        IBankAccountDetail BankAccountDetail
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tender property
        /// </summary>
        ITender Tender
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MicrNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MicrNumberChanging;
        
        /// <summary>
        /// Gets fired when the MicrNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MicrNumberChanged;
        
        /// <summary>
        /// Gets fired before the Date property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateChanging;
        
        /// <summary>
        /// Gets fired when the Date property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateChanged;
        
        /// <summary>
        /// Gets fired before the ChequeNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChequeNumberChanging;
        
        /// <summary>
        /// Gets fired when the ChequeNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChequeNumberChanged;
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the BankAccountDetail property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BankAccountDetailChanging;
        
        /// <summary>
        /// Gets fired when the BankAccountDetail property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BankAccountDetailChanged;
        
        /// <summary>
        /// Gets fired before the Tender property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TenderChanging;
        
        /// <summary>
        /// Gets fired when the Tender property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TenderChanged;
    }
}
