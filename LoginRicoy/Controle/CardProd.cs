using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle
{
    public partial class CardProd : UserControl
    {

        
        public int quantProd;

        private int quantSelect = 0;

        public CardProd()
        {
            InitializeComponent();

           
        }

        private void btnQuantMais_Click(object sender, EventArgs e)
        {
            quantSelect++;

            if(quantSelect < quantProd)
            {
                txtQuant.Text = quantSelect.ToString();
            }
       
            else if(quantSelect == quantProd)
            {
                txtQuant.Text = quantSelect.ToString();

                MessageBox.Show("Você atingio o máximo de produto");
            }

            if(quantSelect > quantProd)
            {
                quantSelect--;
            }

        }

        private void btnQuantMenos_Click(object sender, EventArgs e)
        {
            if(quantSelect > 0)
            {
                quantSelect--;

                txtQuant.Text = quantSelect.ToString();
            }

        }
    }
}
