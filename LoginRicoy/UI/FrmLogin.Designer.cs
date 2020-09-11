namespace UI
{
    partial class FrmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnTwitter = new FerramentasMod.ButtonIconMod();
            this.btnInstagram = new FerramentasMod.ButtonIconMod();
            this.btnFacebook = new FerramentasMod.ButtonIconMod();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasswordMod1 = new FerramentasMod.TextBoxPasswordMod();
            this.iconeSenha = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmail = new FontAwesome.Sharp.IconButton();
            this.textBoxMod1 = new FerramentasMod.TextBoxMod();
            this.linerEmail = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSair = new FerramentasMod.ButtonIconMod();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEscricao = new System.Windows.Forms.Label();
            this.btnCreditos = new FerramentasMod.ButtonIconMod();
            this.Animation = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnTwitter);
            this.pnlLogin.Controls.Add(this.btnInstagram);
            this.pnlLogin.Controls.Add(this.btnFacebook);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnCadastrar);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.textBoxPasswordMod1);
            this.pnlLogin.Controls.Add(this.iconeSenha);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.btnEmail);
            this.pnlLogin.Controls.Add(this.textBoxMod1);
            this.pnlLogin.Controls.Add(this.linerEmail);
            this.pnlLogin.Controls.Add(this.pictureBox3);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(395, 473);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseDown);
            // 
            // btnTwitter
            // 
            this.btnTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwitter.FlatAppearance.BorderSize = 0;
            this.btnTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.btnTwitter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnTwitter.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTwitter.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnTwitter.IconSize = 25;
            this.btnTwitter.Location = new System.Drawing.Point(348, 307);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Rotation = 0D;
            this.btnTwitter.Size = new System.Drawing.Size(25, 28);
            this.btnTwitter.TabIndex = 17;
            this.btnTwitter.UseVisualStyleBackColor = true;
            // 
            // btnInstagram
            // 
            this.btnInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstagram.FlatAppearance.BorderSize = 0;
            this.btnInstagram.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnInstagram.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInstagram.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.btnInstagram.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnInstagram.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(81)))), ((int)(((byte)(67)))));
            this.btnInstagram.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnInstagram.IconSize = 25;
            this.btnInstagram.Location = new System.Drawing.Point(317, 307);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Rotation = 0D;
            this.btnInstagram.Size = new System.Drawing.Size(25, 28);
            this.btnInstagram.TabIndex = 16;
            this.btnInstagram.UseVisualStyleBackColor = true;
            // 
            // btnFacebook
            // 
            this.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnFacebook.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFacebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.btnFacebook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnFacebook.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnFacebook.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnFacebook.IconSize = 25;
            this.btnFacebook.Location = new System.Drawing.Point(286, 307);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Rotation = 0D;
            this.btnFacebook.Size = new System.Drawing.Size(25, 28);
            this.btnFacebook.TabIndex = 15;
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(61, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recuperar senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Image = global::LoginRicoy.Properties.Resources.IconeCadastrarLeaver2;
            this.btnCadastrar.Location = new System.Drawing.Point(123, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(134, 42);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            this.btnCadastrar.MouseHover += new System.EventHandler(this.btnCadastrar_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = global::LoginRicoy.Properties.Resources.IconeLogar2;
            this.btnLogin.Location = new System.Drawing.Point(267, 405);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 42);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogin.TabIndex = 9;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(140, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // textBoxPasswordMod1
            // 
            this.textBoxPasswordMod1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPasswordMod1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordMod1.ColorDig = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.textBoxPasswordMod1.ColorMarca = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.textBoxPasswordMod1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordMod1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.textBoxPasswordMod1.Location = new System.Drawing.Point(84, 246);
            this.textBoxPasswordMod1.MarcaText = "Senha";
            this.textBoxPasswordMod1.Name = "textBoxPasswordMod1";
            this.textBoxPasswordMod1.Size = new System.Drawing.Size(258, 26);
            this.textBoxPasswordMod1.TabIndex = 7;
            this.textBoxPasswordMod1.Text = "Senha";
            // 
            // iconeSenha
            // 
            this.iconeSenha.FlatAppearance.BorderSize = 0;
            this.iconeSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.iconeSenha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.iconeSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconeSenha.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconeSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconeSenha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.iconeSenha.IconSize = 22;
            this.iconeSenha.Location = new System.Drawing.Point(56, 252);
            this.iconeSenha.Name = "iconeSenha";
            this.iconeSenha.Rotation = 0D;
            this.iconeSenha.Size = new System.Drawing.Size(22, 16);
            this.iconeSenha.TabIndex = 6;
            this.iconeSenha.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(56, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 2);
            this.panel2.TabIndex = 4;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnEmail.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEmail.IconSize = 22;
            this.btnEmail.Location = new System.Drawing.Point(56, 173);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Rotation = 0D;
            this.btnEmail.Size = new System.Drawing.Size(22, 16);
            this.btnEmail.TabIndex = 3;
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // textBoxMod1
            // 
            this.textBoxMod1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMod1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMod1.ColorDig = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.textBoxMod1.ColorMarca = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.textBoxMod1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMod1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.textBoxMod1.Location = new System.Drawing.Point(84, 166);
            this.textBoxMod1.MarcaText = "Email";
            this.textBoxMod1.Name = "textBoxMod1";
            this.textBoxMod1.Size = new System.Drawing.Size(266, 26);
            this.textBoxMod1.TabIndex = 2;
            this.textBoxMod1.Text = "Email";
            // 
            // linerEmail
            // 
            this.linerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.linerEmail.Location = new System.Drawing.Point(56, 193);
            this.linerEmail.Name = "linerEmail";
            this.linerEmail.Size = new System.Drawing.Size(294, 2);
            this.linerEmail.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LoginRicoy.Properties.Resources.iconeRicoy;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSair.IconLeave = System.Drawing.Color.White;
            this.btnSair.IconSize = 20;
            this.btnSair.Location = new System.Drawing.Point(785, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Rotation = 0D;
            this.btnSair.Size = new System.Drawing.Size(38, 31);
            this.btnSair.TabIndex = 3;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LoginRicoy.Properties.Resources.undraw_shopping_app_flsj;
            this.pictureBox2.Location = new System.Drawing.Point(499, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEscricao
            // 
            this.lblEscricao.AutoSize = true;
            this.lblEscricao.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscricao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEscricao.Location = new System.Drawing.Point(481, 96);
            this.lblEscricao.Name = "lblEscricao";
            this.lblEscricao.Size = new System.Drawing.Size(342, 44);
            this.lblEscricao.TabIndex = 12;
            this.lblEscricao.Text = "Faça as suas compras online ...\r\nCom entregas em até 3 dias, sem frete.";
            // 
            // btnCreditos
            // 
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.FlatAppearance.BorderSize = 0;
            this.btnCreditos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCreditos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreditos.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnCreditos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCreditos.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreditos.IconLeave = System.Drawing.Color.White;
            this.btnCreditos.IconSize = 30;
            this.btnCreditos.Location = new System.Drawing.Point(785, 433);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Rotation = 0D;
            this.btnCreditos.Size = new System.Drawing.Size(25, 28);
            this.btnCreditos.TabIndex = 18;
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.MouseHover += new System.EventHandler(this.btnCreditos_MouseHover);
            // 
            // Animation
            // 
            this.Animation.Interval = 10;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.lblEscricao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlLogin;
        private FerramentasMod.TextBoxMod textBoxMod1;
        private System.Windows.Forms.Panel linerEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btnEmail;
        private FerramentasMod.TextBoxPasswordMod textBoxPasswordMod1;
        private FontAwesome.Sharp.IconButton iconeSenha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Label label1;
        private FerramentasMod.ButtonIconMod btnSair;
        private System.Windows.Forms.PictureBox btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEscricao;
        private FerramentasMod.ButtonIconMod btnTwitter;
        private FerramentasMod.ButtonIconMod btnInstagram;
        private FerramentasMod.ButtonIconMod btnFacebook;
        private FerramentasMod.ButtonIconMod btnCreditos;
        private System.Windows.Forms.Timer Animation;
    }
}

