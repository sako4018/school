available = dict()
available = {'P001': 40, 'P002': 30, 'P003': 25, 'P003': 3, 'P004': 8}
total_items = sum(available.values())
print(f'Total: {total_items}')
low_stock = [code for code, qty in available.items() if qty < 10]
print(f'<10: {low_stock}') 
