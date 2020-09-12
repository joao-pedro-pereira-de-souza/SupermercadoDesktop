using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Diagnostics;
using LoginRicoy.Properties;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class FrmCadastrarProd : Form
    {

        #region Variáveis para verificar se foi adicionado uma parte do cadastro.


        private bool ImgAdd = false;
        private bool IdAdd = false;
        private bool NomeAdd = false;
        private bool StatusAdd = false;
        private bool QuantAdd = false;
        private bool ValorAdd = false;


        #endregion

        Color CorCode = ColorTranslator.FromHtml("#4b4b4b");

        public FrmCadastrarProd()
        {
            InitializeComponent();

            pnlContainer.Controls.Add(pnlpg2);

            pnlpg2.Top = 0;

            pnlpg2.Left = 450;
            pnlpg2.Visible = true;
        }

        #region Design Shadow

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;


                return cp;
            }
        }

        #endregion

       
        #region CadatroProd.

        private void AdicionarCadastro()
        {
            // Convert Image 
            MemoryStream ms = new MemoryStream();

            ptbImagem.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            //

            DataAcess.ControlDatabase bd = new DataAcess.ControlDatabase();
            //Insert values Class Produtos.
            DataAcess.Produtos prod = new DataAcess.Produtos()
            {
                Id = int.Parse(txtID.Text),
                Nome = txtNome.Text,
                Valor = txtValor.Text,
                Status = txtStatus.Text,
                //                DataValidade = dtpValidade.Value.ToShortDateString(),
                Quantidade = int.Parse(txtQuantidade.Text),

                img = output

            };
            //

            // insert Values
            bd.SetListProd("Produtos/" + txtID.Text, prod);

            MessageBox.Show("Produto :" + txtNome.Text + " foi cadastrado com sucesso");

            limparCaixas();
        }

        #endregion

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                AdicionarCadastro();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu algum erro no banco :\n" + ex.Message);
            }
          


        }

        public void limparCaixas()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtStatus.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";


            ptbImagem.Image = Resources.iconIllustraitorAddImage;
 //           dtpValidade.Value = DateTime.Now.Date;
        }
      

        private void ptbImagem_Click(object sender, EventArgs e)
        {
            #region Adiconar imagem no PintureBox.


            if(ImgAdd == false)
            {
                OpenFileDialog fileimage = new OpenFileDialog();

                fileimage.Title = "Selecione a Imagem";
                fileimage.Filter = "Imagem(*.jpg) | *.jpg";

                if (fileimage.ShowDialog() == DialogResult.OK)
                {
                    Image img = new Bitmap(fileimage.FileName);

                    ptbImagem.Image = img.GetThumbnailImage(350, 200, null, new IntPtr());

                    ImgAdd = true;
                    fvdProgress.Value += 16;
                    lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
                }


            }

           

            #endregion
        }

        #region Próximo - pg2

        private void btnProximaPg_Click(object sender, EventArgs e)
        {
            
            if(ImgAdd == true)
            {
                if (txtID.Text != "")
                {
                    if (txtNome.Text != "")
                    {
                        if (txtStatus.Text != "")
                        {
                            AnimaPg.Start();

                            try
                            {
                                GeradorCode.QRCode code = new GeradorCode.QRCode();

                                ptbCodeID.Image = code.GerarQRCode(txtID.Text , CorCode);

                            }
                            catch(Exception ex)
                            {
                                
                            }
                           

                        }
                        else
                        {
                            MessageBox.Show("vc precisa preencher os campo txtID");
                        }

                    }
                    else
                    {
                        MessageBox.Show("vc precisa preencher os campo txtID");
                    }
                }
                else
                {
                    MessageBox.Show("vc precisa preencher os campo txtID");
                }

            }
            else
            {
                MessageBox.Show("coloca a imagem do produto");
            }
           
        }
        #endregion

        #region Animações

        private void AnimaPg_Tick(object sender, EventArgs e)
        {
            pnlPg1.Left -= 10;
            pnlpg2.Left -= 10;

            if(pnlPg1.Left <= -450)
            {
               
                AnimaPg.Stop();
            }
        }

        private void AnimaVoltarPg_Tick(object sender, EventArgs e)
        {
            pnlPg1.Left += 10;
            pnlpg2.Left += 10;

            if (pnlpg2.Left >= 450)
            {
                
                AnimaVoltarPg.Stop();
            }
        }

        #endregion

        private void btnVoltarPg_Click(object sender, EventArgs e)
        {
            AnimaVoltarPg.Start();
        }


        #region Sistem add Progress TextBoxs


        #region Filtro no textBox Numeric
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }


        }


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        #endregion

        #region verificar andamento da caixa

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string texto = txtID.Text;

            AddProgressID(texto);

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            AddProgressNome(txtNome.Text);
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            AddProgressStatus(txtStatus.Text);
        }


        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            AddProgressQuant(txtQuantidade.Text);
        }



        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            AddProgressValor(txtValor.Text);
        }


        #endregion

        #region Tratamento de erro de progresso em cada caixa de texto.

        private void AddProgressID( string texto)
        {         
            
            if(texto.Length == 0)
            {
                if (fvdProgress.Value > 0)
                {
                    fvdProgress.Value -= 16;
                    IdAdd = false;
                }
            }
            else
            {
                if(IdAdd == false)
                {
                    fvdProgress.Value += 16;
                    IdAdd = true;
                }

            }

            lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
        }

        private void AddProgressNome(string texto)
        {

            if (texto.Length == 0)
            {
                if (fvdProgress.Value > 0)
                {
                    fvdProgress.Value -= 16;
                    NomeAdd = false;
                }
            }
            else
            {
                if (NomeAdd == false)
                {
                    fvdProgress.Value += 16;
                    NomeAdd = true;
                }

            }

            lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
        }


        private void AddProgressStatus(string texto)
        {

            if (texto.Length == 0)
            {
                if (fvdProgress.Value > 0)
                {
                    fvdProgress.Value -= 16;
                    StatusAdd = false;
                }
            }
            else
            {
                if (StatusAdd == false)
                {
                    fvdProgress.Value += 16;
                    StatusAdd = true;
                }

            }

            lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
        }

        private void AddProgressQuant(string texto)
        {

            if (texto.Length == 0)
            {
                if (fvdProgress.Value > 0)
                {
                    fvdProgress.Value -= 16;
                    QuantAdd = false;
                }
            }
            else
            {
                if (QuantAdd == false)
                {
                    fvdProgress.Value += 16;
                    QuantAdd = true;
                }

            }

            lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
        }

        private void AddProgressValor(string texto)
        {

            if (texto.Length == 0)
            {
                if (fvdProgress.Value > 0)
                {
                    fvdProgress.Value -= 16;
                    ValorAdd = false;
                }
            }
            else
            {
                if (ValorAdd == false)
                {
                    fvdProgress.Value += 16;
                    ValorAdd = true;
                }

            }

            lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
        }




        #endregion

        #endregion

        private void FrmCadastrarProd_Load(object sender, EventArgs e)
        {
            mcbCode.SelectedIndex = 0;
        }

        private void btnMinis_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Arrastar Form

        #region Importar Dll user32

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion


        #region Página 2

        private void mcbCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (mcbCode.SelectedIndex == 0)
                {

                    if (txtID.Text.Length > 0)
                    {
                        GeradorCode.QRCode code = new GeradorCode.QRCode();

                        ptbCodeID.Image = code.GerarQRCode(txtID.Text , CorCode);
                    }

                }
                if (mcbCode.SelectedIndex == 1)
                {

                    if (txtID.Text.Length > 0)
                    {
                        GeradorCode.BarCode code = new GeradorCode.BarCode();

                        ptbCodeID.Image = code.GerarBarCode(txtID.Text , CorCode);
                    }

                }
            }
            catch (Exception ex)
            {

            }
           
        }


        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnColorCode_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if(color.ShowDialog() == DialogResult.OK)
            {
                GeradorCode.QRCode code = new GeradorCode.QRCode();

                ptbCodeID.Image = code.GerarQRCode(txtID.Text, color.Color);
            }
        }

        private void btnSalvarCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();

            salvar.Filter = "PNG | *.png | JPEG | *.jpg | BMP | *.bmp";

            if(salvar.ShowDialog() == DialogResult.OK)
            {
                ptbCodeID.Image.Save(salvar.FileName);
            }
        }
    }
}
