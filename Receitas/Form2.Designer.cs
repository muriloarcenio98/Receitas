
namespace Receitas
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelTituloReceita = new System.Windows.Forms.Label();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtMododePreparo = new System.Windows.Forms.TextBox();
            this.labelPreparo = new System.Windows.Forms.Label();
            this.labelIngrediente = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.criacao = new System.Windows.Forms.Label();
            this.horaCriacao = new System.Windows.Forms.Label();
            this.edicao = new System.Windows.Forms.Label();
            this.horaEdicao = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.referencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(311, 503);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelTituloReceita
            // 
            this.labelTituloReceita.AutoSize = true;
            this.labelTituloReceita.Location = new System.Drawing.Point(168, 33);
            this.labelTituloReceita.Name = "labelTituloReceita";
            this.labelTituloReceita.Size = new System.Drawing.Size(147, 15);
            this.labelTituloReceita.TabIndex = 13;
            this.labelTituloReceita.Text = "Titulo da Sua Nova Receita";
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.Location = new System.Drawing.Point(40, 62);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(404, 23);
            this.txtNomeReceita.TabIndex = 1;
            this.txtNomeReceita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(40, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(40, 107);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(404, 137);
            this.txtIngredientes.TabIndex = 2;
            // 
            // txtMododePreparo
            // 
            this.txtMododePreparo.Location = new System.Drawing.Point(39, 266);
            this.txtMododePreparo.Multiline = true;
            this.txtMododePreparo.Name = "txtMododePreparo";
            this.txtMododePreparo.Size = new System.Drawing.Size(404, 154);
            this.txtMododePreparo.TabIndex = 3;
            // 
            // labelPreparo
            // 
            this.labelPreparo.AutoSize = true;
            this.labelPreparo.Location = new System.Drawing.Point(56, 247);
            this.labelPreparo.Name = "labelPreparo";
            this.labelPreparo.Size = new System.Drawing.Size(99, 15);
            this.labelPreparo.TabIndex = 15;
            this.labelPreparo.Text = "Modo de Preparo";
            // 
            // labelIngrediente
            // 
            this.labelIngrediente.AutoSize = true;
            this.labelIngrediente.Location = new System.Drawing.Point(56, 88);
            this.labelIngrediente.Name = "labelIngrediente";
            this.labelIngrediente.Size = new System.Drawing.Size(72, 15);
            this.labelIngrediente.TabIndex = 14;
            this.labelIngrediente.Text = "Ingredientes";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(40, 444);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(404, 53);
            this.txtObservacao.TabIndex = 4;
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(57, 424);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(77, 15);
            this.labelObservacao.TabIndex = 16;
            this.labelObservacao.Text = "Observações ";
            // 
            // criacao
            // 
            this.criacao.AutoSize = true;
            this.criacao.Location = new System.Drawing.Point(40, 6);
            this.criacao.Name = "criacao";
            this.criacao.Size = new System.Drawing.Size(53, 15);
            this.criacao.TabIndex = 9;
            this.criacao.Text = "Criação: ";
            // 
            // horaCriacao
            // 
            this.horaCriacao.AutoSize = true;
            this.horaCriacao.Location = new System.Drawing.Point(96, 6);
            this.horaCriacao.Name = "horaCriacao";
            this.horaCriacao.Size = new System.Drawing.Size(0, 15);
            this.horaCriacao.TabIndex = 10;
            // 
            // edicao
            // 
            this.edicao.AutoSize = true;
            this.edicao.Location = new System.Drawing.Point(258, 6);
            this.edicao.Name = "edicao";
            this.edicao.Size = new System.Drawing.Size(48, 15);
            this.edicao.TabIndex = 11;
            this.edicao.Text = "Edição: ";
            // 
            // horaEdicao
            // 
            this.horaEdicao.AutoSize = true;
            this.horaEdicao.Location = new System.Drawing.Point(310, 6);
            this.horaEdicao.Name = "horaEdicao";
            this.horaEdicao.Size = new System.Drawing.Size(0, 15);
            this.horaEdicao.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(189, 503);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Doce";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(189, 526);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Salgado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // referencia
            // 
            this.referencia.AutoSize = true;
            this.referencia.Location = new System.Drawing.Point(234, 517);
            this.referencia.Name = "referencia";
            this.referencia.Size = new System.Drawing.Size(0, 15);
            this.referencia.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 549);
            this.Controls.Add(this.referencia);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.edicao);
            this.Controls.Add(this.horaEdicao);
            this.Controls.Add(this.horaCriacao);
            this.Controls.Add(this.criacao);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.labelIngrediente);
            this.Controls.Add(this.labelPreparo);
            this.Controls.Add(this.txtMododePreparo);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.labelTituloReceita);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Adicionando Nova Receita";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelTituloReceita;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtMododePreparo;
        private System.Windows.Forms.Label labelPreparo;
        private System.Windows.Forms.Label labelIngrediente;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.Label criacao;
        private System.Windows.Forms.Label horaCriacao;
        private System.Windows.Forms.Label edicao;
        private System.Windows.Forms.Label horaEdicao;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label referencia;
    }
}