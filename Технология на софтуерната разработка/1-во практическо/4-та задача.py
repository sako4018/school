x1 = float(input("Enter a x1: "))
y1 = float(input("Enter a y1: "))
x2 = float(input("Enter a x2: "))
y2 = float(input("Enter a y2: "))

if x1 > x2 or y1 > y2:
    print("Invalid coordinates")
else:
    print("Enter a test coordinates: ")
    x = float(input("Enter a x: "))
    y = float(input("Enter a y: "))

    is_inside = (x1 <= x <= x2) and (y1 <= y <= y2)
    print(f"The point ({x}, {y}) is inside rectangle: {is_inside}")