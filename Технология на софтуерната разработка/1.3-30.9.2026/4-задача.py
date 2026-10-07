num = int(input("Enter '!{number}'  !"))
calc = num
for i in range (1, calc):
    calc = calc * i

print(f"!{num} = {calc}")