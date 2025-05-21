namespace ListaDeTarefas
{
    partial class Conteudo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteudo));
            navBar = new Panel();
            btnMinimizar = new PictureBox();
            btnFechar = new PictureBox();
            panelCentral = new Panel();
            pictureBox1 = new PictureBox();
            navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // navBar
            // 
            navBar.BackColor = Color.FromArgb(0, 153, 173);
            navBar.Controls.Add(pictureBox1);
            navBar.Controls.Add(btnMinimizar);
            navBar.Controls.Add(btnFechar);
            navBar.Dock = DockStyle.Top;
            navBar.Location = new Point(0, 0);
            navBar.Name = "navBar";
            navBar.Size = new Size(615, 41);
            navBar.TabIndex = 0;
            navBar.MouseDown += navBar_MouseDown;
            navBar.MouseMove += navBar_MouseMove;
            navBar.MouseUp += navBar_MouseUp;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.icons8_linha_horizontal_50;
            btnMinimizar.Location = new Point(535, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 32);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Image = Properties.Resources.icons8_excluir_50;
            btnFechar.Location = new Point(576, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 32);
            btnFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFechar.TabIndex = 0;
            btnFechar.TabStop = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panelCentral
            // 
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 41);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(615, 437);
            panelCentral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lista_de_tarefas__1_;
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Conteudo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 478);
            Controls.Add(panelCentral);
            Controls.Add(navBar);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Conteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conteudo";
            Load += Conteudo_Load;
            navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navBar;
        private PictureBox btnMinimizar;
        private PictureBox btnFechar;
        private Panel panelCentral;
        private PictureBox pictureBox1;
    }
}
