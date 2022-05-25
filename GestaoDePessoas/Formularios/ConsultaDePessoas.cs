using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoDePessoas.Formularios
{
    public partial class ListadeUsuarios : Form
    {   //Representa uma lista fortemente tipada de objetos que podem ser acessados por índice.
        //Fornece métodos para pesquisar, classificar e manipular listas.
        public List<Usuario> listaDeUsuario { get; set; }
        //Os construtores são tipos especiais de métodos usados ​​para criar e inicializar objetos.
        //É através deste tipo especial de método, chamado de construtor, que você cria instâncias de uma classe.
        public ListadeUsuarios()
        {
            InitializeComponent();
            listaDeUsuario = new List<Usuario>();

        }
        //Representa um controle de botão do Windows.
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cadastrodepessoas Cadastrodepessoas = new Cadastrodepessoas(null);
            DialogResult resultado = Cadastrodepessoas.ShowDialog(this);

            var usuarioId = Cadastrodepessoas.Usuario.Id = 1;
            //A estrutura condicional if/else é um recurso que indica quais instruções
            //o sistema deve processar de acordo com uma expressão booleana.
            //Assim, o sistema testa se uma condição é verdadeira e então
            //executa comandos de acordo com esse resultado.
            if (resultado == DialogResult.OK)
            {

            
            if (listaDeUsuario.Count == 0)
            {
                Cadastrodepessoas.Usuario.Id = usuarioId;
            }
            else
            {
                var ProximoId = listaDeUsuario.Last().Id + 1;
                Cadastrodepessoas.Usuario.Id = ProximoId;

            }
            listaDeUsuario.Add(Cadastrodepessoas.Usuario);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaDeUsuario;
            }

            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciei a tela para abrir o novo formulário
                Cadastrodepessoas Cadastrodepessoas = new Cadastrodepessoas(null);
                DialogResult resultado = Cadastrodepessoas.ShowDialog(this);

                //Criar um construtor para puxar informações para tela
                
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

           
        }
    }
}