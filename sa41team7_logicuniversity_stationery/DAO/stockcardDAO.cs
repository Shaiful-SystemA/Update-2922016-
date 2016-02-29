using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class stockcardDAO
    {
        LSEntities ctx;

        public stockcardDAO()
        {
            ctx = new LSEntities();
        }

        public List<stockcard> getAllStockCardTransactionsByStockIDAndItemID(int stockID, string itemID)
        {
            return ctx.stockcards.Where(x => x.stockID == stockID && x.itemID == itemID).ToList();
        }

        public string updateStockCard(stockcard sc)
        {
            stockcard stkcard = ctx.stockcards.Where(x => x.stockID == sc.stockID).FirstOrDefault();

            if (null == stkcard)
                return "fail";

            stkcard.itemID = sc.itemID;
            stkcard.transactiondate = sc.transactiondate;

            //issuedtype is the status of the transaction on the stock card
            if (stkcard.issuedtype.Equals("Adjustment_AddQty") || stkcard.issuedtype.Equals("Adjustment_MinusQty")
                || stkcard.issuedtype.Equals("Supplier")
                || stkcard.issuedtype.Equals("Disbursement")
                || stkcard.issuedtype.Equals("Collection_AddQty") || stkcard.issuedtype.Equals("Collection_MinusQty"))
                stkcard.issuedtype = sc.issuedtype;
            {
                stkcard.qty = sc.qty;
            }

            ctx.SaveChanges();
            return "Success";
        }
    }
}