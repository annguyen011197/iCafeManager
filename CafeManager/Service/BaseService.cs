using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Service
{
    //T kiểu dữ liệu trả về
    //Id Kiêu dữ liệu khóa chính của object
    public interface BaseService<T, ID>
    {
        T findOne(ID id);

        List<T> findAll();

        List<T> findAll(List<ID> listId);

        long count();

        bool exists(ID id);

        bool update(T entity);

        bool update(List<T> listEntity);

        bool save(T entity);

        bool save(List<T> listEntity);

        void delete(ID id);

        void delete(T entity);

        void delete(List<T> listEntity);

        void deleteAll();
    }
}
