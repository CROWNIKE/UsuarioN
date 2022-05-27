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
            Cadastrodepessoas cadastrodepessoas = new Cadastrodepessoas(null);
            DialogResult resultado = cadastrodepessoas.ShowDialog(this);

            var usuarioId = cadastrodepessoas.Usuario.Id = 1;
            //A estrutura condicional if/else é um recurso que indica quais instruções
            //o sistema deve processar de acordo com uma expressão booleana.
            //Assim, o sistema testa se uma condição é verdadeira e então
            //executa comandos de acordo com esse resultado.
            if (resultado == DialogResult.OK)
            {

            
            if (listaDeUsuario.Count == 0)
            {
                cadastrodepessoas.Usuario.Id = usuarioId;
            }
            else
            {
                var ProximoId = listaDeUsuario.Last().Id + 1;
                cadastrodepessoas.Usuario.Id = ProximoId;

            }
            listaDeUsuario.Add(cadastrodepessoas.Usuario);
            listaUsuariosCadastrados.DataSource = null;
            listaUsuariosCadastrados.DataSource = listaDeUsuario;
            this.listaUsuariosCadastrados.Columns["Senha"].Visible = false;
            }

            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.listaUsuariosCadastrados.Columns["Senha"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Portanto, o bloco PHP try catch serve para que,
            //em um dado momento em que um código possa gerar um erro inesperado,
            //o programador consiga manipular as possibilidades e exceções.
            //Dessa forma, através do Try ele irá tentar executar o código, caso não ocorra nenhum erro,
            //o programa seguirá o seu fluxo normal.
            try
            {
                if(MessageBox.Show("Deseja realmente fechar o programa? ", "Aviso do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente fechar o programa? ", "Aviso do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                var indexSelecionado = listaUsuariosCadastrados.CurrentCell.RowIndex;
                var usuarioSelecionado = listaUsuariosCadastrados.Rows[indexSelecionado].DataBoundItem as Usuario;


                var cadastrodepessoas = new Cadastrodepessoas(usuarioSelecionado);
                DialogResult resultado = cadastrodepessoas.ShowDialog(this);

                listaUsuariosCadastrados.DataSource = null;
                listaUsuariosCadastrados.DataSource = listaDeUsuario;


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
          
            listaUsuariosCadastrados.DataSource = null;
            listaUsuariosCadastrados.DataSource = listaDeUsuario;
            this.listaUsuariosCadastrados.Columns["Senha"].Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Deseja realmente Excluir esse Usuario? ", "Aviso do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            }
            catch (Exception)
            {

                throw;
            }
            
            
            
            try
            
            {
               
                    var indexSelecionado = listaUsuariosCadastrados.CurrentCell.RowIndex;
                var usuarioSelecionado = listaUsuariosCadastrados.Rows[indexSelecionado].DataBoundItem as Usuario;


                listaDeUsuario.Remove(usuarioSelecionado);

                listaUsuariosCadastrados.DataSource = null;
                listaUsuariosCadastrados.DataSource = listaDeUsuario;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}