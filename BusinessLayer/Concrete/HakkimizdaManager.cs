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
    public class HakkimizdaManager:IHakkimizdaService
    {
        IHakkimdaDal _hakkimdaDal;

        public HakkimizdaManager(IHakkimdaDal hakkimdaDal)
        {
            _hakkimdaDal = hakkimdaDal;
        }

        public hakkimda GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<hakkimda> GetList()
        {
           return _hakkimdaDal.GetListAll();
        }

        public void TAdd(hakkimda t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(hakkimda t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(hakkimda t)
        {
            throw new NotImplementedException();
        }
    }
}
