#guess number
import random
random_number = random.randint(1, 20)
win = True
countAttempts = 0

print("---Welcome to the game! Guess the number---")
print("Number between 1-20")

while win: 
    guess = int(input("Enter your guess: "))
    countAttempts = countAttempts + 1

    if guess > random_number:
        print("The number is greater!")
    elif guess < random_number:
        print("The number is lower!")
    elif guess == random_number:
        print("You WIN!!!")
        win = False;
print(f"you needed {countAttempts} attempts")

    