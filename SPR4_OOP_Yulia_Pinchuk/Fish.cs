using System;


namespace SPR4_OOP_Yuliya_Pinchuck
{
    public abstract class Fish
    {
        private int _deep { get; set; }
        private int _weight { get; set; }

        public Fish(int deep, int weight)
        {
            _deep = deep;
            _weight = weight;
        }

        public abstract void eat();

        public void reachTheFood()
        {
            Console.WriteLine("[Food found]");
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
