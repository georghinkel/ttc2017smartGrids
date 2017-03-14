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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61968.Work
{
    
    
    /// <summary>
    /// The public interface for Work
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Work))]
    [XmlDefaultImplementationTypeAttribute(typeof(Work))]
    public interface IWork : IModelElement, IDocument
    {
        
        /// <summary>
        /// The priority property
        /// </summary>
        string Priority
        {
            get;
            set;
        }
        
        /// <summary>
        /// The requestDateTime property
        /// </summary>
        DateTime RequestDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<WorkKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WorkTasks property
        /// </summary>
        IOrderedSetExpression<IWorkTask> WorkTasks
        {
            get;
        }
        
        /// <summary>
        /// The Designs property
        /// </summary>
        IOrderedSetExpression<IDesign> Designs
        {
            get;
        }
        
        /// <summary>
        /// The BusinessCase property
        /// </summary>
        IBusinessCase BusinessCase
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WorkFlowSteps property
        /// </summary>
        IOrderedSetExpression<IWorkFlowStep> WorkFlowSteps
        {
            get;
        }
        
        /// <summary>
        /// The WorkCostDetails property
        /// </summary>
        IOrderedSetExpression<IWorkCostDetail> WorkCostDetails
        {
            get;
        }
        
        /// <summary>
        /// The ErpProjectAccounting property
        /// </summary>
        IErpProjectAccounting ErpProjectAccounting
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Project property
        /// </summary>
        IProject Project
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Request property
        /// </summary>
        IRequest Request
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WorkBillingInfo property
        /// </summary>
        IWorkBillingInfo WorkBillingInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Customers property
        /// </summary>
        IOrderedSetExpression<ICustomer> Customers
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Priority property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriorityChanging;
        
        /// <summary>
        /// Gets fired when the Priority property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriorityChanged;
        
        /// <summary>
        /// Gets fired before the RequestDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequestDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the RequestDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequestDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the BusinessCase property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BusinessCaseChanging;
        
        /// <summary>
        /// Gets fired when the BusinessCase property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BusinessCaseChanged;
        
        /// <summary>
        /// Gets fired before the ErpProjectAccounting property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpProjectAccountingChanging;
        
        /// <summary>
        /// Gets fired when the ErpProjectAccounting property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpProjectAccountingChanged;
        
        /// <summary>
        /// Gets fired before the Project property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProjectChanging;
        
        /// <summary>
        /// Gets fired when the Project property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProjectChanged;
        
        /// <summary>
        /// Gets fired before the Request property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequestChanging;
        
        /// <summary>
        /// Gets fired when the Request property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequestChanged;
        
        /// <summary>
        /// Gets fired before the WorkBillingInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkBillingInfoChanging;
        
        /// <summary>
        /// Gets fired when the WorkBillingInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkBillingInfoChanged;
    }
}
