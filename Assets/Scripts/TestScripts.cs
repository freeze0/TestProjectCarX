using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyClass
{
    public int i;
    public int j;
}

public class TestScripts : MonoBehaviour
{
    void Start()
    {
        short s = 0;
        long l = long.MaxValue;
        int i = 0;
        float f = 0;
        double d = 0;
        object o = d;
        double d2 = (double)o;
        i = (int)l;

        int[] array1 = new int[10]; // ссылочный тип
        object[] array2 = new object[100]; // object - адрес на €чейку в пам€ти, все массивы хран€тс€ в "куче"
        array2[0] = "asdfghj"; // 

        List<int> list = new List<int>(); // обычный массив "под капотом", если будем добавл€ть новый объект, то удалит все старые данные и впишет данные в новый,
                                          // расширенный массив, скопировав данные, лучше сразу указывать capacity, аллоцирование пам€ти

        TestFunc(ref i);

        MyClass mc = new MyClass(); // создание класса 

        var gf = mc;

        Debug.Log($"short:{short.MinValue} - {short.MaxValue}");

    }

    public void TestFunc(/* in / out */ ref int i) // in передает значение из имеющихс€, ref позвол€ет изменить имеющуюс€ переменную создадим новую копию положим 10,
                                                   // out об€заны что то сделать с переменной
    {
        i = 10;
        Debug.Log(i);
    }

    public void TestFunc(MyClass mc)
    {
        mc.i = 1;
        mc.j = 2;
    }
}