points = int(input("Enter points: "))
skipped = int(input("Enter percentage skipped classes: "))
if skipped >= 20:
    print("(>20%) skipped classes")
else:
    if points >= 90:
        print("Excellent (6.00)")
    elif points >=75 and points < 90:
        print("Very Good (5.00)")
    elif points >= 60 and points < 75:
        print("Good (4.00)")
    elif points >= 50 and points < 60:
        print("Satisfactory (3.00)")
    elif points < 50:
        print("Poor (2.00)")
    else:
        print("Invalid points")

