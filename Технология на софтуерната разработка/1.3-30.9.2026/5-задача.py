num = int(input("Enter positive number: "))

sum_all = 0
odd_count = 0
even_count = 0 

while num > 0:
    digit = num % 10
    sum_all += digit

    if digit % 2 == 0:
        even_count += 1
    else:
        odd_count +=1

    num //= 10

print(f"sum: {sum_all}, odd count: {odd_count}, even count: {even_count}")


