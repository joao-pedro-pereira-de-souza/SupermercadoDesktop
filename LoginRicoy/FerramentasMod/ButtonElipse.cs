using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace FerramentasMod
{
    public partial class ButtonElipse : UserControl
    {
        public ButtonElipse()
        {
            ForeColor = Color.White;

            InitializeComponent();
        }

       

        string txt = "Texto";

        int wh = 40; float ang = 45;// variavel Radius "wh" , Variavel Angulo color "ang"

        Color clhover = Color.Blue; Color clleaver; // Variavel gradient Color

        Color colorbutton = Color.Orange;

        bool efeito = true;

        Font txtshow = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        Font txtleaver = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        #region Propriedade
        public int borderRadius
        {
            // Propriedade
            get
            {
                return wh;
            }

            set
            {
                wh = value; Invalidate();
            }
        }

        public bool EfeitoTexto
        {
            get
            {
                return efeito;
            }
            set
            {
                efeito = value; Invalidate();
            }
        }

        public Font TextShow
        {
            get
            {
                return txtshow;
            }
            set
            {
                txtshow = value; Invalidate();
            }
        }

        public Font TextLeaver
        {
            get
            {
                return txtleaver;
            }
            set
            {
                txtleaver = value; Invalidate();
            }
        }


        public Color ColorButton
        {
            // Propriedade
            get
            {
                return colorbutton;
            }

            set
            {
                colorbutton = value; Invalidate();
            }
        }

        public Color ColorLeaver
        {
            // Propriedade
            get
            {
                return clleaver;
            }

            set
            {
                clleaver = value; Invalidate();
            }
        }

        public Color ColorHover
        {
            // Propriedade
            get
            {
                return clhover;
            }

            set
            {
                clhover = value; Invalidate();
            }
        }

        // Aviso!!! pode Modificar o Angulo da cor Sem o efeito TimeColor
        public float AnguloColor
        {
            get { return ang; }

            set { ang = value; Invalidate(); }
        }

        public string Texto
        {
            get { return txt; }

            set { txt = value; Invalidate(); }
        }

        #endregion

        #region Sistema desing
        protected override void OnPaint(PaintEventArgs e)
        {
            //Sistema
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            GraphicsPath gb = new GraphicsPath();
            gb.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gb.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gb.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gb.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);


            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, colorbutton, colorbutton,20), gb);

            // sString

            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle,
                new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

            base.OnPaint(e);
        }
        #endregion


        private void ButtonElipse_MouseHover(object sender, System.EventArgs e)
        {
            if(efeito == true)
            {
                this.Font = txtshow;
            }
            this.colorbutton = clhover;
        }

        private void ButtonElipse_MouseLeave(object sender, System.EventArgs e)
        {
           if(efeito == true)
           {
                this.Font = txtleaver;
           }
            this.colorbutton = clleaver;
        }

        

    }
}
