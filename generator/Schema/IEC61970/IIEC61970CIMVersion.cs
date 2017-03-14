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

namespace TTC2017.SmartGrids.CIM.IEC61970
{
    
    
    /// <summary>
    /// The public interface for IEC61970CIMVersion
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(IEC61970CIMVersion))]
    [XmlDefaultImplementationTypeAttribute(typeof(IEC61970CIMVersion))]
    public interface IIEC61970CIMVersion : IModelElement, IElement
    {
        
        /// <summary>
        /// The date property
        /// </summary>
        DateTime Date
        {
            get;
            set;
        }
        
        /// <summary>
        /// The version property
        /// </summary>
        string Version
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Date property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateChanging;
        
        /// <summary>
        /// Gets fired when the Date property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateChanged;
        
        /// <summary>
        /// Gets fired before the Version property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VersionChanging;
        
        /// <summary>
        /// Gets fired when the Version property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VersionChanged;
    }
}

