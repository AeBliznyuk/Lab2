namespace Lab2
{
    public class Milk
    {
        public bool Presence { get; set; }
        public int Price { get; set; }
        public Milk(bool presence)
        {
            Presence = presence;
            if (presence) 
                Price = 20;
            else
                Price = 0;
        }
    }

}
