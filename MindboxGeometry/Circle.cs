using System.ComponentModel;

namespace MindboxGeometry;

//При радиусе круга < 0, радиус устанавливается на 0
public class Circle : Shape
{
    private double rad;

    public Circle(double rad)
    {
        if (rad <= 0) rad = 0;
        this.rad = rad;
    }

    public double FindArea()
    {
        return rad * rad * Math.PI;
    }
}