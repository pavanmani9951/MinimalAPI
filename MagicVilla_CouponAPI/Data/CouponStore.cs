using MagicVilla_CouponAPI.Models;

namespace MagicVilla_CouponAPI.Data
{
    public static class CouponStore
    {
        public static List<Coupon> Coupons = new List<Coupon>{
            new Coupon() {Id=1,Name="Myntra",Percent=30,IsActive=false },
            new Coupon() {Id=2,Name="Flipkart",Percent=45,IsActive=false },
            new Coupon() {Id=3,Name="Ajio",Percent=65,IsActive=false },
            new Coupon() {Id=4,Name="Amazon",Percent=20,IsActive=false }
        };
    }
}   