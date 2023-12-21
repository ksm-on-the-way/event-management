using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public interface IEventMgtDAO<T>
    {
        public T? GetByName(string str);

        public T? GetById(int id);

        public List<T> GetAll();

        public int Update(T t);

        public int Delete(T t);

        public void Add(T t);


    }
}
