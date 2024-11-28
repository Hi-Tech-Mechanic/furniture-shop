// public class test 
// {
//     private double money = 50000;
//     private int additiveMoney = 1000;
// 	Coupon lowDiscount = new() { Count = 2, DiscountSize = 5 };
// 	Coupon MediumDiscount = new() { Count = 1, DiscountSize = 10 };
// 	Coupon HightDiscount = new() { Count = 0, DiscountSize = 25 };

// 	partial class Coupon
// 	{
// 		public int Count {get; set;}
// 		public int DiscountSize {get; set;}
// 	}

//     private void AddMoney()
//     {
//         money += additiveMoney;
//     }

// 	private void AddCupone(int couponIndex)
// 	{
// 		switch (couponIndex)
// 		{
// 			case 0: lowDiscount.Count++; break;
// 			case 1: MediumDiscount.Count++; break;
// 			case 2: HightDiscount.Count++; break;
// 		}
// 	}
// }