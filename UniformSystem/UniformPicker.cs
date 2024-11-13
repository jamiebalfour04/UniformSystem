namespace UniformSystem
{
    public partial class UniformPicker : Form
    {

        private HashSet<String> registrationClasses = new HashSet<String>();
        public static List<String> allPupils = new List<String>();

        public UniformPicker()
        {
            InitializeComponent();

            var fileStream = new System.IO.FileStream("allPupils.csv", System.IO.FileMode.Open, System.IO.FileAccess.Read);

            var file = new System.IO.StreamReader(fileStream, System.Text.Encoding.UTF8);

            String line = "";
            while((line == file.ReadLine()) != false)
            {
                line = line.Substring(0, line.Length - 1).Trim();
                string[] columns = line.Split(",");

                string regiClass = columns[2];

                registrationClasses.Add(regiClass);
                allPupils.Add(line);
            }


        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            ClassView c = new ClassView(comboBox1.Text);
            c.Visible = true;
        }
    }
}
