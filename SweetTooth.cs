using System;
class SweetTooth : Ninja
{

    public SweetTooth() : base(1500) 
    {

    }

    public override void Consume(IConsumable item)
    {
        if(this.IsFull)
        {
            Console.WriteLine("You cant eat anymore FatAss");
        }else
        {
            if(item.IsSweet)
            {
            this.calorieIntake = this.calorieIntake + 10;
            }
            item.GetInfo();
            this.ConsumptionHistory.Add(item);
        }
    }
}