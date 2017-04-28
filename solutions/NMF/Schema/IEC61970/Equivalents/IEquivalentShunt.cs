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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.Equivalents
{
    
    
    /// <summary>
    /// The public interface for EquivalentShunt
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EquivalentShunt))]
    [XmlDefaultImplementationTypeAttribute(typeof(EquivalentShunt))]
    public interface IEquivalentShunt : IModelElement, IEquivalentEquipment
    {
        
        /// <summary>
        /// The b property
        /// </summary>
        float B
        {
            get;
            set;
        }
        
        /// <summary>
        /// The g property
        /// </summary>
        float G
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the B property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BChanging;
        
        /// <summary>
        /// Gets fired when the B property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BChanged;
        
        /// <summary>
        /// Gets fired before the G property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GChanging;
        
        /// <summary>
        /// Gets fired when the G property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GChanged;
    }
}
