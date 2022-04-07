
using System;

class SpiceHound : Ninja
{
    public SpiceHound() :base(1200)
    {

    }
    public override void Consume(IConsumable item)
    {
        if(this.IsFull)
        {
            Console.WriteLine("You cant eat anymore FatAss");
        }else
        {
            if(item.IsSpicy)
            {
            this.calorieIntake = this.calorieIntake - 5;
            }
            item.GetInfo();
            this.ConsumptionHistory.Add(item);
        }
    }
}