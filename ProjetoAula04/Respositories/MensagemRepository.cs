using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Respositories
{
    public class MensagemRepository : IMensagemFactory
    {
        private string _connectionstring;

        public MensagemRepository()
        {
            _connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBProjetoAula04;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public void Create(Mensagem mensagem)
        {
            throw new NotImplementedException();
        }
    }
}
