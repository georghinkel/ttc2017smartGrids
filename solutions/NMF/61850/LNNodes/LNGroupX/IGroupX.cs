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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupX
{
    
    
    /// <summary>
    /// The public interface for GroupX
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GroupX))]
    [XmlDefaultImplementationTypeAttribute(typeof(GroupX))]
    public interface IGroupX : IModelElement, IDomainLN
    {
        
        /// <summary>
        /// The EEHealth property
        /// </summary>
        Nullable<HealthStateKind> EEHealth
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Loc property
        /// </summary>
        ISPS Loc
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EEName property
        /// </summary>
        IDPL EEName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpCnt property
        /// </summary>
        IINS OpCnt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Pos property
        /// </summary>
        IDPC Pos
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BlkOpn property
        /// </summary>
        ISPC BlkOpn
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BlkCls property
        /// </summary>
        ISPC BlkCls
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChaMotEna property
        /// </summary>
        ISPC ChaMotEna
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the EEHealth property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EEHealthChanging;
        
        /// <summary>
        /// Gets fired when the EEHealth property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EEHealthChanged;
        
        /// <summary>
        /// Gets fired before the Loc property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocChanging;
        
        /// <summary>
        /// Gets fired when the Loc property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocChanged;
        
        /// <summary>
        /// Gets fired before the EEName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EENameChanging;
        
        /// <summary>
        /// Gets fired when the EEName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EENameChanged;
        
        /// <summary>
        /// Gets fired before the OpCnt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpCntChanging;
        
        /// <summary>
        /// Gets fired when the OpCnt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpCntChanged;
        
        /// <summary>
        /// Gets fired before the Pos property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PosChanging;
        
        /// <summary>
        /// Gets fired when the Pos property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PosChanged;
        
        /// <summary>
        /// Gets fired before the BlkOpn property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkOpnChanging;
        
        /// <summary>
        /// Gets fired when the BlkOpn property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkOpnChanged;
        
        /// <summary>
        /// Gets fired before the BlkCls property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkClsChanging;
        
        /// <summary>
        /// Gets fired when the BlkCls property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkClsChanged;
        
        /// <summary>
        /// Gets fired before the ChaMotEna property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChaMotEnaChanging;
        
        /// <summary>
        /// Gets fired when the ChaMotEna property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChaMotEnaChanged;
    }
}
