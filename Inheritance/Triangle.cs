
// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    public Triangle()
    {

    }

    public Triangle(int hyp)
    {
        Hypotenuse = hyp;
    }

    public Triangle(int hyp, int height, int length)
    {
        Hypotenuse = hyp;
        Height = Height;
        Length = Length;
    }

    public double Hypotenuse { get; set; }

    public double getArea()
    {
        return .5 * Length * Height;
    }
}

