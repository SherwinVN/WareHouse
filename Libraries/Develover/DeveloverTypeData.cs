using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover
{
    public class DelTypeData
    {
        public class TypeColumns
        {
            public string Caption;
            public string Name;
            public string FieldName;
            public bool Visible;
            public bool AllowFocus;
            public bool AllowEdit;
            public int Width;
            public int Index;
            public Enum.EnumTypeColumns TypeColumn;
            public Enum.SumaryType SumaryType;
            public string StringFormat;

            public string ChildModel;
            public string SQLData;
            public string KeyMember;
            public string DisplayMember;
            public string ValueMember;
            public string NullText;
            public string Model;
        }
    }
}
