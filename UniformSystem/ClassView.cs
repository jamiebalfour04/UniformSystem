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
    public partial class ClassView : Form
    {

        private List<string> pupils = new List<string>();
        private string registrationClass = "";

        public ClassView(string registrationClass)
        {
            InitializeComponent();
            pupils.Add("Kameron Kent Holmes");
            pupils.Add("Ava Morgan");
            this.registrationClass = registrationClass;
        }

        private void ClassView_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string item in pupils)
            {
                PupilDetail p = new PupilDetail(item);
                this.panel1.Controls.Add(p);
                p.Location = new Point(0, i * 50);
                p.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                p.Width = panel1.Width;
                i++;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string csvOutput = "";
            foreach(Control c in panel1.Controls)
            {
                PupilDetail p = (PupilDetail) c;
                if (p.needsRecorded())
                {
                    csvOutput += p.csvOutput() + "\n";
                }
                
            }

            MessageBox.Show(csvOutput);
        }
    }
}
