using System;
using System.Collections.Generic;
using System.Text;

namespace Beltzac.FornecedoresProdutos.Dominio.Modelos
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Guid IdFornecedor { get; set; }
    }
}
