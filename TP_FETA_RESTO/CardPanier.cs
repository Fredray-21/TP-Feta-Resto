using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FETA_RESTO
{
    public partial class CardPanier : Form
    {
        public CardPanier()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int IdFormule = Convert.ToInt32(lblNOFORMULE.Text.Split("°")[1]);
            MessageBox.Show(IdFormule.ToString());
        }
    }
}
