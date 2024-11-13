using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniformSystem
{
    public partial class PupilDetail : UserControl
    {
        public PupilDetail(String name)
        {
            InitializeComponent();
            this.nameLabel.Text = name;
        }

        private bool noTie = false;
        private bool noUniform = false;


        public void setName(string n)
        {
            this.nameLabel.Text = n;
        }

        public string getName()
        {
            return this.nameLabel.Text;
        }

        private void btnNoTie_Click(object sender, EventArgs e)
        {
            noTie = !noTie;

            if (noTie)
            {
                btnNoTie.BackColor = Color.Red;
            }
            else
            {
                btnNoTie.BackColor = Color.Transparent;
            }
        }

        public bool needsRecorded()
        {
            return noTie || noUniform;
        }

        public String csvOutput()
        {

            String tieString = "Yes";
            if (noTie)
            {
                tieString = "No";
            }

            String uniformString = "Yes";
            if (noUniform)
            {
                uniformString = "No";
            }

            return this.nameLabel.Text + ", " + tieString + ", " + uniformString;
        }

        private void btnNoUniform_Click(object sender, EventArgs e)
        {
            noUniform = !noUniform;

            if (noUniform)
            {
                btnNoUniform.BackColor = Color.Red;
            }
            else
            {
                btnNoUniform.BackColor = Color.Transparent;
            }
        }
    }
}
