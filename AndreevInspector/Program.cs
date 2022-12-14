using System;
using InspectorLib;

namespace AndreevInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp func = new FunctionInsp();
            func.GetInspector("Васильев Василий Иванович");//Вывод главного инспектора
            func.GetСarInspection("Автоинспекция г. Чита");//Вывод названия автоинспекции
            func.SetInspector("");//Изменение ФИО главного инспектора
            func.GenerateNumber(5, 'H');//Вывод госномера
            func.GetWorker();//Вывод списка сотрудников автоинспекции
            func.AddWorker();//Добавление сотрудника автоинспекции
        }
    }
}
