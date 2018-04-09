using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_loja_dal.Models;

namespace web_loja_dal.DAO
{
    class CestaDAO : IDAO<CESTA>
    {
        public CESTA getById(int id)
        {
            using (var db = new Model())
            {
                try
                {
                    return db.CESTA.Find(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return null;
                }
            }
        }

        public bool insert(CESTA t)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CESTA.Attach(t);
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

        public List<CESTA> list()
        {
            using (var db = new Model())
            {
                try
                {
                    return db.CESTA.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Produto!: " + ex);
                    return null;
                }
            }
        }

        public bool remove(CESTA t)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CESTA.Remove(db.CESTA.Find(t.ID));
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

        public bool update(CESTA t)
        {
            using (var db = new Model())
            {
                try
                {
                    db.CESTA.Add(t);
                    db.Entry(t).State = System.Data.Entity.EntityState.Modified;
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
