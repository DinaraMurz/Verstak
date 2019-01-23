using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Box
    {

        public Crafts woodPickaxe = new Crafts  { CraftsBody = new int[,] { { 1, 1, 1 }, { 0, 3, 0 }, { 0, 3, 0 } } };
        public Crafts stonePickaxe = new Crafts { CraftsBody = new int[,] { { 2, 2, 2 }, { 0, 3, 0 }, { 0, 3, 0 } } };
        public Crafts goldPickaxe = new Crafts { CraftsBody = new int[,] { { 4, 4, 4 }, { 0, 3, 0 }, { 0, 3, 0 } } };
        public Crafts metalPickaxe = new Crafts { CraftsBody = new int[,] { { 5, 5, 5 }, { 0, 3, 0 }, { 0, 3, 0 } } };



        public Crafts woodShovel = new Crafts { CraftsBody = new int[,] { { 0, 1, 0 }, { 0, 3, 0 }, { 0, 3, 0 } } };
        public Crafts stoneShovel = new Crafts { CraftsBody = new int[,] { { 0, 2, 0 }, { 0, 3, 0 }, { 0, 3, 0 } } };
        public Crafts goldShovel = new Crafts { CraftsBody = new int[,] { { 0, 4, 0 }, { 0, 3, 0 }, { 0, 3, 0 } } };
        public Crafts metalShovel = new Crafts { CraftsBody = new int[,] { { 0, 5, 0 }, { 0, 3, 0 }, { 0, 3, 0 } } };


        public Crafts woodSword = new Crafts { CraftsBody = new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 3, 0 } } };
        public Crafts stoneSword = new Crafts { CraftsBody = new int[,] { { 0, 2, 0 }, { 0, 2, 0 }, { 0, 3, 0 } } };
        public Crafts goldSword = new Crafts { CraftsBody = new int[,] { { 0, 4, 0 }, { 0, 4, 0 }, { 0, 3, 0 } } };
        public Crafts metalSword = new Crafts { CraftsBody = new int[,] { { 0, 5, 0 }, { 0, 5, 0 }, { 0, 3, 0 } } };


        private Thing _wood { get; set; }
        private Thing _stone { get; set; }
        private Thing _stick { get; set; }
        private Thing _gold { get; set; }
        private Thing _metal { get; set; }
        private const int zero = 0, three = 3, two = 2, nine = 9, fiftine = 15;
        public int[,] filling = new int[three, three];
        
        


        public void DrawVerstak()
        {
            Console.WriteLine("_|_|_");
            Console.WriteLine("_|_|_");
            Console.WriteLine("_|_|_");
        }
        public void ShowInfo()
        {
            Console.WriteLine("to move use Arrouse\nto create use Enter");
        }

        public void ShowList()
        {
            Console.WriteLine($"0 - Delete thing\n1 - wood\n2 - stone\n3 - sticl\n4 - gold\n5 - metal");
        }

        public void WriteThings()
        {
            for (int i = 0; i < three; i++)
            {
                for (int j = 0; j < three; j++)
                {
                    Console.SetCursorPosition(j * two, i);
                    Console.WriteLine(filling[i, j]);
                }
            }
        }





        public string Create()
        {
            // я хотела зделать switch но тогда перегруска не срабатывает
            if (woodPickaxe == filling)
            {
                return "woodPickaxe";
            }
            else if (stonePickaxe == filling)
            {
                return "stonePickaxe";
            }
            else if (goldPickaxe == filling)
            {
                return "goldPickaxe";
            }
            else if (metalPickaxe == filling)
            {
                return "metalPickaxe";
            }

            else if (woodShovel == filling)
            {
                return "woodShovel";
            }
            else if (stoneShovel == filling)
            {
                return "stoneShovel";
            }
            else if (goldShovel == filling)
            {
                return "goldShovel";
            }
            else if (metalShovel == filling)
            {
                return "metalShovel";
            }

            else if (woodShovel == filling)
            {
                return "woodShovel";
            }
            else if (stoneShovel == filling)
            {
                return "stoneShovel";
            }
            else if (goldShovel == filling)
            {
                return "goldShovel";
            }
            else if (woodSword == filling)
            {
                return "woodSword";
            }
            else if (stoneSword == filling)
            {
                return "stoneSword";
            }
            else if (goldSword == filling)
            {
                return "goldSword";
            }
            else if (metalSword == filling)
            {
                return "metalSword";
            }
            else
            return "Ошибка, попробуйте ввести снова";
        }

    }
}