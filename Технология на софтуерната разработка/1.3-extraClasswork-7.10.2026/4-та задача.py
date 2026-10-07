age = int(input("Enter years: "))
if age == 18:
    print("=18")
elif age > 18:
    print(">18")
else:
    print("<18")
counter = 1
while counter <= 5:
    print(f"Count: {counter}")
    counter = counter + 1
