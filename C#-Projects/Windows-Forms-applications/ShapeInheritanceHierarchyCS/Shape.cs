// Shape will be the base class for this program
public abstract class Shape {
    // Auto implemented properties 
      public int X {  get; set; }
      public int Y { get; set; }
      public abstract string Name { get;}

    // Constructer that Assigns parameters to their respecative properties
      public Shape (int x, int y) {
        X = x;
        Y = y;

    }
    // Returns a string representaion of a object using the lambda expression
    public override string ToString() => $"Name:{Name} \n" +
                                         $"X:{X}\n" +
                                         $"Y:{Y}";

}
