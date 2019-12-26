using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Develover.Utilities.Enum;

namespace Develover.Utilities
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
            public EnumTypeColumns TypeColumn;
            public SumaryType SumaryType;
            public string StringFormat;

            public string ChildModel;
            public string SQLData;
            public string KeyMember;
            public string DisplayMember;
            public string ValueMember;
            public string NullText;
            public List<TypeColumns> TypeColumnGridLookup;
        }
    }
}
