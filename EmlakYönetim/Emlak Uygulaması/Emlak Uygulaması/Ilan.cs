using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Uygulaması
{
    public partial class Ilan : UserControl
    {
        public Ilan()
        {
            InitializeComponent();
        }

        public static int S_Ilan_No { get; set; }

        private void Ilan_Load(object sender, EventArgs e)
        {
        }

        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            S_Ilan_No = Convert.ToInt32(btnDetaylar.Tag);
        }
    }
}
