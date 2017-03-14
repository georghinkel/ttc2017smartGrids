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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The public interface for GmlObservation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlObservation))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlObservation))]
    public interface IGmlObservation : IModelElement, IElement
    {
        
        /// <summary>
        /// The target property
        /// </summary>
        string Target
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dateTime property
        /// </summary>
        DateTime DateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resultOf property
        /// </summary>
        string ResultOf
        {
            get;
            set;
        }
        
        /// <summary>
        /// The using property
        /// </summary>
        string Using
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlDiagramObjects property
        /// </summary>
        IOrderedSetExpression<IGmlDiagramObject> GmlDiagramObjects
        {
            get;
        }
        
        /// <summary>
        /// The ChangeItems property
        /// </summary>
        IOrderedSetExpression<IChangeItem> ChangeItems
        {
            get;
        }
        
        /// <summary>
        /// The GmlValues property
        /// </summary>
        IOrderedSetExpression<IGmlValue> GmlValues
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Target property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TargetChanging;
        
        /// <summary>
        /// Gets fired when the Target property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TargetChanged;
        
        /// <summary>
        /// Gets fired before the DateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanged;
        
        /// <summary>
        /// Gets fired before the ResultOf property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResultOfChanging;
        
        /// <summary>
        /// Gets fired when the ResultOf property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResultOfChanged;
        
        /// <summary>
        /// Gets fired before the Using property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsingChanging;
        
        /// <summary>
        /// Gets fired when the Using property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsingChanged;
    }
}
