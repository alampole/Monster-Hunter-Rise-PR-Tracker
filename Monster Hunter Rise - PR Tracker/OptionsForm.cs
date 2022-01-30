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
    public partial class OptionsForm : Form
    {
        List<string> m_Filters = new List<string>();

        public List<string> Filters { get { return m_Filters; } }

        public OptionsForm()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if(((CheckBox)c).Name != "Village")
                        ((CheckBox)c).CheckedChanged += new EventHandler(VillageCheckbox_CheckedChanged);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VillageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!m_Filters.Contains(((CheckBox)sender).Name))
            {
                m_Filters.Add(((CheckBox)sender).Name);
            }
            else
            {
                m_Filters.Remove(((CheckBox)sender).Name);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }

            m_Filters.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
