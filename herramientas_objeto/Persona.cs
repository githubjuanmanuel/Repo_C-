using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herramientas_objeto
{
    public class Persona
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public Persona(int _id, string _user, string _password)
        {
            Id = _id;
            User = _password;
            Password = _password;
        }
    }
}
