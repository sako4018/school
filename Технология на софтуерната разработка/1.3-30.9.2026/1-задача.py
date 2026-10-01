a = int(input("Enter a: "))
b = int(input("Enrwe b: "))

original_a, original_b = a, b

while a != b:
    if a > b:
        a = a - b
    else:
        b = b-a

print("NOD of: " + original_a + " and " + original_b + " is: " + a)
