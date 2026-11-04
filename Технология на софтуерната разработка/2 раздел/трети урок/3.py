import math

def print_even(*args):
    even_numbers = [num for num in args if isinstance(num, int) and num % 2 == 0]
    print(f"Четни числа: {even_numbers}")

def is_prime(n):
    if n < 2:
        return False
    for i in range(2, int(math.sqrt(n)) + 1):
        if n % i == 0:
            return False
    return True

def count_primes(*args):
    count = 0
    for num in args:
        if is_prime(num):
            count += 1
    return count
