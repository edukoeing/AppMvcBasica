﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
    {
        public String Nome { get; set; }

        public String Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }



        /* - EF Relations (relacionamento visível) */

        public IEnumerable<Produto> Produtos { get; set; }
    }
}

