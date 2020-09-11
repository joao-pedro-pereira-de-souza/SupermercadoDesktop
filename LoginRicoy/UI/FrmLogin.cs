using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Transparent Object PtbBox

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(100,180);

            pictureBox2.BackColor = Color.Transparent;

            pictureBox2.BringToFront();

            //btnSair
            pictureBox1.Controls.Add(btnSair);

            btnSair.Location = new Point(390, 0);

            btnSair.BackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSair.BringToFront();
            //

            //lblDescrição
            pictureBox1.Controls.Add(lblEscricao);

            lblEscricao.Location = new Point(50, 120);

            lblEscricao.BackColor = Color.Transparent;
           
            lblEscricao.BringToFront();
            //


            pictureBox1.Controls.Add(btnCreditos);

            btnCreditos.Location = new Point(390, 450);

            btnCreditos.BackColor = Color.Transparent;
            btnCreditos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCreditos.BringToFront();

            pictureBox1.Controls.Add(lblEscricao);

            lblEscricao.Location = new Point(50, 120);

            lblEscricao.BackColor = Color.Transparent;

            lblEscricao.BringToFront();

            #endregion

            //Animação Slide Form

            Location = new Point(Location.X + 250, Location.Y);

            Animation.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreditos_MouseHover(object sender, EventArgs e)
        {
            ToolTip Informat = new ToolTip();

            Informat.IsBalloon = true;

            Informat.SetToolTip(this.btnCreditos, "Créditos icones \n https://undraw.co/search");
        }



        private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCadastrar_MouseHover(object sender, EventArgs e)
        {
            btnCadastrar.Image = LoginRicoy.Properties.Resources.IconeCadastrarShow2;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.Image = LoginRicoy.Properties.Resources.IconeCadastrarLeaver2;
        }

        int quantAnim = 250;

        private void Animation_Tick(object sender, EventArgs e)
        {
            // Splash
            quantAnim -= 10;

            Location = new Point(Location.X - 10, Location.Y);

            Opacity += 0.008;

            if (quantAnim == 0)
            {
                Opacity = 100;

                Animation.Stop();
            }
            //
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarProd prod = new FrmCadastrarProd();

            prod.ShowDialog();
        }

        Thread t1;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Close();
            t1 = new Thread(abrirJanela);
          
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void abrirJanela(object obj)
        {

            Application.Run(new FrmHome());
            
        }
    }
}
