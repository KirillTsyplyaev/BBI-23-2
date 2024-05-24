using System.Numerics;

internal class Program
{
    static void Main(String[] args)
    {
        Dot[] dots = 
            { 
            new Dot(1, 2, 3),
            new Dot(2,3,5), 
            new Dot (2,3,4),
            new Dot(6,3,1) 
        };
        Vector[] vector = 
        {
            new Vector(dots[0], dots[1]), 
            new Vector(dots[0], dots[2]), 
            new Vector(dots[2], dots[3]),
            new Vector(dots[1], dots[2]),
            new Vector(dots[2], dots[1])
        };
        foreach(Vector vec in vector)
        {
            Vector.VectorInfo(vec); double length = Vector.VectorLength(vec);
            Console.WriteLine($"длина вектора {length}");
        }
        
        
       
    }
}
struct Vector
{
    private Dot _dot1;
    private Dot _dot2;
   
   
    public Vector(Dot dot1, Dot dot2)
    {
        _dot1 = dot1;
        _dot2 = dot2;
    }

    public Dot Dot1
    {
        get { return _dot1; }
        private set { _dot1 = value; }
    }

    public Dot Dot2
    {
        get { return _dot2; }
        private set { _dot2 = value; }
    }

    public static double VectorLength(Vector vector)
    {
        double lengthOfVector = Math.Sqrt(Math.Pow(vector._dot2.X - vector._dot1.X, 2) + Math.Pow(vector._dot2.Y - vector._dot1.Y, 2) + Math.Pow(vector._dot2.Z - vector._dot1.Z, 2));
        return lengthOfVector;
    }

    public static void VectorInfo(Vector vector)
    {
        Console.WriteLine($" координаты первой точки {vector._dot1.X},{vector._dot1.Y}, {vector._dot1.Z}  координаты второй точки{vector._dot2.X},{vector._dot2.Y}, {vector._dot2.Z},  ");
    }
}
struct Dot
{
    
    private int[] dot = new int[3] ;

    public Dot(int x, int y, int z)
    {
        dot[0] = x;
        dot[1] = y;
        dot[2] = z;
    }

    public int X
    {
        get { return dot[0]; }
        private set { dot[0] = value; }
    }

    public int Y
    {
        get { return dot[1]; }
        private set { dot[1] = value; }
    }

    public int Z
    {
        get { return dot[2]; }
        private set { dot[2] = value; }
    }

    public int[,] returnMatrix(Dot dot1, Dot dot2)
    {
        int[,] Matrix = new int[2, 3]
        {
            { dot1.X, dot1.Y, dot1.Z},
            { dot2.X, dot2.Y,dot2.Z},
        };
        return Matrix;
    }

}