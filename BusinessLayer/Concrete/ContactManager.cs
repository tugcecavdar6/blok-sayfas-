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
   public class ContactManager :IContactService
    {
        IiletisimDal _iletisimDal;

        public ContactManager(IiletisimDal ıiletisimDal)
        {
            this._iletisimDal = ıiletisimDal;
        }

        public void ContactAdd(iletisim1 iletisim1)
        {
            _iletisimDal.Insert(iletisim1);
        }
    }
}
