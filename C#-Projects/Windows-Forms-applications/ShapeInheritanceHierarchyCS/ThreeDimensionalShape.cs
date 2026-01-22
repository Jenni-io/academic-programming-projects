// Abstract class that also inherits from Shape

using System.Runtime.CompilerServices;

public abstract class ThreeDimensionalShape : Shape {
    // Auto implemented properties 
    public int Dimension1 { get; set; }
    public int Dimension2 { get; set; }
    public int Dimension3 { get; set; }
    // Get only abstract properties
    public abstract double Area { get; }
    public abstract double Volume { get; }

    // This constructer passes relevent base class arguements to the base class constructer 
    public ThreeDimensionalShape(int x, int y, int d1, int d2, int d3) : base(x, y ){ 
        // Assigns this classes parameters to their repective properties
        Dimension1 = d1; 
        Dimension2 = d2; 
        Dimension3 = d3;

    }

}
