using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Threading;
using global::System.Windows.Forms;

namespace UniformSystem
{
    public partial class UniformPicker : Form
    {

      
        public UniformPicker()
        {
            InitializeComponent();

            var fileStream = new System.IO.FileStream("allPupils.csv", System.IO.FileMode.Open, System.IO.FileAccess.Read);

            var file = new System.IO.StreamReader(fileStream, System.Text.Encoding.UTF8);

            string fileStr = file.ReadToEnd();

            foreach (string line in fileStr.Split())
            {
                if (line != "")
                {
                    String linex = line.Substring(0, line.Length - 1).Trim();
                    string[] columns = linex.Split(',');

                    string regiClass = columns[2];

                    if (Program.registrationClasses.ContainsKey(regiClass) == false)
                    {
                        Program.registrationClasses.Add(regiClass, new List<string>());
                    }

                    Program.registrationClasses[regiClass].Add(linex);
                }

            }

            List<string> keys = new List<string>();

            foreach(string k in Program.registrationClasses.Keys)
            {
                keys.Add(k);
                Program.registrationClasses[k].Sort();
            }

            keys.Sort();

            foreach (string k in keys)
            {
                comboBox1.Items.Add(k);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            ClassView c = new ClassView(comboBox1.Text);
            c.Visible = true;
            this.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginWindow l = new LoginWindow();
            l.Visible = true;
        }

        private void UniformPicker_Load(object sender, EventArgs e)
        {

        }
    }
}
