using LojaVirtualAPI.Model;
using System.Net;

namespace LojaVirtualAPI.Dto
{
    public class ResponseDTO<T>
    {
        public T Object { get; set; }
        public List<string> Messages { get; set; }

        public int StatusCode { get; set; }

        public ResponseDTO()
        {
            Messages = new List<string>();
        }
    }
}
