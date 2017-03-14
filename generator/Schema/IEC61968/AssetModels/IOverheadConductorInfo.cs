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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.AssetModels
{
    
    
    /// <summary>
    /// The public interface for OverheadConductorInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OverheadConductorInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(OverheadConductorInfo))]
    public interface IOverheadConductorInfo : IModelElement, IConductorInfo
    {
        
        /// <summary>
        /// The neutralInsulationThickness property
        /// </summary>
        float NeutralInsulationThickness
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseConductorSpacing property
        /// </summary>
        float PhaseConductorSpacing
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseConductorCount property
        /// </summary>
        int PhaseConductorCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MountingPoint property
        /// </summary>
        IMountingPoint MountingPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the NeutralInsulationThickness property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeutralInsulationThicknessChanging;
        
        /// <summary>
        /// Gets fired when the NeutralInsulationThickness property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeutralInsulationThicknessChanged;
        
        /// <summary>
        /// Gets fired before the PhaseConductorSpacing property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseConductorSpacingChanging;
        
        /// <summary>
        /// Gets fired when the PhaseConductorSpacing property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseConductorSpacingChanged;
        
        /// <summary>
        /// Gets fired before the PhaseConductorCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseConductorCountChanging;
        
        /// <summary>
        /// Gets fired when the PhaseConductorCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseConductorCountChanged;
        
        /// <summary>
        /// Gets fired before the MountingPoint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MountingPointChanging;
        
        /// <summary>
        /// Gets fired when the MountingPoint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MountingPointChanged;
    }
}

