using System.ComponentModel;

namespace Develover
{
    public interface IDeveloverControl : IDeveloverComponent
    {
        [Browsable(true)]
        string FieldBinding { get; set; }
        [Browsable(true)]
        Enum.EnumTypeColumns TypeFieldColumns { get; set; }
        [Browsable(true)]
        bool IsGUID { get; set; }

    }
}
