using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolOlympiad.Tasks
{

    /// <summary>
    /// Этот класс от первого задагния , выполнения реализация класса -
    /// будет выполняться в методе Main
    /// </summary>
    class FirstTask
    {

        private List<int> _params = new List<int>();


        /// <summary>
        /// Записываем в массив параметры которые введет юзер
        /// На каздый запрос параметра выводиться текст , который передаем в массиве
        /// Если количество параметров преодалеет количество текста в массиве то выведеться "Введите доп. Параметр"
        /// И цикл продолжиться
        /// </summary>
        /// <param name="amountParams"></param>
        /// <param name="sentence"></param>
        public void TakeParams(int amountParams, string[] sentence)
        {
            for(int i =0; i < amountParams; i++)
            {
                if (i < sentence.Length)
                    Console.WriteLine(sentence[i]);
                else
                    Console.WriteLine("Введите доп. Параметр");

                int param = EnterRightNum(1,100);
                _params.Add(param);
            }

            Console.WriteLine($@"Количество учеников: {Calculate(_params.ToArray())}");
        }

        /// <summary>
        /// Проверяет относиться ли число к заднонному лимиту
        /// </summary>
        /// <param name="leftLimmit"></param>
        /// <param name="rightLimmit"></param>
        /// <returns></returns>
        private int EnterRightNum(int leftLimmit, int rightLimmit)
        {
            int param = 0;
            do
            {
                try
                {
                    param = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Environment.FailFast("УПС :((( Произошла ошибка");
                }
                if (param > rightLimmit || param < leftLimmit)
                {
                    Console.WriteLine(@$"Число должно быть больше {leftLimmit} и меньше {rightLimmit}");
                }
            } while (param > rightLimmit && param > leftLimmit);
            return param;
        }
        /// <summary>
        /// Метод считающий сколько всего учеников будет участвовать
        /// Количество заданных данных передаеться в массиве
        /// Плюсом данного метода являеться гибкость, 
        /// мы можем в будующем разделить количество учеников на пол , или оценнки, 
        /// и не зависит от количества параметров
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
       private int Calculate(int[] numbers)
        {
            int result = 1;
            for(int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            return result;
        }

    }
}
