using System;
using System.Collections.Generic;
using System.Text;

namespace Beltzac.FornecedoresProdutos.Dominio.Modelos
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string HashSenha { get; set; }
        public string SalSenha { get; set; }
    }
}
