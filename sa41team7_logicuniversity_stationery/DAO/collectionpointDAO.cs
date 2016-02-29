using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class collectionpointDAO
    {
        LSEntities ctx;
        public collectionpointDAO() 
        {
            ctx = new LSEntities();
        }

        public List<collectionpoint> getAllCollectionPoint()
        { 
            return ctx.collectionpoints.ToList();
        }

        public collectionpoint getCollectionPointByName(string collectionPointName)
        {
            return ctx.collectionpoints.Where(x => x.collectionpointname == collectionPointName).FirstOrDefault();
        }
    }
}