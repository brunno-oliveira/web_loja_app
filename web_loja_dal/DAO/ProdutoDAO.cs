using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_loja_dal.Models;

namespace web_loja_dal.DAO
{
    public class ProdutoDAO
    {
        public List<PRODUTO> list()
        {
            using (var db = new Model())
            {
                try
                {
                    List<PRODUTO> teste = db.PRODUTO.ToList();
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
        
        public void insert(PRODUTO produto)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Attach(produto);
                    db.SaveChanges();
                } catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                }
            }
        }

        public void update(PRODUTO produto)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Add(produto);
                    db.Entry(produto).State = System.Data.Entity.EntityState.Modified;                    
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                }
            }
        }

        public void remove(PRODUTO produto)
        {
            using (var db = new Model())
            {
                try
                {
                    db.PRODUTO.Remove(db.PRODUTO.Find(produto.ID));
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                }
            }
        }
    }
}
