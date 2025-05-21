namespace ListaDeTarefas.UserControls
{
    partial class UC_Login
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
            btnLogin = new Button();
            linkCadastrar = new LinkLabel();
            lblLogin = new Label();
            txtEmailL = new TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            txtSenhaL = new TextBox();
            pictureBox1 = new PictureBox();
            pbVisivel = new PictureBox();
            pbOculto = new PictureBox();
            linkFgtPwd = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOculto).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 153, 173);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(374, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Font = new Font("Arial Narrow", 12F);
            linkCadastrar.LinkColor = Color.FromArgb(0, 153, 173);
            linkCadastrar.Location = new Point(400, 320);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(65, 20);
            linkCadastrar.TabIndex = 5;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastrar";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(0, 153, 173);
            lblLogin.Location = new Point(375, 64);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(111, 43);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Log In";
            // 
            // txtEmailL
            // 
            txtEmailL.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailL.Location = new Point(356, 139);
            txtEmailL.Name = "txtEmailL";
            txtEmailL.Size = new Size(159, 26);
            txtEmailL.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(302, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(302, 196);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // txtSenhaL
            // 
            txtSenhaL.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaL.Location = new Point(356, 193);
            txtSenhaL.Name = "txtSenhaL";
            txtSenhaL.Size = new Size(159, 26);
            txtSenhaL.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lista_de_tarefas__1_;
            pictureBox1.Location = new Point(31, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pbVisivel
            // 
            pbVisivel.Cursor = Cursors.Hand;
            pbVisivel.Image = Properties.Resources.icons8_visível_50;
            pbVisivel.Location = new Point(521, 188);
            pbVisivel.Name = "pbVisivel";
            pbVisivel.Size = new Size(35, 33);
            pbVisivel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVisivel.TabIndex = 8;
            pbVisivel.TabStop = false;
            pbVisivel.Click += pbVisivel_Click;
            // 
            // pbOculto
            // 
            pbOculto.Cursor = Cursors.Hand;
            pbOculto.Image = Properties.Resources.icons8_cego_64;
            pbOculto.Location = new Point(521, 188);
            pbOculto.Name = "pbOculto";
            pbOculto.Size = new Size(35, 33);
            pbOculto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOculto.TabIndex = 9;
            pbOculto.TabStop = false;
            pbOculto.Click += pbOculto_Click;
            // 
            // linkFgtPwd
            // 
            linkFgtPwd.AutoSize = true;
            linkFgtPwd.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkFgtPwd.LinkColor = Color.FromArgb(0, 153, 173);
            linkFgtPwd.Location = new Point(356, 221);
            linkFgtPwd.Name = "linkFgtPwd";
            linkFgtPwd.Size = new Size(101, 20);
            linkFgtPwd.TabIndex = 4;
            linkFgtPwd.TabStop = true;
            linkFgtPwd.Text = "Esqueci a senha";
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkFgtPwd);
            Controls.Add(pbOculto);
            Controls.Add(pbVisivel);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenhaL);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmailL);
            Controls.Add(lblLogin);
            Controls.Add(linkCadastrar);
            Controls.Add(btnLogin);
            Name = "UC_Login";
            Size = new Size(615, 437);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisivel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOculto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private LinkLabel linkCadastrar;
        private Label lblLogin;
        private TextBox txtEmailL;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtSenhaL;
        private PictureBox pictureBox1;
        private PictureBox pbVisivel;
        private PictureBox pbOculto;
        private LinkLabel linkFgtPwd;
    }
}
