using System.ComponentModel;
using static Develover.Utilities.Enum;

namespace Develover.GUI
{
    public interface IDeveloverControl : IDeveloverComponent
    {
        [Browsable(true)]
        string FieldBinding { get; set; }
        [Browsable(true)]
        EnumTypeColumns TypeFieldColumns { get; set; }
        [Browsable(true)]
        bool IsGUID { get; set; }

    }
}
