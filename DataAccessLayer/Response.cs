using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Response<T>
    {
        public T Content { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public Response(T content)
        {
            Content = content;
            IsValid = true;
        }
        public Response(Exception ex)
        {
            ErrorMessage = ex.Message;
            IsValid = false;
        }
    }
}
