using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestaoDePessoas
{
    public partial class Cadastrodepessoas : Form
    {
        public Usuario Usuario { get; set; }
        
        //Criando o usuario.

        public Cadastrodepessoas(Usuario linha)
        {
            //Salvando Usuario
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
            //linha id recebe a informação inserida e manda pra caixa id e assim por diante.
            caixaId.Text = linha.Id.ToString();
            caixaNome.Text = linha.Nome;
            caixaSenha.Text = linha.Senha;
            caixaEmail.Text = linha.Email;
            caixaNascimento.Text = linha.DataNascimento;
            caixacriacao.Text = linha.DataCriacao;
        }

        private void OK_Click(object sender, EventArgs e)
        {   //pega a informação inseriada na caixaNome e etc para inserir no Usuario.nome e etc...
            try
            {
                if (MessageBox.Show.("Deseja adicionar esse Usuario");
            }
            catch (Exception)
            {

                throw;
            }

            Usuario.Nome = caixaNome.Text;
            if (caixaNome.Text == "")
            {   //messagebox insere a mensagem e executar a função
                MessageBox.Show("Campo Nome, Obrigatório!");
                return;
            }
            Usuario.Senha = caixaSenha.Text;
            if (caixaSenha.Text =="")
            {
                MessageBox.Show("Campo Senha, Obrigatório!");
                return;
            }
            
            Usuario.Email = caixaEmail.Text;


            string email = caixaEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            
            if (match.Success)
            {
                Usuario.Email = caixaEmail.Text;
            }
            else
            {
                MessageBox.Show("Email está incorreto!");
                return ;
            }
            
               
            Usuario.DataNascimento = caixaNascimento.Text;
            Usuario.DataCriacao = caixacriacao.Text;

            DialogResult =  DialogResult.OK;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();       
        }

        

       

}





   
   
       
        
    
}
