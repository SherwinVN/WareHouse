using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverTabNavigationPage : TabNavigationPage, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }
    }
}
