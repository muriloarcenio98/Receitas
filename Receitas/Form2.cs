using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Receitas
{
    public partial class Form2 : Form
    {
        public AddReceita NovaReceita = null;
        bool ativo = true;
        private List<AddReceita> ListaDados;
        public Form2(List<AddReceita> dados)
        {
            InitializeComponent();
            ListaDados = dados;
            //Aqui eu coloco a barra lateral no texbox
            txtIngredientes.ScrollBars = ScrollBars.Both;
            txtMododePreparo.ScrollBars = ScrollBars.Both;
            txtObservacao.ScrollBars = ScrollBars.Both;
            //Pegando a hora do sistema
            DateTime time = DateTime.Now;
            string hora = time.ToString();
            //controle para salvar o horario

                horaCriacao.Text = hora;
                edicao.Visible = false;
                horaEdicao.Visible = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sair do cadastro de receitas
            bool teste = MessageBox.Show("Você não salvou sua receita", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Cancel;
            if (teste == false)
            {
                ativo = false;
                Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //saindo do cadastro de receitas pelo x
            if (ativo == true)
            {
                if (MessageBox.Show("Você não salvou sua receita", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificando se os text estão certos
            errorProvider1.Clear();
            bool erro = false;
            if(txtNomeReceita.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNomeReceita, "Toda receita tem um nome. Futuramente você vai encontrala no seu livro de receitas pelo nome");
                erro = true;
            }
            for (int i = 0; i < ListaDados.Count; i++)
            {
                if (txtNomeReceita.Text.Trim() == ListaDados[i].Nome)
                {
                    errorProvider1.SetError(txtNomeReceita, "Já existe uma receita com esse nome");
                    erro = true;
                }
            }
            
            if (txtIngredientes.Text.Trim() == "")
            {
                errorProvider1.SetError(txtIngredientes, "Você precisa colocar os ingredientes. Sem eles, não tem como reproduzir a receita");
                erro = true;
            }
            if (txtMododePreparo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMododePreparo, "Toda receia um ordem de colocar os ingredientes. O que fazer com cada um. E como finalizar o prato");
                erro = true;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                errorProvider1.SetError(referencia, "Aqual o tipo do prato?");
                erro = true;
            }
            if (erro == false)
            {
                //Podemos continuar o dodigo daqui
 
                    //Preenchimento Manualmente a 1 Receita
                    AddReceita novaReceita = new AddReceita();
                    novaReceita.Nome = txtNomeReceita.Text.Trim();

                    string Ingrediente = txtIngredientes.Text.Trim();
                    novaReceita.Ingrediente = Ingrediente.Replace("\r\n", ";");

                    string Preparo = txtMododePreparo.Text.Trim();
                    novaReceita.Preparo = Preparo.Replace("\r\n", ";");

                    string Observacao = txtObservacao.Text.Trim();
                    novaReceita.Observacao = Observacao.Replace("\r\n", ";");

                    novaReceita.Criacao = horaCriacao.Text;

                    if (radioButton1.Checked)
                        novaReceita.Tipo = "Doce";
                    else
                        novaReceita.Tipo = "Salgado";

                    NovaReceita = novaReceita;
                    //Fechar sem passar pela tratativa de erro
                    MessageBox.Show("Receita Salva com Sucesso", "Boas Noticias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ativo = false;
                    Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
