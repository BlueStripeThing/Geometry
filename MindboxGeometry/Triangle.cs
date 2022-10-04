namespace MindboxGeometry;

public class Triangle : Shape
{
    private double a, b, c;

    //При создании треугольника - сортировка сторон по возрастанию,
    //что бы избавится в последствии от условий в проверках.
    //Сделано с мыслью что пользователю не требуется доступ к сторонам
    public Triangle(double a, double b, double c)
    {
        double temp;
        if (a > b)
        {
            temp = b;
            b = a;
            a = temp;
        }
        if (b > c)
        {
            temp = c;
            c = b;
            b = temp;
        }
        if (a > b)
        {
            temp = b;
            b = a;
            a = temp;
        }
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double FindArea()
    {
        if (Exists())
        {
            if (IsRight())
            {
                return (a * b) / 2;
            }
            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        else return 0;
    }

    //Проверка на прямоугольный треугольник
    private bool IsRight()
    {
        if (a * a + b * b == c * c)
        {
           // Console.WriteLine("Это прямоугольный треугольник");
            return true;
        }
        else return false;
    }
    
    //Проверка на существование треугольника
    private bool Exists()
    {
        if (a + b > c)
        {
            return true;
        }
        else
        {
           // Console.WriteLine("Такого треугольника не существует");
            return false; 
        }
    }
}