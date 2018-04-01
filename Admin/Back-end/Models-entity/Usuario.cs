using System;

namespace Back_end.Models_entity
{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }

        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }
    }
}