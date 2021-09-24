using System;

namespace CouponNumber
{
    class UC5_CouponNumber
    {
        static void Main(string[] args)
        {
            int couponNo, distinct = 0, count = 0;
            Console.Write("Enter the Distinct Number: ");
            couponNo = int.Parse(Console.ReadLine());

            bool[] isCollected = new bool[couponNo];
            while(distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;
                if(!isCollected[newCoupon])
                {
                    distinct++;
                    isCollected[newCoupon] = true;
                }
            }

            Console.WriteLine("Total Random Number needed to have all distinct coupons: " + count);
        }
    }
}
