// This is a concrete CLass that inherits ThreeDimensionalShape

using System.ComponentModel;
using System.Drawing;

public class Sphere : ThreeDimensionalShape {
    public int Radius {
        get {
            return Dimension1;
        }
        set {
            Dimension1 = value;
            Dimension2 = value;
            Dimension3 = value;
        }
    }
    // This property OVERRIDES the Abstract Area property of ThreeDimensionalShape
    // And Calculates/Returns the area of a Sphere
    public override double Area { 
        get {
            return 4*(Math.PI * Math.Pow(Radius, 2)); 
        }
    }
    // This property OVERRIDES the Abstract Volume property of 
    // And Calculates/Returns the Volume of a square
    public override double Volume {
        get {
            return 4 * (Math.PI * Math.Pow(Radius, 3)) / 3;
        }
    }
    // This property OVERRIDES the Abstract Name property
    // And returns the name of the shape 
    public override string Name {
        get {
            return "Sphere";
        }
    }
    // Constructer that pases relevant base class arg to base class constructer
    public Sphere(int x, int y, int radius) : base(x, y, radius, radius, radius) {
        Radius = radius;
    }

    public override string ToString() => $"{base.ToString()} \nRadius: {Radius}\n";
}