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
            Program.registrationClasses[registrationClass].Sort();
            foreach (Pupil pup in Program.registrationClasses[registrationClass])
            {
                PupilDetail p = new PupilDetail(pup.getForename() + " " + pup.getSurname(), registrationClass);
                this.flowLayoutPanel1.Controls.Add(p);
                //p.Location = new Point(0, i * 50);
                //p.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                //p.Width = panel1.Width;
                //p.Height = 40;
                if(i % 2 == 0)
                {
                    p.BackColor = Color.LightGray; 
                }
                i++;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {


            string csvOutput = "";
            foreach(Control c in flowLayoutPanel1.Controls)
            {
                PupilDetail p = (PupilDetail) c;
                if (p.needsRecorded())
                {
                    csvOutput += p.csvOutput() + "\n";
                }
                
            }

            Directory.CreateDirectory("ProgramOutput/" + Program.todayYear + "/" + Program.todayMonth + "/" + Program.todayDay + "/");
            try
            {
                File.WriteAllText("ProgramOutput/" + Program.todayYear + "/" + Program.todayMonth + "/" + Program.todayDay + "/" + registrationClass + ".csv", csvOutput);
                MessageBox.Show("Data saved.");

                this.Close();
                Application.Exit();
            } catch(IOException ex)
            {
                MessageBox.Show("The data could not be saved right now (someone could be accessing it right now). Please try again in a few seconds.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void ClassView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClassView_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.Width = flowLayoutPanel1.Width;
            }
        }
    }
}
