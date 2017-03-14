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
    /// The public interface for WindingInsulation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WindingInsulation))]
    [XmlDefaultImplementationTypeAttribute(typeof(WindingInsulation))]
    public interface IWindingInsulation : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The insulationResistance property
        /// </summary>
        string InsulationResistance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The leakageReactance property
        /// </summary>
        float LeakageReactance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The insulationPFStatus property
        /// </summary>
        string InsulationPFStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ToWinding property
        /// </summary>
        IDistributionTransformerWinding ToWinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Ground property
        /// </summary>
        IGround Ground
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TransformerObservation property
        /// </summary>
        ITransformerObservation TransformerObservation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        IStatus Status
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromWinding property
        /// </summary>
        IDistributionTransformerWinding FromWinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the InsulationResistance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InsulationResistanceChanging;
        
        /// <summary>
        /// Gets fired when the InsulationResistance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InsulationResistanceChanged;
        
        /// <summary>
        /// Gets fired before the LeakageReactance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeakageReactanceChanging;
        
        /// <summary>
        /// Gets fired when the LeakageReactance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeakageReactanceChanged;
        
        /// <summary>
        /// Gets fired before the InsulationPFStatus property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InsulationPFStatusChanging;
        
        /// <summary>
        /// Gets fired when the InsulationPFStatus property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InsulationPFStatusChanged;
        
        /// <summary>
        /// Gets fired before the ToWinding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ToWindingChanging;
        
        /// <summary>
        /// Gets fired when the ToWinding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ToWindingChanged;
        
        /// <summary>
        /// Gets fired before the Ground property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GroundChanging;
        
        /// <summary>
        /// Gets fired when the Ground property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GroundChanged;
        
        /// <summary>
        /// Gets fired before the TransformerObservation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerObservationChanging;
        
        /// <summary>
        /// Gets fired when the TransformerObservation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerObservationChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the FromWinding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromWindingChanging;
        
        /// <summary>
        /// Gets fired when the FromWinding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromWindingChanged;
    }
}

