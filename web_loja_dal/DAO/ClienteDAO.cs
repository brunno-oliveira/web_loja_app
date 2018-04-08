using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_loja_dal.Models;

namespace web_loja_dal.DAO
{
    class ClienteDAO
    {
        public List<CLIENTE> list()
        {
            using (var db = new Model())
            {
                try
                {                    
                    return db.CLIENTE.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return null;
                }
            }
        }

        public CLIENTE getById(int id)
        {
            using (var db = new Model())
            {
                try
                {
                    return db.CLIENTE.Find(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return null;
                }
            }
        }

        public void insert(CLIENTE cliente)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CLIENTE.Attach(cliente);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                }
            }
        }

        public void update(CLIENTE cliente)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CLIENTE.Add(cliente);
                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                }
            }
        }

        public void remove(CLIENTE cliente)
        {
            using (var db = new Model())
            {
                try {                 
                    db.CLIENTE.Remove(db.CLIENTE.Find(cliente.ID));
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
