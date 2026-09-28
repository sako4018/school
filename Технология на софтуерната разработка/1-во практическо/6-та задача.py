kg = float(input("Enter weight in kg: "))
m = float(input("Enter height in meters: "))
bmi = kg / (m ** 2)
if bmi < 18.5:
    print(f"Your BMI is {bmi}. You are underweight.")
elif 18.5 <= bmi < 25:
    print(f"Your BMI is {bmi}. You have a normal weight.")
elif 25 <= bmi < 30:
    print(f"Your BMI is {bmi}. You are overweight.")
else:
    print(f"Your BMI is {bmi}. You are obese.")
