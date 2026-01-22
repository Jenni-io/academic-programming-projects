// This class is a concrete classs that inherits from ThreeDimensionalShape
public class Cube : ThreeDimensionalShape {
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
    // And Calculates/Returns the area of a Cube
    public override double Area {
        get {
            return 6 * (Side * Side);
        }
    }
    // This property OVERRIDES the Abstract Volume property of ThreeDimentionalShape
    // And Calculates/Returns the Volume of a Cube
    public override double Volume {
        get {
            return Math.Pow(Side, 3); //??

        }
    }
    // This property OVERRIDES the Abstract Name property
    // And returns the name of the shape 
    public override string Name {
        get {
            return "Cube";
        }
    }
    // Constructer that pases relevant base class arg to base class constructer
    public Cube(int x, int y, int side) : base(x, y, side, side, side) { 
        Side = side;

    }

    public override string ToString() => $"{base.ToString()} \n" +
                                         $"Side:{Side} \n";
}