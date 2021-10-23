# Importing the essential functions from modules.
from random import randint

#  Getting the necessary inputs.
start = int(input("Enter the starting number of the range from which the number will be randomly selected: "))
end = int(input("Enter the ending number of the range from which the number will be randomly selected: "))
attempts = int(input("Enter the number of attempts to guess the number: "))

if attempts < end - start:

    num, fails = randint(start, end + 1), 0

    # Loop for the main game.
    for _ in range(attempts):

        guess = int(input("Enter your guess: "))

        if guess == num:

            print("You guessed the number correctly!")
            break

        else:

            fails += 1

    if fails == attempts:

        print("You were not able to guess the number correctly.")
        
else:
    
    print("Number of attempts mut be smaller than the possible number of outcomes.")