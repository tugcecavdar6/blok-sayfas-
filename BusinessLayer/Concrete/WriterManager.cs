using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
       public class WriterManager : IWriterService
        {
            IYazarDal _writerdal;

        public WriterManager(IYazarDal writerdal)
        {
            _writerdal = writerdal;
        }

        public Yazar GetById(int id)
        {
            return _writerdal.GetById(id);
        }

        public List<Yazar> GetList(int id)
        {
            return _writerdal.GetListAll(w => w.yazarID == id);
        }
        public List<Yazar> GetList(string email)
        {
            return _writerdal.GetListAll(w => w.yazarMail == email);
        }

        public List<Yazar> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Yazar> GetListWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.yazarID == id);
        }

        public void TAdd(Yazar t)
        {
            _writerdal.Insert(t);
        }

        public void TDelete(Yazar t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Yazar t)
        {
             _writerdal.Update(t);
        }

        
    }
}
