using static Develover.Utilities.Enum;

namespace Develover.GUI
{
    public interface IDeveloverControl : IDeveloverComponent
    {
        string FieldBinding { get; set; }
        EnumTypeColumns TypeFieldColumns { get; set; }

    }
}
