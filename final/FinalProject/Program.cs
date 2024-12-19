using System;

class Program
{
    static void Main(string[] args)
    {
        IntroHQ intro = new IntroHQ();
        Wasteland main = new Wasteland();
        SecretTemple final = new SecretTemple();
        Combat combat = new Combat();
        Character player = new Character();
        intro.StartMessage();
        TypeOutMessage message = new TypeOutMessage();
        combat.SetPlayer(player.GetHealth(), player.GetAttack(), player.GetDefense());
        combat.SetEnemy(1);
        Boolean _endCombat = false;
        while(_endCombat==false)
        {
            if(combat.CombatEncounter()==true)
            {
                _endCombat = true;
            }
            else
            {
                Console.WriteLine("You've failed NE317. Retry.");
            continue;
            }
        }
        intro.EndMessage();
        int _trigger = 0;
        while(_trigger<6)
        {
            main.StartMessage();
            int decider = main.GetDecider();
            combat.SetEnemy(_trigger);
            if(decider==1)
            {
                _endCombat = false;
                while(_endCombat==false)
                {
                    if(combat.CombatEncounter()==true)
                    {
                        _endCombat = true;
                    }
                    else
                    {
                        Console.WriteLine("You've failed NE317. Retry.");
                        continue;
                    }
                }
                player.LevelUp();
            }
            if(decider==2)
            {
                player.StatusReport();
            }
            if(decider==3)
            {
                message.SlowType(@"As you stare at the Wasteland, the futility of your existence dawns upon you. You turn off you visual input for the last time
 and watch as the world fades to black. You finally feel no pain, no fear, no regret. You are free.");
            }
            _trigger++;
            player.LevelUp();
        }
        final.StartMessage();
        combat.SetPlayer(player.GetHealth(), player.GetAttack(), player.GetDefense());
        final.SetEnding(combat.FinalCombat());
        final.EndMessage();
    }
}
