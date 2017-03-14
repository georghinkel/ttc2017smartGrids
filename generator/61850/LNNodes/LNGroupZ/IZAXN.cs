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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ
{
    
    
    /// <summary>
    /// The public interface for ZAXN
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ZAXN))]
    [XmlDefaultImplementationTypeAttribute(typeof(ZAXN))]
    public interface IZAXN : IModelElement, IGroupZ
    {
        
        /// <summary>
        /// The OpTmh property
        /// </summary>
        IINS OpTmh
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Vol property
        /// </summary>
        IMV Vol
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Amp property
        /// </summary>
        IMV Amp
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OpTmh property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanging;
        
        /// <summary>
        /// Gets fired when the OpTmh property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanged;
        
        /// <summary>
        /// Gets fired before the Vol property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VolChanging;
        
        /// <summary>
        /// Gets fired when the Vol property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VolChanged;
        
        /// <summary>
        /// Gets fired before the Amp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmpChanging;
        
        /// <summary>
        /// Gets fired when the Amp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmpChanged;
    }
}

