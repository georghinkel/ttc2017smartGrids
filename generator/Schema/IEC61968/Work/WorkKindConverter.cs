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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61968.Work
{
    
    
    public class WorkKindConverter : System.ComponentModel.TypeConverter
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
                return default(WorkKind);
            }
            string valueString = value.ToString();
            if ((valueString == "maintenance"))
            {
                return WorkKind.Maintenance;
            }
            if ((valueString == "inspection"))
            {
                return WorkKind.Inspection;
            }
            if ((valueString == "other"))
            {
                return WorkKind.Other;
            }
            if ((valueString == "construction"))
            {
                return WorkKind.Construction;
            }
            if ((valueString == "service"))
            {
                return WorkKind.Service;
            }
            if ((valueString == "meter"))
            {
                return WorkKind.Meter;
            }
            if ((valueString == "reconnect"))
            {
                return WorkKind.Reconnect;
            }
            if ((valueString == "disconnect"))
            {
                return WorkKind.Disconnect;
            }
            return default(WorkKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            WorkKind valueCasted = ((WorkKind)(value));
            if ((valueCasted == WorkKind.Maintenance))
            {
                return "maintenance";
            }
            if ((valueCasted == WorkKind.Inspection))
            {
                return "inspection";
            }
            if ((valueCasted == WorkKind.Other))
            {
                return "other";
            }
            if ((valueCasted == WorkKind.Construction))
            {
                return "construction";
            }
            if ((valueCasted == WorkKind.Service))
            {
                return "service";
            }
            if ((valueCasted == WorkKind.Meter))
            {
                return "meter";
            }
            if ((valueCasted == WorkKind.Reconnect))
            {
                return "reconnect";
            }
            if ((valueCasted == WorkKind.Disconnect))
            {
                return "disconnect";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
