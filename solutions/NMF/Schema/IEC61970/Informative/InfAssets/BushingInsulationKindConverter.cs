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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    public class BushingInsulationKindConverter : System.ComponentModel.TypeConverter
    {
        
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
        {
            return (sourceType == typeof(string));
        }
        
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
        {
            return (destinationType == typeof(string));
        }
        
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if ((value == null))
            {
                return default(BushingInsulationKind);
            }
            string valueString = value.ToString();
            if ((valueString == "other"))
            {
                return BushingInsulationKind.Other;
            }
            if ((valueString == "paperoil"))
            {
                return BushingInsulationKind.Paperoil;
            }
            if ((valueString == "solidPorcelain"))
            {
                return BushingInsulationKind.SolidPorcelain;
            }
            if ((valueString == "compound"))
            {
                return BushingInsulationKind.Compound;
            }
            return default(BushingInsulationKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            BushingInsulationKind valueCasted = ((BushingInsulationKind)(value));
            if ((valueCasted == BushingInsulationKind.Other))
            {
                return "other";
            }
            if ((valueCasted == BushingInsulationKind.Paperoil))
            {
                return "paperoil";
            }
            if ((valueCasted == BushingInsulationKind.SolidPorcelain))
            {
                return "solidPorcelain";
            }
            if ((valueCasted == BushingInsulationKind.Compound))
            {
                return "compound";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
