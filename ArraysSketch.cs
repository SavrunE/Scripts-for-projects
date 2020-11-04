using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public void Start()
    {
        DictionaryHint();
    }

    void Update()
    {

    }
    private void DictionaryHint()
    {
        Dictionary<string, string> counters = new Dictionary<string, string>();
        counters.Add("Russia", "Moscow");
        counters.Add("Spain", "Madrid");
        counters.Add("France", "Paris");

        counters.Remove("Spain");

        if (counters.ContainsKey("Russia"))//поиск по ключу Russia выведет значение Moscow
        {
            Debug.Log(counters["Russia"]);
        }
        foreach (var city in counters)//перебор
        {
            Debug.Log($"Страна - {city.Key}, а столица - {city.Value}");
        }

    }

    //как стопка книг, последняя пришла, первая ушла
    private void StackHint()
    {
        Stack<int> numbers = new Stack<int>();

        numbers.Push(0);
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);

        while (numbers.Count > 0)
        {

            Debug.Log(numbers.Peek());//получает последний элемент без удаления 
            Debug.Log(numbers.Pop());//забираем последнее значение
        }
    }

    private void QueueHint()
    {
        Queue<string> enemies = new Queue<string>();

        enemies.Enqueue("Swordman");
        enemies.Enqueue("Archer");
        enemies.Enqueue("Bomber");
        enemies.Enqueue("Paladin");
        enemies.Enqueue("Templar");
        Debug.Log(enemies.Dequeue());//вытянуть из очереди первый элемент (он выйдет из очереди)
        Debug.Log(enemies.Peek());//получить первый элемент без удаления
        foreach (var enemy in enemies)
        {
            Debug.Log(enemy);
        }

    }
    private void ListHint()
    {
        List<int> numbers = new List<int>(3);
        numbers.Add(50);
        numbers.Add(3);
        numbers.Add(33);
        numbers.Add(333);

        numbers.AddRange(new int[] { 5, 3, 4 });//добавить в конец листа значения 5 3 4

        numbers.RemoveAt(0);// убрать 0й элемент
        numbers.Remove(3);//убрать значение 3
        Debug.Log(numbers.IndexOf(333));// поиск первого индекса, который содержит значение 333

        numbers.Insert(0, 123); //ставим в 0 индекс значение 123
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
        //for (int i = 0; i < numbers.Count; i++)
        //{

        //    Debug.Log(numbers[i]);
        //}
    }
}
