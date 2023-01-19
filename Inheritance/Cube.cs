
// See https://aka.ms/new-console-template for more information

class Cube : Shape, IShape
{



    public double Width { get; set; }

    public double Height { get; set; }

    public double getArea()
    {
        return Length * Length;
    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}
