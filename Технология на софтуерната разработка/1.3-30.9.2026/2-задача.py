#fibonacci
n = int(input("Enter number n: "))

if n > 0:
    print("Enter number > 0")

elif n == 1:
    print("fibonacci number: 1")

else:
    a = 1
    b = 1
    for _ in range(3, n+1):
        a, b = b, a + b
        print(b, end=" ")
    print()