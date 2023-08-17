using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pedro Henrique Botelho Lima

namespace SWII6_TP1
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author() { }

        public Author(string name, string email, char gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }
    }
}
