/* 
----------------------------------------------------------------
<Program Title> Math equation generator
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 3/22/25
Last modified: 3/26/25
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose:
This program generats a equation seperated by left right and Operand 
then verifies answer to said equation 
-----------------------------------------------------------------
*/


public enum MathOperation
{

    Addition = 0,
    Subtraction = 1,
    Multiplication = 2,
    Modulus = 3
} 

public class MathQuestion {

    // initalizes left right operand and operation
    private static int _leftOperand;
    private static int _rightOperand;
    private static MathOperation _operation;


    private static MathOperation GetOperator() {
        // generats a random num from 0 to 3 to identifi what operand will _operation be
        Random RND = new Random();
        return (MathOperation)RND.Next(0, 4);

    }

    private static int GetOperand() {
        // generats a random num from 0 to 9 for left and right operand
        Random RND = new Random();
        return RND.Next(0, 10);

 
    }

    public static string GetProblem()  {

        // calls GetOperand to assing random num to the left and right operands.
        _leftOperand = GetOperand();
        _rightOperand = GetOperand();

        // calls GetOperator and asigns randome num to _operation
        _operation = GetOperator();

        // if rightOperand is 0 and _operation is % this changes the right operands number
        while (_operation == MathOperation.Modulus && _rightOperand == 0) {
            _rightOperand = GetOperand();
        }

        string symbol = "";

        // assigns the correct symbole from the num from MathOperation 
        switch (_operation) { 
        case MathOperation.Addition:
             symbol = "+";
                break;
        case MathOperation.Subtraction:
             symbol = "-";
                break;
        case MathOperation.Multiplication:
             symbol = "X";
                break;
        case MathOperation.Modulus:
             symbol = "%";
                break;
        default:
                symbol = "?";
                break;
        }
        // concatenats the correct equation format
            return $"{_leftOperand} {symbol} {_rightOperand} = ";
    }


    public static int GetAnswer() {
        int result = 0;
        
        // finds the correct answer to the question given to the user
        switch (_operation) {
            case MathOperation.Addition:
                result = _leftOperand + _rightOperand;
                break;
            case MathOperation.Subtraction:
                result =  _leftOperand - _rightOperand;
                break;
            case MathOperation.Multiplication:
                result = _leftOperand * _rightOperand;
                break;
            case MathOperation.Modulus:
                result = _leftOperand % _rightOperand;
                break;
            default:
                result = 0;
                break;
        }
        // returns correct answer to be then compared
        return result;
    }
}