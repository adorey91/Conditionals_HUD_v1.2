using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_HUD_v1._2
{
    internal class Program
    {
        // declarations
        static string game = "Game Name";
        static string playerName;
        static float score = 0f;
        static int health = 100;
        static int lives = 3;
        static string weapon;
        static string playerInput;
        static float multiplier;


        static void Main(string[] args)
        {
            playerName = pName();



        }

        static void cleanHUD()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void changeWeapon()
        {
            if (playerInput == "0")
            {
                weapon = "stick";
            }
            else if (playerInput == "1") 
            {
                weapon = "";
            }
            else if (playerInput == "2")
            {
                weapon = "";
            }
            else if (playerInput == "3")
            {
                weapon = "";
            }
            else if (playerInput == "4")
            {
                weapon = "";
            }
            else if (playerInput == "5")
            {
                weapon = "";
            }
            else
            {
                weapon = "blade of grass";
                multiplier = 0.1f;

            }
        }

        static string pName()
        {
            Console.WriteLine("Enter Name: ");
            return Console.ReadLine();
        }

        static void takeDamage(int damage)
        {
            health = health - damage;
        }

        static void heal(int hp)
        {
            health = health + hp;
        }
        
        static void healthCheck()
        {
            if (health <= 0)
            {
                Console.WriteLine("Player Died");
                health = 0;
                lives = lives - 1;
            }

            else if (lives <= 0)
            {
                Console.WriteLine("Game Over");
                lives = 0;
            } 
        }

        static void ShowHUD()
        {
            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Score: " + score + "| " + "Multiplier: " + multiplier);
            Console.WriteLine("Health: " + health + "| " + "Lives: " + lives);
            Console.WriteLine("");
        }
    }
}
