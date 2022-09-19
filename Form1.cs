using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResultApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Odaberite Yes / No / Cancel", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            switch (rez)

            {

                case DialogResult.Yes:

                    txtRezultat.Text = "Izabrali ste dugme YES";

                    break;

                case DialogResult.No:

                    txtRezultat.Text = "Izabrali ste dugme NO";

                    break;

                case DialogResult.Cancel:

                    txtRezultat.Text = "Izabrali ste dugme Cancel";

                    break;

            }
        }
    }
}
