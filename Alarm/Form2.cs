using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form2 : Form
    {
        public TimeSpan selectedDate;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(tbInput.Text, "HH:mm:ss", 
                System.Globalization.CultureInfo.InvariantCulture, 
                System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                this.selectedDate = parsedDate.TimeOfDay;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbWarning.ForeColor = Color.Red;
                tbInput.Clear();
            }
        }
    }
}
