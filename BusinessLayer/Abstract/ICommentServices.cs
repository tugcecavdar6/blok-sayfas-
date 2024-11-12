using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentServices
    {
        void YorumAdd(yorumlar yorumlar);
        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
       List<yorumlar> GetList(int id);
      //  Category GetCategoryId(int id);
    }
}
