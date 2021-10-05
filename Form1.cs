using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class FormRekenmachine : Form
    {
        Rekenen rekenen = new Rekenen();

        public FormRekenmachine()
        {
            InitializeComponent();
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            rekenen.X = double.Parse(tbX.Text);
        }
        private void tbY_TextChanged(object sender, EventArgs e)
        {
            rekenen.Y = double.Parse(tbY.Text);
        }

        private void btOptellen_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Optellen().ToString();
        }
        private void btAftrekken_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Aftrekken().ToString();
        }
        private void btVermenigvuldiging_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Vermenigvuldigen().ToString();
        }
        private void btDelen_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Delen().ToString();
        }
        private void btMachtsverheffing_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Machtsverheffing().ToString();
        }
        private void btKwadraat_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Kwadraat().ToString();
        }
        private void btVierkantswortel_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Vierkantswortel().ToString();
        }
        private void btWorteltrekking_Click(object sender, EventArgs e)
        {
            tbResult.Text = rekenen.Worteltrekking().ToString();
        }

        private void FormRekenmachine_Load(object sender, EventArgs e)
        {

        }
    }
}
