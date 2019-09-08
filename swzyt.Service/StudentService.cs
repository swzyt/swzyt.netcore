using SqlSugar;
using swzyt.Entity;
using swzyt.IService;
using swzyt.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace swzyt.Service
{
    public class StudentService : BaseDB, IStudent
    {
        //private SqlSugarClient db = BaseDB.GetClient();
        public SimpleClient<Student> sdb = new SimpleClient<Student>(BaseDB.GetClient());
        #region base
        public TableModel<Student> GetPageList(int pageIndex, int pageSize)
        {
            PageModel p = new PageModel() { PageIndex = pageIndex, PageSize = pageSize };
            Expression<Func<Student, bool>> ex = (it => 1 == 1);
            List<Student> data = sdb.GetPageList(ex, p);
            TableModel<Student> t = new TableModel<Student>();
            t.Code = 0;
            t.Count = p.PageCount;
            t.Data = data;
            t.Msg = "成功";
            return t;
        }

        public Student Get(long id)
        {
            return sdb.GetById(id);
        }

        public bool Add(Student entity)
        {
            return sdb.Insert(entity);
        }

        public bool Update(Student entity)
        {
            return sdb.Update(entity);
        }

        public bool Dels(dynamic[] ids)
        {
            return sdb.DeleteByIds(ids);
        }
        #endregion
    }
}
