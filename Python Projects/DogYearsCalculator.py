''' 
-----------------------------------------------------------------------------
Solution:        Lab 5

-----------------------------------------------------------------------------
Developer:      Jenni Morales
Course:         Intro to Programming & Logic – CITC-1301
Creation Date:  11/5/2024
Last Mod Date:  11/5/2024
E-mail Address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------------------
Purpose - Calculates a dog's approximate age in dog years based on human years
-----------------------------------------------------------------------------
Description of input: <Dogs age in human years>
Description of output: <The actual age of the dog in dog years>

-----------------------------------------------------------------------------
'''
# Constants
FIRST_YEAR_EQUIV = 15
SECOND_YEAR_EQUIV = 9
THREE_PLUS_YEARS_MULTIPLIER = 5

def main():
    # Output program's purpose
    print("This program calculate's a dog's approximate age in \"dog years\" based on human years.\n")

    # Get human years from user
    humanYears = float(input("Dog's age in human years? "))
    # while loop informs the user that "Human years must be a positive number"
    #  and ask the user to enter humanYears again 
    while  humanYears <= 0:
        print("\nHuman age must be a positive number.")
        humanYears = float(input("Dog's age in human years? "))
        
    dogYears = getDogYears(humanYears)
    print("\nA dog with a human age of", format(humanYears, ",.1f"), "years is", 
            format(dogYears, ",.1f"), "in dog years.")

def getDogYears(humanYears): 
        # Human years to dog years calculation
        if humanYears <= 1:
            dogYears = FIRST_YEAR_EQUIV * humanYears
        elif humanYears <= 2:
            dogYears = FIRST_YEAR_EQUIV + SECOND_YEAR_EQUIV * (humanYears - 1)
        else:
            dogYears = FIRST_YEAR_EQUIV + SECOND_YEAR_EQUIV + THREE_PLUS_YEARS_MULTIPLIER * (humanYears - 2)
        # end if
        return  dogYears

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if
