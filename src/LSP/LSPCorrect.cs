using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Bird
    {
        public abstract void Move();
    }

    public class FlyingBird: Bird
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }

    public class Penguin:Bird
    {
        public override void Move()
        {
           Console.WriteLine("swimming");
        }
    }
}
