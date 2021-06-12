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
    public partial class Form1 : Form
    {
        //craindo lista
        private List<AddReceita> dados = new List<AddReceita>();

        public Form1()
        {
            InitializeComponent();

            //carregando lista
            if (File.Exists(@"Banco\banco.txt"))
            {
                string[] array = File.ReadAllLines(@"Banco\banco.txt", Encoding.Default);
                int controle = 0;
                for (int i = 0; i < array.Length; i += 7) //tratando erro.. ele gerava muita lista repetida... então usei 2 contadores. mas como precisava do contador em cima
                {//para não adicionar mais linhas. deixcei ele contando normalmente, e todos que vem ele pula a quantidade da lista
                    AddReceita adicionando = new AddReceita();
                    adicionando.Nome = array[controle]; controle++;
                    adicionando.Ingrediente = array[controle]; controle++;
                    adicionando.Preparo = array[controle]; controle++;
                    adicionando.Observacao = array[controle]; controle++;
                    adicionando.Tipo = array[controle]; controle++;
                    adicionando.Criacao = array[controle]; controle++;
                    adicionando.Edicao = array[controle]; controle++;
                    dados.Add(adicionando);
                }
                
            }
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //Minhas Receitas
           teste chamar = new teste(dados);
           chamar.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar Minhas Receitas?", "Alerta", MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Novas Receitas
            Form2 chamar = new Form2(dados);
            chamar.ShowDialog();
            string nome = "banco";
            if (chamar.NovaReceita != null)
            {
                dados.Add(chamar.NovaReceita);

                StreamWriter escrever = new StreamWriter("Banco/" + nome + ".txt");
                for (int i = 0; i < dados.Count; i++)
                {
                    escrever.WriteLine(dados[i].Nome);
                    escrever.WriteLine(dados[i].Ingrediente);
                    escrever.WriteLine(dados[i].Preparo);
                    escrever.WriteLine(dados[i].Observacao);
                    escrever.WriteLine(dados[i].Tipo);
                    escrever.WriteLine(dados[i].Criacao);
                    escrever.WriteLine(dados[i].Edicao);
                }
                escrever.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            {
                if (MessageBox.Show("Já vai?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
