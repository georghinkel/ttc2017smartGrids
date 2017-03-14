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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The public interface for Procedure
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Procedure))]
    [XmlDefaultImplementationTypeAttribute(typeof(Procedure))]
    public interface IProcedure : IModelElement, IDocument
    {
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<ProcedureKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        string SequenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The corporateCode property
        /// </summary>
        string CorporateCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The instruction property
        /// </summary>
        string Instruction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Limits property
        /// </summary>
        IOrderedSetExpression<ILimit> Limits
        {
            get;
        }
        
        /// <summary>
        /// The CompatibleUnits property
        /// </summary>
        IOrderedSetExpression<ICompatibleUnit> CompatibleUnits
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
        /// The ProcedureValues property
        /// </summary>
        IOrderedSetExpression<IUserAttribute> ProcedureValues
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the CorporateCode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanging;
        
        /// <summary>
        /// Gets fired when the CorporateCode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanged;
        
        /// <summary>
        /// Gets fired before the Instruction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstructionChanging;
        
        /// <summary>
        /// Gets fired when the Instruction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstructionChanged;
    }
}

