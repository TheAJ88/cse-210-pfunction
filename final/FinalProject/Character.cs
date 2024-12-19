using System;

class Character
{
    protected int _health;
    protected int _attack;
    protected int _defense;
    public Character()
    {
        _health = 80;
        _attack = 12;
        _defense = 5;
    }
    public void LevelUp()
    {
        _health += 10;
        _attack += 5;
        _defense += 2;
        Console.WriteLine("You've leveled up!");
    }
    public int GetHealth()
    {
        return _health;
    }
    public int GetAttack()
    {
        return _attack;
    }
    public int GetDefense()
    {
        return _defense;
    }
    public void StatusReport()
    {
        Console.WriteLine("NE317 STATUS REPORT (86) Version 97.G4");
        Console.WriteLine("Health: " + _health);
        Console.WriteLine("Attack: " + _attack);
        Console.WriteLine("Defense: " + _defense);
    }
}