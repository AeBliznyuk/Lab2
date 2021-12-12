namespace Lab2
{
    public class TeaVariety
    {
        public string Name { get; set; } 
        public int Price { get; set; }
        public TeaVariety(string name)
        {
            Name = name;
            switch (name)
            {
                case "Улун":
                    Price = 150;
                    break;
                case "Гречневый":
                    Price = 170;
                    break;
            }
        }
    }
}
