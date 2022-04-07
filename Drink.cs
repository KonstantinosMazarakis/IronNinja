using System;
class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}
    
        public string GetInfo()
    {
        return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }

    public Drink(string n,int cal, bool spicy)
    {
        Name = n;
        Calories = cal;
        IsSpicy = spicy;
        IsSweet = true;
    }
}   

