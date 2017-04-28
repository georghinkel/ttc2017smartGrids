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
    /// The public interface for ErpInvoice
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ErpInvoice))]
    [XmlDefaultImplementationTypeAttribute(typeof(ErpInvoice))]
    public interface IErpInvoice : IModelElement, IDocument
    {
        
        /// <summary>
        /// The amount property
        /// </summary>
        float Amount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<ErpInvoiceKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The transactionDateTime property
        /// </summary>
        DateTime TransactionDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The referenceNumber property
        /// </summary>
        string ReferenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dueDate property
        /// </summary>
        string DueDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The mailedDate property
        /// </summary>
        string MailedDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The transferType property
        /// </summary>
        string TransferType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The proForma property
        /// </summary>
        bool ProForma
        {
            get;
            set;
        }
        
        /// <summary>
        /// The billMediaKind property
        /// </summary>
        Nullable<BillMediaKind> BillMediaKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerAccount property
        /// </summary>
        ICustomerAccount CustomerAccount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpInvoiceLineItems property
        /// </summary>
        IOrderedSetExpression<IErpInvoiceLineItem> ErpInvoiceLineItems
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Amount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmountChanging;
        
        /// <summary>
        /// Gets fired when the Amount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmountChanged;
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the TransactionDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransactionDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the TransactionDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransactionDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the ReferenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the ReferenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the DueDate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DueDateChanging;
        
        /// <summary>
        /// Gets fired when the DueDate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DueDateChanged;
        
        /// <summary>
        /// Gets fired before the MailedDate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MailedDateChanging;
        
        /// <summary>
        /// Gets fired when the MailedDate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MailedDateChanged;
        
        /// <summary>
        /// Gets fired before the TransferType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransferTypeChanging;
        
        /// <summary>
        /// Gets fired when the TransferType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransferTypeChanged;
        
        /// <summary>
        /// Gets fired before the ProForma property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProFormaChanging;
        
        /// <summary>
        /// Gets fired when the ProForma property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProFormaChanged;
        
        /// <summary>
        /// Gets fired before the BillMediaKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillMediaKindChanging;
        
        /// <summary>
        /// Gets fired when the BillMediaKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillMediaKindChanged;
        
        /// <summary>
        /// Gets fired before the CustomerAccount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAccountChanging;
        
        /// <summary>
        /// Gets fired when the CustomerAccount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAccountChanged;
    }
}
