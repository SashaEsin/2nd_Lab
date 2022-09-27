#region Task 1 - 3

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c;
if (a > 0)
{
    c = Math.Max(a, b);
}
else
{
    c = Math.Min(a, b);
}

Console.WriteLine(c);

#endregion


#region Task 1 - 5

double S_c = 70;
double S_s = 36.74;
double Side_s = Math.Sqrt(S_s);
double Radius_c = Math.Sqrt(S_c / Math.PI);
double Radius_min = Side_s / Math.Sqrt(2);
if (Radius_c >= Radius_min)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("N0");
}

S_c = 0.86;
S_s = 0.74;
Side_s = Math.Sqrt(S_s);
Radius_c = Math.Sqrt(S_c / Math.PI);
Radius_min = Side_s / Math.Sqrt(2);
if (Radius_c >= Radius_min)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("N0");
}

#endregion

#region Task 1 - 10 

double x = Convert.ToDouble(Console.ReadLine());
double y;

if (x <= -1)
{
    y = 0;
}
else if ((x > -1) && (x <= 0))
{
    y = x + 1;
}
else
{
    y = 1;
}

Console.WriteLine(y);

#endregion


#region Task 2 - 1

int n = Convert.ToInt32(Console.ReadLine());
while (n == 0)
{
    n = Convert.ToInt32(Console.ReadLine());
}

double mid_tall = 0;
for (int i = 0; i < n; i++)
{
    mid_tall += Convert.ToDouble(Console.ReadLine());
}

mid_tall /= n;
Console.WriteLine(mid_tall);

#endregion

#region Task 2 - 10

int mark1, mark2, mark3, mark4;
int cout1 = 0;
int n2 = Convert.ToInt32(Console.ReadLine());
string[] marks1;
for (int i = 0; i < n2; i++)
{
    marks1 = Console.ReadLine().Split();
    mark1 = int.Parse(marks1[0]);
    mark2 = int.Parse(marks1[1]);
    mark3 = int.Parse(marks1[2]);
    mark4 = int.Parse(marks1[3]);
    if ((mark1 > 3) && (mark2 > 3) && (mark3 > 3) && (mark4 > 3))
    {
        cout1 += 1;
    }
    marks1 = Array.Empty<string>();

}

Console.WriteLine(cout1);

#endregion


#region Task 3 - 4
int r1 = Convert.ToInt16(Console.ReadLine());
int r2 = Convert.ToInt16(Console.ReadLine());
string x1, y1;
string line1 = Console.ReadLine();
string[] coord;
int count2 = 0;

while (line1 != "")
{
    coord = line1.Split();
    x1 = coord[0];
    y1 = coord[1];
    if ((Math.Abs(int.Parse(x1)) <= r2) && (Math.Abs(int.Parse(y1)) >= r1) && (Math.Abs(int.Parse(y1)) <= r2))
    {
        count2++;
    }

    line1 = Console.ReadLine();

}

Console.WriteLine(count2);

#endregion

#region Task 3 - 11
string[] marks2;
string line2 = Console.ReadLine();
string mark21, mark22, mark23, mark24;
double mid_mark1;
double mid_mark2 = 0;
int count3 = 0;
int count4 = 0;
while (line2 != "")
{
    marks2 = line2.Split();
    mark21 = marks2[0];
    mark22 = marks2[1];
    mark23 = marks2[2];
    mark24 = marks2[3];
    mid_mark1 = (double.Parse(mark21) + double.Parse(mark22) + double.Parse(mark23) + double.Parse(mark24)) / 4;
    if (mid_mark1 < 2.5)
    {
        count3++;
    }
    count4++;
    mid_mark2 += mid_mark1;
    line2 = Console.ReadLine();
}
mid_mark2 /= count4;

Console.WriteLine(count3 + " " + mid_mark2);
#endregion

#region Task 3 - 12
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Выберете площадь, которую хотите посчитать: 1 - площадь квадрата; 2 - площадь круга; 3 - площадь равностороннего треугольника");
int choice = Convert.ToInt16(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine(Math.Pow(r, 2));
        break;
    case 2:
        Console.WriteLine(Math.Pow(r, 2) * Math.PI);
        break;
    case 3:
        Console.WriteLine(Math.Pow(r, 2) * Math.Sqrt(3) / 4);
        break;
    default:
        break;
}

#endregion

#region Task 3 - 13

double A, B;
string line3 = Console.ReadLine();
string[] sides;
int choice2;
while (line3 != "")
{
    sides = line3.Split();
    A = double.Parse(sides[0]);
    B = double.Parse(sides[1]);
    Console.WriteLine("Выберете плозадь, которую хотите посчитать: 1 - площадь прямоугольника; 2 - площадь кольца; 3 - площадь равнобедренного треугольника");
    choice2 = Convert.ToInt32(Console.ReadLine());
    switch (choice2)
    {
        case 1:
            Console.WriteLine(A * B);
            break;
        case 2: 
            Console.WriteLine(Math.Pow(Math.Max(A, B), 2) * Math.PI - Math.Pow(Math.Min(A, B), 2) * Math.PI);
            break;
        case 3:
            Console.WriteLine(B * Math.Sqrt(4 * Math.Pow(A, 2) - Math.Pow(B, 2)) / 4);
            break;
    }
    line3 = Console.ReadLine();
}

#endregion
