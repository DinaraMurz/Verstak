using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Crafts
    {
        public string Name { get; set; }
        public int numberOfCraft { get; set; }
        private const int three = 3;
        public int[,] craftsBody = new int[three, three];

        public int[,] CraftsBody { get; set; }

        public int[,] GetCraftsBody()
        {
            return craftsBody;
        }

        public void SetCraftsBody(int[,] craft)
        {
            craftsBody = craft;
        }


        public static bool operator ==(Crafts craft, int[,] filling)
        {
            int boofCraft, boofFilling,counter = 0;
            for (int i = 0; i < three; i++)
            {
                for (int j = 0; j < three; j++)
                {
                    boofCraft = craft.CraftsBody[i, j];
                    boofFilling = filling[i, j];

                    Console.SetCursorPosition(10, 10);

                    //Console.WriteLine(boofCraft + "  " + boofFilling);


                    if (boofCraft == boofFilling)
                        counter++;
                }
            }
            switch(counter)
            {
                case 9:
                    return true;
                    break;
            }
            return false;
        }

        public static bool operator !=(Crafts craft, int[,] filling)
        {
            int boofCraft, boofFilling;
            for (int i = 0; i < three; i++)
            {
                for (int j = 0; j < three; j++)
                {
                    boofCraft = craft.craftsBody[j, i];
                    boofFilling = filling[j, i];
                    if (boofCraft == boofFilling)
                        return false;
                }
            }
            return true;
        }



    }
}