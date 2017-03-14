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
    /// The public interface for WorkTask
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WorkTask))]
    [XmlDefaultImplementationTypeAttribute(typeof(WorkTask))]
    public interface IWorkTask : IModelElement, IDocument
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
        /// The schedOverride property
        /// </summary>
        string SchedOverride
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Crews property
        /// </summary>
        IOrderedSetExpression<ICrew> Crews
        {
            get;
        }
        
        /// <summary>
        /// The SwitchingSchedules property
        /// </summary>
        IOrderedSetExpression<ISwitchingSchedule> SwitchingSchedules
        {
            get;
        }
        
        /// <summary>
        /// The MiscCostItems property
        /// </summary>
        IOrderedSetExpression<IMiscCostItem> MiscCostItems
        {
            get;
        }
        
        /// <summary>
        /// The LaborItems property
        /// </summary>
        IOrderedSetExpression<ILaborItem> LaborItems
        {
            get;
        }
        
        /// <summary>
        /// The WorkFlowStep property
        /// </summary>
        IWorkFlowStep WorkFlowStep
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Assets property
        /// </summary>
        IOrderedSetExpression<IAsset> Assets
        {
            get;
        }
        
        /// <summary>
        /// The Capabilities property
        /// </summary>
        IOrderedSetExpression<ICapability> Capabilities
        {
            get;
        }
        
        /// <summary>
        /// The Work property
        /// </summary>
        IWork Work
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DesignLocationCUs property
        /// </summary>
        IOrderedSetExpression<IDesignLocationCU> DesignLocationCUs
        {
            get;
        }
        
        /// <summary>
        /// The ContractorItems property
        /// </summary>
        IOrderedSetExpression<IContractorItem> ContractorItems
        {
            get;
        }
        
        /// <summary>
        /// The Design property
        /// </summary>
        IDesign Design
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EquipmentItems property
        /// </summary>
        IOrderedSetExpression<IEquipmentItem> EquipmentItems
        {
            get;
        }
        
        /// <summary>
        /// The MaterialItems property
        /// </summary>
        IOrderedSetExpression<IMaterialItem> MaterialItems
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
        /// The QualificationRequirements property
        /// </summary>
        IOrderedSetExpression<IQualificationRequirement> QualificationRequirements
        {
            get;
        }
        
        /// <summary>
        /// The Usages property
        /// </summary>
        IOrderedSetExpression<IUsage> Usages
        {
            get;
        }
        
        /// <summary>
        /// The OverheadCost property
        /// </summary>
        IOverheadCost OverheadCost
        {
            get;
            set;
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
        /// Gets fired before the SchedOverride property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SchedOverrideChanging;
        
        /// <summary>
        /// Gets fired when the SchedOverride property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SchedOverrideChanged;
        
        /// <summary>
        /// Gets fired before the WorkFlowStep property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkFlowStepChanging;
        
        /// <summary>
        /// Gets fired when the WorkFlowStep property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkFlowStepChanged;
        
        /// <summary>
        /// Gets fired before the Work property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkChanging;
        
        /// <summary>
        /// Gets fired when the Work property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkChanged;
        
        /// <summary>
        /// Gets fired before the Design property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DesignChanging;
        
        /// <summary>
        /// Gets fired when the Design property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DesignChanged;
        
        /// <summary>
        /// Gets fired before the OverheadCost property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OverheadCostChanging;
        
        /// <summary>
        /// Gets fired when the OverheadCost property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OverheadCostChanged;
    }
}

