def print_primes_in_range(m, n):
    primes = []
    for num in range(m, n + 1):
        if is_prime(num):
            primes.append(num)
    print(f"primes in range [{m}, {n}]: {primes}")

print_primes_in_range(20, 60)
    
