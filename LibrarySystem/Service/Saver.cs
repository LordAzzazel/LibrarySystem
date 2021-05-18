using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Service
{
    public static class Saver
    {
        public static string Role { get; set; }

        public static string Status { get; set; }

        public static string Query { get; set; }

        public static string FormName { get; set; }
        
        public static string FormFunctionName { get; set; }

        public static List<string> Values { get; set; }

        public static Form MainForm { get; set; }

        public static Form TableShower { get; set; }

        public static bool StateStop { get; set; } = false;

        public static void FormDisabler()
        {
            MainForm.Enabled = false;
            TableShower.Enabled = false;
        }
        public static void FormEnabler()
        {
            MainForm.Enabled = true;
            TableShower.Enabled = true;
            Values.Clear();
        }

        public static bool ComboboxChecker(ComboBox cb)
        {
            if (cb.Items.Contains(cb.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
