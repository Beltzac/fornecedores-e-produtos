using System;
using System.Collections.Generic;
using System.Text;

namespace Beltzac.FornecedoresProdutos.Dominio.Modelos
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
    }
}
