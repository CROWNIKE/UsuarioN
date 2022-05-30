using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoDePessoas.Formularios
{
    public partial class ListadeUsuarios : Form
    {
        public List<Usuario> listaDeUsuario { get; set; }

        public ListadeUsuarios()
        {
            InitializeComponent();
            listaDeUsuario = new List<Usuario>();
        }

        private void AoClicarEmNovo(object sender, EventArgs e)
        {
            var cadastrodepessoas = new Cadastrodepessoas(null);
            var resultado = cadastrodepessoas.ShowDialog(this);
            var usuarioId = cadastrodepessoas.Usuario.Id = 1;

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

        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            try
            {
                if (DeveFecharPrograma())
                {
                    Close();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show($"erro inesperado \n {ax.Message}");
            }
        }

        public bool DeveFecharPrograma()
        {
            return MessageBox.Show("Deseja realmente fechar o programa? ", "Aviso do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void AoClicarEmOK(object sender, EventArgs e)
        {
            try
            {
                if (DeveFecharPrograma())
                {
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado");
            }
        }

        private void AoClicarEmEditar(object sender, EventArgs e)
        {
            try
            {
                var indexSelecionado = listaUsuariosCadastrados.CurrentCell.RowIndex;
                var usuarioSelecionado = listaUsuariosCadastrados.Rows[indexSelecionado].DataBoundItem as Usuario;

                var cadastrodepessoas = new Cadastrodepessoas(usuarioSelecionado);
                var resultado = cadastrodepessoas.ShowDialog(this);

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

        private void AoClicaEmExcluir(object sender, EventArgs e)
        {
            try
            {
                if(DeveExcluirUsuario())
                {
                    var indexSelecionado = listaUsuariosCadastrados.CurrentCell.RowIndex;
                    var usuarioSelecionado = listaUsuariosCadastrados.Rows[indexSelecionado].DataBoundItem as Usuario;
                    listaDeUsuario.Remove(usuarioSelecionado);

                    listaUsuariosCadastrados.DataSource = null;
                    listaUsuariosCadastrados.DataSource = listaDeUsuario;
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"erro inesperado \n {ex.Message}");
            }
        }

        public bool DeveExcluirUsuario()
        {
            return MessageBox.Show("Deseja realmente Excluir esse Usuario? ", "Aviso do sistema",
                MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}