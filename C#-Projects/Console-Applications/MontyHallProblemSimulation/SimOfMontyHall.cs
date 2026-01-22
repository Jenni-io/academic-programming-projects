
/* 
----------------------------------------------------------------
<Program Title> Monty Hall problem 
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 4/27/2025
Last modified: 5/2/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose: "Sets up " a simulation of game show where the "Player"
choose a door to win are car or a goat
-----------------------------------------------------------------
*/
public enum GameStrategy // is moved outside class to
{                       // be able to use in the Driver test
    Keep = 0,
    Switch = 1,
    Random = 2
}// end enum

public enum GameResult // is moved outside class to
{                      // be able to use in the Driver test
    Won = 0,
    Lost = 1
}// end enum

public class LetsMakeADeal {

    private enum DoorPrize // Player Shouldn't
    {                        // know whats behind the door therefor private
        Null = 0,
        Car = 1,
        Goat = 2
    }// end enum


    private Random rnd = new Random(); 
    private DoorPrize[] _doors = new DoorPrize[3];
    private int CarDoor { get; set; }
    
    public LetsMakeADeal() {
        // makes all doors contain a goat first
        for (int i = 0; i < 3; i++) {
            _doors[i] = DoorPrize.Goat;
        }
        // the door that contains a car is chose randomly
        CarDoor = GetRandomDoor();// calls the method to get random door
        _doors[CarDoor] = DoorPrize.Car; // assigns car to randomly chosen door(index)
    }

    public GameResult PlayGame(GameStrategy strategy) {
        int playerDoor = GetRandomDoor(); // since no input randomly get players door
        int hostDoor = GetHostDoor(playerDoor); // choses the door host will reveal

        int finalDoor = 0;  

        // Determins "Players" final choice based on strategy (since this is a simulation the test driver passes through the strategy choice)
        switch (strategy) {
            case GameStrategy.Keep:
                finalDoor = playerDoor;  // Keeps OG choice
                break;
            case GameStrategy.Switch:
                finalDoor = GetSwitchDoor(playerDoor, hostDoor); // door that isnt OG players choice OR door reveled
                break;
            case GameStrategy.Random:
                if(rnd.Next(2) == 0)  { // choses between strategy 0(Keep) or 1 (Switch)
                    finalDoor = playerDoor; // Keeps OG choice
                } else {
                    finalDoor = GetSwitchDoor(playerDoor, hostDoor); // door that isnt OG players choice OR door reveled

                }
                break;
            default:
                finalDoor = playerDoor; // shouldn't happend BUT provided to aviod errors 
                break;


        }
        // if your FINAL Choice is the card door you win else boo hoo
        if (_doors[finalDoor] == DoorPrize.Car) {
            return GameResult.Won;
        } else {
            return GameResult.Lost;
        }


    }

    // Method ensure door that will be switched will not be the OG door or door already revealed
    private int GetSwitchDoor (int playerDoor, int hostDoor) {
        for (int num = 0; num < 3; num++) {
            if (num != playerDoor && num != hostDoor) {
                return num;
            }
        }
        return playerDoor; // shouldnt happen, placed to get rid of error
    }
    private int GetRandomDoor() {

        return rnd.Next(0, 3);// random num from 0 to 2 will be chosen
    }

    private int GetHostDoor(int playerDoor) {
        int door;
        do {
            door = rnd.Next(0, 3); // Makes sure the door is always randomly choosen 
        } while (_doors[door] == DoorPrize.Car || door == playerDoor); // if random door(num index) doesnt contain a car
            return door;                                                // OR is the players door THIS will be the door revealed
                                                                        // to player
        
    }
}
