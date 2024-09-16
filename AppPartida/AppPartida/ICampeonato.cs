namespace AppPartida
{
    public interface ICampeonato
    {
        void CriarTabela();
        void VerTabela();
        void Placar(int partidaId, int golTime1, int golTime2);
        Finais ObterFinais();
    }
}
