using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;




public class MyClass<TItem>
{
    private TItem[] m_array = new TItem[10];

    public void Insert(TItem[] item)
    {

    }

}


public class TestScripts : MonoBehaviour
{
    void Start()
    {
        System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
        short s = 0;
        long l = long.MaxValue;
        int i = 0;
        //float f = 0;
        double d = 0;
        object o = d;
        double d2 = (double)o;
        i = (int)l;

        int[] array1 = new int[10]; // ��������� ���
        object[] array2 = new object[100]; // object - ����� �� ������ � ������, ��� ������� �������� � "����"
        array2[0] = "asdfghj"; // 

        List<int> list = new List<int>(); // ������� ������ "��� �������", ���� ����� ��������� ����� ������, �� ������ ��� ������ ������ � ������ ������ � �����,
                                          // ����������� ������, ���������� ������, ����� ����� ��������� capacity, ������������� ������
        TestFunc(ref i);

       /* MyClass mc = new MyClass(); // �������� ������ */

        var gf = s;

        //Debug.Log($"short:{short.MinValue} - {short.MaxValue}");

        //Debug.Log("12");

        MyClass<uint> mc = new MyClass<uint>();

        TestFunc<int>(ref i);

        //sw = .StartNew();

        for (int j = 0; j < 100000; j++)
        {
            //myList.Push(new MyClass());
        }

        List<int> standartList = new List<int>();
        //Debug.Log("Stopwatch");
    }
    

    public void TestFunc(/* in / out */ ref int i) // in �������� �������� �� ���������, ref ��������� �������� ��������� ���������� �������� ����� ����� ������� 10,
                                                   // out ������� ��� �� ������� � ����������
    {
        i = 10;
        //Debug.Log(i);
    }

    public void TestFunc<T>(ref T i) where T: struct
    {

    }

    /*public void TestFunc(MyClass mc)
    {
        mc.i = 1;
        mc.j = 2;
    }*/
    



}