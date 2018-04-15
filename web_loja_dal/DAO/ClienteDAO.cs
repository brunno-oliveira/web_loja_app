using System;
using System.Collections.Generic;
using System.Linq;
using web_loja_dal.Models;

namespace web_loja_dal.DAO
{
    public class ClienteDAO : IDAO<CLIENTE>
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

        public Boolean insert(CLIENTE cliente)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CLIENTE.Attach(cliente);
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

        public Boolean update(CLIENTE cliente)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CLIENTE.Add(cliente);
                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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
                try {                 
                    db.CLIENTE.Remove(db.CLIENTE.Find(id));
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
