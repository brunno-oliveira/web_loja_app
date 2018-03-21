using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_loja_app.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
    }
}