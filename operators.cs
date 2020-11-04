using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class test : MonoBehaviour
{
    void Start()
    {
        Debug.Log(1 == 2 ? 3 : 4);//тернарный оператор, если 1 == 2 вернет 3, иначе 4.

        int? z = null;
        int? a = 2;

        Debug.Log(z ??= z = a);//оператор объединения, если z = null возвращает значение операнда с права
        Debug.Log(z ??= 5);// иначе получаем значение с лева

        //еще 1 пример 
        int? ar = null;
        int b = ar ?? -1; // output: -1
    



        int[] numbers = { 4, 7, 10 };
        int product = numbers.Aggregate(1, (int interim, int next) => interim * next);// лямбда выражение output: 280
    }
    public string Fuuu() => "Fuuu";// определение тела выражения

    public class SomeBase<T> where T : SomeBase<T>, new()// T Как параметр универсального типа
    public class NextBase<GenericThingy> where GenericThingy : SomeBase<GenericThingy>, new()
}
