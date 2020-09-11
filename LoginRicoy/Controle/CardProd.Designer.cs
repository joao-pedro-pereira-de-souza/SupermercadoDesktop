namespace Controle
{
    partial class CardProd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuantMais = new FerramentasMod.ButtonIconMod();
            this.btnQuantMenos = new FerramentasMod.ButtonIconMod();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new FerramentasMod.ButtonElipse();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.ptbProduto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnQuantMais);
            this.panel1.Controls.Add(this.btnQuantMenos);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.ptbProduto);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 296);
            this.panel1.TabIndex = 0;
            // 
            // btnQuantMais
            // 
            this.btnQuantMais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantMais.FlatAppearance.BorderSize = 0;
            this.btnQuantMais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuantMais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuantMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantMais.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQuantMais.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnQuantMais.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnQuantMais.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.btnQuantMais.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnQuantMais.IconSize = 16;
            this.btnQuantMais.Location = new System.Drawing.Point(180, 198);
            this.btnQuantMais.Name = "btnQuantMais";
            this.btnQuantMais.Rotation = 0D;
            this.btnQuantMais.Size = new System.Drawing.Size(31, 26);
            this.btnQuantMais.TabIndex = 7;
            this.btnQuantMais.UseVisualStyleBackColor = true;
            this.btnQuantMais.Click += new System.EventHandler(this.btnQuantMais_Click);
            // 
            // btnQuantMenos
            // 
            this.btnQuantMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantMenos.FlatAppearance.BorderSize = 0;
            this.btnQuantMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuantMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuantMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantMenos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQuantMenos.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnQuantMenos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnQuantMenos.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnQuantMenos.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnQuantMenos.IconSize = 16;
            this.btnQuantMenos.Location = new System.Drawing.Point(143, 198);
            this.btnQuantMenos.Name = "btnQuantMenos";
            this.btnQuantMenos.Rotation = 0D;
            this.btnQuantMenos.Size = new System.Drawing.Size(31, 26);
            this.btnQuantMenos.TabIndex = 6;
            this.btnQuantMenos.UseVisualStyleBackColor = true;
            this.btnQuantMenos.Click += new System.EventHandler(this.btnQuantMenos_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.txtQuant.Location = new System.Drawing.Point(97, 195);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(40, 29);
            this.txtQuant.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(7, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade :";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AnguloColor = 45F;
            this.btnAdicionar.borderRadius = 10;
            this.btnAdicionar.ColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.btnAdicionar.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnAdicionar.ColorLeaver = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.EfeitoTexto = true;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(36, 256);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(155, 29);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.TextLeaver = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Texto = "Adicionar";
            this.btnAdicionar.TextShow = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(0, 147);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(227, 44);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Nome Produto";
            // 
            // lblNome
            // 
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblNome.Location = new System.Drawing.Point(0, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(227, 31);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Produto";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbProduto
            // 
            this.ptbProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbProduto.Location = new System.Drawing.Point(0, 0);
            this.ptbProduto.Name = "ptbProduto";
            this.ptbProduto.Size = new System.Drawing.Size(227, 116);
            this.ptbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbProduto.TabIndex = 0;
            this.ptbProduto.TabStop = false;
            // 
            // CardProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(20, 3, 3, 20);
            this.Name = "CardProd";
            this.Size = new System.Drawing.Size(240, 309);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FerramentasMod.ButtonIconMod btnQuantMais;
        private FerramentasMod.ButtonIconMod btnQuantMenos;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label1;
        private FerramentasMod.ButtonElipse btnAdicionar;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.PictureBox ptbProduto;
    }
}
