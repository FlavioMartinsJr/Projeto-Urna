namespace projeto_urna
{
    partial class frmCriarChapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarChapa));
            this.btnCapturar = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grpchapas = new System.Windows.Forms.GroupBox();
            this.b = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome_chapa = new System.Windows.Forms.Label();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.lblImagem_chapa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grpchapas.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(82, 256);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(118, 26);
            this.btnCapturar.TabIndex = 5;
            this.btnCapturar.Text = "Capturar Imagem";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem.Location = new System.Drawing.Point(35, 19);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(214, 190);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 7;
            this.picImagem.TabStop = false;
            // 
            // grpchapas
            // 
            this.grpchapas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpchapas.Controls.Add(this.b);
            this.grpchapas.Controls.Add(this.txtDescricao);
            this.grpchapas.Controls.Add(this.btnCadastro);
            this.grpchapas.Controls.Add(this.txtPeriodo);
            this.grpchapas.Controls.Add(this.txtNome);
            this.grpchapas.Controls.Add(this.lblCidade);
            this.grpchapas.Controls.Add(this.lblDescricao);
            this.grpchapas.Controls.Add(this.lblNome_chapa);
            this.grpchapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpchapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpchapas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.grpchapas.Location = new System.Drawing.Point(68, 81);
            this.grpchapas.Margin = new System.Windows.Forms.Padding(10);
            this.grpchapas.Name = "grpchapas";
            this.grpchapas.Padding = new System.Windows.Forms.Padding(5);
            this.grpchapas.Size = new System.Drawing.Size(336, 359);
            this.grpchapas.TabIndex = 8;
            this.grpchapas.TabStop = false;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.White;
            this.b.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.b.FlatAppearance.BorderSize = 3;
            this.b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.ForeColor = System.Drawing.Color.Black;
            this.b.Location = new System.Drawing.Point(186, 288);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(109, 59);
            this.b.TabIndex = 4;
            this.b.Text = "Limpar";
            this.b.UseVisualStyleBackColor = false;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(38, 118);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(257, 154);
            this.txtDescricao.TabIndex = 2;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCadastro.FlatAppearance.BorderSize = 3;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Location = new System.Drawing.Point(38, 288);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(109, 59);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.BackColor = System.Drawing.SystemColors.Control;
            this.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(151, 61);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(144, 19);
            this.txtPeriodo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(151, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 19);
            this.txtNome.TabIndex = 0;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(19, 61);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(130, 18);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Turma / Periodo";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(19, 97);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(90, 18);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblNome_chapa
            // 
            this.lblNome_chapa.AutoSize = true;
            this.lblNome_chapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_chapa.Location = new System.Drawing.Point(19, 25);
            this.lblNome_chapa.Name = "lblNome_chapa";
            this.lblNome_chapa.Size = new System.Drawing.Size(129, 18);
            this.lblNome_chapa.TabIndex = 10;
            this.lblNome_chapa.Text = "Nome da Chapa";
            // 
            // grpControles
            // 
            this.grpControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.grpControles.Controls.Add(this.lblImagem_chapa);
            this.grpControles.Controls.Add(this.picImagem);
            this.grpControles.Controls.Add(this.btnCapturar);
            this.grpControles.Location = new System.Drawing.Point(410, 73);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(287, 367);
            this.grpControles.TabIndex = 7;
            this.grpControles.TabStop = false;
            // 
            // lblImagem_chapa
            // 
            this.lblImagem_chapa.AutoSize = true;
            this.lblImagem_chapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem_chapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImagem_chapa.Location = new System.Drawing.Point(98, 212);
            this.lblImagem_chapa.Name = "lblImagem_chapa";
            this.lblImagem_chapa.Size = new System.Drawing.Size(84, 15);
            this.lblImagem_chapa.TabIndex = 6;
            this.lblImagem_chapa.Text = "Logo Chapa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblTitulos);
            this.groupBox1.Location = new System.Drawing.Point(68, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulos
            // 
            this.lblTitulos.AutoSize = true;
            this.lblTitulos.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitulos.Location = new System.Drawing.Point(31, 16);
            this.lblTitulos.Name = "lblTitulos";
            this.lblTitulos.Size = new System.Drawing.Size(311, 33);
            this.lblTitulos.TabIndex = 10;
            this.lblTitulos.Text = "CADASTRE SUA CHAPA";
            // 
            // frmCriarChapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(759, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grpchapas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmCriarChapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Chapa";
            this.Load += new System.EventHandler(this.frmCriarChapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grpchapas.ResumeLayout(false);
            this.grpchapas.PerformLayout();
            this.grpControles.ResumeLayout(false);
            this.grpControles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox grpchapas;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome_chapa;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblImagem_chapa;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}