using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Hunter_Rise___PR_Tracker
{
    public partial class NewRunForm : Form
    {
        public int Minutes { get { return (int)MinutesBox.Value; } }
        public int Seconds { get { return (int)SecondsBox.Value; } }
        public int Milliseconds { get { return (int)MillisecondsBox.Value; } }
        public Weapon weapon { get { return (Weapon)WeaponDropdown.SelectedIndex; } }
        public RunStyle rules { get { return (RunStyle)RulesDropDown.SelectedIndex; } }

        public NewRunForm()
        {
            InitializeComponent();

            string[] weaponArray = Enum.GetNames(typeof(Weapon));

            for (int i = 0; i < weaponArray.Length; i++)
            {
                WeaponDropdown.Items.Add(weaponArray[i].Replace("_", " "));
            }

            string[] styleArray = Enum.GetNames(typeof(RunStyle));

            foreach (string style in styleArray)
            {
                RulesDropDown.Items.Add(style);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (WeaponDropdown.SelectedIndex == -1 || RulesDropDown.SelectedIndex == -1 || (MinutesBox.Value == 0 && SecondsBox.Value == 0 && MillisecondsBox.Value == 0))
            {
                Warning form = new Warning();
                form.ShowDialog();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
