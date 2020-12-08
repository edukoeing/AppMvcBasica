using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

       
        public String Nome { get; set; }

        public String Descricao { get; set; }

        public String Imagem { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* - EF Relations (relacionamento visível) */
        public Fornecedor Produtos { get; set; }
    }
}
