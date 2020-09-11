using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;
using System.Drawing;

namespace FerramentasMod
{
    public class ButtonIconMod : IconButton
    {


        #region Variáveis

        private Color iconhover = Color.Black;
        private Color iconleave = Color.White;


        public Color IconHover
        {
            get
            {
                return iconhover;
            }
            set
            {
                iconhover = value;
            }
        }


        public Color IconLeave
        {
            get
            {
                return iconleave;
            }
            set
            {
                iconleave = value;
            }
        }
        #endregion

        public ButtonIconMod()
        {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(60, 60);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ButtonIconMod
            // 

            // ConfigStyle
            
       
            //
            this.MouseLeave += new System.EventHandler(this.ButtonIconMod_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ButtonIconMod_MouseHover);
            this.ResumeLayout(false);

        }

        #region Médutos

        private void ButtonIconMod_MouseHover(object sender, EventArgs e)
        {
            this.IconColor = IconHover;
        }

        private void ButtonIconMod_MouseLeave(object sender, EventArgs e)
        {
            this.IconColor = IconLeave;
        }

        #endregion

    }
}
