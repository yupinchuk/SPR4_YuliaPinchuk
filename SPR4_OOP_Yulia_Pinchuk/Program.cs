namespace SPR4_OOP_Yuliya_Pinchuck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fish[] fishes = {new Salmon(6, 2), new Shark(12, 200),
            new Salmon(4, 1)};
            foreach (Fish fish in fishes)
            {
                fish.eat();
                Console.WriteLine();
            }
        }
    }
}
