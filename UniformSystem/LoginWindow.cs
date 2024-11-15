using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniformSystem
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "knoxOfficeStaff" &&  passwordInput.Text == "jbofficeknox2024")
            {

                string dir = "ProgramOutput/" + Program.todayYear + "/" + Program.todayMonth + "/" + Program.todayDay;
                if (Directory.Exists(dir))
                {
                    string[] files = Directory.GetFiles(dir);
                    string output = "Name,Has tie?,Has full uniform?";
                    foreach (string file in files)
                    {
                        output += File.ReadAllText(file);
                    }

                    File.WriteAllText("ProgramOutput/" + Program.today + ".csv", output);
                    Process.Start("explorer.exe", new FileInfo("ProgramOutput/").FullName);
                }
                else
                {
                    MessageBox.Show("No data has been entered yet.");
                }

            }
            else
            {
                MessageBox.Show("Incorrect login data");
            }

            
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
