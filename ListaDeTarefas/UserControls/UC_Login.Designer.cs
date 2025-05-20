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
            linkLabel1 = new LinkLabel();
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
            btnLogin.Location = new Point(399, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 35);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 12F);
            linkLabel1.LinkColor = Color.FromArgb(0, 153, 173);
            linkLabel1.Location = new Point(425, 329);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastrar";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(0, 153, 173);
            lblLogin.Location = new Point(407, 44);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(111, 43);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Log In";
            // 
            // txtEmailL
            // 
            txtEmailL.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailL.Location = new Point(380, 147);
            txtEmailL.Name = "txtEmailL";
            txtEmailL.Size = new Size(159, 26);
            txtEmailL.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(326, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(326, 204);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // txtSenhaL
            // 
            txtSenhaL.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaL.Location = new Point(380, 201);
            txtSenhaL.Name = "txtSenhaL";
            txtSenhaL.Size = new Size(159, 26);
            txtSenhaL.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lista_de_tarefas__1_;
            pictureBox1.Location = new Point(22, 82);
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
            pbVisivel.Location = new Point(545, 197);
            pbVisivel.Name = "pbVisivel";
            pbVisivel.Size = new Size(35, 33);
            pbVisivel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVisivel.TabIndex = 8;
            pbVisivel.TabStop = false;
            // 
            // pbOculto
            // 
            pbOculto.Cursor = Cursors.Hand;
            pbOculto.Image = Properties.Resources.icons8_cego_64;
            pbOculto.Location = new Point(545, 197);
            pbOculto.Name = "pbOculto";
            pbOculto.Size = new Size(35, 33);
            pbOculto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOculto.TabIndex = 9;
            pbOculto.TabStop = false;
            // 
            // linkFgtPwd
            // 
            linkFgtPwd.AutoSize = true;
            linkFgtPwd.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkFgtPwd.LinkColor = Color.FromArgb(0, 153, 173);
            linkFgtPwd.Location = new Point(380, 229);
            linkFgtPwd.Name = "linkFgtPwd";
            linkFgtPwd.Size = new Size(101, 20);
            linkFgtPwd.TabIndex = 10;
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
            Controls.Add(linkLabel1);
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
        private LinkLabel linkLabel1;
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
