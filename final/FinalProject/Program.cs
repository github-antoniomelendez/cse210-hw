using System;

class Program
{
    static void Main(string[] args)
    {
        List<Solid> solids = new List<Solid>();

        Cube solid1 = new Cube("cube", "Green", 3);
        solids.Add(solid1);

        Cuboid solid2 = new Cuboid("cuboid", "Purple", 4, 5, 3);
        solids.Add(solid2);

        Sphere solid3 = new Sphere("sphere", "Yellow", 10);
        solids.Add(solid3);

        Cone solid4 = new Cone("cone", "Blue", 8, 6, 7);
        solids.Add(solid4);

        Cylinder solid5 = new Cylinder("cylinder", "Black", 9, 6);
        solids.Add(solid5);

        Pyramid solid6 = new Pyramid("Pyramid", "Red", 9, 6, 4);
        solids.Add(solid6);

        Prism solid7 = new Prism("Prism", "Orange", 4, 12, 2);
        solids.Add(solid7);

        foreach (Solid s in solids)
        {
            //this gets the color of the solid
            string color = s.GetColor();

            //this gets the name of the solid
            string name = s.GetName();

            //this gets the volume of the solid
            double volume = s.GetVolume();

            //This gets the surface area in the solid
            double areaFaces = s.GetSurfaceArea();

            Console.WriteLine($"The {color} {name} has a volume of {volume} cm3.");
            Console.WriteLine($"The surface area of the {color} {name} is {areaFaces} cm2.");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Geometry is fun!");
    }

}