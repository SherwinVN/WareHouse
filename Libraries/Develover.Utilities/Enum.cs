using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Utilities
{
    public class Enum
    {
        public enum EnumPermission { View, New, Edit, Delete, Print, Denial }
        public enum TypeLicenses { None,Free, Persional,Company}
        public enum EnumTypeFooterColumnGridView { Sum,Count,Average }
        public enum EnumTypeColumns { Date,Time,Check,Text,Number,Combobox,Gridlookup}

        public static EnumTypeColumns GetTypeColumn(string StrTypeData)
        {
            EnumTypeColumns enumTypeColumns = new EnumTypeColumns();
            switch (StrTypeData)
            {
                case "Number":
                    enumTypeColumns = EnumTypeColumns.Number;
                    break;

                case "Check":
                    enumTypeColumns = EnumTypeColumns.Check;
                    break;
                case "Combobox":
                    enumTypeColumns = EnumTypeColumns.Combobox;
                    break;
                case "Date":
                    enumTypeColumns = EnumTypeColumns.Date;
                    break;
                case "Gridlookup":
                    enumTypeColumns = EnumTypeColumns.Gridlookup;
                    break;
                case "Text":
                    enumTypeColumns = EnumTypeColumns.Text;
                    break;
                case "Time":
                    enumTypeColumns = EnumTypeColumns.Time;
                    break;
            }
            return enumTypeColumns;
        }

    }
}
