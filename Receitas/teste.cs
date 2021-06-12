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
    public partial class teste : Form
    {
        private List<AddReceita> listaDados;
        public teste(List<AddReceita> dados)
        {
            InitializeComponent();
            listaDados = dados;
            dataGridView1.DataSource = dados;
        }

        private void teste_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = listaDados;
                    break;

                case 1:
                    dataGridView1.DataSource = listaDados.FindAll(x => x.Tipo == "Salgado");
                    break;

                case 2:
                    dataGridView1.DataSource = listaDados.FindAll(x => x.Tipo == "Doce");
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorGrid = dataGridView1.SelectedCells[0].Value.ToString();

            if (valorGrid == "Salgado") {
                comboBox1.SelectedIndex = 1;
            }
                
            else if (valorGrid == "Doce") { 
                comboBox1.SelectedIndex = 2;
            }
            else
            {
                Edicao editando = new Edicao(listaDados, valorGrid);
                editando.ShowDialog();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teste_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você deseja fechar suas receitas?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
