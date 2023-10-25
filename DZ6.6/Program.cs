using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6._6
{
    class Program
    {
        static void Input()
        {
            using (StreamWriter list = new StreamWriter("server.txt", true, Encoding.Unicode))
            {
                char proceed = 'д';

                do
                {
                    string note = string.Empty;
                    string now = DateTime.Now.ToString();
                    Console.WriteLine($"\nДата и время добавления записи: {now}");
                    note += $"{now}#";

                    Console.WriteLine("\nВведите Ф.И.О: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите возраст: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите рост: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите дату рождения: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите место рождения: ");
                    note += $"{Console.ReadLine()}#";

                    list.WriteLine(note);
                    Console.Write("\nДля добавления нового сторудника нажмите - д, для завернения - Enter");
                    proceed = Console.ReadKey(true).KeyChar;

                } while (char.ToLower(proceed) == 'д');
            }

        }
        static void Print()
        {
            using (StreamReader list2 = new StreamReader("server.txt", Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"\n{"Дата и врнемя",15}{"Ф.И.О",15} {"Время",20} {"Возраст",15} {"Рост",15} {"Дата Рождения",20} {"Место"}");

                while ((line = list2.ReadLine()) != null)
                {
                    string[] daty = line.Split('#');
                    Console.WriteLine($"{daty[0],15} {daty[1],15} {daty[2],15} {daty[3],15} {daty[4],15} {daty[5],20} {daty[6]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 - что бы вывести данные на экран");
            Console.WriteLine("Введите 2 - что бы заполнить данные и добавить новую запись в конце файла ");


            string number = Console.ReadLine();
            bool i = true;

            if (number == "1")
            {
                Print();
            }
            else if (number == "2")
            {
                Input();
            }
            else
            {
                i = false;
            }

            Console.ReadKey();
        }
    }
}