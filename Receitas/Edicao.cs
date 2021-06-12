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
    public partial class Edicao : Form
    {
        bool ativo = true;
        private List<AddReceita> ListaDados;
        private string salvar;
        public Edicao(List<AddReceita> dados,string nome)
        {
            InitializeComponent();
            ListaDados = dados;
            salvar = nome;
            for (int i = 0; i < ListaDados.Count; i++)
            {//Adicionando os dados ao 
                if(String.Equals(ListaDados[i].Nome, nome))
                {
                    txtNomeReceita.Text = ListaDados[i].Nome;
                    string arrumando = ListaDados[i].Ingrediente;
                    txtIngredientes.Text = arrumando.Replace(";", "\r\n");
                    arrumando = ListaDados[i].Preparo;
                    txtMododePreparo.Text = arrumando.Replace(";", "\r\n");
                    arrumando = ListaDados[i].Observacao;
                    txtObservacao.Text = arrumando.Replace(";", "\r\n");
                    if (ListaDados[i].Tipo == "Doce")
                    {
                        radioButton1.Select();
                    }
                    else
                    {
                        radioButton2.Select();
                    }
                    horaCriacao.Text = ListaDados[i].Criacao;
                }   
            }
            //=================================================================================================
            //Aqui eu coloco a barra lateral no texbox
            txtIngredientes.ScrollBars = ScrollBars.Both;
            txtMododePreparo.ScrollBars = ScrollBars.Both;
            txtObservacao.ScrollBars = ScrollBars.Both;
            //Pegando a hora do sistema
            DateTime time = DateTime.Now;
            string hora = time.ToString();
            //controle para salvar o horario
            txtNomeReceita.Enabled = false;
            horaEdicao.Text = hora;
        }

        private void Edicao_Load(object sender, EventArgs e)
        {

        }

        private void btncompartilhar_Click(object sender, EventArgs e)
        {
            //compartilhar
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "Texto|*.txt";
                salvar.Title = "Banco de Dados";
                DialogResult salvando = salvar.ShowDialog();
                if (salvando != DialogResult.OK)
                    return;
                String caminho = salvar.FileName;
                StreamWriter escrever = new StreamWriter(caminho);
                    escrever.WriteLine("Titulo: " + txtNomeReceita.Text);
                    escrever.WriteLine("\nIngredientes: \n" + txtIngredientes.Text);
                    escrever.WriteLine("\nModo de Preparo: \n" + txtMododePreparo.Text);
                    escrever.WriteLine("\nObservação: \n" + txtObservacao.Text);
                    if (radioButton1.Checked)
                        escrever.WriteLine("\nTipo: " + "Doce");
                    else
                        escrever.WriteLine("\nTipo: " + "Salgado");

                    escrever.WriteLine("\nCriação: " + horaCriacao.Text);
                    escrever.WriteLine("\nEdição: " + horaEdicao.Text);

                escrever.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //salvar
            //Verificando se os text estão certos
            errorProvider1.Clear();
            bool erro = false;
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

                string Ingrediente = txtIngredientes.Text.Trim();
                novaReceita.Ingrediente = Ingrediente.Replace("\r\n", ";");

                string Preparo = txtMododePreparo.Text.Trim();
                novaReceita.Preparo = Preparo.Replace("\r\n", ";");

                string Observacao = txtObservacao.Text.Trim();
                novaReceita.Observacao = Observacao.Replace("\r\n", ";");

                novaReceita.Edicao = horaEdicao.Text;

                if (radioButton1.Checked)
                    novaReceita.Tipo = "Doce";
                else
                    novaReceita.Tipo = "Salgado";

                ativo = false;
                //salvar toda a lista no arquivo novamente
                for (int i = 0; i < ListaDados.Count; i++)
                {//Adicionando os dados ao 
                    if (String.Equals(ListaDados[i].Nome, salvar))
                    ListaDados[i].Ingrediente = novaReceita.Ingrediente;
                    ListaDados[i].Preparo = novaReceita.Preparo;
                    ListaDados[i].Observacao = novaReceita.Observacao;
                    ListaDados[i].Tipo = novaReceita.Tipo;
                    ListaDados[i].Edicao = horaEdicao.Text;
                }
                //=============================================================================
                if (File.Exists(@"Banco\banco.txt"))
                {
                    File.Delete(@"Banco\banco.txt");

                    string nome = "banco";


                    StreamWriter escrever = new StreamWriter("Banco/" + nome + ".txt");
                    for (int i = 0; i < ListaDados.Count; i++)
                    {
                        escrever.WriteLine(ListaDados[i].Nome);
                        escrever.WriteLine(ListaDados[i].Ingrediente);
                        escrever.WriteLine(ListaDados[i].Preparo);
                        escrever.WriteLine(ListaDados[i].Observacao);
                        escrever.WriteLine(ListaDados[i].Tipo);
                        escrever.WriteLine(ListaDados[i].Criacao);
                        escrever.WriteLine(ListaDados[i].Edicao);
                    }
                    escrever.Close();

                }
                    
                        //=============================================================================
                        //Fechar sem passar pela tratativa de erro
                    MessageBox.Show("Receita Atualizada com Sucesso", "Boas Noticias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ativo = false;
                    Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool teste = MessageBox.Show("Você não editou sua receita", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Cancel;
            if (teste == false)
            {
                ativo = false;
                Close();
            }
        }

        private void Edicao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ativo == true)
            {
                if (MessageBox.Show("Você deseja sair da tela de edção?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
