using System;
using System.Collections.Generic;
using System.Linq;
using web_loja_dal.Models;

namespace web_loja_dal.DAO
{
    public class ProdutoDAO : IDAO<PRODUTO>
    {
        public List<PRODUTO> list()
        {
            using (var db = new Model())
            {
                try
                {
                    return db.PRODUTO.ToList();                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return null;
                }
            }
        }

        public PRODUTO getById(int id)
        {
            using(var db = new Model())
            {
                try
                {
                    return db.PRODUTO.Find(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return null;
                }
            }
        }
        
        public Boolean insert(PRODUTO produto)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Attach(produto);
                    db.SaveChanges();
                    return true;
                } catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return false;
                }
            }
        }

        public Boolean update(PRODUTO produto)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Add(produto);
                    db.Entry(produto).State = System.Data.Entity.EntityState.Modified;                    
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return false;
                }
            }
        }

        public Boolean remove(PRODUTO produto)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Remove(db.PRODUTO.Find(produto.ID));
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return false;
                }
            }
        }
    }
}
