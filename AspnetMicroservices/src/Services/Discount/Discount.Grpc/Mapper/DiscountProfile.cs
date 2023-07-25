namespace Discount.Grpc.Mapper
{
    public class DiscountProfile: Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, GetDiscountResponse>().ReverseMap();
        }
    }
}
