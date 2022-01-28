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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(645, 375);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Info_Closed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form kartSkills = new KartSkills();
            kartSkills.Show();
            this.Hide();
        }
    }
}
