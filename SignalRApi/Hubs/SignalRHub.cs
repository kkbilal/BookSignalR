using Microsoft.AspNetCore.SignalR;
using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;

namespace SignalRApi.Hubs
{
	public class SignalRHub : Hub
	{
		private readonly ICategoryService _categoryservice;
		private readonly IProductService _productservice;
		private readonly IOrderService _orderservice;
		private readonly IMoneyCaseService _moneycaseservice;
		private readonly ITableMenuService _tablemenuservice;
		private readonly IBookingService _bookingservice;
		private readonly INotificationService _notificationservice;

        public SignalRHub(IProductService productservice, ICategoryService categoryService, IOrderService orderservice, IMoneyCaseService moneycaseservice, ITableMenuService tablemenuservice, IBookingService bookingservice, INotificationService notificationservice)
        {
            _productservice = productservice;
            _categoryservice = categoryService;
            _orderservice = orderservice;
            _moneycaseservice = moneycaseservice;
            _tablemenuservice = tablemenuservice;
            _bookingservice = bookingservice;
            _notificationservice = notificationservice;
        }

        public async Task SendStatistic()
		{
			var categoryCountValue = _categoryservice.TGetCategoryCount();
			await Clients.All.SendAsync("ReceiveCategoryCount", categoryCountValue);
			
			var productCountValue = _productservice.TGetProductCount();
			await Clients.All.SendAsync("ReceiveProductCount", productCountValue);

			var activeCategoriesvalue = _categoryservice.TActiveCategoryCount();
			await Clients.All.SendAsync("ReceiveActiveCategoriesCount", activeCategoriesvalue);

			var passiveCategoriesvalue = _categoryservice.TPassiveCategoryCount();
			await Clients.All.SendAsync("ReceivePassiveCategoriesCount", passiveCategoriesvalue);

			var productHamburgervalue = _productservice.TProductCountByCategoryNameHamburger();
			await Clients.All.SendAsync("ProductCountByCategoryNameHamburger",productHamburgervalue);

			var productDrinkvalue = _productservice.TProductCountByCategoryNameDrink();
			await Clients.All.SendAsync("ProductCountByCategoryNameDrink", productDrinkvalue);

			var avaragePricevalue = _productservice.TProductPriceAvg();
			await Clients.All.SendAsync("AvarageProductPrice", avaragePricevalue.ToString("0.00")+"₺");

			var maxPriceproductvalue = _productservice.TProductPriceMax();
			await Clients.All.SendAsync("ProductPriceMax", maxPriceproductvalue.ToString("0.00") + "₺");

			var minPriceproductvalue = _productservice.TProductPriceMin();
			await Clients.All.SendAsync("ProductPriceMin", minPriceproductvalue.ToString("0.00") + "₺");

			var avgHamburgerpricevalue = _productservice.TProductPriceByHamburger();
			await Clients.All.SendAsync("ProductPriceByHamburger", avgHamburgerpricevalue.ToString("0.00") + "₺");

			var totalordercountvalue = _orderservice.TOrderCount();
			await Clients.All.SendAsync("OrderCount", totalordercountvalue);

			var activeordercountvalue = _orderservice.TOrderActiveCount();
			await Clients.All.SendAsync("OrderActiveCount", activeordercountvalue);

			var lastordercountvalue = _orderservice.TLastOrderPrice();
			await Clients.All.SendAsync("LastOrderPrice", lastordercountvalue.ToString("0.00") + "₺");

			var moneyamountvalue = _moneycaseservice.TTotalMoneyCaseAmount();
			await Clients.All.SendAsync("TotalMoneyCaseAmount", moneyamountvalue.ToString("0.00") + "₺");

			var todayamountvalue = _orderservice.TTodayTotalAmount();
			await Clients.All.SendAsync("TodayTotalAmount", todayamountvalue.ToString("0.00") + "₺");

			var tablecountvalue = _tablemenuservice.TTableMenuCount();
			await Clients.All.SendAsync("TableMenuCount", tablecountvalue);

		}
		public async Task SendProgress()
		{
			var totalmoneyValue = _moneycaseservice.TTotalMoneyCaseAmount();
			await Clients.All.SendAsync("TotalMoneyCaseAmount", totalmoneyValue.ToString("0.00")+"₺");

			var activeOrdersvalue = _orderservice.TOrderActiveCount();
			await Clients.All.SendAsync("OrderActiveCount", activeOrdersvalue);

			var tableCountvalue = _tablemenuservice.TTableMenuCount();
			await Clients.All.SendAsync("TableMenuCount", tableCountvalue);
		}
		public async Task GetBookingList()
		{
			var values =_bookingservice.TGetListAll();
			await Clients.All.SendAsync("ReceiveBookingList", values);
		}
		public async Task GetNotification()
		{
			var values = _notificationservice.TNotificationCountByStatusFalse();
			await Clients.All.SendAsync("ReceviceFalseNotifications", values);

			var notificationvalue = _notificationservice.TGetNotificationByStatusFalse();
			await Clients.All.SendAsync("ReceiveNotificationListByFalse",notificationvalue);
		}
	}
}
