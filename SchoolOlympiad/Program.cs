using SchoolOlympiad.Tasks;
using System;

namespace SchoolOlympiad
{
    class Program
    {

        private static string[] _firstTaskSentences = new string[]
        {
            "Введите количество областей",
            "Введите количество районов",
            "Введите количество школ",
            "Введите количество школьников"
        };

        static void Main(string[] args)
        {
            /// Запуск первой задачи
            //FirstTask firstTask = new FirstTask();
            //firstTask.TakeParams(4, _firstTaskSentences);

            /// Запуск второй задачи
            SecondTask secondTask = new SecondTask();
            secondTask.TakeParams();

        }
    }
}
