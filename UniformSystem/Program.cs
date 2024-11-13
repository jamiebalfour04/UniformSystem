using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UniformSystem
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UniformPicker());
        }

        public static Dictionary<string, List<string>> registrationClasses = new Dictionary<string, List<string>>();
        public static string todayDay = DateTime.Now.ToString("dd");
        public static string todayMonth = DateTime.Now.ToString("MM");
        public static string todayYear = DateTime.Now.ToString("yyyy");
        public static string today = DateTime.Now.ToString("yyyy-MM-dd");
    }
}