using System;

Console.WriteLine("1.������� 2 �����");
Console.WriteLine("2.������� ������ �� �������");
Console.WriteLine("3.����������� ��� �����");
Console.WriteLine("4.��������� ������ �� ������");
Console.WriteLine("5.�������� � ������� N ������ �����");
Console.WriteLine("6.����� ���������� ������ �� �����");
Console.WriteLine("7.����� n - �� ������� �� �����");
Console.WriteLine("8.����� ��������� �� �����");
Console.WriteLine("9.����� �� ���������");
Console.WriteLine("�������� ���� �� ��������: ");
int d = Convert.ToInt32(Console.ReadLine());
while (d != 9);
{
    if(d == 1)

    {
        Console.WriteLine("������� ������ �����: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("������� ������ �����: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("���������: ");
        Console.WriteLine(a + b);
    }

    else if(d == 2)
    {
        Console.WriteLine("������� ������ �����: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("������� ������ �����: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("���������: ");
        Console.WriteLine(a - b);
    }

    else if(d == 3)
    {
        Console.WriteLine("������� ������ �����: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("������� ������ �����: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("���������: ");
        Console.WriteLine(a * b);
    }

    else if(d == 4)
    {
        Console.WriteLine("������� ������ �����: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("������� ������ �����: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("���������: ");
        Console.WriteLine(a / b);
    }

    else if(d == 5)
    {
        Console.WriteLine("������� �����: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("������� �������: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int c = a;
        for(int t = 1; t < N; t++)
        {
            c = a * c;
        }
        Console.WriteLine("���������: ");
        Console.WriteLine(c);
    }

    else if(d == 6)
    {
        Console.WriteLine("������� �����: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(a));
    }

    else if(d == 7)
    {
        Console.WriteLine("������� ������ �����: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("������� �������, ������� ���� �����: ");
        double n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("���������: " + a / 100 * a);
    }

    else if(d == 8)
    {
        Console.WriteLine("������� �����: ");
        int f = 1;
        for(int r = 2; r <= Convert.ToInt32(Console.ReadLine()); r++)
        {
            f = f * r;
        }
        Console.WriteLine("���������: " + f);
    }
}