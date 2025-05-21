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
            dgvTarefas.Location = new Point(18, 171);
            dgvTarefas.Margin = new Padding(4, 5, 4, 5);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.RowHeadersWidth = 62;
            dgvTarefas.Size = new Size(707, 424);
            dgvTarefas.TabIndex = 0;
            dgvTarefas.CellDoubleClick += dgvTarefas_CellDoubleClick;
            dgvTarefas.CellEndEdit += dgvTarefas_CellEndEdit;
            dgvTarefas.CellFormatting += dgvTarefas_CellFormatting;
            // 
            // btnCriarT
            // 
            btnCriarT.Font = new Font("Arial Narrow", 12F);
            btnCriarT.Location = new Point(395, 114);
            btnCriarT.Margin = new Padding(4, 5, 4, 5);
            btnCriarT.Name = "btnCriarT";
            btnCriarT.Size = new Size(123, 47);
            btnCriarT.TabIndex = 1;
            btnCriarT.Text = "Criar tarefa";
            btnCriarT.UseVisualStyleBackColor = true;
            btnCriarT.Click += btnCriarT_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Arial Narrow", 12F);
            btnEditar.Location = new Point(733, 266);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(113, 47);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Arial Narrow", 12F);
            btnListar.Location = new Point(733, 194);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(113, 47);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Arial Narrow", 12F);
            btnExcluir.Location = new Point(733, 541);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(113, 47);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtCriarT
            // 
            txtCriarT.Location = new Point(41, 119);
            txtCriarT.Margin = new Padding(4, 5, 4, 5);
            txtCriarT.Name = "txtCriarT";
            txtCriarT.Size = new Size(327, 31);
            txtCriarT.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(0, 153, 173);
            lblLogin.Location = new Point(313, 18);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(219, 37);
            lblLogin.TabIndex = 14;
            lblLogin.Text = "Lista de Tarefas";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblLogin);
            Controls.Add(txtCriarT);
            Controls.Add(btnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnEditar);
            Controls.Add(btnCriarT);
            Controls.Add(dgvTarefas);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Home";
            Size = new Size(879, 728);
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
