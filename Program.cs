using System;

namespace interface_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animals
            Ant ant = new Ant();
            BettaFish bettaFish = new BettaFish();
            CopperheadSnake copperhead = new CopperheadSnake();
            Earthworm earthworm = new Earthworm();
            Finch finch = new Finch();
            Gerbil gerbil = new Gerbil();
            Mouse mouse = new Mouse();
            Parakeet parakeet = new Parakeet();
            Terrapin terrapin = new Terrapin();
            TimberRattlesnake timber = new TimberRattlesnake();

            //Cages
            DiggingCage diggingCage = new DiggingCage();
            FlyingCage flyingCage = new FlyingCage();
            GroundCage groundCage = new GroundCage();
            SwimmingCage swimmingCage = new SwimmingCage();

            //Adding
            diggingCage.cage.Add(ant);
            diggingCage.cage.Add(earthworm);
            groundCage.cage.Add(copperhead);
            groundCage.cage.Add(timber);
            groundCage.cage.Add(mouse);
            groundCage.cage.Add(gerbil);
            flyingCage.cage.Add(finch);
            flyingCage.cage.Add(parakeet);
            swimmingCage.cage.Add(bettaFish);
            swimmingCage.cage.Add(terrapin);
        }
    }
}
