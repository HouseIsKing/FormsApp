using ElectionSystem2._0.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionSystem2._0
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LaunchBTN_Click(object sender, EventArgs e)
        {
            if (voterRDB.Checked)
            {
                this.Hide();
                var voterWindow = new VoterView();
                voterWindow.Closed += (s, args) => this.Close();
                voterWindow.Show();
            }
            if (userRDB.Checked)
            {
                this.Hide();
                var voterWindow = new UsherView();
                voterWindow.Closed += (s, args) => this.Close();
                voterWindow.Show();
            }

            if (electionCommitteeRDB.Checked)
            {
                this.Hide();
                var voterWindow = new ElectionCommitteeView();
                voterWindow.Closed += (s, args) => this.Close();
                voterWindow.Show();
            }
            if (ballotCommitteeRDB.Checked)
            {
                this.Hide();
                var voterWindow = new BallotCommitteeView();
                voterWindow.Closed += (s, args) => this.Close();
                voterWindow.Show();
            }
        }
    }
}
