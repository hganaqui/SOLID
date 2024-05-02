using Single.Solucao;
using Single.Violando;

namespace Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciarTarefasFull gerenciarTarefasFull = new GerenciarTarefasFull();
            gerenciarTarefasFull.conectarAPI();
            gerenciarTarefasFull.enviarNotificacao();

            // Imagina que agora precisamos conectar a APi para um gerenciar eventos, tivemos que replicar o código 
            // alem disso não ficaria centralizado e a manutenção deveria ser mais de um lugar

            //----------------------------------------------------//

            GerenciadorTarefas gerenciadorTarefas = new GerenciadorTarefas();
            gerenciadorTarefas.criarTarefa();
            Notificador notificador = new Notificador();
            notificador.enviarNotificacao();

            // Com essa divisão de classes conseguimos reaproveitar mais o código e pra manutenção fazendo em um lugar unico

        }
    }
}
