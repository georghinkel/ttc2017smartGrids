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
    /// The public interface for WireArrangement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WireArrangement))]
    [XmlDefaultImplementationTypeAttribute(typeof(WireArrangement))]
    public interface IWireArrangement : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The mountingPointX property
        /// </summary>
        float MountingPointX
        {
            get;
            set;
        }
        
        /// <summary>
        /// The mountingPointY property
        /// </summary>
        float MountingPointY
        {
            get;
            set;
        }
        
        /// <summary>
        /// The position property
        /// </summary>
        int Position
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WireType property
        /// </summary>
        IWireType WireType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConductorInfo property
        /// </summary>
        IConductorInfo ConductorInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MountingPointX property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MountingPointXChanging;
        
        /// <summary>
        /// Gets fired when the MountingPointX property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MountingPointXChanged;
        
        /// <summary>
        /// Gets fired before the MountingPointY property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MountingPointYChanging;
        
        /// <summary>
        /// Gets fired when the MountingPointY property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MountingPointYChanged;
        
        /// <summary>
        /// Gets fired before the Position property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PositionChanging;
        
        /// <summary>
        /// Gets fired when the Position property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PositionChanged;
        
        /// <summary>
        /// Gets fired before the WireType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WireTypeChanging;
        
        /// <summary>
        /// Gets fired when the WireType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WireTypeChanged;
        
        /// <summary>
        /// Gets fired before the ConductorInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductorInfoChanging;
        
        /// <summary>
        /// Gets fired when the ConductorInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductorInfoChanged;
    }
}
