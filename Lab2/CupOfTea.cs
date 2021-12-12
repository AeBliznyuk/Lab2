namespace Lab2
{
   public class CupOfTea
   {
        public Milk Milk { get; set; }
        public Sugar Sugar { get; set; }
        public TeaVariety TeaVariety { get; set; }
        public int Price { get; set; }
        public CupOfTea(Milk milk, Sugar sugar, TeaVariety teaVariety)
        {
            Milk = milk;
            Sugar = sugar;
            TeaVariety = teaVariety;
            Price = milk.Price + sugar.Price + teaVariety.Price;
        }
   }
}
