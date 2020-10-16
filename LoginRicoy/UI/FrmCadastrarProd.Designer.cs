namespace UI
{
    partial class FrmCadastrarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new FerramentasMod.ButtonIconMod();
            this.btnSair = new FerramentasMod.ButtonIconMod();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlPg1 = new System.Windows.Forms.Panel();
            this.btnProximaPg = new FerramentasMod.ButtonElipse();
            this.txtNome = new FerramentasMod.TextBoxMod();
            this.txtStatus = new FerramentasMod.TextBoxMod();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMod3 = new FerramentasMod.PanelMod();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMod2 = new FerramentasMod.PanelMod();
            this.txtID = new FerramentasMod.TextBoxMod();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMod1 = new FerramentasMod.PanelMod();
            this.pnlProgressoCad = new System.Windows.Forms.Panel();
            this.lblStatusProgress = new System.Windows.Forms.Label();
            this.fvdProgress = new FiveCodMaterialDesign.FiveCodProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlpg2 = new System.Windows.Forms.Panel();
            this.btnColorCode = new FerramentasMod.ButtonIconMod();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvarCode = new FerramentasMod.ButtonElipse();
            this.label7 = new System.Windows.Forms.Label();
            this.mcbCode = new MetroFramework.Controls.MetroComboBox();
            this.ptbCodeID = new System.Windows.Forms.PictureBox();
            this.txtValor = new FerramentasMod.TextBoxMod();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMod4 = new FerramentasMod.PanelMod();
            this.btnVoltarPg = new FerramentasMod.ButtonElipse();
            this.btnConcluir = new FerramentasMod.ButtonElipse();
            this.txtQuantidade = new FerramentasMod.TextBoxMod();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMod6 = new FerramentasMod.PanelMod();
            this.AnimaPg = new System.Windows.Forms.Timer(this.components);
            this.AnimaVoltarPg = new System.Windows.Forms.Timer(this.components);
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pnlPg1.SuspendLayout();
            this.pnlProgressoCad.SuspendLayout();
            this.pnlpg2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.ptbIcon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMini
            // 
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMini.IconColor = System.Drawing.Color.White;
            this.btnMini.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnMini.IconLeave = System.Drawing.Color.White;
            this.btnMini.IconSize = 18;
            this.btnMini.Location = new System.Drawing.Point(631, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Rotation = 0D;
            this.btnMini.Size = new System.Drawing.Size(18, 21);
            this.btnMini.TabIndex = 5;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnSair.IconLeave = System.Drawing.Color.White;
            this.btnSair.IconSize = 18;
            this.btnSair.Location = new System.Drawing.Point(661, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Rotation = 0D;
            this.btnSair.Size = new System.Drawing.Size(18, 21);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ptbIcon
            // 
            this.ptbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbIcon.Image = global::LoginRicoy.Properties.Resources.iconRegistroadd1;
            this.ptbIcon.Location = new System.Drawing.Point(7, 4);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(39, 39);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbIcon.TabIndex = 3;
            this.ptbIcon.TabStop = false;
            this.ptbIcon.Click += new System.EventHandler(this.ptbIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(51, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cadastro";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.pnlPg1);
            this.pnlContainer.Controls.Add(this.pnlProgressoCad);
            this.pnlContainer.Location = new System.Drawing.Point(251, 59);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(453, 370);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlPg1
            // 
            this.pnlPg1.Controls.Add(this.btnProximaPg);
            this.pnlPg1.Controls.Add(this.txtNome);
            this.pnlPg1.Controls.Add(this.txtStatus);
            this.pnlPg1.Controls.Add(this.label5);
            this.pnlPg1.Controls.Add(this.panelMod3);
            this.pnlPg1.Controls.Add(this.label4);
            this.pnlPg1.Controls.Add(this.panelMod2);
            this.pnlPg1.Controls.Add(this.txtID);
            this.pnlPg1.Controls.Add(this.label1);
            this.pnlPg1.Controls.Add(this.panelMod1);
            this.pnlPg1.Location = new System.Drawing.Point(3, 3);
            this.pnlPg1.Name = "pnlPg1";
            this.pnlPg1.Size = new System.Drawing.Size(447, 310);
            this.pnlPg1.TabIndex = 25;
            // 
            // btnProximaPg
            // 
            this.btnProximaPg.AnguloColor = 45F;
            this.btnProximaPg.borderRadius = 10;
            this.btnProximaPg.ColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnProximaPg.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnProximaPg.ColorLeaver = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnProximaPg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximaPg.EfeitoTexto = true;
            this.btnProximaPg.ForeColor = System.Drawing.Color.White;
            this.btnProximaPg.Location = new System.Drawing.Point(291, 267);
            this.btnProximaPg.Name = "btnProximaPg";
            this.btnProximaPg.Size = new System.Drawing.Size(125, 33);
            this.btnProximaPg.TabIndex = 6;
            this.btnProximaPg.TextLeaver = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPg.Texto = "Próximo";
            this.btnProximaPg.TextShow = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPg.Click += new System.EventHandler(this.btnProximaPg_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ColorDig = System.Drawing.Color.Black;
            this.txtNome.ColorMarca = System.Drawing.Color.Gray;
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(42, 137);
            this.txtNome.MarcaText = null;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 22);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.ColorDig = System.Drawing.Color.Black;
            this.txtStatus.ColorMarca = System.Drawing.Color.Gray;
            this.txtStatus.ForeColor = System.Drawing.Color.Gray;
            this.txtStatus.Location = new System.Drawing.Point(42, 216);
            this.txtStatus.MarcaText = null;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(363, 22);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(38, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome";
            // 
            // panelMod3
            // 
            this.panelMod3.AnguloColor = 45F;
            this.panelMod3.borderRadius = 10;
            this.panelMod3.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod3.ForeColor = System.Drawing.Color.White;
            this.panelMod3.Location = new System.Drawing.Point(31, 127);
            this.panelMod3.Name = "panelMod3";
            this.panelMod3.Size = new System.Drawing.Size(385, 41);
            this.panelMod3.TabIndex = 3;
            this.panelMod3.Texto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(38, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // panelMod2
            // 
            this.panelMod2.AnguloColor = 45F;
            this.panelMod2.borderRadius = 10;
            this.panelMod2.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod2.ForeColor = System.Drawing.Color.White;
            this.panelMod2.Location = new System.Drawing.Point(31, 206);
            this.panelMod2.Name = "panelMod2";
            this.panelMod2.Size = new System.Drawing.Size(385, 41);
            this.panelMod2.TabIndex = 3;
            this.panelMod2.Texto = "";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ColorDig = System.Drawing.Color.Black;
            this.txtID.ColorMarca = System.Drawing.Color.Gray;
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.Location = new System.Drawing.Point(42, 60);
            this.txtID.MarcaText = null;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(363, 22);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // panelMod1
            // 
            this.panelMod1.AnguloColor = 45F;
            this.panelMod1.borderRadius = 10;
            this.panelMod1.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod1.ForeColor = System.Drawing.Color.White;
            this.panelMod1.Location = new System.Drawing.Point(31, 50);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(385, 41);
            this.panelMod1.TabIndex = 0;
            this.panelMod1.Texto = "";
            // 
            // pnlProgressoCad
            // 
            this.pnlProgressoCad.Controls.Add(this.lblStatusProgress);
            this.pnlProgressoCad.Controls.Add(this.fvdProgress);
            this.pnlProgressoCad.Controls.Add(this.label2);
            this.pnlProgressoCad.Location = new System.Drawing.Point(3, 318);
            this.pnlProgressoCad.Name = "pnlProgressoCad";
            this.pnlProgressoCad.Size = new System.Drawing.Size(447, 49);
            this.pnlProgressoCad.TabIndex = 24;
            // 
            // lblStatusProgress
            // 
            this.lblStatusProgress.AutoSize = true;
            this.lblStatusProgress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblStatusProgress.Location = new System.Drawing.Point(149, 8);
            this.lblStatusProgress.Name = "lblStatusProgress";
            this.lblStatusProgress.Size = new System.Drawing.Size(26, 17);
            this.lblStatusProgress.TabIndex = 25;
            this.lblStatusProgress.Text = "0%";
            // 
            // fvdProgress
            // 
            this.fvdProgress.BGColor = "#ff9f43";
            this.fvdProgress.Location = new System.Drawing.Point(6, 28);
            this.fvdProgress.Name = "fvdProgress";
            this.fvdProgress.Size = new System.Drawing.Size(410, 14);
            this.fvdProgress.TabIndex = 24;
            this.fvdProgress.Text = "fiveCodProgressBar1";
            this.fvdProgress.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "prograsso do cadastro:";
            // 
            // pnlpg2
            // 
            this.pnlpg2.BackColor = System.Drawing.Color.White;
            this.pnlpg2.Controls.Add(this.btnColorCode);
            this.pnlpg2.Controls.Add(this.panel2);
            this.pnlpg2.Controls.Add(this.txtValor);
            this.pnlpg2.Controls.Add(this.label6);
            this.pnlpg2.Controls.Add(this.panelMod4);
            this.pnlpg2.Controls.Add(this.btnVoltarPg);
            this.pnlpg2.Controls.Add(this.btnConcluir);
            this.pnlpg2.Controls.Add(this.txtQuantidade);
            this.pnlpg2.Controls.Add(this.label8);
            this.pnlpg2.Controls.Add(this.panelMod6);
            this.pnlpg2.Location = new System.Drawing.Point(707, 67);
            this.pnlpg2.Name = "pnlpg2";
            this.pnlpg2.Size = new System.Drawing.Size(447, 312);
            this.pnlpg2.TabIndex = 26;
            this.pnlpg2.Visible = false;
            // 
            // btnColorCode
            // 
            this.btnColorCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorCode.FlatAppearance.BorderSize = 0;
            this.btnColorCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnColorCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnColorCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorCode.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnColorCode.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.btnColorCode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnColorCode.IconHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(132)))), ((int)(((byte)(241)))));
            this.btnColorCode.IconLeave = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnColorCode.IconSize = 22;
            this.btnColorCode.Location = new System.Drawing.Point(422, 108);
            this.btnColorCode.Name = "btnColorCode";
            this.btnColorCode.Rotation = 0D;
            this.btnColorCode.Size = new System.Drawing.Size(18, 21);
            this.btnColorCode.TabIndex = 12;
            this.btnColorCode.UseVisualStyleBackColor = true;
            this.btnColorCode.Click += new System.EventHandler(this.btnColorCode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvarCode);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.mcbCode);
            this.panel2.Controls.Add(this.ptbCodeID);
            this.panel2.Location = new System.Drawing.Point(32, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 120);
            this.panel2.TabIndex = 11;
            // 
            // btnSalvarCode
            // 
            this.btnSalvarCode.AnguloColor = 45F;
            this.btnSalvarCode.borderRadius = 10;
            this.btnSalvarCode.ColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnSalvarCode.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnSalvarCode.ColorLeaver = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnSalvarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCode.EfeitoTexto = true;
            this.btnSalvarCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCode.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCode.Location = new System.Drawing.Point(16, 84);
            this.btnSalvarCode.Name = "btnSalvarCode";
            this.btnSalvarCode.Size = new System.Drawing.Size(98, 28);
            this.btnSalvarCode.TabIndex = 13;
            this.btnSalvarCode.TextLeaver = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCode.Texto = "Salvar";
            this.btnSalvarCode.TextShow = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCode.Click += new System.EventHandler(this.btnSalvarCode_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.label7.Location = new System.Drawing.Point(13, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "usando o dado ID no QRCode";
            // 
            // mcbCode
            // 
            this.mcbCode.BackColor = System.Drawing.SystemColors.InfoText;
            this.mcbCode.FormattingEnabled = true;
            this.mcbCode.ItemHeight = 23;
            this.mcbCode.Items.AddRange(new object[] {
            "QRCode",
            "BarCode"});
            this.mcbCode.Location = new System.Drawing.Point(16, 11);
            this.mcbCode.Name = "mcbCode";
            this.mcbCode.Size = new System.Drawing.Size(214, 29);
            this.mcbCode.TabIndex = 11;
            this.mcbCode.UseSelectable = true;
            this.mcbCode.SelectedIndexChanged += new System.EventHandler(this.mcbCode_SelectedIndexChanged);
            // 
            // ptbCodeID
            // 
            this.ptbCodeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ptbCodeID.Location = new System.Drawing.Point(240, 4);
            this.ptbCodeID.Name = "ptbCodeID";
            this.ptbCodeID.Size = new System.Drawing.Size(133, 108);
            this.ptbCodeID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCodeID.TabIndex = 10;
            this.ptbCodeID.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.ColorDig = System.Drawing.Color.Black;
            this.txtValor.ColorMarca = System.Drawing.Color.Gray;
            this.txtValor.ForeColor = System.Drawing.Color.Gray;
            this.txtValor.Location = new System.Drawing.Point(249, 55);
            this.txtValor.MarcaText = null;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 22);
            this.txtValor.TabIndex = 9;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(245, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor";
            // 
            // panelMod4
            // 
            this.panelMod4.AnguloColor = 45F;
            this.panelMod4.borderRadius = 10;
            this.panelMod4.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod4.ForeColor = System.Drawing.Color.White;
            this.panelMod4.Location = new System.Drawing.Point(238, 45);
            this.panelMod4.Name = "panelMod4";
            this.panelMod4.Size = new System.Drawing.Size(138, 41);
            this.panelMod4.TabIndex = 7;
            this.panelMod4.Texto = "";
            // 
            // btnVoltarPg
            // 
            this.btnVoltarPg.AnguloColor = 45F;
            this.btnVoltarPg.borderRadius = 10;
            this.btnVoltarPg.ColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnVoltarPg.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnVoltarPg.ColorLeaver = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.btnVoltarPg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarPg.EfeitoTexto = true;
            this.btnVoltarPg.ForeColor = System.Drawing.Color.White;
            this.btnVoltarPg.Location = new System.Drawing.Point(142, 262);
            this.btnVoltarPg.Name = "btnVoltarPg";
            this.btnVoltarPg.Size = new System.Drawing.Size(125, 33);
            this.btnVoltarPg.TabIndex = 6;
            this.btnVoltarPg.TextLeaver = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPg.Texto = "Voltar";
            this.btnVoltarPg.TextShow = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPg.Click += new System.EventHandler(this.btnVoltarPg_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.AnguloColor = 45F;
            this.btnConcluir.borderRadius = 10;
            this.btnConcluir.ColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnConcluir.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(64)))));
            this.btnConcluir.ColorLeaver = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.EfeitoTexto = true;
            this.btnConcluir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.Color.White;
            this.btnConcluir.Location = new System.Drawing.Point(288, 262);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(125, 33);
            this.btnConcluir.TabIndex = 6;
            this.btnConcluir.TextLeaver = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Texto = "Cadastrar";
            this.btnConcluir.TextShow = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.ColorDig = System.Drawing.Color.Black;
            this.txtQuantidade.ColorMarca = System.Drawing.Color.Gray;
            this.txtQuantidade.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantidade.Location = new System.Drawing.Point(43, 55);
            this.txtQuantidade.MarcaText = null;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(115, 22);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.label8.Location = new System.Drawing.Point(39, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantidade";
            // 
            // panelMod6
            // 
            this.panelMod6.AnguloColor = 45F;
            this.panelMod6.borderRadius = 10;
            this.panelMod6.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod6.ForeColor = System.Drawing.Color.White;
            this.panelMod6.Location = new System.Drawing.Point(32, 45);
            this.panelMod6.Name = "panelMod6";
            this.panelMod6.Size = new System.Drawing.Size(138, 41);
            this.panelMod6.TabIndex = 0;
            this.panelMod6.Texto = "";
            // 
            // AnimaPg
            // 
            this.AnimaPg.Interval = 10;
            this.AnimaPg.Tick += new System.EventHandler(this.AnimaPg_Tick);
            // 
            // AnimaVoltarPg
            // 
            this.AnimaVoltarPg.Interval = 10;
            this.AnimaVoltarPg.Tick += new System.EventHandler(this.AnimaVoltarPg_Tick);
            // 
            // ptbImagem
            // 
            this.ptbImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.ptbImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImagem.Image = global::LoginRicoy.Properties.Resources.iconIllustraitorAddImage;
            this.ptbImagem.Location = new System.Drawing.Point(12, 59);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(233, 373);
            this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagem.TabIndex = 10;
            this.ptbImagem.TabStop = false;
            this.ptbImagem.Click += new System.EventHandler(this.ptbImagem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FrmCadastrarProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(704, 443);
            this.Controls.Add(this.pnlpg2);
            this.Controls.Add(this.ptbImagem);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarProd";
            this.Load += new System.EventHandler(this.FrmCadastrarProd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlPg1.ResumeLayout(false);
            this.pnlPg1.PerformLayout();
            this.pnlProgressoCad.ResumeLayout(false);
            this.pnlProgressoCad.PerformLayout();
            this.pnlpg2.ResumeLayout(false);
            this.pnlpg2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox ptbImagem;
        private System.Windows.Forms.Label label3;
      //  private FerramentasMod.ButtonIconMod btnSair;
        private System.Windows.Forms.Label label2;
      //  private FiveCodMaterialDesign.FiveCodProgressBar fvdProgress;
        private System.Windows.Forms.Panel pnlPg1;
    //    private FerramentasMod.ButtonIconMod btnStatusZoom;
        private FerramentasMod.ButtonElipse btnProximaPg;
        private FerramentasMod.TextBoxMod txtNome;
        private FerramentasMod.TextBoxMod txtStatus;
        private System.Windows.Forms.Label label5;
        private FerramentasMod.PanelMod panelMod3;
        private System.Windows.Forms.Label label4;
        private FerramentasMod.PanelMod panelMod2;
        private FerramentasMod.TextBoxMod txtID;
        private System.Windows.Forms.Label label1;
        private FerramentasMod.PanelMod panelMod1;
        private System.Windows.Forms.Panel pnlProgressoCad;
        private System.Windows.Forms.Panel pnlpg2;
        private FerramentasMod.ButtonElipse btnConcluir;
        private FerramentasMod.TextBoxMod txtQuantidade;
        private System.Windows.Forms.Label label8;
        private FerramentasMod.PanelMod panelMod6;
        private System.Windows.Forms.Timer AnimaPg;
        private FerramentasMod.TextBoxMod txtValor;
        private System.Windows.Forms.Label label6;
        private FerramentasMod.PanelMod panelMod4;
        private FerramentasMod.ButtonElipse btnVoltarPg;
        private System.Windows.Forms.Timer AnimaVoltarPg;
        private FiveCodMaterialDesign.FiveCodProgressBar fvdProgress;
        private System.Windows.Forms.Label lblStatusProgress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbCodeID;
        private FerramentasMod.ButtonElipse btnSalvarCode;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox mcbCode;
       
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ptbIcon;
        private FerramentasMod.ButtonIconMod btnSair;
        private FerramentasMod.ButtonIconMod btnMini;
        private FerramentasMod.ButtonIconMod btnColorCode;
    }
}