namespace UI
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
            this.lblValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new FerramentasMod.ButtonElipse();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.ptbProduto = new System.Windows.Forms.PictureBox();
            this.btnAdicionarProd = new FerramentasMod.ButtonIconMod();
            this.btnmenosprod = new FerramentasMod.ButtonIconMod();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAdicionarProd);
            this.panel1.Controls.Add(this.btnmenosprod);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 257);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblValor.Location = new System.Drawing.Point(92, 152);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 20);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(38, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor :";
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.White;
            this.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.txtQuant.Location = new System.Drawing.Point(266, 149);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(40, 29);
            this.txtQuant.TabIndex = 5;
            this.txtQuant.Text = "0";
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(171, 157);
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
            this.btnAdicionar.Location = new System.Drawing.Point(112, 208);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(182, 35);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.TextLeaver = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Texto = "Adicionar";
            this.btnAdicionar.TextShow = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(27, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(376, 50);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Nome Produto";
            // 
            // lblNome
            // 
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblNome.Location = new System.Drawing.Point(30, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(373, 52);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Produto";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbProduto
            // 
            this.ptbProduto.BackColor = System.Drawing.Color.Transparent;
            this.ptbProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbProduto.Location = new System.Drawing.Point(17, 45);
            this.ptbProduto.Name = "ptbProduto";
            this.ptbProduto.Size = new System.Drawing.Size(211, 167);
            this.ptbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProduto.TabIndex = 0;
            this.ptbProduto.TabStop = false;
            // 
            // btnAdicionarProd
            // 
            this.btnAdicionarProd.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicionarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdicionarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdicionarProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdicionarProd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnAdicionarProd.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdicionarProd.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnAdicionarProd.IconSize = 20;
            this.btnAdicionarProd.Location = new System.Drawing.Point(347, 157);
            this.btnAdicionarProd.Name = "btnAdicionarProd";
            this.btnAdicionarProd.Rotation = 0D;
            this.btnAdicionarProd.Size = new System.Drawing.Size(29, 17);
            this.btnAdicionarProd.TabIndex = 11;
            this.btnAdicionarProd.UseVisualStyleBackColor = true;
            this.btnAdicionarProd.Click += new System.EventHandler(this.btnAdicionarProd_Click);
            // 
            // btnmenosprod
            // 
            this.btnmenosprod.FlatAppearance.BorderSize = 0;
            this.btnmenosprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnmenosprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnmenosprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenosprod.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnmenosprod.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnmenosprod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnmenosprod.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnmenosprod.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnmenosprod.IconSize = 20;
            this.btnmenosprod.Location = new System.Drawing.Point(312, 156);
            this.btnmenosprod.Name = "btnmenosprod";
            this.btnmenosprod.Rotation = 0D;
            this.btnmenosprod.Size = new System.Drawing.Size(29, 17);
            this.btnmenosprod.TabIndex = 10;
            this.btnmenosprod.UseVisualStyleBackColor = true;
            this.btnmenosprod.Click += new System.EventHandler(this.btnmenosprod_Click);
            // 
            // CardProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ptbProduto);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(20, 3, 3, 20);
            this.Name = "CardProd";
            this.Size = new System.Drawing.Size(619, 257);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label1;
        private FerramentasMod.ButtonElipse btnAdicionar;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.PictureBox ptbProduto;
        public System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label2;
        private FerramentasMod.ButtonIconMod btnmenosprod;
        private FerramentasMod.ButtonIconMod btnAdicionarProd;
        public System.Windows.Forms.Label lblNome;
    }
}
