using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class mobilenotificationDAO
    {
        LSEntities ctx;

        public mobilenotificationDAO()
        {
            ctx = new LSEntities();
        }

        public mobilenotification getMobileNotificationByID(int mobNoti)
        {
            return ctx.mobilenotifications.Where(x => x.notificationID == mobNoti).First();
        }

        public List<mobilenotification> getMobileNotiListByReceiverID(String receiverID)
        {
            return ctx.mobilenotifications.Where(x => x.receiverID == receiverID).ToList();
        }

        public List<mobilenotification> selectMobileNotiList()
        {
            return ctx.mobilenotifications.ToList();
        }

        public String createMobileNoti(mobilenotification mobNoti)
        {
            ctx.mobilenotifications.Add(mobNoti);
            ctx.SaveChanges();
            return "Success";
        }

        public String updateMobNoti(mobilenotification mobNoti)
        {
            mobilenotification mobileNoti = ctx.mobilenotifications.Where(x => x.notificationID == mobNoti.notificationID).First();
            if (null == mobileNoti)
                return "Fail";
            mobileNoti.status = mobNoti.status;
            ctx.SaveChanges();
            return "Success";
        }
    }
}