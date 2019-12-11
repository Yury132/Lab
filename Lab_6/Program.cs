using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab_6
{
    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            attribute = null;
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);

            if (isAttribute.Length > 0)
            {
                attribute = isAttribute[0];
                return true;
            }

            return false;
        }



        static void Main(string[] args)
        {






            Console.WriteLine("\nЧасть 2: РЕФЛЕКСИЯ\n");

            Type t = typeof(ReflectionObserver);

            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПубличные методы");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства с атрубутами");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(CustomAttribute), out attrObj))
                {
                    CustomAttribute attr = attrObj as CustomAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
            Console.WriteLine("InvokeMember");
            ReflectionObserver fi = (ReflectionObserver)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });
            Console.WriteLine("InvokeMethod");
            object[] parameters = { 10, 5 };
            object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("Plus(10,5)={0}", Result);

            Console.ReadLine();

        }
    }
}
