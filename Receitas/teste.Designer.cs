
namespace Receitas
{
    partial class teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preparo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criacao,
            this.Edicao,
            this.Ingrediente,
            this.Preparo,
            this.Observacao,
            this.Nome,
            this.Tipo});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(-41, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(607, 289);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Criacao
            // 
            this.Criacao.DataPropertyName = "Criacao";
            this.Criacao.HeaderText = "Criacao";
            this.Criacao.Name = "Criacao";
            this.Criacao.ReadOnly = true;
            this.Criacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Criacao.Visible = false;
            // 
            // Edicao
            // 
            this.Edicao.DataPropertyName = "Edicao";
            this.Edicao.HeaderText = "Edicao";
            this.Edicao.Name = "Edicao";
            this.Edicao.ReadOnly = true;
            this.Edicao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edicao.Visible = false;
            // 
            // Ingrediente
            // 
            this.Ingrediente.DataPropertyName = "Ingrediente";
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.ReadOnly = true;
            this.Ingrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ingrediente.Visible = false;
            // 
            // Preparo
            // 
            this.Preparo.DataPropertyName = "Preparo";
            this.Preparo.HeaderText = "Preparo";
            this.Preparo.Name = "Preparo";
            this.Preparo.ReadOnly = true;
            this.Preparo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Preparo.Visible = false;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.HeaderText = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            this.Observacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observacao.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Receitas";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.FillWeight = 30F;
            this.Tipo.HeaderText = "Tipo da Receita";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Salgados",
            "Doces"});
            this.comboBox1.Location = new System.Drawing.Point(12, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(539, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 330);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "teste";
            this.Text = "Listagem de Receitas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.teste_FormClosing);
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preparo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}