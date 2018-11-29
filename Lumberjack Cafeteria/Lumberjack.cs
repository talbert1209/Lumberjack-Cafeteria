using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;

namespace Lumberjack_Cafeteria
{
    public class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> _meal;
        public int FlapjackCount
        {
            get { return _meal.Count; }
        }

        public Lumberjack(string name)
        {
            Name = name;
            _meal = new Stack<Flapjack>();
        }

        public void TakeFlapjack(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                _meal.Push(food);
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($@"{Name}'s eating flapjacks");
            while (FlapjackCount > 0)
            {
                var flapjackToEat = _meal.Pop().ToString().ToLower();
                Console.WriteLine($@"{Name} ate a {flapjackToEat} flapjack.");
            }
        }
    }
}