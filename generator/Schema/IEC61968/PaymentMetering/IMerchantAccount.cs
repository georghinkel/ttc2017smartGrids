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
    /// The public interface for MerchantAccount
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MerchantAccount))]
    [XmlDefaultImplementationTypeAttribute(typeof(MerchantAccount))]
    public interface IMerchantAccount : IModelElement, IDocument
    {
        
        /// <summary>
        /// The provisionalBalance property
        /// </summary>
        float ProvisionalBalance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The currentBalance property
        /// </summary>
        float CurrentBalance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BankStatements property
        /// </summary>
        IOrderedSetExpression<IBankStatement> BankStatements
        {
            get;
        }
        
        /// <summary>
        /// The MerchantAgreement property
        /// </summary>
        IMerchantAgreement MerchantAgreement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Transactors property
        /// </summary>
        IOrderedSetExpression<ITransactor> Transactors
        {
            get;
        }
        
        /// <summary>
        /// The Vendors property
        /// </summary>
        IOrderedSetExpression<IVendor> Vendors
        {
            get;
        }
        
        /// <summary>
        /// The VendorShifts property
        /// </summary>
        IOrderedSetExpression<IVendorShift> VendorShifts
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ProvisionalBalance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProvisionalBalanceChanging;
        
        /// <summary>
        /// Gets fired when the ProvisionalBalance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProvisionalBalanceChanged;
        
        /// <summary>
        /// Gets fired before the CurrentBalance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CurrentBalanceChanging;
        
        /// <summary>
        /// Gets fired when the CurrentBalance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CurrentBalanceChanged;
        
        /// <summary>
        /// Gets fired before the MerchantAgreement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MerchantAgreementChanging;
        
        /// <summary>
        /// Gets fired when the MerchantAgreement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MerchantAgreementChanged;
    }
}

