using System;
using System.Collections.Generic;
using System.Text;
using web_loja_dal.DAO;
using web_loja_dal.Models;

namespace web_loja_bll.Service
{
    public class ProdutoService
    {
        private static ProdutoDAO dao = new ProdutoDAO();

        public List<PRODUTO> list()
        {
            return dao.list();
        }

        public PRODUTO getById(int id)
        {
            return dao.getById(id);
        }

        public Boolean insert(PRODUTO produto)
        {
            return dao.insert(produto);
        }

        public Boolean update(PRODUTO produto)
        {
            return dao.update(produto);
        }
        
          public Boolean remove(PRODUTO produto)
        {
            return dao.remove(produto);
        }
    }
}
