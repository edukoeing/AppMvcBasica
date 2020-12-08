using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        public String Logradouro { get; set; }

        public String Numero { get; set; }

        public String Complemento { get; set; }

        public decimal Cep { get; set; }

        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public decimal Estado { get; set; }


        /* - EF Relations (relacionamento visível) */
        public Fornecedor Produtos { get; set; }
    }


}
