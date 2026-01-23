''' 
-----------------------------------------------------------------------------
Solution:        Lab 8

-----------------------------------------------------------------------------
Developer:      Jenni Morales
Course:         Intro to Programming & Logic – CITC-1301
Creation Date:  11/21/2024
Last Mod Date:  11/21/2024
E-mail Address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------------------
Purpose - Program that allows input pf grocery bill for each 12 months in year  
and calculate 
Total Average and Max/Min of grocery bills.
-----------------------------------------------------------------------------
Description of input: <Users grocery bill for each month in year>
Description of output: <MIN MAX AVERAGE and TOTAL of those numbers>

-----------------------------------------------------------------------------
'''

def main():
    # Tells the user that the program calculates total, average, lowest and highest grocery bills entered
    print('This program calculates the total, average, lowest and highest grocery bills entered')
    # list of the 12 months
    months = ['January', 'Febuary', 'March', 'April', 'May', 'June', 'July', 'August', 'September',
     'October', 'November', 'December']
    # the emty list that with the users input will contain the grocery bills of each month
    bills = [0] * len(months)
    
    total = 0 # acumelater for the sum 

    
    for index in range (len(months)):

     # this while loop allows that the user is informed that a error ocured when 
     # entering the input and is given the same promt 
     while True :
      try:
          bills[index] = float(input(f'Enter the grocery bill for {months[index]} : $')) # this loop loops 12 times and asks  
          break                                                               # the user for input of grocery bills to add to the bills list 

      except ValueError:
            print('Must be a numeric value.')

    # calculates total value in bills list
    for value in bills:
        total += value

    # calculates total average of bills list
    average = total / len(months)

    # gets the max and min number of bills list
    highBill = max(bills)
    lowBill = min(bills)

    # from high and low bill varables the bill.index gets the index of the numbers -
    # in the variable and maches it to the index of the months list
    highMon = months[bills.index(highBill)]
    lowMon = months[bills.index(lowBill)]

    # outputs to the user the total, average, min and max months from bill list
    print(f'\nTotal grocery bill : ${total:,.2f}')
    print(f'Average grocery bill : ${average:,.2f}')
    print(f'Highest grocery bill : {highMon}')
    print(f'Lowest grocery bill: {lowMon}')


main()
