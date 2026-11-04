def same(a, b):
    if a == b:
        print("same")
    else:
        print("not same")

def couple_names(name1 = "Bill",  name2 = "Alice"):
    print(f"{name1} and {name2} are a couple.")


same()
same(5, 6)
couple_names()
couple_names("John", "Jane")