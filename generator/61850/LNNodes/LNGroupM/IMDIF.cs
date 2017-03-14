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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.Enumerations;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupM
{
    
    
    /// <summary>
    /// The public interface for MDIF
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MDIF))]
    [XmlDefaultImplementationTypeAttribute(typeof(MDIF))]
    public interface IMDIF : IModelElement, IGroupM
    {
        
        /// <summary>
        /// The OpARem property
        /// </summary>
        IWYE OpARem
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Amp1 property
        /// </summary>
        ISAV Amp1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Amp2 property
        /// </summary>
        ISAV Amp2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Amp3 property
        /// </summary>
        ISAV Amp3
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OpARem property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpARemChanging;
        
        /// <summary>
        /// Gets fired when the OpARem property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpARemChanged;
        
        /// <summary>
        /// Gets fired before the Amp1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Amp1Changing;
        
        /// <summary>
        /// Gets fired when the Amp1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Amp1Changed;
        
        /// <summary>
        /// Gets fired before the Amp2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Amp2Changing;
        
        /// <summary>
        /// Gets fired when the Amp2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Amp2Changed;
        
        /// <summary>
        /// Gets fired before the Amp3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Amp3Changing;
        
        /// <summary>
        /// Gets fired when the Amp3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Amp3Changed;
    }
}
