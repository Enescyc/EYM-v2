using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYM.Forms
{
    public partial class students : DevExpress.XtraEditors.XtraForm
    {
        public students()
        {
            InitializeComponent();
        }

      

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }
    }
}
