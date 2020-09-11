using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CardProd : UserControl
    {

        
        public int quantProd;

        private int quantSelect = 0;

        public string valorProd;

        public CardProd()
        {
            InitializeComponent();

           
        }

       

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            try
            {

                int quantprod = int.Parse(txtQuant.Text);

                if(quantprod > 0)
                {
                    Controle.ProdutosCart Produtos = new Controle.ProdutosCart()
                    {
                        nomeProd = lblNome.Text,
                        quantidade = int.Parse(txtQuant.Text),
                        Valor = lblValor.Text,
                        Produto = ptbProduto.Image
                        
                    };

                    int numeric = Controle.DadosCartUser.numercID;

                    Controle.DadosCartUser.userCard.Add(numeric, Produtos);

                    numeric = numeric + 1;

                    ControlStaticFrm.home.lblQuantCart.Text = numeric.ToString();

                    ControlStaticFrm.home.lblQuantCart.Visible = true;

                    Controle.DadosCartUser.numercID++;

                    MessageBox.Show("Produto adicionado no carrinho");
                }
                else
                {
                    MessageBox.Show("selecione pelo menos um produto");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro :\n" + ex.Message);
            }
           

        }

        private void btnmenosprod_Click(object sender, EventArgs e)
        {
            if (quantSelect > 0)
            {
                quantSelect--;

                txtQuant.Text = quantSelect.ToString();
            }

        }

        private void btnAdicionarProd_Click(object sender, EventArgs e)
        {
            if (quantSelect < quantProd)
            {
                quantSelect++;
                txtQuant.Text = quantSelect.ToString();
            }

            else if (quantSelect == quantProd)
            {
                txtQuant.Text = quantSelect.ToString();

                MessageBox.Show("Você atingio o máximo de produto");
            }

            if (quantSelect > quantProd)
            {
                quantSelect--;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
