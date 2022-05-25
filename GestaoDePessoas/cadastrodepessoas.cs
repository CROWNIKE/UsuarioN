using System;
using System.Windows.Forms;

namespace GestaoDePessoas
{
    public partial class Cadastrodepessoas : Form
    {
        
        public Usuario Usuario { get; set; }
        


         public Cadastrodepessoas(Usuario usuario)
         {
            //Salvando Usuario
            InitializeComponent();
            caixacriacao.Enabled = false;
            caixaId.Enabled = false;

            if (usuario == null)
            {
                Usuario = new Usuario();
            }
            else
            {
                Usuario = usuario;
            }

         }

       

        private void OK_Click(object sender, EventArgs e)
        {   //pega a informação inseriada na caixaNome e etc para inserir no Usuario.nome e etc...


            Usuario.Nome = caixaNome.Text;
            if (caixaNome.Text == "")
            {
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
            if (caixaEmail.Text =="")
            {
                MessageBox.Show("Campo Email, Obrigatório");
                return;
            }

            Usuario.DataNascimento = caixaNascimento.Text;
            Usuario.DataCriacao = caixacriacao.Text;
            DialogResult = DialogResult.OK;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();        //botao fechar
        }

        private void caixaSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }





   
   
       
        
    
}
