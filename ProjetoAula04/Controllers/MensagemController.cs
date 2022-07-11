using ProjetoAula04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Controllers
{
    /// <summary>
    /// Classe para execução do fluxo de dados
    /// </summary>
    public class MensagemController
    {
        public void EnviarMensagem()
        {
            try
            {
                Console.WriteLine("\n*** ENVIO DE MENSGEM ***");

                var mensagem = new Mensagem();
                mensagem.IdMensagem = Guid.NewGuid();
                mensagem.DataHoraEnvio = DateTime.Now;

                Console.Write("Informe o e-mail do destinatário...: ");
                mensagem.Email = Console.ReadLine();

                Console.Write("Informe o assunto da mensagem......: ");
                mensagem.Assunto = Console.ReadLine();

                Console.Write("Informe o texto da mensagem......: ");
                mensagem.Texto = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao enviar mensagem: {e.Message}");
            }
        }
    }
}
