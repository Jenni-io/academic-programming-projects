''' 
-----------------------------------------------------------------------------
Solution:        Great Pumpkin 

-----------------------------------------------------------------------------
Developer:      Jenni Morales
Course:         Intro to Programming & Logic – CITC-1301
Creation Date:  11/26/2024
Last Mod Date:  12/4/2024
E-mail Address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------------------
Purpose - Creates a list based on users wishes to the Great pumpkin
-----------------------------------------------------------------------------
Description of input: <Users input on what it wishes>
Description of output: <Creates a new file called 'GreatPumpkin.txt' that contains 
the list of wishes the user want the Great Pumpkin to Grant them>

-----------------------------------------------------------------------------
'''

def main():
    # Empty list to add items
    wish = []
    again = 'y'
    print('This program creats a file that writes a list you wished from the great pumpkin')
    print(' ')
    print('What would you like to recive from the great pumpkin?')

    # Loops and asks if user wishes to add items
    while again == 'y' or again == 'Y':
        wish_list = str(input('Enter item: '))
        wish.append(wish_list)   # adds wish iteams from wish_list variable to the empty wish list
        again = input ('Do you want to add a item? y/n ' ) 
        if again == 'N' or again == 'n':
                break

    try:
        infile = open('GreatPumpkin.txt', 'w') # writes and creates text file if it doesn't exist
        infile.write('Great Pumpkin wish list: ')
        clean_list = ", ".join(wish) #Cleans and removes the unwanted brackets that come with a list
        
        infile.write(str(clean_list)) # writes and turns the var wish's list to string
        infile.close() # close file

    except Exception as err:
            print(f"An error occurred while writing the file")

    try:
        infile = open('GreatPumpkin.txt', 'r') # reads text file
        print(infile.readline()) # reads lines
        infile.close() # close file
    except Exception as err:
            print(f"An error occurred while reading the file")
main()