using CarteiraApp.Modelo;

namespace CarteiraApp.BDMock
{
    public class AtivoRepository
    {
        private static AtivoRepository _instance;
        private static List<Ativo> ativos;

        public static AtivoRepository Instance()
        {
            if (_instance == null)
            {
                ativos = new List<Ativo>();
                IniciarValores();
                _instance = new AtivoRepository();
            }
            return _instance;
        }

        private static void IniciarValores()
        {
            ativos.Add(new Ativo("MGLU3", 100, 10, DateTime.Now));
            ativos.Add(new Ativo("MGLU3", 200, 20, DateTime.Now));
            ativos.Add(new Ativo("BBDC4", 101, 30, DateTime.Now));
        }

        public List<Ativo> ObterAtivos() => ativos;
    }
}