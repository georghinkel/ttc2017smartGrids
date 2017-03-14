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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl
{
    
    
    /// <summary>
    /// The public interface for LoadMgmtRecord
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(LoadMgmtRecord))]
    [XmlDefaultImplementationTypeAttribute(typeof(LoadMgmtRecord))]
    public interface ILoadMgmtRecord : IModelElement, IActivityRecord
    {
        
        /// <summary>
        /// The loadReduction property
        /// </summary>
        float LoadReduction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LoadMgmtFunction property
        /// </summary>
        ILoadMgmtFunction LoadMgmtFunction
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the LoadReduction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadReductionChanging;
        
        /// <summary>
        /// Gets fired when the LoadReduction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadReductionChanged;
        
        /// <summary>
        /// Gets fired before the LoadMgmtFunction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadMgmtFunctionChanging;
        
        /// <summary>
        /// Gets fired when the LoadMgmtFunction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadMgmtFunctionChanged;
    }
}

