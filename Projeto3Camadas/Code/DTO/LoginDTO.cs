using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class LoginDTO
    {
        private string _id;
        private string _Email;
        private string _Senha;

        public string Id { get => _id; set => _id = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
    }
}
