tu = (1,2,[4,5],2,'apple',2)
for item in tu:
    print(item)
apple_index = tu.index('apple')
count_twos = tu.count(2)
print(f"apple's index = {apple_index}")
print(f"two's count = {count_twos}")

word_list = text.split()
print(f"list with words: {word_list}")
word_list.sort()
print(f"Sort like 'ABC': {word_list}")