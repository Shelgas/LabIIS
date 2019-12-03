using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class Battle
    {

        public Battle(Hero hero, IMonster monster)
        {
            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Health -= hero.Attack();
                hero.Health -= monster.Attack();
            }

            if (hero.Health > 0) Console.WriteLine(@"                                                   /$$          
                                                  |__/          
 /$$   /$$  /$$$$$$  /$$   /$$       /$$  /$$  /$$ /$$ /$$$$$$$ 
| $$  | $$ /$$__  $$| $$  | $$      | $$ | $$ | $$| $$| $$__  $$
| $$  | $$| $$  \ $$| $$  | $$      | $$ | $$ | $$| $$| $$  \ $$
| $$  | $$| $$  | $$| $$  | $$      | $$ | $$ | $$| $$| $$  | $$
|  $$$$$$$|  $$$$$$/|  $$$$$$/      |  $$$$$/$$$$/| $$| $$  | $$
 \____  $$ \______/  \______/        \_____/\___/ |__/|__/  |__/
 /$$  | $$                                                      
|  $$$$$$/                                                      
 \______/");
            else Console.WriteLine(@"                                           /$$ /$$                 /$$
                                          | $$|__/                | $$
 /$$   /$$  /$$$$$$  /$$   /$$        /$$$$$$$ /$$  /$$$$$$   /$$$$$$$
| $$  | $$ /$$__  $$| $$  | $$       /$$__  $$| $$ /$$__  $$ /$$__  $$
| $$  | $$| $$  \ $$| $$  | $$      | $$  | $$| $$| $$$$$$$$| $$  | $$
| $$  | $$| $$  | $$| $$  | $$      | $$  | $$| $$| $$_____/| $$  | $$
|  $$$$$$$|  $$$$$$/|  $$$$$$/      |  $$$$$$$| $$|  $$$$$$$|  $$$$$$$
 \____  $$ \______/  \______/        \_______/|__/ \_______/ \_______/
 /$$  | $$                                                            
|  $$$$$$/                                                            
 \______/ ");
        }
    }
}
