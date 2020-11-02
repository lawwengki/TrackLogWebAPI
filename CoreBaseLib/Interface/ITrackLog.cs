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
        List<AddtoCartRModel> GetAddToCartData();
        List<AddPaymentInfoRModel> GetPaymentInfoData();
        List<AddToWishlistRModel> GetAddToWishListData();
        List<CompleteRegistrationRModel> GetCompleteRegistrationData();
        List<InitiateCheckoutRModel> GetInitiateCheckOutData();
        List<PageViewRModel> GetPageViewData();
        List<PurchaseRModel> GetPurchaseData();
        List<SearchRModel> GetSearchData();
        List<SubscribeRModel> GetSubscribeData();

        RVal ResetEvents();

    }
}
