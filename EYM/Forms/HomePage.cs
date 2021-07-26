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
    public partial class HomePage : DevExpress.XtraEditors.XtraForm
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eYMDataSet.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTableAdapter.Fill(this.eYMDataSet.Students);

        }
    }
}
