namespace UI
{
    partial class UserListProd
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDeletar = new FerramentasMod.ButtonIconMod();
            this.ptbProd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(104, 51);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeletar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletar.IconColor = System.Drawing.Color.Gray;
            this.btnDeletar.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeletar.IconLeave = System.Drawing.Color.Gray;
            this.btnDeletar.IconSize = 16;
            this.btnDeletar.Location = new System.Drawing.Point(270, 6);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Rotation = 0D;
            this.btnDeletar.Size = new System.Drawing.Size(32, 36);
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // ptbProd
            // 
            this.ptbProd.Location = new System.Drawing.Point(212, 1);
            this.ptbProd.Name = "ptbProd";
            this.ptbProd.Size = new System.Drawing.Size(52, 47);
            this.ptbProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbProd.TabIndex = 2;
            this.ptbProd.TabStop = false;
            // 
            // UserListProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ptbProd);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserListProd";
            this.Size = new System.Drawing.Size(305, 51);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FerramentasMod.ButtonIconMod btnDeletar;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.PictureBox ptbProd;
    }
}
