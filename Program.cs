using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkExitControl
{
    class Program

    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userSaid;

            Console.Write("Вы в клубе садомазо... Ваше стоп слово  exit. Чем хотите получить удар ?:");
            userSaid = Console.ReadLine();

            if (userSaid == stopWord)
            {
                Console.Write("Вы сказали стоп слова. Приходите еще и приводите друзей.");
            }
            else if (userSaid != stopWord)
            {
                while (userSaid != stopWord)
                {
                    Console.Write($"Вы получили удар {userSaid}. ");                 
                    Console.Write("Чем хотите получить удар еще раз ?:");
                    userSaid = Console.ReadLine();
                }
            }         
        }
    }
}
