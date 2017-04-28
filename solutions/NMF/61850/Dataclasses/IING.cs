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
    /// The public interface for ING
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ING))]
    [XmlDefaultImplementationTypeAttribute(typeof(ING))]
    public interface IING : IModelElement
    {
        
        /// <summary>
        /// The setVal property
        /// </summary>
        Nullable<int> SetVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minVal property
        /// </summary>
        Nullable<int> MinVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maxVal property
        /// </summary>
        Nullable<int> MaxVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The stepSize property
        /// </summary>
        Nullable<int> StepSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SetVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SetValChanging;
        
        /// <summary>
        /// Gets fired when the SetVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SetValChanged;
        
        /// <summary>
        /// Gets fired before the MinVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinValChanging;
        
        /// <summary>
        /// Gets fired when the MinVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinValChanged;
        
        /// <summary>
        /// Gets fired before the MaxVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxValChanging;
        
        /// <summary>
        /// Gets fired when the MaxVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxValChanged;
        
        /// <summary>
        /// Gets fired before the StepSize property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StepSizeChanging;
        
        /// <summary>
        /// Gets fired when the StepSize property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StepSizeChanged;
    }
}
