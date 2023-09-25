using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Conditionals_HUD_v1._2
{
    internal class Program
    {
        // declarations
        static string game = "Game Name";
        static float score = 0f;
        static int health = 100;
        static int lives = 3;
        static string weapon = "fists";
        static int playerInput;
        static float multiplier = 0.5f;


        static void Main(string[] args)
        {
            ShowHUD();
            Console.WriteLine("In the heart of a war-torn city, Sarah Jay, a mild-mannered librarian, found herself trust into a battle for survival. With enemy soldiers closing in, she desperately searched for a way out. She had no combat training just a deep desire to protect her family.");

            cleanHUD();
            ShowHUD();
            Console.WriteLine("As she fled through the rubble-strewn streets Sarah stumbled upon a mysterious artifact glowing iwth an otherworldly light. Without thinking, she picked it up, feeling a surger of power coursing through her.");

            cleanHUD();
            ShowHUD();
            Console.WriteLine("The enemy soldiers continued their relentless pursuit. Sarah, now wielding the shield, blocked most bullets and projectiles with ease, marveling at her newfound abilities. She realized that he had become the city's last hope for survival");
            Console.WriteLine("Sarah looked down and noticed she'd been hit by a bullet");
            takeDamage(15);

            cleanHUD();
            ShowHUD();
            Console.WriteLine("Facing a formidable adversary, a merciless enemy commander named General Voss, Sarah found herself outmatched. Voss was armed with a high-tech energy sword that could cut through anything. Sarah's shield held up against the onslaught but was slowly weakening.");

            cleanHUD();
            ShowHUD();
            Console.WriteLine("Desperation set in as Sarah's shield showed cracks. She needed a way to turn the tide. Spotting a fallen soldier's weapon nearby, he lunged for it, exchanging his shield for ...");
            Console.WriteLine("");
            Console.WriteLine("Pick a number between 0 and 5");
            changeWeapon();

            cleanHUD();
            ShowHUD();
            Console.WriteLine("The sudden change of weapons caught Voss off guard. A fierce duel ensued between Sarah and General Voss. The " + weapon + " unleashed devastating energy beams, but Voss's agility and experience made him a formidable foe. Each clash of their weapons sent sparks flying.");

            cleanHUD();
            ShowHUD();
            Console.WriteLine("In the heat of battle, Sarah sustained a severe wound.");
            takeDamage(75);
            
            cleanHUD();
            ShowHUD();
            Console.WriteLine("As she felt the life draining from her, the artifact she had found earlier began to glow again.It enveloped her in a healing aura, sealing her injuries..");
            heal(70);

            cleanHUD();
            ShowHUD();
            Console.WriteLine("The battle raged on until, with a final, mighty blow, Sarah managed to disarm General Voss. Cornered and defeated, Voss realized he had met his match. In a moment of unexpected mercy, Sarah spared his life, believing that the cycle of violence needed to end.");

            cleanHUD();
            ShowHUD();
            Console.WriteLine("With the battle won and the enemy in retreat, Sarah had saved his city. She looked at the artifact, which had saved her life and given her the power to protect those she loved. She knew her life as a librarian was over; she had become the city's reluctant hero.\r\n\r\n\"The Reluctant Warrior\" was born from an ordinary woman's desperation but transformed into an extraordinary tale of courage, sacrifice, and newfound strength in the face of adversity.");
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
            playerInput = Convert.ToInt32(Console.ReadLine());

            if (playerInput == 0)
            {
                weapon = "shield";
                multiplier = 1.3f;
            }
            else if (playerInput == 1) 
            {
                weapon = "spear";
                multiplier = 1.5f;
            }
            else if (playerInput == 2)
            {
                weapon = "war hammer";
                multiplier = 3.2f;
            }
            else if (playerInput == 3)
            {
                weapon = "dagger";
                multiplier = 1.7f;
            }
            else if (playerInput == 4)
            {
                weapon = "slingshot";
                multiplier = 0.7f;
            }
            else if (playerInput == 5)
            {
                weapon = "rifle";
                multiplier = 3.5f;
            }
            else
            {
                weapon = "blade of grass";
                multiplier = 0.1f;
            }
        }

        static void takeDamage(int damage)
        {
            Console.WriteLine("");
            Console.WriteLine("Sarah has taken " + damage + " damage");
            health = health - damage;
        }

        static void heal(int hp)
        {
            Console.WriteLine("");
            Console.WriteLine("Sarah has healed " + hp + " health points");
            health = health + hp;

            if (health > 100)
            {
                health = 100;
            }
        }
        
        static void healthCheck()
        {
            if (health <= 0)
            {
                Console.WriteLine("Player Died");
                health = 0;
                lives = lives - 1;
            }
            else if (health > 0 && health < 15)
            {
                Console.WriteLine("Imminent Danger");
            }
            else if (health >15 && health <50)
            {
                Console.WriteLine("Badly Hurt");
            }    
            else if (health >50 && health <75)
            {
                Console.WriteLine("Hurt");
            }
            else if(health >75 && health <100)
            {
                Console.WriteLine("Healthy");
            }
            else if (health == 100)
            {
                Console.WriteLine("Perfectly Healthy");
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
            Console.WriteLine("Score: " + score + "| " + "Multiplier: " + multiplier);
            Console.WriteLine("Health: " + health + "| " + "Lives: " + lives);
            healthCheck();
            Console.WriteLine("Current Weapon: " + weapon);
            Console.WriteLine("");
        }
    }
}
