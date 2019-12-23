using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Develover.GUI.RepositoryItems
{
    public class DeveloverRepositoryItemTextEdit : RepositoryItemTextEdit
    {
        public DeveloverRepositoryItemTextEdit() : base()
        {

        }
        public void ToUpper()
        {
            CharacterCasing = CharacterCasing.Upper;
        }

    }
}
