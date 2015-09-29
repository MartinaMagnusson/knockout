namespace DAL
{
    public class Numbers
    {
        public int ID { get; set; }
        public RandomNumbers randomNumbers = new RandomNumbers();
        public StaticNumbers staticNumbers = new StaticNumbers();
    }
}