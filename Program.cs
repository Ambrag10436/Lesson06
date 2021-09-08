using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;                                   //подключаем библиотеку для работы с текстом - разбивка на строки (вывод по середине консоли)

namespace Homework_Theme_01
{
    class Program
    {
        /// <summary>
        /// Код который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>


        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            {
                Console.WriteLine("Пользователь номер 1 - Введите Ваше имя");                                     // запрос ввода имени от пользователя номер 1
                string UserName1 = Console.ReadLine();                                                            //создаем переменную string с именем Name(имя), которое вводит пользователь
                Console.WriteLine("Привет, " + UserName1 + "!");                                                  //выводим приветствие с тем, что вписал пользователь
                Console.WriteLine("Введите Ваш возраст");                                                         //запрашиваем ввод возраста
                int AgeUser1 = Convert.ToInt32(Console.ReadLine());                                               //создаем переменную типа инт с названием Age (возраст), и конвертируем в число, так как изначально это строка
                Console.WriteLine("Введите Ваш рост");                                                           //запрашиваем ввод роста
                int HeightUser1 = Convert.ToInt32(Console.ReadLine());                                            //создаем переменную типа инт с названием Height (Рост), и конвертируем в число, так как изначально это строка
                Console.WriteLine("Введите Ваш бал по истории");                                                  //запрос балла по истории
                byte HistoryUser1 = Convert.ToByte(Console.ReadLine());                                          //создаем переменную byte с именем History, и конвертируем в число, так как изначально это строка
                Console.WriteLine("Введите Ваш бал по математике");                                              //запрос балла по математике
                byte MathUser1 = Convert.ToByte(Console.ReadLine());                                             //создаем переменную byte с именем Math, и конвертируем в число, так как изначально это строка
                Console.WriteLine("Введите Ваш бал по русскому языку");                                          //запрос балла по рус
                byte RusLangUser1 = Convert.ToByte(Console.ReadLine());                                           //создаем переменную byte с именем RusLang, и конвертируем в число, так как изначально это строка
                double ResultUser1 = Convert.ToDouble((HistoryUser1 + MathUser1 + RusLangUser1) / 3.0 );               //считаем средний балл по трем предметам
                string ResultUser1Formated = ResultUser1.ToString("#.##");                                         //ограничиваем вывод среднего балла двумя знаками после запятой
                Console.WriteLine(UserName1 + " Ваш возраст: " + AgeUser1  + "Ваш рост: " + HeightUser1 + "История: " + HistoryUser1 + "Математика: " + MathUser1 + "Русский язык: " + RusLangUser1 + "Ваш средний бал равен: " + ResultUser1Formated);       //выводим строкой данные которые ввел юзер
                Console.WriteLine("Нажмите любую клавишу для продолжения...");         //выводим надпись о запросе продолжения
                Console.ReadKey();                                                     //ждем от юзера дейстыий
                Console.Clear();                                                       //после нажатия клавиши очищаем консоль и освобождаем место для второго юзера
                //Второй юзер вводит данные
                                
                Console.WriteLine("Пользователь номер 2 - Введите Ваше имя");          //предложение второму юзеру ввести имя
                string UserName2 = Console.ReadLine();                                 //создаем новую переменную и записываем в нее имя юзера
                Console.WriteLine("Введите Ваш возраст");                              //предложение ввести возраст
                int AgeUser2 = Convert.ToInt32(Console.ReadLine());                    //создаем переменную для возраста, записываем возраст введенный юзером
                Console.WriteLine("Введите Ваш рост");                                 //предложение ввести рост
                int HeightUser2 = Convert.ToInt32(Console.ReadLine());                 //создаем переменную для роста изаписываем то, что ввел юзер
                Console.WriteLine("Введите Ваш бал по истории");                       //запрос балла по истории
                byte HistoryUser2 = Convert.ToByte(Console.ReadLine());                //создаем переменную для балла по истории
                Console.WriteLine("Введите Ваш бал по математике");                    //запрос балла по математике
                byte MathUser2 = Convert.ToByte(Console.ReadLine());                   //создаем переменную для балла по математике
                Console.WriteLine("Введите Ваш бал по русскому языку");                //запрос балла по русскому языку
                byte RusLangUser2 = Convert.ToByte(Console.ReadLine());                //создаем переменную для балла по русскому языку
                double ResultUser2 = Convert.ToDouble((HistoryUser2 + MathUser2 + RusLangUser2) / 3.0 );     //считаем средний балл
                string ResultUser2Formated = ResultUser2.ToString("#.##");               //ограничиваем вывод среднего балла двумя знаками после запятой
                Console.Clear();                                                         //очищаем окно консоли
                string pattern = "Имя: {0} \nВозраст: {1} \nРост {2} \nБал по истории {3} \nБал по математике {4} \nБал по русскому языку {5} \nСредний бал {6}";      //собираем паттерн
                
                Console.WriteLine(pattern,                                                                                                                             //используя паттерн выводим данные столбиком
                                UserName2,
                                AgeUser2,
                                HeightUser2,
                                HistoryUser2,
                                MathUser2,
                                RusLangUser2,
                                ResultUser2Formated);

                Console.WriteLine("Нажмите любую клавишу...");  //запрос о продолжении
                Console.ReadKey();                              //ожидание действий юзера
                Console.Clear();                                //очищаем окно консоли и освобождаем место для следующего юзера

                // Пользователь номер 3 вводит свои данные

                Console.WriteLine("Пользователь номер 3 - Введите Ваше имя");                      //запрос ввода имени третьего юзера
                string UserName3 = Console.ReadLine();                                             //создаем переменную и записываем имя юзера
                Console.WriteLine("Введите Ваш возраст");                                          //запрос ввода возраста
                int AgeUser3 = Convert.ToInt32(Console.ReadLine());                                //записываем в переменную возраст
                Console.WriteLine("Введите Ваш рост");                                             //запрос ввода роста
                int HeightUser3 = Convert.ToInt32(Console.ReadLine());                             //записываем в переменную рост
                Console.WriteLine("Введите Ваш бал по истории");                                   //запрос бала по истории
                byte HistoryUser3 = Convert.ToByte(Console.ReadLine());                            //записываем в переменную бал по истории
                Console.WriteLine("Введите Ваш бал по математике");                                //запрос бала по математике
                byte MathUser3 = Convert.ToByte(Console.ReadLine());                               //записываем в переменную бал по математике
                Console.WriteLine("Введите Ваш бал по русскому языку");                            //запрос бала по русскому языку
                byte RusLangUser3 = Convert.ToByte(Console.ReadLine());                            //записываем в переменную бал по русскому
                double ResultUser3 = Convert.ToDouble((HistoryUser3 + MathUser3 + RusLangUser3) / 3.0 );    //считаем средний бал
                string ResultUser3Formated = ResultUser3.ToString("#.##");                         //ограничиваем вывод среднего балла двумя знаками после запятой
                Console.Clear();                                                                   //очищаем консоль
                                                                                                   //собираем строку с введенными данными
                string totalUser3 = $"Имя: {UserName3,-10} \nВозраст: {AgeUser3} \nРост: {HeightUser3}см \nБал по истории: {HistoryUser3} \nБал по математике: {MathUser3} \nБал по русскому языку: {RusLangUser3} \nСредний бал: {ResultUser3Formated}";
                string[] lines = Regex.Split(totalUser3, "\r\n|\r|\n");         //разбиваем текст на строики
                int left = 0;                                                   //определяем для каждой строки отступ слева - равен 0
                int top = (Console.WindowHeight / 2) - (lines.Length / 2) - 1;  //определяем отступ сверху для первой строки - высота экрана делим пополам минус длина текста деленная пополам и все этол минус 1
                int center = Console.WindowWidth / 2;                           //находим центр консоли: делим ширину экрана пополам

                for(int i =0; i< lines.Length; i++)
                {
                    left = center - (lines[i].Length / 2);                      //определяем отступ для текущей строки
                    Console.SetCursorPosition(left, top);                       // меняем положение курсора на найденные ранее точки left и top;( где left равна центру минус длина строки деленная пополам)
                    Console.WriteLine(lines[i]);                                //выводим строку
                    top = Console.CursorTop;
                }            
                Console.ReadKey();
            
            }





            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            

        }
    }
}
