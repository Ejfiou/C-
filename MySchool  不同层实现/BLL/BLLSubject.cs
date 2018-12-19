using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Model;
using MySchool.DALMSSQL;
namespace MySchool.BLL
{
    public class BLLSubject
    {
        private DALSubject dalSubject = new DALSubject();

        public IEnumerable<Subject> QueryAll()
        {
            return dalSubject.QueryAll();
        }

        //public Task< IEnumerable<Subject>> QueryAllAsync()
        //{
        //    return Task<IEnumerable<Subject>>.Run(() =>
        //    {
        //       return dalSubject.QueryAll();
        //    });
        //}

        public Task<IEnumerable<Subject>> QueryAllAsync()
        {
            return dalSubject.QueryAllAsync();
        }
    }
}
