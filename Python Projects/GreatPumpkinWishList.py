# I would like to replace Lab 6 please

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