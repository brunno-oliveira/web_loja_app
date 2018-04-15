using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_loja_dal.DAO
{
    interface IDAO<T> where T : class
    {
        List<T> list();

        T getById(int id);

        Boolean insert(T t);

        Boolean update(T t);

        Boolean remove(int id);
    }
}
