using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoDePessoas.Formularios
{
    public partial class ConsultaDePessoas : Form
    {
        private DialogResult resultado;

        public List<Usuario> Usuario { get; set; }
        public ConsultaDePessoas()
        {
            InitializeComponent();

            Usuario = new List<Usuario>();

            //eu quero formatar a grid primeiro, criar as colunas.
            CriarColunasDaGrid();
        }

        private void CriarColunasDaGrid()
        {
            listaDePessoasGrid.Columns.Add("id", "Id");
            listaDePessoasGrid.Columns.Add("nome", "Nome");
            listaDePessoasGrid.Columns.Add("senha", "Senha");
            listaDePessoasGrid.Columns.Add("email", "Email");
            listaDePessoasGrid.Columns.Add("data aniversario", "Data Aniversario");
            listaDePessoasGrid.Columns.Add("data criacao", "Data Criacao");





        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            cadastrodepessoas cadastrodepessoas = new cadastrodepessoas();
            cadastrodepessoas.ShowDialog();

        }

        private void button3_Click(object sender, System.EventArgs e)
        {

            cadastrodepessoas cadastrodepessoas = new cadastrodepessoas();
            cadastrodepessoas.ShowDialog();
        }
    }
}
