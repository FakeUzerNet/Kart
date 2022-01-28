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
    public partial class KartSkills : Form
    {
        public KartSkills()
        {
            InitializeComponent();
        }

        private void KartSkils_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(645, 375);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RegistrationRacer_Click(object sender, EventArgs e)
        {
            Form registrationRacer = new RegistrationRace();
            registrationRacer.Show();
            this.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Form info = new Info();
            info.Show();
            this.Hide();
        }

        private void KartSkills_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            Form authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }
    }
}
