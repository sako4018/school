numbers = [1,2,3]
numbers.append([4,5])
print(f"append: {numbers}")

numbers.extend([6,7])
print(f"after 'extend': {numbers}")

numbers.insert(1,99)
print(f"with inserted numbers: {numbers}")

numbers.remove([4,5])
print(f"removed [4,5]: {numbers}")

numbers.reverse() 
touple_number = tuple(numbers)
print(f"кортеж {touple_number}")