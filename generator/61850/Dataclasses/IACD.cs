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
    /// The public interface for ACD
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ACD))]
    [XmlDefaultImplementationTypeAttribute(typeof(ACD))]
    public interface IACD : IModelElement
    {
        
        /// <summary>
        /// The general property
        /// </summary>
        Nullable<bool> General
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phsA property
        /// </summary>
        Nullable<bool> PhsA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phsB property
        /// </summary>
        Nullable<bool> PhsB
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phsC property
        /// </summary>
        Nullable<bool> PhsC
        {
            get;
            set;
        }
        
        /// <summary>
        /// The neut property
        /// </summary>
        Nullable<bool> Neut
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dirGeneral property
        /// </summary>
        IFaultDirection DirGeneral
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dirPhsA property
        /// </summary>
        IDirectionPhase DirPhsA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dirPhsB property
        /// </summary>
        IDirectionPhase DirPhsB
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dirPhsC property
        /// </summary>
        IDirectionPhase DirPhsC
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dirNeut property
        /// </summary>
        IDirectionPhase DirNeut
        {
            get;
            set;
        }
        
        /// <summary>
        /// The q property
        /// </summary>
        IQuality Q
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the General property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GeneralChanging;
        
        /// <summary>
        /// Gets fired when the General property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GeneralChanged;
        
        /// <summary>
        /// Gets fired before the PhsA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhsAChanging;
        
        /// <summary>
        /// Gets fired when the PhsA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhsAChanged;
        
        /// <summary>
        /// Gets fired before the PhsB property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhsBChanging;
        
        /// <summary>
        /// Gets fired when the PhsB property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhsBChanged;
        
        /// <summary>
        /// Gets fired before the PhsC property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhsCChanging;
        
        /// <summary>
        /// Gets fired when the PhsC property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhsCChanged;
        
        /// <summary>
        /// Gets fired before the Neut property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeutChanging;
        
        /// <summary>
        /// Gets fired when the Neut property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeutChanged;
        
        /// <summary>
        /// Gets fired before the DirGeneral property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirGeneralChanging;
        
        /// <summary>
        /// Gets fired when the DirGeneral property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirGeneralChanged;
        
        /// <summary>
        /// Gets fired before the DirPhsA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirPhsAChanging;
        
        /// <summary>
        /// Gets fired when the DirPhsA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirPhsAChanged;
        
        /// <summary>
        /// Gets fired before the DirPhsB property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirPhsBChanging;
        
        /// <summary>
        /// Gets fired when the DirPhsB property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirPhsBChanged;
        
        /// <summary>
        /// Gets fired before the DirPhsC property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirPhsCChanging;
        
        /// <summary>
        /// Gets fired when the DirPhsC property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirPhsCChanged;
        
        /// <summary>
        /// Gets fired before the DirNeut property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirNeutChanging;
        
        /// <summary>
        /// Gets fired when the DirNeut property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirNeutChanged;
        
        /// <summary>
        /// Gets fired before the Q property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QChanging;
        
        /// <summary>
        /// Gets fired when the Q property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QChanged;
    }
}

