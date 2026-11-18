import os
import shutil

def clean_folder(folder_path):
    for filename in os.listdir(folder_path):
        if os.path.isfile(os.path.join(folder_path, filename)):
            print(os.path.join(folder_path, filename))


if __name__ == "__main__":
    print("Desktop Cleaner Script")
    folder_path = 'EDIT THIS'
    if os.path.isdir(folder_path):
        clean_folder(folder_path)
        print("Cleaning complete.")
    else:
        print("Invalid folder path. Please ensure the path is correct and try again.")