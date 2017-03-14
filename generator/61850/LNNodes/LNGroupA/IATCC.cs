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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA
{
    
    
    /// <summary>
    /// The public interface for ATCC
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ATCC))]
    [XmlDefaultImplementationTypeAttribute(typeof(ATCC))]
    public interface IATCC : IModelElement, IGroupA
    {
        
        /// <summary>
        /// The TapChg property
        /// </summary>
        IBSC TapChg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TapPos property
        /// </summary>
        IISC TapPos
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ParOp property
        /// </summary>
        IDPC ParOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LTCBlk property
        /// </summary>
        ISPC LTCBlk
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LTCDragRs property
        /// </summary>
        ISPC LTCDragRs
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VRed1 property
        /// </summary>
        ISPC VRed1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VRed2 property
        /// </summary>
        ISPC VRed2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CtlV property
        /// </summary>
        IMV CtlV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LodA property
        /// </summary>
        IMV LodA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CircA property
        /// </summary>
        IMV CircA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PhAng property
        /// </summary>
        IMV PhAng
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HiCtlV property
        /// </summary>
        IMV HiCtlV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LoCtlV property
        /// </summary>
        IMV LoCtlV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HiDmdA property
        /// </summary>
        IMV HiDmdA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HiTapPos property
        /// </summary>
        IINS HiTapPos
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LoTapPos property
        /// </summary>
        IINS LoTapPos
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BndCtr property
        /// </summary>
        IASG BndCtr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BndWid property
        /// </summary>
        IASG BndWid
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CtlDlTmms property
        /// </summary>
        IASG CtlDlTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LDCR property
        /// </summary>
        IASG LDCR
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LDCX property
        /// </summary>
        IASG LDCX
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BlkLV property
        /// </summary>
        IASG BlkLV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BlkRV property
        /// </summary>
        IASG BlkRV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RnbkRV property
        /// </summary>
        IASG RnbkRV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LimLodA property
        /// </summary>
        IASG LimLodA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LDC property
        /// </summary>
        ISPG LDC
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmDlChr property
        /// </summary>
        ISPG TmDlChr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LDCZ property
        /// </summary>
        IASG LDCZ
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VRedVal property
        /// </summary>
        IASG VRedVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TapBlkR property
        /// </summary>
        IASG TapBlkR
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TapBlkL property
        /// </summary>
        IASG TapBlkL
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the TapChg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapChgChanging;
        
        /// <summary>
        /// Gets fired when the TapChg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapChgChanged;
        
        /// <summary>
        /// Gets fired before the TapPos property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapPosChanging;
        
        /// <summary>
        /// Gets fired when the TapPos property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapPosChanged;
        
        /// <summary>
        /// Gets fired before the ParOp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ParOpChanging;
        
        /// <summary>
        /// Gets fired when the ParOp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ParOpChanged;
        
        /// <summary>
        /// Gets fired before the LTCBlk property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LTCBlkChanging;
        
        /// <summary>
        /// Gets fired when the LTCBlk property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LTCBlkChanged;
        
        /// <summary>
        /// Gets fired before the LTCDragRs property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LTCDragRsChanging;
        
        /// <summary>
        /// Gets fired when the LTCDragRs property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LTCDragRsChanged;
        
        /// <summary>
        /// Gets fired before the VRed1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRed1Changing;
        
        /// <summary>
        /// Gets fired when the VRed1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRed1Changed;
        
        /// <summary>
        /// Gets fired before the VRed2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRed2Changing;
        
        /// <summary>
        /// Gets fired when the VRed2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRed2Changed;
        
        /// <summary>
        /// Gets fired before the CtlV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtlVChanging;
        
        /// <summary>
        /// Gets fired when the CtlV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtlVChanged;
        
        /// <summary>
        /// Gets fired before the LodA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LodAChanging;
        
        /// <summary>
        /// Gets fired when the LodA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LodAChanged;
        
        /// <summary>
        /// Gets fired before the CircA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CircAChanging;
        
        /// <summary>
        /// Gets fired when the CircA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CircAChanged;
        
        /// <summary>
        /// Gets fired before the PhAng property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhAngChanging;
        
        /// <summary>
        /// Gets fired when the PhAng property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhAngChanged;
        
        /// <summary>
        /// Gets fired before the HiCtlV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiCtlVChanging;
        
        /// <summary>
        /// Gets fired when the HiCtlV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiCtlVChanged;
        
        /// <summary>
        /// Gets fired before the LoCtlV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoCtlVChanging;
        
        /// <summary>
        /// Gets fired when the LoCtlV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoCtlVChanged;
        
        /// <summary>
        /// Gets fired before the HiDmdA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiDmdAChanging;
        
        /// <summary>
        /// Gets fired when the HiDmdA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiDmdAChanged;
        
        /// <summary>
        /// Gets fired before the HiTapPos property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiTapPosChanging;
        
        /// <summary>
        /// Gets fired when the HiTapPos property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiTapPosChanged;
        
        /// <summary>
        /// Gets fired before the LoTapPos property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoTapPosChanging;
        
        /// <summary>
        /// Gets fired when the LoTapPos property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoTapPosChanged;
        
        /// <summary>
        /// Gets fired before the BndCtr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BndCtrChanging;
        
        /// <summary>
        /// Gets fired when the BndCtr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BndCtrChanged;
        
        /// <summary>
        /// Gets fired before the BndWid property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BndWidChanging;
        
        /// <summary>
        /// Gets fired when the BndWid property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BndWidChanged;
        
        /// <summary>
        /// Gets fired before the CtlDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtlDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the CtlDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtlDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the LDCR property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCRChanging;
        
        /// <summary>
        /// Gets fired when the LDCR property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCRChanged;
        
        /// <summary>
        /// Gets fired before the LDCX property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCXChanging;
        
        /// <summary>
        /// Gets fired when the LDCX property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCXChanged;
        
        /// <summary>
        /// Gets fired before the BlkLV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkLVChanging;
        
        /// <summary>
        /// Gets fired when the BlkLV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkLVChanged;
        
        /// <summary>
        /// Gets fired before the BlkRV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkRVChanging;
        
        /// <summary>
        /// Gets fired when the BlkRV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkRVChanged;
        
        /// <summary>
        /// Gets fired before the RnbkRV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RnbkRVChanging;
        
        /// <summary>
        /// Gets fired when the RnbkRV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RnbkRVChanged;
        
        /// <summary>
        /// Gets fired before the LimLodA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LimLodAChanging;
        
        /// <summary>
        /// Gets fired when the LimLodA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LimLodAChanged;
        
        /// <summary>
        /// Gets fired before the LDC property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCChanging;
        
        /// <summary>
        /// Gets fired when the LDC property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCChanged;
        
        /// <summary>
        /// Gets fired before the TmDlChr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmDlChrChanging;
        
        /// <summary>
        /// Gets fired when the TmDlChr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmDlChrChanged;
        
        /// <summary>
        /// Gets fired before the LDCZ property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCZChanging;
        
        /// <summary>
        /// Gets fired when the LDCZ property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LDCZChanged;
        
        /// <summary>
        /// Gets fired before the VRedVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRedValChanging;
        
        /// <summary>
        /// Gets fired when the VRedVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRedValChanged;
        
        /// <summary>
        /// Gets fired before the TapBlkR property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapBlkRChanging;
        
        /// <summary>
        /// Gets fired when the TapBlkR property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapBlkRChanged;
        
        /// <summary>
        /// Gets fired before the TapBlkL property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapBlkLChanging;
        
        /// <summary>
        /// Gets fired when the TapBlkL property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapBlkLChanged;
    }
}

