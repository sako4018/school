text = "I'm using single quotes in Python"

print(f"Оригинален низ: {text}")
print(f"Малки букви: {text.lower()}")
print(f"Главни букви: {text.upper()}")

ggwords_list = text.split()
print(f"Списък с думи: {words_list}")

words_list.sort()
print(f"Сортирани думи: {words_list}")

