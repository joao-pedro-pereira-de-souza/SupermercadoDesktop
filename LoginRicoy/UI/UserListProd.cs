using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
namespace UI
{
    public partial class UserListProd : UserControl
    {
        public int NumericProd;
        public UserListProd()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DadosCartUser.userCard.Remove(NumericProd);
            this.Hide();
        }
    }
}
