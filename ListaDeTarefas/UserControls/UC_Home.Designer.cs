namespace ListaDeTarefas.UserControls
{
    partial class UC_Home
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
            dgvTarefas = new DataGridView();
            btnCriarT = new Button();
            btnEditar = new Button();
            btnListar = new Button();
            btnExcluir = new Button();
            txtCriarT = new TextBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // dgvTarefas
            // 
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Location = new Point(13, 103);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.RowHeadersWidth = 62;
            dgvTarefas.Size = new Size(495, 254);
            dgvTarefas.TabIndex = 0;
            dgvTarefas.CellDoubleClick += dgvTarefas_CellDoubleClick;
            dgvTarefas.CellEndEdit += dgvTarefas_CellEndEdit;
            dgvTarefas.CellFormatting += dgvTarefas_CellFormatting;
            // 
            // btnCriarT
            // 
            btnCriarT.Font = new Font("Microsoft Sans Serif", 12F);
            btnCriarT.Location = new Point(276, 68);
            btnCriarT.Name = "btnCriarT";
            btnCriarT.Size = new Size(86, 28);
            btnCriarT.TabIndex = 1;
            btnCriarT.Text = "Criar tarefa";
            btnCriarT.UseVisualStyleBackColor = true;
            btnCriarT.Click += btnCriarT_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEditar.Location = new Point(513, 160);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 28);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Microsoft Sans Serif", 12F);
            btnListar.Location = new Point(513, 116);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(79, 28);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft Sans Serif", 12F);
            btnExcluir.Location = new Point(513, 325);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 28);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtCriarT
            // 
            txtCriarT.Location = new Point(29, 71);
            txtCriarT.Name = "txtCriarT";
            txtCriarT.Size = new Size(230, 23);
            txtCriarT.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(0, 153, 173);
            lblLogin.Location = new Point(219, 11);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(182, 26);
            lblLogin.TabIndex = 14;
            lblLogin.Text = "Lista de Tarefas";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblLogin);
            Controls.Add(txtCriarT);
            Controls.Add(btnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnEditar);
            Controls.Add(btnCriarT);
            Controls.Add(dgvTarefas);
            Name = "UC_Home";
            Size = new Size(615, 437);
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTarefas;
        private Button btnCriarT;
        private Button btnEditar;
        private Button btnListar;
        private Button btnExcluir;
        private TextBox txtCriarT;
        private Label lblLogin;
        private PictureBox pictureBox1;
    }
}
