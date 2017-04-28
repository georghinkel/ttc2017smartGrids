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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.Customers
{
    
    
    public class CustomerKindConverter : System.ComponentModel.TypeConverter
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
                return default(CustomerKind);
            }
            string valueString = value.ToString();
            if ((valueString == "residential"))
            {
                return CustomerKind.Residential;
            }
            if ((valueString == "internalUse"))
            {
                return CustomerKind.InternalUse;
            }
            if ((valueString == "windMachine"))
            {
                return CustomerKind.WindMachine;
            }
            if ((valueString == "commercialIndustrial"))
            {
                return CustomerKind.CommercialIndustrial;
            }
            if ((valueString == "energyServiceScheduler"))
            {
                return CustomerKind.EnergyServiceScheduler;
            }
            if ((valueString == "residentialStreetlightOthers"))
            {
                return CustomerKind.ResidentialStreetlightOthers;
            }
            if ((valueString == "energyServiceSupplier"))
            {
                return CustomerKind.EnergyServiceSupplier;
            }
            if ((valueString == "residentialAndStreetlight"))
            {
                return CustomerKind.ResidentialAndStreetlight;
            }
            if ((valueString == "residentialFarmService"))
            {
                return CustomerKind.ResidentialFarmService;
            }
            if ((valueString == "pumpingLoad"))
            {
                return CustomerKind.PumpingLoad;
            }
            if ((valueString == "residentialAndCommercial"))
            {
                return CustomerKind.ResidentialAndCommercial;
            }
            if ((valueString == "other"))
            {
                return CustomerKind.Other;
            }
            return default(CustomerKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            CustomerKind valueCasted = ((CustomerKind)(value));
            if ((valueCasted == CustomerKind.Residential))
            {
                return "residential";
            }
            if ((valueCasted == CustomerKind.InternalUse))
            {
                return "internalUse";
            }
            if ((valueCasted == CustomerKind.WindMachine))
            {
                return "windMachine";
            }
            if ((valueCasted == CustomerKind.CommercialIndustrial))
            {
                return "commercialIndustrial";
            }
            if ((valueCasted == CustomerKind.EnergyServiceScheduler))
            {
                return "energyServiceScheduler";
            }
            if ((valueCasted == CustomerKind.ResidentialStreetlightOthers))
            {
                return "residentialStreetlightOthers";
            }
            if ((valueCasted == CustomerKind.EnergyServiceSupplier))
            {
                return "energyServiceSupplier";
            }
            if ((valueCasted == CustomerKind.ResidentialAndStreetlight))
            {
                return "residentialAndStreetlight";
            }
            if ((valueCasted == CustomerKind.ResidentialFarmService))
            {
                return "residentialFarmService";
            }
            if ((valueCasted == CustomerKind.PumpingLoad))
            {
                return "pumpingLoad";
            }
            if ((valueCasted == CustomerKind.ResidentialAndCommercial))
            {
                return "residentialAndCommercial";
            }
            if ((valueCasted == CustomerKind.Other))
            {
                return "other";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
