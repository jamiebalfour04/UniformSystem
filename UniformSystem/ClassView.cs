using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace UniformSystem
{
    public partial class ClassView : Form
    {

        private string registrationClass = "";

        public ClassView(string registrationClass)
        {
            InitializeComponent();
            this.registrationClass = registrationClass;
        }

        private void ClassView_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string item in Program.registrationClasses[registrationClass])
            {
                string[] details = item.Split(',');
                PupilDetail p = new PupilDetail(details[0] + " " + details[1], registrationClass);
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

            Directory.CreateDirectory("ProgramOutput/" + Program.todayYear + "/" + Program.todayMonth + "/" + Program.todayDay + "/");

            File.WriteAllText("ProgramOutput/" + Program.todayYear + "/" + Program.todayMonth + "/" + Program.todayDay + "/" + registrationClass + ".csv", csvOutput);

            MessageBox.Show("Data saved.");

            this.Close();
        }
    }
}
