using System;

namespace ObjectRedaktor
{
    public class MassObj
    {
        public virtual void Add(ref object[] ObjMass, object obj)
        {
            Array.Resize(ref ObjMass, ObjMass.Length + 1);
            ObjMass[ObjMass.Length - 1] = obj;
            Console.WriteLine("Добавлен елемент " + ObjMass[ObjMass.Length - 1], ObjMass);
        }

        public virtual void Remove(ref object[] ObjMass, object obj)
        {
            object k;
            for (int i = 0; i < ObjMass.Length; i++)
            {
                k = ObjMass[i];
                if (obj.ToString() == (ObjMass[i]).ToString())
                {
                    Console.WriteLine(i);
                    for (int j = i; j < ObjMass.Length; j++, i++)
                    {
                        if (j == ObjMass.Length - 1)
                        {
                            Console.WriteLine("Удален елемент " + k);
                            Array.Resize(ref ObjMass, ObjMass.Length - 1);
                            return;
                        }
                        ObjMass[j] = ObjMass[i + 1];
                    }
                }
            }
            Console.WriteLine("Такого объекта там нет");
        }
        public virtual void Check(ref object[] ObjMass, int Id)
        {

            for (int i = 0; i < ObjMass.Length; i++)
            {
                if (i == Id)
                {
                    Console.WriteLine(ObjMass[Id]);
                    Console.WriteLine("Найден елемент " + ObjMass[Id] + "", ObjMass);
                    break;
                }
            }
            if (Id <= 0 && Id >= ObjMass.Length)
            {
                Console.WriteLine("Такого нету");
            }

        }
        public virtual void MasLength(ref object[] ObjMass)
        {
            Console.WriteLine(ObjMass.Length);
            Console.WriteLine("Длина масива " + ObjMass.Length + "", ObjMass);
        }


    }
}
