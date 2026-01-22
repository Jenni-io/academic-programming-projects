// Abstract class that inherits from Shape
public abstract class TwoDimensionalShape : Shape {
    // Auto implemented properties
    public int Dimension1 { get; set; }
    public int Dimension2 { get; set; }
    // Get only abstract property 
    public abstract double Area { get; }

    // This constructor paasses the  relevant base class arguments to the base class constructor and
   // assign this class's parameters to their respective properties
    public TwoDimensionalShape(int x, int y, int d1, int d2) : base( x, y) {
        Dimension1 = d1;
        Dimension2 = d2;
    }
}