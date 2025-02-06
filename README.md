# Recipe Manager Application

## Table of Contents
1. [Introduction](#introduction)
2. [Features](#features)
3. [Requirements](#requirements)
4. [Installation](#installation)
5. [Usage](#usage)
6. [Project Structure](#project-structure)
7. [Contributing](#contributing)
8. [Acknowledgments](#acknowledgments)

---

## Introduction

This project is part of the Portfolio of Evidence (PoE) for the Programming 2A module (**PROG6221**). The application allows users to manage recipes, including adding ingredients, steps, and nutritional information. It also includes advanced filtering features.

The application is built using **C#** and **WPF (Windows Presentation Foundation)**, following object-oriented programming principles.

---

## Features

### Core Functionalities:
- Add unlimited recipes with names, ingredients, and cooking steps.
- Display recipes in alphabetical order.
- Enter calories and food groups for each ingredient.
- Calculate and display total calories for each recipe.
- Notify the user when a recipe exceeds 300 calories.
- Scale recipes by factors of **0.5, 2, or 3**.
- Reset ingredient quantities to original values.
- Clear all data to enter a new recipe.

### Advanced Features:
- **Filter recipes** by:
  - Ingredient name.
  - Food group.
  - Maximum calorie count.
- Create menus and display a **pie chart** showing the percentage of each food group in the total menu.

---

## Requirements

To run this application, ensure you have the following installed:

- **Visual Studio 2019 or later** (Community Edition is sufficient).
- **.NET Framework** or **.NET Core SDK**.
- **Git** (for version control).

---

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/PROG6221-PoE.git
Navigate to the project directory:

bash
Copy
Edit
cd PROG6221-PoE
Open the Project:

Open PROG6221_PoE.sln in Visual Studio.
Restore Dependencies:

If prompted, restore any missing NuGet packages.
Build the Solution:

Go to "Build" > "Build Solution" or press Ctrl + Shift + B.
Usage
Running the Application
Press F5 in Visual Studio to run the application.
Adding a Recipe
Click "Add Recipe".
Enter a recipe name.
Use "Add Ingredient" to input details.
Use "Add Step" to input cooking instructions.
Click "Save".
Filtering Recipes
Click "Filter Recipes".
Enter criteria (ingredient name, food group, or calorie count).
Click "Apply Filter".
Viewing Recipe Details
Select a recipe from the list.
A detailed view will show:
Ingredients, steps, total calories, and warnings.
Scaling Recipes
Adjust ingredient quantities by 0.5, 2, or 3.
Resetting Quantities
Click "Reset Quantities" to revert to the original values.
Clearing Data
Click "Clear Data" to remove all recipes.
Project Structure
bash
Copy
Edit
PROG6221_PoE/
│
├── PROG6221_PoE/
│   ├── MainWindow.xaml          # Main application window
│   ├── MainWindow.xaml.cs       # Code-behind for the main window
│   ├── AddRecipeWindow.xaml     # Window for adding new recipes
│   ├── AddRecipeWindow.xaml.cs  # Code-behind for adding recipes
│   ├── RecipeDetailsWindow.xaml # Window for viewing recipe details
│   ├── RecipeDetailsWindow.xaml.cs # Code-behind for recipe details
│   ├── FilterRecipesWindow.xaml # Window for filtering recipes
│   ├── FilterRecipesWindow.xaml.cs # Code-behind for filtering recipes
│   ├── App.xaml                 # Application resources
│   ├── App.xaml.cs              # Application startup logic
│   ├── Classes/                 # Core classes
│   │   ├── Recipe.cs            # Recipe class
│   │   ├── Ingredient.cs        # Ingredient class
│   │   ├── Step.cs              # Cooking step class
│   └── ...
│
├── PROG6221_PoE.sln           # Solution file
├── README.md                  # This file
└── Documentation/             # Additional documentation
    ├── UserManual.pdf          # User manual
    └── FeedbackDescription.txt # Summary of lecturer feedback
Contributing
This project was developed as an academic assignment. Contributions are not currently accepted, but feel free to fork the repository.

Acknowledgments
Material Design in XAML Toolkit (for styling the GUI).
Sweet Life: Food Groups Guide
Lecturer Feedback for valuable improvements.
Tags
Part1: Marks completion of Command-Line Application.
PoE: Final submission for the Portfolio of Evidence (GUI Application).
Contact
For questions or feedback, please contact:
📧 [your-email@example.com]

License
This project is licensed under the MIT License. See the LICENSE file for details.

yaml
Copy
Edit

---

### **How to Use This README**
1. **Save the file as `README.md`** in your GitHub repository.
2. **Replace placeholders** like `your-username` and `your-email@example.com`.
3. **Commit and push** the `README.md` file to your GitHub repository.

---

### **Why is this README Effective?**
✅ **Well-structured**: Uses clear sections with a **Table of Contents**.  
✅ **Easy to follow**: Provides **installation steps** and **usage instructions**.  
✅ **Proper formatting**: Uses Markdown for **bold text, bullet points, and code blocks**.  
✅ **Detailed project structure**: Helps developers understand the code organization.  

Let me know if you need any modifications! 🚀
