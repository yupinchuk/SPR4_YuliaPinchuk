namespace SPR4_OOP_Yuliya_Pinchuck
{
    class Salmon : Fish
    {
        private int _deep { get; set; }
        private int _weight { get; set; }

        public Salmon(int deep, int weight) : base(deep, weight) { }

        public override void eat()
        {
            reachTheFood();
            Console.WriteLine("Eating...algae..");
        }

        public int getDeep()
        {
            return _deep;
        }
        public int getWeight()
        {
            return _weight;
        }

    }
}
