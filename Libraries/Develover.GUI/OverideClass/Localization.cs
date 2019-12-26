using Develover.Utilities;
using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Develover.GUI.OverideClass
{
    public class Localization
    {
        public class DeveloverGridLocalizer : GridLocalizer
        {
            public DeveloverGridLocalizer()
            {
                Globalization();
            }
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FindControlFindButton:
                        return "Tìm";
                    case GridStringId.FindControlClearButton:
                        return "Bỏ";
                    case GridStringId.GridGroupPanelText:
                        return "Kéo thả cột vào đây để gom nhóm";
                    case GridStringId.MenuColumnSortAscending:
                        return "Sắp xếp tăng dần";
                    case GridStringId.MenuColumnSortDescending:
                        return "Sắp xếp giảm dần";
                    case GridStringId.MenuColumnClearSorting:
                        return "Bỏ sắp xếp";
                    case GridStringId.MenuColumnGroup:
                        return "Gom nhóm theo cột này";
                    case GridStringId.MenuGroupPanelShow:
                        return "Hiện hộp gom nhóm";
                    case GridStringId.MenuGroupPanelHide:
                        return "Ẩn hộp gom nhóm";
                    case GridStringId.MenuGroupPanelFullExpand:
                        return "Mở tất cả các nhóm";
                    case GridStringId.MenuGroupPanelFullCollapse:
                        return "Thu tất cả các nhóm";
                    case GridStringId.MenuColumnUnGroup:
                        return "Bỏ gom nhóm";
                    case GridStringId.MenuColumnRemoveColumn:
                        return "Ẩn cột này";
                    case GridStringId.MenuColumnShowColumn:
                        return "Hiện cột này";
                    case GridStringId.MenuColumnColumnCustomization:
                        return "Tùy chỉnh cột";
                    case GridStringId.CustomizationCaption:
                        return "Tùy chỉnh cột";
                    //case GridStringId.CustomizationColumns:
                    //    return "Kéo và thả cột vào đây để tùy chỉnh";
                    //case GridStringId.CustomizationBands:
                    //    return "Kéo và thả cột vào đây để tùy chỉnh";
                    //case GridStringId.CustomizationFormBandHint:
                    //    return "Kéo và thả cột vào đây để tùy chỉnh";
                    case GridStringId.CustomizationFormColumnHint:
                        return "Kéo và thả cột vào đây để tùy chỉnh";
                    case GridStringId.MenuColumnBestFit:
                        return "Căn chỉnh";
                    case GridStringId.MenuColumnBestFitAllColumns:
                        return "Căn chỉnh tất cả";
                    case GridStringId.MenuColumnFilterEditor:
                        return "Cài đặt lọc";
                    //case GridStringId.MenuColumnFilter:
                    //    return "menu filter";
                    case GridStringId.PopupFilterCustom:
                        return "(Tùy chọn:";
                    case GridStringId.PopupFilterAll:
                        return "(Tất cả:";
                    case GridStringId.FilterPanelCustomizeButton:
                        return "Sửa lọc";
                    case GridStringId.FilterBuilderCaption:
                        return "Cài đặt lọc";
                    case GridStringId.FilterBuilderOkButton:
                        return "Đồng ý";
                    case GridStringId.FilterBuilderApplyButton:
                        return "Áp dụng";
                    case GridStringId.FilterBuilderCancelButton:
                        return "Hủy bỏ";
                    case GridStringId.MenuColumnAutoFilterRowShow:
                        return "Hiện hàng lọc tự động";
                    case GridStringId.MenuColumnAutoFilterRowHide:
                        return "Ẩn hàng lọc tự động";
                    case GridStringId.MenuColumnFilterMode:
                        return "Chế độ lọc";
                    case GridStringId.MenuColumnFilterModeDisplayText:
                        return "Văn bản";
                    case GridStringId.MenuColumnFilterModeValue:
                        return "Giá trị";
                    case GridStringId.CustomFilterDialogCancelButton:
                        return "Hủy bỏ";
                    //case GridStringId.CustomFilterDialog2FieldCheck:
                    //    return "2FieldCheck";
                    case GridStringId.CustomFilterDialogCaption:
                        return "Hiển thị những hàng có:";
                    //case GridStringId.CustomFilterDialogClearFilter:
                    //    return "Clear";
                    case GridStringId.CustomFilterDialogEmptyOperator:
                        return "(Chọn phép toán:";
                    case GridStringId.CustomFilterDialogEmptyValue:
                        return "(Điền giá trị:";
                    case GridStringId.CustomFilterDialogFormCaption:
                        return "Tùy chọn lọc tự động";
                    //case GridStringId.CustomFilterDialogHint:
                    //    return "fil hint";
                    case GridStringId.CustomFilterDialogOkButton:
                        return "Đồng ý";
                    case GridStringId.CustomFilterDialogRadioAnd:
                        return "Và";
                    case GridStringId.CustomFilterDialogRadioOr:
                        return "Hoặc";        
                    default:
                        return base.GetLocalizedString(id);
                }
            }
            public void Globalization()
            { //    vi           Vietnamese                              vi-VN
                CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");

                Thread.CurrentThread.CurrentUICulture = culture;

                Thread.CurrentThread.CurrentCulture = culture;
                //.NET Framework 4.5 +
                //CultureInfo.DefaultThreadCurrentCulture = culture;
                //CultureInfo.DefaultThreadCurrentUICulture = culture;
            }

        }
    }
}
