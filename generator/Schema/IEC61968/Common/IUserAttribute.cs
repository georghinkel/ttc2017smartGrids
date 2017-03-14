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
    /// The public interface for UserAttribute
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(UserAttribute))]
    [XmlDefaultImplementationTypeAttribute(typeof(UserAttribute))]
    public interface IUserAttribute : IModelElement, IElement
    {
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        int SequenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The name property
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        string Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PropertySpecification property
        /// </summary>
        ISpecification PropertySpecification
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PassThroughBills property
        /// </summary>
        IOrderedSetExpression<IPassThroughBill> PassThroughBills
        {
            get;
        }
        
        /// <summary>
        /// The Transaction property
        /// </summary>
        ITransaction Transaction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RatingAssets property
        /// </summary>
        IOrderedSetExpression<IAsset> RatingAssets
        {
            get;
        }
        
        /// <summary>
        /// The ErpLedgerEntries property
        /// </summary>
        IOrderedSetExpression<IErpLedgerEntry> ErpLedgerEntries
        {
            get;
        }
        
        /// <summary>
        /// The PropertyAssets property
        /// </summary>
        IOrderedSetExpression<IAsset> PropertyAssets
        {
            get;
        }
        
        /// <summary>
        /// The ErpStatementLineItems property
        /// </summary>
        IOrderedSetExpression<IMarketStatementLineItem> ErpStatementLineItems
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
        /// The ProcedureDataSets property
        /// </summary>
        IOrderedSetExpression<IProcedureDataSet> ProcedureDataSets
        {
            get;
        }
        
        /// <summary>
        /// The RatingSpecification property
        /// </summary>
        ISpecification RatingSpecification
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Procedure property
        /// </summary>
        IProcedure Procedure
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BillDeterminants property
        /// </summary>
        IOrderedSetExpression<IBillDeterminant> BillDeterminants
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the PropertySpecification property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PropertySpecificationChanging;
        
        /// <summary>
        /// Gets fired when the PropertySpecification property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PropertySpecificationChanged;
        
        /// <summary>
        /// Gets fired before the Transaction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransactionChanging;
        
        /// <summary>
        /// Gets fired when the Transaction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransactionChanged;
        
        /// <summary>
        /// Gets fired before the RatingSpecification property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatingSpecificationChanging;
        
        /// <summary>
        /// Gets fired when the RatingSpecification property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatingSpecificationChanged;
        
        /// <summary>
        /// Gets fired before the Procedure property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProcedureChanging;
        
        /// <summary>
        /// Gets fired when the Procedure property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProcedureChanged;
    }
}
