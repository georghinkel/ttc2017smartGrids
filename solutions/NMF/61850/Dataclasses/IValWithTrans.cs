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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The public interface for ValWithTrans
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ValWithTrans))]
    [XmlDefaultImplementationTypeAttribute(typeof(ValWithTrans))]
    public interface IValWithTrans : IModelElement
    {
        
        /// <summary>
        /// The posVal property
        /// </summary>
        Nullable<int> PosVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The transInd property
        /// </summary>
        Nullable<bool> TransInd
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the PosVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PosValChanging;
        
        /// <summary>
        /// Gets fired when the PosVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PosValChanged;
        
        /// <summary>
        /// Gets fired before the TransInd property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransIndChanging;
        
        /// <summary>
        /// Gets fired when the TransInd property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransIndChanged;
    }
}
