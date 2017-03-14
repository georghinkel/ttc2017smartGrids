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
    /// The public interface for ProcedureDataSet
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ProcedureDataSet))]
    [XmlDefaultImplementationTypeAttribute(typeof(ProcedureDataSet))]
    public interface IProcedureDataSet : IModelElement, IDocument
    {
        
        /// <summary>
        /// The completedDateTime property
        /// </summary>
        DateTime CompletedDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeasurementValues property
        /// </summary>
        IOrderedSetExpression<IMeasurementValue> MeasurementValues
        {
            get;
        }
        
        /// <summary>
        /// The TransformerObservations property
        /// </summary>
        IOrderedSetExpression<ITransformerObservation> TransformerObservations
        {
            get;
        }
        
        /// <summary>
        /// The Properties property
        /// </summary>
        IOrderedSetExpression<IUserAttribute> Properties
        {
            get;
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
        /// Gets fired before the CompletedDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CompletedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the CompletedDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CompletedDateTimeChanged;
        
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

