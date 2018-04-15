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
                    db.PRODUTO.Add(produto);                
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
                    db.PRODUTO.Attach(produto);
                    var entry = db.Entry(produto);
                    entry.Property(e => e.NOME).IsModified = true;
                    entry.Property(e => e.MARCA).IsModified = true;
                    entry.Property(e => e.QUANTIDADE).IsModified = true;
                    entry.Property(e => e.VALOR).IsModified = true;
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

        public Boolean remove(int id)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Remove(db.PRODUTO.Find(id));
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
