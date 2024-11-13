using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniformSystem
{
    public partial class PupilDetail : UserControl
    {
        public PupilDetail(string name, string registrationClass)
        {
            InitializeComponent();
            this.nameLabel.Text = name;
            this.registrationClass = registrationClass;
        }

        private bool noTie = false;
        private bool noUniform = false;
        private string registrationClass;

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

            return this.nameLabel.Text + ", " + tieString + ", " + uniformString + "," + registrationClass;
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
