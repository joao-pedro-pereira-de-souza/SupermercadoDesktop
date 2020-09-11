using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;

namespace UI
{
    public partial class FrmListProd : Form
    {
        int topCard = 0;

        public FrmListProd()
        {
            InitializeComponent();
        }

        private void FrmListProd_Load(object sender, EventArgs e)
        {
            for(int i=0;i < DadosCartUser.userCard.Count;i++)
            {
                UserListProd prods = new UserListProd();

                prods.lblNome.Text = DadosCartUser.userCard[i].nomeProd;

                prods.ptbProd.Image = DadosCartUser.userCard[i].Produto;

                pnlContainer.Controls.Add(prods);

                prods.Top = topCard;

                topCard += (prods.Height + 5);

                pnlContainer.Tag = prods;

                prods.Show();


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
