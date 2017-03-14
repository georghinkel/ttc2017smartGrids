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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The public interface for Project
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Project))]
    [XmlDefaultImplementationTypeAttribute(typeof(Project))]
    public interface IProject : IModelElement, IDocument
    {
        
        /// <summary>
        /// The budget property
        /// </summary>
        float Budget
        {
            get;
            set;
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
        /// The Works property
        /// </summary>
        IOrderedSetExpression<IWork> Works
        {
            get;
        }
        
        /// <summary>
        /// The Requests property
        /// </summary>
        IOrderedSetExpression<IRequest> Requests
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
        /// The SubProjects property
        /// </summary>
        IOrderedSetExpression<IProject> SubProjects
        {
            get;
        }
        
        /// <summary>
        /// The ParentProject property
        /// </summary>
        IProject ParentProject
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Budget property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BudgetChanging;
        
        /// <summary>
        /// Gets fired when the Budget property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BudgetChanged;
        
        /// <summary>
        /// Gets fired before the ErpProjectAccounting property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpProjectAccountingChanging;
        
        /// <summary>
        /// Gets fired when the ErpProjectAccounting property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpProjectAccountingChanged;
        
        /// <summary>
        /// Gets fired before the BusinessCase property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BusinessCaseChanging;
        
        /// <summary>
        /// Gets fired when the BusinessCase property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BusinessCaseChanged;
        
        /// <summary>
        /// Gets fired before the ParentProject property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ParentProjectChanging;
        
        /// <summary>
        /// Gets fired when the ParentProject property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ParentProjectChanged;
    }
}

