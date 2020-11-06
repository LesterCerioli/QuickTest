using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTestBuy.Domain.Entidades
{
    public class Usuario : Entidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Pedido>  Pedidos { get; set; }



        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Deve ser adicionado o NOME do Usuario");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O EMAIL deve ser informado");

        }
    }
}
