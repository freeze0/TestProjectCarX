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

        int[] array1 = new int[10]; // ��������� ���
        object[] array2 = new object[100]; // object - ����� �� ������ � ������, ��� ������� �������� � "����"
        array2[0] = "asdfghj"; // 

        List<int> list = new List<int>(); // ������� ������ "��� �������", ���� ����� ��������� ����� ������, �� ������ ��� ������ ������ � ������ ������ � �����,
                                          // ����������� ������, ���������� ������, ����� ����� ��������� capacity, ������������� ������

        TestFunc(ref i);

        MyClass mc = new MyClass(); // �������� ������ 

        var gf = mc;

        Debug.Log($"short:{short.MinValue} - {short.MaxValue}");

    }

    public void TestFunc(/* in / out */ ref int i) // in �������� �������� �� ���������, ref ��������� �������� ��������� ���������� �������� ����� ����� ������� 10,
                                                   // out ������� ��� �� ������� � ����������
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