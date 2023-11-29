using System;

namespace SPR4_OOP_Yuliya_Pinchuck
{
    class Shark : Fish
    {
        private int _deep { get; set; }
        private int _weight { get; set; }

        public Shark(int deep, int weight) : base(deep, weight) { }

        public override void eat()
        {
            reachTheFood();
            Console.WriteLine("Eating...human..");
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
