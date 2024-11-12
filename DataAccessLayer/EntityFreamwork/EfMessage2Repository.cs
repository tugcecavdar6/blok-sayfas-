using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamwork
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetSendBoxWithMessageByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Messages2.Include(x => x.ReceiverUserWriter).Where(y => y.SenderId == id).ToList();
            }
        }

        public List<Message2> GetInboxWithMessageByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Messages2.Include(x => x.SenderUserWriter).Where(x => x.ReceiverId == id).ToList();
            }
        }
        public List<Message2> GetListWithMessageByWriter(int id)
        {

            using (var context = new Context())
            {
                return context.Messages2.Include(x => x.SenderUserWriter).Where(y => y.ReceiverId == id).ToList();
            }
        }
    }
}
