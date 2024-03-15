namespace Agendamento.Exceptions
{
    public class DuplicateUserCpfException : Exception
    {
        public DuplicateUserCpfException(string message): base(message)
        {

        }
    }
}
