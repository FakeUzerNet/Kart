using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    public partial class CheckRacer : Form
    {
        public CheckRacer()
        {
            InitializeComponent();
        }

        private void CheckRacer_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(645, 375);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
