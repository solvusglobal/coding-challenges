def calculate_even_sum(limit):
    even_numbers = []
    
    for i in range(1, limit + 1):
        if i % 2 == 0:
            even_numbers.append(i)
    
    total_sum = 0
    for num in even_numbers:
        total_sum += num
        
    return total_sum

print(calculate_even_sum(1000000))
