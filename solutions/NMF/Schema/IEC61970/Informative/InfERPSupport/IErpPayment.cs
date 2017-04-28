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
    /// The public interface for ErpPayment
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ErpPayment))]
    [XmlDefaultImplementationTypeAttribute(typeof(ErpPayment))]
    public interface IErpPayment : IModelElement, IDocument
    {
        
        /// <summary>
        /// The termsPayment property
        /// </summary>
        string TermsPayment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpPayableLineItems property
        /// </summary>
        IOrderedSetExpression<IErpPayableLineItem> ErpPayableLineItems
        {
            get;
        }
        
        /// <summary>
        /// The ErpInvoiceLineItems property
        /// </summary>
        IOrderedSetExpression<IErpInvoiceLineItem> ErpInvoiceLineItems
        {
            get;
        }
        
        /// <summary>
        /// The ErpRecLineItems property
        /// </summary>
        IOrderedSetExpression<IErpRecLineItem> ErpRecLineItems
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the TermsPayment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TermsPaymentChanging;
        
        /// <summary>
        /// Gets fired when the TermsPayment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TermsPaymentChanged;
    }
}
