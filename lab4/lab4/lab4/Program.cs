using System;
using System.IO;

namespace lab4
{
    /// <summary>
    /// Класс для реализации поставленной задачи
    /// </summary>
    class Program
    {
        /// <summary>
        /// Общий интерфейс приложения
        /// </summary>
        public interface IAbstractApp
        {
            /// <summary>
            /// Функция для возврата настроек нужных определенной стране
            /// </summary>
            /// <returns>изменяемые настройки</returns>
            IAbstractSettings GetSettings();
        }
        /// <summary>
        /// Класс Russia приложения
        /// </summary>
        class RussiaRedactor : IAbstractApp
        {
            /// <summary>
            /// Функция для настроек Russia
            /// </summary>
            /// <returns>Настройки приложения под Russia</returns>
            public IAbstractSettings GetSettings()
            {
                return new RussiaSettings();
            }
        }
        /// <summary>
        /// Класс China приложения
        /// </summary>
        class CSHRedactor : IAbstractApp
        {
            /// <summary>
            /// Функция для настроек China
            /// </summary>
            /// <returns>Настройки приложения China</returns>
            public IAbstractSettings GetSettings()
            {
                return new ChinaSettings();
            }
        }
        /// <summary>
        /// Класс Germany приложения
        /// </summary>
        class GermanyRedactor : IAbstractApp
        {
            /// <summary>
            /// Настройки Germany приложения
            /// </summary>
            /// <returns>Настройки под Germany</returns>
            public IAbstractSettings GetSettings()
            {
                return new GermanySettings();
            }
        }
        /// <summary>
        /// Интерфейс настроек
        /// </summary>
        public interface IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название страны
            /// </summary>
            /// <returns>Страна под изменение настроек</returns>
            string WhichCountry();
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            string SetSettings1();
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            string SetSettings2();
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            string SetSettings3();
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            string SetSettings4();
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            string SetSettings5();
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            string SetSettings6();
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            string SetSettings7();
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            string SetSettings8();
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            string SetSettings9();
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            string SetSettings10();

        }
        /// <summary>
        /// Класс настроек Russia
        /// </summary>
        class RussiaSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название страны
            /// </summary>
            /// <returns>Страна под изменение настроек</returns>
            public string WhichCountry()
            {
                return "Эти настройки для Russia:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Russia";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Russia";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Russia";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Russia";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Russia";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Russia";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Russia";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Russia";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Russia";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Russia";
            }
        }
        /// <summary>
        /// Класс настроек China
        /// </summary>
        class ChinaSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название страны
            /// </summary>
            /// <returns>Страна под изменение настроек</returns>
            public string WhichCountry()
            {
                return "Эти настройки для China:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под China";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под China";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под China";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под China";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под China";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под China";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под China";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под China";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под China";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под China";
            }
        }
    
        /// <summary>
        /// Класс настроект Germany
        /// </summary>
        class GermanySettings:IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название страны
            /// </summary>
            /// <returns>Страна под изменение настроек</returns>
            public string WhichCountry()
            {
                return "Эти настройки для Germany:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
        {
            return "Меняем настройку 1 под Germany";
        }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
        {
            return "Меняем настройку 2 под Germany";
        }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
        {
            return "Меняем настройку 3 под Germany";
        }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
        {
            return "Меняем настройку 4 под Germany";
        }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
        {
            return "Меняем настройку 5 под Germany";
        }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
        {
            return "Меняем настройку 6 под Germany";
        }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
        {
            return "Меняем настройку 7 под Germany";
        }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
        {
            return "Меняем настройку 8 под Germany";
        }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
        {
            return "Меняем настройку 9 под Germany";
        }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
        {
            return "Меняем настройку 10 под Germany";
        }
    }

        /// <summary>
        /// Класс под клиента
        /// </summary>
        class Client
        {
            /// <summary>
            /// Процедура вывода настроек для Russia
            /// </summary>
            public void Russia()
            {
                ClientMethod(new RussiaRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода настроект China
            /// </summary>
            public void China()
            {
                ClientMethod(new Chinaedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода настроек Germany
            /// </summary>
            public void Germany()
            {
                ClientMethod(new GermanyRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода на экран изменяемых настроек и названия страны
            /// </summary>
            /// <param name="redactor для обращения к функциям интерфейса приложения"></param>
            public void ClientMethod(IAbstractApp redactor)
            {
                var Settings = redactor.GetSettings();
                Console.WriteLine(Settings.WhichCountry());
                Console.WriteLine(Settings.SetSettings1());
                Console.WriteLine(Settings.SetSettings2());
                Console.WriteLine(Settings.SetSettings3());
                Console.WriteLine(Settings.SetSettings4());
                Console.WriteLine(Settings.SetSettings5());
                Console.WriteLine(Settings.SetSettings6());
                Console.WriteLine(Settings.SetSettings7());
                Console.WriteLine(Settings.SetSettings8());
                Console.WriteLine(Settings.SetSettings9());
                Console.WriteLine(Settings.SetSettings10());
            }
        }
        /// <summary>
        /// Функция определения страны
        /// </summary>
        /// <param name="name имя файла"></param>
        /// <returns>название страны</returns>
        public static string GetCountry(string name)
        {
            FileInfo test = new FileInfo(name);
            string ext = test.Extension;
            return ext;
        }
        /// <summary>
        /// основное тело программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                string name, ext;
                Console.WriteLine("Введите название страны:");
                name = Console.ReadLine();
                ext = GetCountry(name);
                switch (ext)
                {
                    case "Russia":
                        new Client().Russia();
                        break;
                    case "China":
                        new Client().CSH();
                        break;
                    case "Germany":
                        new Client().Germany();
                        break;
                    default:
                        Console.WriteLine("Invalid country! Load the correct file.");
                        break;
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Wrong file name!");
            }
        }
    }
}
