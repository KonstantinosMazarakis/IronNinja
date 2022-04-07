using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SpiceHound Kostas = new SpiceHound();
            SweetTooth Brandon = new SweetTooth();
            
             while(!Kostas.IsFull)
                Kostas.Consume(buffet.Serve());
            
            while(!Brandon.IsFull)
                Brandon.Consume(buffet.Serve());

                if(Kostas.ConsumptionHistory.Count > Brandon.ConsumptionHistory.Count)
                {
                    Console.WriteLine("Kostas is the fatass");
                }else
                {
                    Console.WriteLine("Brandon is the fatass");
                }
        }
    }
}
