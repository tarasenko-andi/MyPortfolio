using System;

namespace ObjectRedaktor
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] MassObject = new object[] { };
            MassObj MassObject2 = new MassObj();
            bool k = true;
            while (k)
            {
                Console.WriteLine("Выберите какую функцию необходимо сделать: \n" +
                                "1-Добавить елемент в масив объектов \t" +
                                "2-Удалить елемент масива\t" +
                                "3-Просмотреть величину масива в данный момент\t" +
                                "4-Просмотреть елемент по Id елемента\t" +
                                "5-Закрыть програму");
                string str = Console.ReadLine();
                switch (str)
                {
                    case ("1"):
                        Console.WriteLine("Укажите объект который будет добавлен в масив:");
                        object str1 = Console.ReadLine();
                        MassObject2.Add(ref MassObject, str1);
                        break;
                    case ("2"):
                        Console.WriteLine("Укажите объект который будет удален из масива:");
                        object str2 = Console.ReadLine();
                        MassObject2.Remove(ref MassObject, str2);
                        break;
                    case ("3"):
                        MassObject2.MasLength(ref MassObject);
                        break;
                    case ("4"):
                        Console.WriteLine("Укажите объект который будем искать:");
                        int str4 = Int32.Parse(Console.ReadLine());
                        MassObject2.Check(ref MassObject, str4);
                        break;
                    case ("5"):
                        k = false;
                        break;
                    default:
                        Console.WriteLine("Неверно указано параметр");
                        continue;
                }
            }
        }
    }
}


