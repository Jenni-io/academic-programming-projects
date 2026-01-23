''' 
-----------------------------------------------------------------------------
Solution:        Lab 7

-----------------------------------------------------------------------------
Developer:      Jenni Morales
Course:         Intro to Programming & Logic – CITC-1301
Creation Date:  11/12/2024
Last Mod Date:  11/12/2024
E-mail Address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------------------
Purpose - Generate a student Web Page
-----------------------------------------------------------------------------
Description of input: <students name, major, collage, expected gradutation year 
and sentence of hobbies/or intrest>
Description of output: <All input will be writen into a
 file that will then be converted to a webpage in html>

-----------------------------------------------------------------------------
'''

def main():

    # defines what the program does
    print('Student Web Page Generator')
    print('This program generates a web page based on entered information')
    
    # all while loops are infinite with the true boolean statement
    # This allows with the len() function to verify if there is
    # any input in the input statements if not a error message returns 
    while True:
        name = input("Enter your name: ")
        if len(name) > 0:
            break
        else:
            print("Must enter one or more characters.")

    # Verification of input in major input statement 
    while True:
        major = input("Enter your major: ")
        if len(major) > 0:
            break
        else:
            print("Must enter one or more characters.")

    # Verification of input in major input statement 
    while True:
        college = input("Enter your college: ")
        if len(college) > 0:
            break
        else:
            print("'Must enter one or more characters. ")

    # Verification of input in major input statement 
    while True:
        try:
            gradYear = str(input("Enter your expected graduation year: "))
            if len(gradYear) > 0 and gradYear.isdigit():
                break
            else:
                print('Must be a numeric value.')
        except ValueError:
            print("Must be a numeric value. ")

    # input statement of hobbies and intrest
    hob = input("Hobbies and Interests : ")
    filename = 'biography.html'
    
    # passes variables to the writeBiography() function
    writeBiography(filename, name, major, college, gradYear, hob)
    
    # This fuction generates the student web page by writing 
    # HTML syntax to a html file
def writeBiography(filename, name, major,college,gradYear,hob):

    try: 
        # Opens the file from the filename varible in main function
        outputFile = open(filename, 'w') 

        # the syntax is being writen to the file
        outputFile.write('<html>' + '\n')
        outputFile.write('<head><title>' + college + 'student:' + name + '</title></head>' + '\n')
        outputFile.write('<body>')
        outputFile.write('<center><h1>' + name + '</h1></center>' + '\n')
        outputFile.write('<hr />' + '\n')
        outputFile.write('<p> My name is' + name + '. I am a' + major + 'major at' + college + '. I expect to graduate in' + gradYear + '</p>' + '\n' )
        outputFile.write('<br /><br />' + '\n')
        outputFile.write('<p>' + hob + '</p>' + '\n')
        outputFile.write('<hr />' + '\n')
        outputFile.write('</body>' + '\n')
        outputFile.write('</html>' + '\n')

        # Closes the file
        outputFile.close()

        # Anounces the file was writen
        print('Writing web pages to "biography.html".')
        print('Done!')
        # Describs a error that happend with writing file
    except Exception as err:
        print(f"An error occurred while writing the file")

main ()

