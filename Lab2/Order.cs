using System.Collections.Generic;

namespace Lab2
{
    public class Order
    {
        public List<CupOfTea> CupsOfTea { get; set; }
        public int Price { get; set; }
        public Order()
        {
            CupsOfTea = new List<CupOfTea>();
        }
        public void CalculatePrice()
        {
            Price = 0;
            foreach (var cupOfTea in CupsOfTea)
            {
                Price += cupOfTea.Price;
            }
        }
        public void Add(CupOfTea cupOfTea)
        {
            CupsOfTea.Add(cupOfTea);
        }
    }
}
