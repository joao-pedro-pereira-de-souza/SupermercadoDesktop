using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FerramentasMod
{
    public partial class PanelMod : UserControl
    {
        public PanelMod()
        {
            ForeColor = Color.White;
            InitializeComponent();
        }

        string txt = "Texto";

        int wh = 20; float ang = 45;// variavel Radius "wh" , Variavel Angulo color "ang"

        Color cl0 = Color.Blue, cl1 = Color.Orange; // Variavel gradient Color


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


        public Color Color0
        {
            // Propriedade
            get
            {
                return cl0;
            }

            set
            {
                cl0 = value; Invalidate();
            }
        }


        public Color Color1
        {
            // Propriedade
            get
            {
                return cl1;
            }

            set
            {
                cl1 = value; Invalidate();
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


            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0, cl1, ang), gb);

            // sString

            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle,
                new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

            base.OnPaint(e);
        }
        #endregion
    }
}
