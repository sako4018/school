def run_quiz(questions):
    score = 0
    for question in questions:
        print(question["prompt"])
        for option in question["option"]:
            print(option)
        answer = input("Enter (A, B, C, D): ")
        if answer == question["answer"]:
            print("Correct, hooray!! \n")
            score += 1

        else:
            print(f"wrong! LOSER! the correct answer is {question["answer"]}\n")

    print(f"You gpt {score} out of {len(questions)} questions correct. ")


run_quiz(questions)