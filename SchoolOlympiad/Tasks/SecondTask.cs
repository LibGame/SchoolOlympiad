using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolOlympiad.Tasks
{
    class SecondTask
    {
        /// <summary>
        /// Принимаю параметры
        /// </summary>
        public void TakeParams()
        {
            Console.WriteLine("Введите количество задач");
            int taskAmount = EnterRightNum(1, 10);
            Console.WriteLine($@"Введите следующе количество занятого времени {taskAmount * 3}");
            int[] timeTask = new int[taskAmount * 3];

            for (int i = 0; i < timeTask.Length; i++)
            {
                Console.WriteLine("Введите сколько времени заняло");
                int param = EnterRightNum(1, 500);
                timeTask[i] = param;
            }

            Calculate(timeTask, taskAmount);
        }

        /// <summary>
        /// Здесь происходит счет решенных задач и штрафов
        /// </summary>
        /// <param name="times"></param>
        /// <param name="amountTasks"></param>
        private void Calculate(int[] times, int amountTasks)
        {
            int resuts = 0;
            int sum = 0;
            int index = 1;

            for(int i = 0; i < times.Length; i++)
            {
                sum += times[i];
                if (index == 3)
                {
                    Console.WriteLine(sum);
                    if (sum < 500)
                        resuts += 500 - sum;
                    else
                    {
                        amountTasks--;
                    }
                    sum = 0;
                    index = 0;
                }
                index++;
            }

            Console.WriteLine($@"Количество решенных задач {amountTasks}");
            Console.WriteLine($@"Штрафы {resuts}");
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
    }
}
