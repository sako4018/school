words = [
    {"spanish": "el", "english": "the"},
    {"spanish": "de", "english": "of/from"},
    {"spanish": "que", "english": "that/which"},
    {"spanish": "y", "english": "and"},
    {"spanish": "a", "english": "to/at"},
    {"spanish": "en", "english": "in/on"},
    {"spanish": "un", "english": "a/an"},
    {"spanish": "ser", "english": "to be"},
    {"spanish": "se", "english": "oneself/itself"},
    {"spanish": "no", "english": "no/not"},
    {"spanish": "haber", "english": "to have (auxiliary)"},
    {"spanish": "por", "english": "for/by"},
    {"spanish": "con", "english": "with"},
    {"spanish": "su", "english": "his/her/your/their"},
    {"spanish": "para", "english": "for/to"},
    {"spanish": "como", "english": "like/as"},
    {"spanish": "estar", "english": "to be"},
    {"spanish": "tener", "english": "to have"},
    {"spanish": "le", "english": "him/her/you (indirect object)"},
    {"spanish": "lo", "english": "it/him/you (direct object)"},
]
def quiz_user(words):
    random.shuffle(words)
    score = 0
    for word in words:
        print(f"What is english translation of '{word['spanish']}'?")
        user_answear = input("Your answer: ").strip().lower()
        correct_answear = word['english'].lower()

        if user_answear == correct_answear:
            print("Correct!")
            score + 1
        else:
            print(f"Wrong!!! Answer is: {word['english']}")

def main():
    print("Welcome to the Language Learning Flashcards App!")
    input("Press Enter to start the quiz...")
    quiz_user(words)

if __name__ == "__main__":
    main()