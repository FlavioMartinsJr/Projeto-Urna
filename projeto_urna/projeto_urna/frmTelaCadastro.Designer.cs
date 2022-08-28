namespace projeto_urna
{
    partial class frmTelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaCadastro));
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.bntcadas = new System.Windows.Forms.Button();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblrm = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxAluno = new System.Windows.Forms.CheckBox();
            this.cbxProfessor = new System.Windows.Forms.CheckBox();
            this.cbxUsuário = new System.Windows.Forms.CheckBox();
            this.cbxAdministrador = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRM_border = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtcor2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsenha
            // 
            this.lblsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.lblsenha.Location = new System.Drawing.Point(175, 231);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(72, 23);
            this.lblsenha.TabIndex = 23;
            this.lblsenha.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.Location = new System.Drawing.Point(254, 233);
            this.txtsenha.MaxLength = 8;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(235, 19);
            this.txtsenha.TabIndex = 2;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntcadas
            // 
            this.bntcadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.bntcadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntcadas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.bntcadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntcadas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntcadas.Location = new System.Drawing.Point(239, 363);
            this.bntcadas.Name = "bntcadas";
            this.bntcadas.Size = new System.Drawing.Size(254, 52);
            this.bntcadas.TabIndex = 7;
            this.bntcadas.Text = "Cadastrar";
            this.bntcadas.UseVisualStyleBackColor = false;
            this.bntcadas.Click += new System.EventHandler(this.Bntcadas_Click);
            // 
            // txtRM
            // 
            this.txtRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRM.ForeColor = System.Drawing.Color.Black;
            this.txtRM.Location = new System.Drawing.Point(254, 183);
            this.txtRM.MaxLength = 5;
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(235, 19);
            this.txtRM.TabIndex = 1;
            this.txtRM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRM.TextChanged += new System.EventHandler(this.txtRM_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(254, 134);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 19);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblrm
            // 
            this.lblrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrm.AutoSize = true;
            this.lblrm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.lblrm.Location = new System.Drawing.Point(204, 181);
            this.lblrm.Name = "lblrm";
            this.lblrm.Size = new System.Drawing.Size(43, 23);
            this.lblrm.TabIndex = 14;
            this.lblrm.Text = "RM:";
            // 
            // lblnome
            // 
            this.lblnome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.lblnome.Location = new System.Drawing.Point(178, 136);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(71, 23);
            this.lblnome.TabIndex = 13;
            this.lblnome.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // cbxAluno
            // 
            this.cbxAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAluno.AutoSize = true;
            this.cbxAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.cbxAluno.Location = new System.Drawing.Point(235, 277);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(74, 23);
            this.cbxAluno.TabIndex = 3;
            this.cbxAluno.Text = "Aluno";
            this.cbxAluno.UseVisualStyleBackColor = true;
            this.cbxAluno.CheckedChanged += new System.EventHandler(this.cbxAluno_CheckedChanged);
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProfessor.AutoSize = true;
            this.cbxProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.cbxProfessor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfessor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxProfessor.Location = new System.Drawing.Point(396, 277);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(93, 23);
            this.cbxProfessor.TabIndex = 4;
            this.cbxProfessor.Text = "Professor";
            this.cbxProfessor.UseVisualStyleBackColor = false;
            this.cbxProfessor.CheckedChanged += new System.EventHandler(this.cbxProfessor_CheckedChanged);
            // 
            // cbxUsuário
            // 
            this.cbxUsuário.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUsuário.AutoSize = true;
            this.cbxUsuário.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsuário.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.cbxUsuário.Location = new System.Drawing.Point(235, 318);
            this.cbxUsuário.Name = "cbxUsuário";
            this.cbxUsuário.Size = new System.Drawing.Size(84, 23);
            this.cbxUsuário.TabIndex = 5;
            this.cbxUsuário.Text = "Usuário";
            this.cbxUsuário.UseVisualStyleBackColor = true;
            this.cbxUsuário.CheckedChanged += new System.EventHandler(this.cbxUsuário_CheckedChanged);
            // 
            // cbxAdministrador
            // 
            this.cbxAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAdministrador.AutoSize = true;
            this.cbxAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.cbxAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdministrador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxAdministrador.Location = new System.Drawing.Point(396, 318);
            this.cbxAdministrador.Name = "cbxAdministrador";
            this.cbxAdministrador.Size = new System.Drawing.Size(137, 23);
            this.cbxAdministrador.TabIndex = 6;
            this.cbxAdministrador.Text = "Administrador";
            this.cbxAdministrador.UseVisualStyleBackColor = false;
            this.cbxAdministrador.CheckedChanged += new System.EventHandler(this.cbxAdministrador_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(254, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(235, 34);
            this.textBox1.TabIndex = 30;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // txtRM_border
            // 
            this.txtRM_border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRM_border.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRM_border.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRM_border.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtRM_border.Enabled = false;
            this.txtRM_border.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRM_border.ForeColor = System.Drawing.Color.Black;
            this.txtRM_border.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtRM_border.Location = new System.Drawing.Point(254, 175);
            this.txtRM_border.Name = "txtRM_border";
            this.txtRM_border.ReadOnly = true;
            this.txtRM_border.Size = new System.Drawing.Size(235, 34);
            this.txtRM_border.TabIndex = 31;
            this.txtRM_border.TabStop = false;
            this.txtRM_border.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRM_border.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(254, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(235, 34);
            this.textBox3.TabIndex = 32;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.linkLabel1.Location = new System.Drawing.Point(333, 435);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 22);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtcor
            // 
            this.txtcor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtcor.Enabled = false;
            this.txtcor.Location = new System.Drawing.Point(730, 479);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(10, 20);
            this.txtcor.TabIndex = 34;
            this.txtcor.Visible = false;
            // 
            // txtcor2
            // 
            this.txtcor2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtcor2.Enabled = false;
            this.txtcor2.Location = new System.Drawing.Point(730, 12);
            this.txtcor2.Name = "txtcor2";
            this.txtcor2.Size = new System.Drawing.Size(10, 20);
            this.txtcor2.TabIndex = 35;
            this.txtcor2.Visible = false;
            // 
            // frmTelaCadastro
            // 
            this.AcceptButton = this.bntcadas;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 511);
            this.Controls.Add(this.txtcor2);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.txtRM_border);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxAdministrador);
            this.Controls.Add(this.cbxUsuário);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.cbxAluno);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.bntcadas);
            this.Controls.Add(this.lblrm);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblrm;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxAluno;
        private System.Windows.Forms.CheckBox cbxProfessor;
        private System.Windows.Forms.CheckBox cbxUsuário;
        private System.Windows.Forms.CheckBox cbxAdministrador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtRM_border;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bntcadas;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtcor2;
    }
}