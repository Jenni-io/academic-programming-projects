// This is a Concrete Class that inherits from
// TwoDimensionalShape (Abstract class)

public class Square : TwoDimensionalShape {
    public int Side {
        get {
            return Dimension1;
        }
        set {
            Dimension1 = value;
            Dimension2 = value;
        }
    }
    // This property OVERRIDES the Abstract Area property
    // And Calculates/Returns the area of a square
    public override double Area {
        get {
            return Side * Side;
        }
    }
    // This property OVERRIDES the Abstract Name property
    // And Returns Name of the shape
    public override string Name {
        get {
            return "Square";
        }
    }

    // Constructer that pases relevant base class arg to base class constructer
    public Square(int x, int y, int side) : base(x, y, side, side) {
        Side = side;
       
    }

    public override string ToString() => $"{base.ToString()} \nSide: {Side}\n";
}