using System;

namespace _1_add
{//Реализуйте шаблон NVI в собственной иерархии наследования.
   
    class BaseClass
    {
        protected virtual void DoWork()
        {
            Console.WriteLine("Базовый класс");
        }

        public void GetWork()
        {
            DoWork();
        }
    }

    class DerivedClass : BaseClass
    {
        protected override void DoWork()
        {
            Console.WriteLine("Производный класс");
        }
    }
    class Program
    {
        static void Main()
        {
            BaseClass instance = new DerivedClass();

            instance.GetWork();

            //Delay
            Console.ReadKey();
        }
    }
}
