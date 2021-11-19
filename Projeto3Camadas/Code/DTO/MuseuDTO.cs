using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class MuseuDTO
    {
        //Propriedades privadas
        private string _Id;
        private string _Nome;
        private string _Email;
        private string _Senha;

        //Métodos de encapsulamento (CTRL+R,E)
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
        public string Id { get => _Id; set => _Id = value; }
    }
}
