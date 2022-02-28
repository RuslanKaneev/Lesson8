using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения (application-scope). 
 * Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках.
 * При следующем запуске отобразить эти сведения. Задать приложению версию и описание.*/
namespace Lesson8_1
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            string privetPolzov = Properties.Settings.Default.privetPolz;
            Console.WriteLine($"{privetPolzov}");

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) | string.IsNullOrEmpty(Properties.Settings.Default.UserAge) | string.IsNullOrEmpty(Properties.Settings.Default.UserWork))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                

                Console.WriteLine("Введите свой возраст");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                

                Console.WriteLine("Введите свой род деятельности");
                Properties.Settings.Default.UserWork = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                string userName = Properties.Settings.Default.UserName;
                string userAge = Properties.Settings.Default.UserAge;
                string userWork = Properties.Settings.Default.UserWork;
                Console.WriteLine($" имя пользователя {userName} \n возраст {userAge} \n род деятельности {userWork}");
            }

            Console.ReadKey();
        }
    }
}
