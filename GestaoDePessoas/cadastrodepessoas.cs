using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestaoDePessoas
{
    public partial class Cadastrodepessoas : Form
    {
        public Usuario Usuario { get; set; }

        public Cadastrodepessoas(Usuario linha)
        {
            InitializeComponent();
            caixacriacao.Enabled = false;
            caixaId.Enabled = false;

            if (linha == null)
            {
                Usuario = new Usuario();
            }
            else
            {
                Usuario = linha;
                PreencherDados(linha);
            }
        }

        private void PreencherDados(Usuario linha)
        {
            caixaId.Text = linha.Id.ToString();
            caixaNome.Text = linha.Nome;
            caixaSenha.Text = linha.Senha;
            caixaEmail.Text = linha.Email;
            caixaNascimento.Text = linha.DataNascimento;
            caixacriacao.Text = linha.DataCriacao;
        }

        private void AoClicarEmOK(object sender, EventArgs e)
        {
            Usuario.Nome = caixaNome.Text;
            if (caixaNome.Text == "")
            {
                MessageBox.Show("Campo Nome, Obrigatório!");
                return;
            }
            Usuario.Senha = caixaSenha.Text;
            if (caixaSenha.Text == "")
            {
                MessageBox.Show("Campo Senha, Obrigatório!");
                return;
            }

            Usuario.Email = caixaEmail.Text;

            var email = caixaEmail.Text;
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match(email);

            if (match.Success)
            {
                Usuario.Email = caixaEmail.Text;
            }
            else
            {
                MessageBox.Show("Email está incorreto!");
                return;
            }

            Usuario.DataNascimento = caixaNascimento.Text;
            Usuario.DataCriacao = caixacriacao.Text;

            DialogResult = DialogResult.OK;
        }

        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            Close();
        }
    }
}
