''' 
-----------------------------------------------------------------------------
Solution:        Lab 6

-----------------------------------------------------------------------------
Developer:      Jenni Morales
Course:         Intro to Programming & Logic – CITC-1301
Creation Date:  11/5/2024
Last Mod Date:  11/5/2024
E-mail Address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------------------
Purpose - To accept a jedi they must guess the correct random number 
under 3 trys if not they are not accepted.
-----------------------------------------------------------------------------
Description of input: <users enter their guess>
Description of output: <if guessed under 3 tries they are accepted>
<if not guessed in 3 tries their to weak and not accepted>

-----------------------------------------------------------------------------
'''
import random

def main():
     # intro to the game and purpose
    print(' ')
    print ('Your long life dream depends on you answer to become a Jedi Council')
    print(' ')
    print ('You have 3 tries to guess a number between 1 and 20')
    print(' ')
    
    # This choses a randome number between 1 and 20
    num = str(random.randint(1, 20))
    
    # gets users first guess and passes the first guess to the first function
    guess1 = input('The number has been chosen what is your first guess? ')
    first(guess1, num)

    # Gets users second guess plus passes  info to second function
    guess2 = input('What is your second guess? ')
    second(guess2, num)

    # Gets users third guess plus pass info to third function
    guess3 = input('What is your third guess? ')
    third(guess3, num)

   
     # first funtion for first guess. Outputs a message depending on if first guess is
     #  higher or lower than random number
def first(guess1, num):

    if num == guess1 :
        print('You guessed the correct number! Congratulations, been accepted to the Jedi Council you have!') 
    
    elif guess1 > num :
        print('Too High, Guess again! ') 

    elif guess1 < num :
        print('Too Low, Guess again! ')
    
    else:
        print('whats your second guess: ')

        
     # Second funtion for Second guess. Outputs a message depending on if second guess is
     #  higher or lower than random number
def second(guess2, num):

    if num == guess2 :
        print('You guessed the correct number! Congratulations, been accepted to the Jedi Council you have!') 
    
    elif guess2 > num :
        print('Too High, Guess again! ')
        
    elif guess2 < num :
        print('Too Low, Guess again! ')
       
    else:
        print('whats your third guess: ')

       
     # Third funtion for Third guess. Is the final attemp to guess the correct num if correct congrats
     # if not YOU WEAK
def third(guess3, num):

    if num == guess3 :
          print('You guessed the correct number! Congratulations, been accepted to the Jedi Council you have!')

    else: 
        guess3 != num 
        print('Ready for the Jedi Council you are not. Weak with the force you are!')
          
# calls main function
main()