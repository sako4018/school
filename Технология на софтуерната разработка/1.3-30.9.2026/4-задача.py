num = int(input("Enter '!{number}'  !"))
calc = num
for i in range (1, num):
    num = num * i
print(f"!{calc} = {num}")