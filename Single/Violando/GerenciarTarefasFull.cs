namespace Single.Violando
{
    // Vemos agora que a Classe GerenciarTarefasFull tem muitas responsabilidades e isso quebra o principio da Responsabilidade única,
    // aonde atrapalha ate na manutenção de código
    public class GerenciarTarefasFull
    {
        public String conectarAPI()
        {
            throw new NotImplementedException();
        }
        public void criarTarefa()
        {
            throw new NotImplementedException();
        }

        public void atualizarTarefa()
        {
            throw new NotImplementedException();
        }

        public void removerTarefa()
        {
            throw new NotImplementedException();
        }

        public void enviarNotificacao()
        {
            throw new NotImplementedException();
        }

        public void produzirRelatorio()
        {
            throw new NotImplementedException();
        }

        public void enviarRelatorio()
        {
            throw new NotImplementedException();
        }
    }
}
