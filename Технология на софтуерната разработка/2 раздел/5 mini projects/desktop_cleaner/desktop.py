import os
import shutil

def clean_folder(folder_path):
    for filename in os.listdir(folder_path):
        file_path = os.path.join(folder_path, filename)

        # skip folders and hidden files like .DS_Store
        if not os.path.isfile(file_path) or filename.startswith("."):
            continue

        # "photo.JPG" -> "jpg"
        name, extension = os.path.splitext(filename)
        extension = extension[1:].lower()
        if extension == "":
            extension = "no_extension"

        target_folder = os.path.join(folder_path, extension)
        if not os.path.isdir(target_folder):
            os.makedirs(target_folder)

        shutil.move(file_path, os.path.join(target_folder, filename))
        print(f"Moved: {filename} -> {extension}/")


if __name__ == "__main__":
    print("Desktop Cleaner Script")
    folder_path = input("Enter folder path: ").strip()
    folder_path = os.path.expanduser(folder_path)
    if os.path.isdir(folder_path):
        clean_folder(folder_path)
        print("Cleaning complete.")
    else:
        print("Invalid folder path. Please ensure the path is correct and try again.")
