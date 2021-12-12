namespace Lab2
{
   public class Sugar
   {
        public int Amount { get; set; }
        public int Price { get; set; }
        public Sugar(int amount)
        {
            Amount = amount;
            Price = Amount * 10;
        }
   }
}
