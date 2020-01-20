using DevExpress.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover
{
    public class Enum
    {
        public enum EnumPermission { View, New, Edit, Delete, Print, Denial }
        public enum TypeLicenses { None, Free, Persional, Company }
        public enum EnumTypeFooterColumnGridView { Sum, Count, Average }
        public enum EnumTypeColumns { Date, Time, Check, Text, Number, Combobox, Gridlookup }
        public enum SumaryType { Sum, Min, Max, Count, Average, Custom, None }

        public EnumTypeColumns GetTypeColumn(string StrTypeData)
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

        public string GetValueControlFormatByTypeColumns(EnumTypeColumns enumTypeColumns, Control control)
        {

            switch (enumTypeColumns)
            {
                case EnumTypeColumns.Number:
                    return String.Format("#,###.##", control.Text);
                case EnumTypeColumns.Check:
                    return String.Format("#,###.##", control.Text);
                case EnumTypeColumns.Combobox:
                    return String.Format("#,###.##", control.Text);
                case EnumTypeColumns.Date:
                    return String.Format("#,###.##", control.Text);
                case EnumTypeColumns.Gridlookup:
                    return String.Format("#,###.##", control.Text);
                case EnumTypeColumns.Text:
                    return String.Format("#,###.##", control.Text);
                case EnumTypeColumns.Time:
                    return String.Format("#,###.##", control.Text);
                default:
                    return "";
            }
        }

        public SumaryType GetSumaryType(string StrSumaryType)
        {
            SumaryType SumaryType = new SumaryType();
            SumaryType = SumaryType.None;
            switch (StrSumaryType)
            {
                case "Sum":
                    SumaryType = SumaryType.Sum;
                    break;
                case "Min":
                    SumaryType = SumaryType.Min;
                    break;
                case "Max":
                    SumaryType = SumaryType.Max;
                    break;
                case "Count":
                    SumaryType = SumaryType.Count;
                    break;
                case "Average":
                    SumaryType = SumaryType.Average;
                    break;
                case "Custom":
                    SumaryType = SumaryType.Custom;
                    break;
                case "None":
                    SumaryType = SumaryType.None;
                    break;
            }
            return SumaryType;
        }

        public SummaryItemType GetSummaryItemType(SumaryType sumaryType)
        {
            SummaryItemType summaryItemType = new SummaryItemType();
            switch (sumaryType)
            {
                case SumaryType.Sum:
                    summaryItemType = SummaryItemType.Sum;
                    break;

                case SumaryType.Min:
                    summaryItemType = SummaryItemType.Min;
                    break;
                case SumaryType.Max:
                    summaryItemType = SummaryItemType.Max;
                    break;
                case SumaryType.Count:
                    summaryItemType = SummaryItemType.Count;
                    break;
                case SumaryType.Average:
                    summaryItemType = SummaryItemType.Average;
                    break;
                case SumaryType.Custom:
                    summaryItemType = SummaryItemType.Custom;
                    break;
                case SumaryType.None:
                    summaryItemType = SummaryItemType.None;
                    break;
            }
            return summaryItemType;
        }
    }
}
