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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations
{
    
    
    /// <summary>
    /// The public interface for Direction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Direction))]
    [XmlDefaultImplementationTypeAttribute(typeof(Direction))]
    public interface IDirection : IModelElement, IElement
    {
        
        /// <summary>
        /// The directionInfo property
        /// </summary>
        string DirectionInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Location property
        /// </summary>
        ILocation Location
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DirectionInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirectionInfoChanging;
        
        /// <summary>
        /// Gets fired when the DirectionInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirectionInfoChanged;
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationChanged;
    }
}

