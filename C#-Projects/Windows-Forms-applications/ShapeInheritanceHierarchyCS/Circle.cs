// Another concreate class that inherits from TwoDimensionalShape class

public class Circle : TwoDimensionalShape {
    public int Radius {
        get {
            return Dimension1;
        }
        set {
            Dimension1 = value;
            Dimension2 = value;
        }
    }
    // This property OVERRIDES the Abstract Area property
    // And Calculates/Returns the area of a Circle
    public override double Area {
        get {
            return Math.PI * Radius * Radius;
        }
    }

// This property OVERRIDES the Abstract Name property
// And returns the name of the shape 
public override string Name {
        get {
            return "Circle";
        }
    }
    // Constructer that pases relevant base class arg to base class constructer
    public Circle(int x, int y, int radius) : base(x, y, radius, radius) { 
        Radius = radius;
      
    }

    public override string ToString() => $"{base.ToString()} \nRadius: {Radius}\n"; 
 

}