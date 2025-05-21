namespace ListaDeTarefas.UserControls
{
    partial class UC_Cadastro
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
            pbOculto = new PictureBox();
            pbVisivel = new PictureBox();
            pictureBox1 = new PictureBox();
            lblSenha = new Label();
            lblEmail = new Label();
            txtEmailC = new TextBox();
            lblLogin = new Label();
            linkLogin = new LinkLabel();
            btnCadastrar = new Button();
            lblNomeUser = new Label();
            txtNomeUsuario = new TextBox();
            txtSenhaC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbOculto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbOculto
            // 
            pbOculto.Cursor = Cursors.Hand;
            pbOculto.Image = Properties.Resources.icons8_cego_64;
            pbOculto.Location = new Point(523, 227);
            pbOculto.Name = "pbOculto";
            pbOculto.Size = new Size(35, 33);
            pbOculto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOculto.TabIndex = 20;
            pbOculto.TabStop = false;
            pbOculto.Click += pbOculto_Click;
            // 
            // pbVisivel
            // 
            pbVisivel.Cursor = Cursors.Hand;
            pbVisivel.Image = Properties.Resources.icons8_visível_50;
            pbVisivel.Location = new Point(523, 227);
            pbVisivel.Name = "pbVisivel";
            pbVisivel.Size = new Size(35, 33);
            pbVisivel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVisivel.TabIndex = 19;
            pbVisivel.TabStop = false;
            pbVisivel.Click += pbVisivel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lista_de_tarefas__1_;
            pictureBox1.Location = new Point(42, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(304, 234);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 20);
            lblSenha.TabIndex = 16;
            lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(304, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // txtEmailC
            // 
            txtEmailC.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailC.Location = new Point(358, 188);
            txtEmailC.Name = "txtEmailC";
            txtEmailC.Size = new Size(159, 26);
            txtEmailC.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(0, 153, 173);
            lblLogin.Location = new Point(319, 45);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(239, 43);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Crie sua conta!";
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Arial Narrow", 12F);
            linkLogin.LinkColor = Color.FromArgb(0, 153, 173);
            linkLogin.Location = new Point(368, 336);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(137, 20);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Já possuo uma conta";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(0, 153, 173);
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(378, 298);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 35);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUser.Location = new Point(304, 139);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(49, 20);
            lblNomeUser.TabIndex = 23;
            lblNomeUser.Text = "Nome:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(358, 136);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(159, 26);
            txtNomeUsuario.TabIndex = 1;
            // 
            // txtSenhaC
            // 
            txtSenhaC.Location = new Point(358, 234);
            txtSenhaC.Name = "txtSenhaC";
            txtSenhaC.Size = new Size(159, 23);
            txtSenhaC.TabIndex = 3;
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSenhaC);
            Controls.Add(lblNomeUser);
            Controls.Add(txtNomeUsuario);
            Controls.Add(pbOculto);
            Controls.Add(pbVisivel);
            Controls.Add(pictureBox1);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmailC);
            Controls.Add(lblLogin);
            Controls.Add(linkLogin);
            Controls.Add(btnCadastrar);
            Name = "UC_Cadastro";
            Size = new Size(615, 437);
            ((System.ComponentModel.ISupportInitialize)pbOculto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisivel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkFgtPwd;
        private PictureBox pbOculto;
        private PictureBox pbVisivel;
        private PictureBox pictureBox1;
        private TextBox txtSenhaL;
        private Label lblSenha;
        private Label lblEmail;
        private TextBox txtEmailC;
        private Label lblLogin;
        private LinkLabel linkLogin;
        private Button btnCadastrar;
        private Label lblNomeUser;
        private TextBox txtNomeUsuario;
        private TextBox txtSenhaC;
    }
}
