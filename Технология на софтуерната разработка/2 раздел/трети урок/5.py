def calculate_stats(*args):
    if not args:
        return 0, 0, None, None
    total_sum = sum(args)
    average = total_sum / len(args)
    minimum = min(args)
    maximum = max(args)
    return total_sum, average, minimum, maximum

calculate_stats(1, 2, 3, 4, 5)