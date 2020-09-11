using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace FerramentasMod
{
    public class TextBoxMod:TextBox
    {
        // Fonte : https://www.youtube.com/watch?v=JuiZG4nKz2A.

        // Variáveis 

        private string marca_Da_aguaText;

        private bool multiline = false;

        private Color colormasca = Color.Gray;

        private Color colordig = Color.Black;

        public TextBoxMod()
        {
            BorderStyle = BorderStyle.None;
            InitializeComponent();
        }

        // Receber e Retornar o Valor da Propriedade...
        public string MarcaText
        {
            get
            {
                return marca_Da_aguaText;
            }
            set
            {
                marca_Da_aguaText = value;

                GetMarcaText();
            }
        }

        [Browsable(false)]

        public new bool Multiline
        {
            get
            {
                return multiline;
            }
            set
            {
                multiline = false;
            }
        }

        public Color ColorMarca
        {
            get { return colormasca; }
            set { colormasca = value; }
        }
        public Color ColorDig
        {
            get { return colordig; }
            set { colordig = value; }
        }
       //
        private void GetMarcaText()
        {
           if((this.Text == MarcaText) || (this.Text == string.Empty))
           {
                this.ForeColor = ColorMarca;
                this.Text = MarcaText;
           }
            else
            {
                this.ForeColor = ColorDig;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxMod
            // 
            this.Enter += new System.EventHandler(this.TextBoxMod_Enter);
            this.Leave += new System.EventHandler(this.TextBoxMod_Leave);
            this.ResumeLayout(false);

        }

        private void TextBoxMod_Enter(object sender, EventArgs e)
        {
            if ((this.Text == MarcaText) || (this.Text == string.Empty))
            {
                this.ForeColor = ColorMarca;
                this.Text = string.Empty;
            }
        }

        private void TextBoxMod_Leave(object sender, EventArgs e)
        {
            GetMarcaText();
        }
    }
}
