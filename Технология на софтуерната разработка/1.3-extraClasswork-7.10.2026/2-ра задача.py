sumEven = 0
countNegative = 0

while(True):
    enter = input("Enter positive uneven number: ")
    if enter == "stop": 
        break
    else:
        if int(enter) % 2 == 0 or (int(enter) % 2 == 0 and int(enter) < 0):
            print("This is even number, enter UNEVEN")
            sumEven = sumEven + int(enter)
        if int(enter) < 0:
            print("Enter positive number")
            countNegative += 1
        elif int(enter) % 2 != 0 and int(enter)>0:
            print("number passes!")

print("-----------------------------------")
print(f"SUM of even numbers = {sumEven}")
print(f"COUNT of negative = {countNegative}")    