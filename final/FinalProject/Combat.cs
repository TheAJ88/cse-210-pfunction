using System;
using System.Runtime.CompilerServices;

class Combat
{
    int _enemyAttack;
    int _playerAttack;
    int _enemyHealth;
    int _playerHealth;
    int _enemyDefense;
    int _playerDefense;
    Random rand = new Random();

    public void SetPlayer(int pHealth, int pAttack, int pDefense)
    {
        _playerHealth = pHealth;
        _playerAttack = pAttack;
        _playerDefense = pDefense;
    }

    public void SetEnemy(int level)
    {
        _enemyHealth = 10*level;
        _enemyAttack = rand.Next(0, _enemyHealth);
        _enemyDefense = rand.Next(0, _enemyHealth);
    }

    public Boolean CombatEncounter()
{
    int _originalHealth = _playerHealth;
    Console.WriteLine("You've encountered an enemy! Prepare for combat!");
    while (_enemyHealth > 0 && _playerHealth > 0)
    {
        Console.WriteLine("Your health: " + _playerHealth);
        Console.WriteLine("Enemy health: " + _enemyHealth);
        Console.WriteLine("What will you do?");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Defend");
        Console.WriteLine("3. Run");
        string input = Console.ReadLine();
        if (input == "1")
        {
            int playerAttack = rand.Next(0, _playerAttack);
            int damageToEnemy = Math.Max(0, playerAttack - _enemyDefense);
            _enemyHealth -= damageToEnemy;

            int enemyAttack = rand.Next(0, _enemyAttack);
            int damageToPlayer = Math.Max(0, enemyAttack - _playerDefense);
            _playerHealth -= damageToPlayer;
        }
        else if (input == "2")
        {
            _playerDefense = rand.Next(0, _playerDefense);
            int enemyAttack = rand.Next(0, _enemyAttack);
            int damageToPlayer = Math.Max(0, enemyAttack - _playerDefense);
            _playerHealth -= damageToPlayer;
        }
        else if (input == "3")
        {
            Console.WriteLine("You ran away!");
            break;
        }

        if (_enemyHealth > 0)
        {
            int enemyAttack = rand.Next(0, _enemyAttack);
            if (enemyAttack % 2 == 0)
            {
                Console.WriteLine("The enemy attacks!");
                int damageToPlayer = Math.Max(0, enemyAttack - _playerDefense);
                _playerHealth -= damageToPlayer;
            }
        }
    }

    if (_enemyHealth <= 0)
    {
        _playerHealth = _originalHealth + 10;
        return true;
    }
    else if (_playerHealth <= 0)
    {
        return false;
    }
    return false;
}
    public Boolean FinalCombat()
    {
        _enemyHealth = _playerHealth;
        _enemyAttack = _playerAttack;
        _enemyDefense = _playerDefense;
        if(CombatEncounter()==true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


