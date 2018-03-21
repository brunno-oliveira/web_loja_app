using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_loja_app.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public double valor { get; set; }
        public int quantidade { get; set; }
    }
}