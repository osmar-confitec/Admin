using System;

namespace Back_end.Models_entity
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
         public Usuario Usuario { get; set; }
    }
}