using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class FrmHome : Form
    {
        
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

        public FrmHome()
        {
            InitializeComponent();
   
        }

        #region Insert values
        /*
        List<string> Nomes = new List<string>()
        { "Uva", "Manga", "Morango", "Banana", "Laranja", "Pêra", "Abacaxi" ,"Abacate", "Acerola",
            "Amora", "Araticum", "Bacaba", "Biribá" ,"Cacau","Cajá","Caqui","Carambola","Cereja",
            "Cidra","Coco","Cupuaçu","Figo","Framboesa","Goiaba","Groselha","Ingá","Jabuticaba","Jaca","Jambo","Jenipapo","Kiwi","Limão" ,"Maçã"};


        List<string> Validade2 = new List<string>()
        { "29/07/2020", "17/07/2020", "19/07/2020", "27/07/2020", "23/07/2020", "10/09/2020", "11/07/2020" ,"29/08/2020", "03/07/2020",
            "07/07/2020", "19/07/2020", "19/08/2020", "16/08/2020" ,"18/08/2020","20/08/2020","12/08/2020","28/08/2020","01/08/2020",
            "05/08/2020","19/08/2020","18/08/2020","22/08/2020","29/09/2020","10/09/2020","27/09/2020","12/09/2020","02/09/2020","09/09/2020","20/09/2020","10/10/2020","28/10/2020","20/10/2020" ,"13/10/2020"};


             List<string> preco = new List<string>()
        { "3,80", "6,30", "9,00" , "2,80", "7,00", "7,00", "9,30" ,"4,90", "5,00" ,
            "4,80", "5,00", "8,10", "5,00" ,"4,90","3,90","5,20","5,20","10,00",
            "9,00","2,00","3,90","11,0","12,00","2,80","5,30","4,80","9,90","11,20","10,00","8,30","6,90","7,80" ,"7,00"};
            */

        #endregion

        private void FrmHome_Load(object sender, EventArgs e)
        {
            #region insert values Firebase
            /*
            for (int i = 0; i < Nomes.Count; i++)
            {

                Produtos prod = new Produtos
                {
                    Id = i,
                    Nome = Nomes[i],
                    DataValidade = Validade2[i],
                    Valor = preco[i],
                    Quantidade = 100 + i
                };
                connect con2 = new connect();

                SetResponse result2 = con2.client.Set("Produtos/" + i, prod);


            }
           
    */

            #endregion

            // Adicionando o form pai na variável.
            ControlStaticFrm.home = this;
           
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        #region Abrir um formulário dentro do Painel Container.

        private Form staticForm = null;

        public void containerAddForm(Form SelectForm)
        {

            if(staticForm != null)
            {
                staticForm.Close();
            }

            // Guardar o form atual .
            staticForm = SelectForm;

            SelectForm.TopLevel = false;

            pnlContainer.Controls.Add(SelectForm);

            SelectForm.Dock = DockStyle.Top;

            pnlContainer.Tag = SelectForm;

            SelectForm.Show();

        }

        #endregion

        #region Design Arrows

        public void addArrowMenu(int x , int y)
        {
            ptbArrows.Visible = true;

            ptbArrows.Location = new Point(x,y);

            ptbArrows.BackColor = Color.Transparent;

            if(pnlAvisoHome.Visible == true)
            {
                pnlAvisoHome.Visible = false;
            }
        }
        #endregion

       

        private void btnControles_Click(object sender, EventArgs e)
        {
            FrmCadastrarProd cad = new FrmCadastrarProd();

            cad.ShowDialog();
        }

      

        private void btnCart_Click(object sender, EventArgs e)
        {
            FrmListProd list = new FrmListProd();

            list.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addArrowMenu(194, btnHome.Location.Y + 10);

            containerAddForm(new UisSubFrm.FrmSubHome());
        }

        private void btnChat_Click_1(object sender, EventArgs e)
        {
            addArrowMenu(194, btnChat.Location.Y + 10);

            containerAddForm(new UisSubFrm.FrmSubChat());
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
