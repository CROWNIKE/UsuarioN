namespace GestaoDePessoas
{
    public class Usuario
    {
        public class Formulario { public int MyProperty { get; set; } }


        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string DataCriacao { get; set; }
        public string DataNascimento { get; set; }
    }
}