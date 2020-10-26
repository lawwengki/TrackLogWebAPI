using CoreBaseLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBaseLib.Models
{
    public interface ITrackLog
    {
        RVal AddtoCartlgAddData(AddtoCartlgModel data);
        RVal AddPaymentInfolgAddData(AddPaymentInfolgModel data);
        RVal AddToWishlistlgAddData(AddToWishlistlgModel data);
        RVal CompleteRegistrationlgAddData(CompleteRegistrationlgModel data);
        RVal InitiateCheckoutlgAddData(InitiateCheckoutlgModel data);
        RVal PageViewlgAddData(PageViewlgModel data);
        RVal PurchaselgAddData(PurchaselgModel data);
        RVal SearchlgAddData(SearchlgModel data);
        RVal SubscribelgAddData(SubscribelgModel data);
        AddtoCartRModel GetAddToCartData();
        AddPaymentInfoRModel GetPaymentInfoData();
        AddToWishlistRModel GetAddToWishListData();
        CompleteRegistrationRModel  GetCompleteRegistrationData();
        InitiateCheckoutRModel GetInitiateCheckOutData();
        PageViewRModel  GetPageViewData();
        PurchaseRModel GetPurchaseData();
        SearchRModel GetSearchData();
        SubscribeRModel  GetSubscribeData();

    }
}
