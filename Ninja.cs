using System;
using System.Collections.Generic;
abstract class Ninja
{
    protected int calorieIntake;
    protected int calorieLimit;
    public List<IConsumable> ConsumptionHistory;
    public Ninja(int calLim)
    {
        calorieLimit = calLim;
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    public bool IsFull {get
    {
        if(calorieIntake > calorieLimit)
        {
            return true;
        }else
        {
            return false;
        }
    }
    } 
    public abstract void Consume(IConsumable item);
}

