namespace WinFormsApp1
{
    partial class frmCadastro
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
            this.lbxNome = new System.Windows.Forms.ListBox();
            this.lbxTelefone = new System.Windows.Forms.ListBox();
            this.lbxCPF = new System.Windows.Forms.ListBox();
            this.lbxCategoria = new System.Windows.Forms.ListBox();
            this.btnNovaPessoa = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxNome
            // 
            this.lbxNome.FormattingEnabled = true;
            this.lbxNome.ItemHeight = 20;
            this.lbxNome.Location = new System.Drawing.Point(12, 45);
            this.lbxNome.Name = "lbxNome";
            this.lbxNome.Size = new System.Drawing.Size(175, 104);
            this.lbxNome.TabIndex = 0;
            // 
            // lbxTelefone
            // 
            this.lbxTelefone.FormattingEnabled = true;
            this.lbxTelefone.ItemHeight = 20;
            this.lbxTelefone.Location = new System.Drawing.Point(193, 45);
            this.lbxTelefone.Name = "lbxTelefone";
            this.lbxTelefone.Size = new System.Drawing.Size(141, 104);
            this.lbxTelefone.TabIndex = 1;
            // 
            // lbxCPF
            // 
            this.lbxCPF.FormattingEnabled = true;
            this.lbxCPF.ItemHeight = 20;
            this.lbxCPF.Location = new System.Drawing.Point(340, 45);
            this.lbxCPF.Name = "lbxCPF";
            this.lbxCPF.Size = new System.Drawing.Size(124, 104);
            this.lbxCPF.TabIndex = 2;
            // 
            // lbxCategoria
            // 
            this.lbxCategoria.FormattingEnabled = true;
            this.lbxCategoria.ItemHeight = 20;
            this.lbxCategoria.Location = new System.Drawing.Point(470, 45);
            this.lbxCategoria.Name = "lbxCategoria";
            this.lbxCategoria.Size = new System.Drawing.Size(101, 104);
            this.lbxCategoria.TabIndex = 3;
            // 
            // btnNovaPessoa
            // 
            this.btnNovaPessoa.Location = new System.Drawing.Point(659, 346);
            this.btnNovaPessoa.Name = "btnNovaPessoa";
            this.btnNovaPessoa.Size = new System.Drawing.Size(129, 92);
            this.btnNovaPessoa.TabIndex = 4;
            this.btnNovaPessoa.Text = "Criar Novo";
            this.btnNovaPessoa.UseVisualStyleBackColor = true;
            this.btnNovaPessoa.Click += new System.EventHandler(this.btnNovaPessoa_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Cliente",
            "Funcionário",
            "Fornecedor"});
            this.cbxCategoria.Location = new System.Drawing.Point(659, 300);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(129, 28);
            this.cbxCategoria.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnNovaPessoa);
            this.Controls.Add(this.lbxCategoria);
            this.Controls.Add(this.lbxCPF);
            this.Controls.Add(this.lbxTelefone);
            this.Controls.Add(this.lbxNome);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Activated += new System.EventHandler(this.frmCadastro_Enter);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.EnabledChanged += new System.EventHandler(this.frmCadastro_Enter);
            this.Enter += new System.EventHandler(this.frmCadastro_Enter);
            this.Validated += new System.EventHandler(this.frmCadastro_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxNome;
        private ListBox lbxTelefone;
        private ListBox lbxCPF;
        private ListBox lbxCategoria;
        private Button btnNovaPessoa;
        private ComboBox cbxCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}