# 📘 Competition2 - Inheritance
# 📚 USF Library Management System – Group1_Competition2_Inheritance
## 🧠 Introduction
Object-Oriented Programming (OOP) is a crucial paradigm in modern software development that enables developers to design scalable, reusable, and maintainable applications. By organizing code into classes and objects, OOP facilitates efficient problem-solving and code management.

In this project, we used **Inheritance** to promote code reusability and reduce redundancy. By creating a class hierarchy involving people (students and staff) and books, we structured a Library Management System that reflects real-world relationships. This approach is essential for designing systems like library management, e-commerce platforms, and content management systems.

---

## 🎯 Learning Objectives
Upon completing this competition, we successfully:
- Applied key principles of Object-Oriented Programming.
- Designed and implemented a system using classes, objects, inheritance, and encapsulation.
- Collaborated effectively using GitHub for version control.
- Developed a functional USF Library Management System with borrowing operations.
- Followed best practices in software design, such as clear code structure and naming conventions.

---

## 📚 Assignment Summary

We created a **Library Management System** that performs the following:
- Manages collections of books and patrons (students and staff).
- Allows borrowing of books with availability validation.
- Displays detailed information about books and patrons.

### 📦 Classes Implemented
- `Person` (Base class) → Name, Email, ID.
- `Student` (inherits from Person) → Adds Major, GraduationYear.
- `Staff` (inherits from Person) → Adds Position, Department.
- `Book` → Title, Author, ISBN, AvailableCopies, method: `BorrowBook()`.
- `Library` → Manages collections and includes:
  - `DisplayBooks()`
  - `DisplayPatrons()`

---

## 🔁 Scenario Implementation

### ✅ Books Created:
- The Art of Data Strategy by Liam Reynolds (4 copies)
- Business Insights with AI by Olivia Carter (3 copies)
- Analytics in Action by Nathan Brooks (6 copies)

### ✅ Students:
- Akhil, Business Analytics, Graduating 2026
- Sandeep, Information Systems, Graduating 2025

### ✅ Staff:
- Grandon Gill, Librarian, Library Services

### 📖 Borrowing Scenario:
1. **Sandeep** borrows *Business Insights with AI*  
2. **Akhil** borrows *Analytics in Action*

### 🧾 Expected Console Output:

Books in Library: Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4 Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 3 Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 6

Patrons in Library: Name: Akhil, ID: S001 Name: Sandeep, ID: S002 Name: Grandon Gill, ID: ST001

Borrowing Books... Sandeep borrowed 'Business Insights with AI' Akhil borrowed 'Analytics in Action'

Books after borrowing: Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4 Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 2 Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 5

---

## 👥 Group Members & Responsibilities

| **Name**     | **Responsibilities**                                          |
|--------------|---------------------------------------------------------------|
| **Jennifer** | Wrote the main program in `Program.cs` and set up GitHub repo |
| **Chandar**  | Developed `Book.cs` and `Staff.cs` classes                    |
| **Faisal**   | Implemented `Library.cs`              |
| **Ronia**    | Created base class `Person.cs`                                |

---

## 🔧 GitHub Workflow & Commands Used

### Step-by-step Git Workflow:
1. **Repository Creation** by Jennifer  
   `Group1_Competition2_Inheritance`

2. **Clone the repo**  
 
   git clone https://github.com/your-org/Group1_Competition2_Inheritance.git
   cd Group1_Competition2_Inheritance


💻 Git & GitHub Commands by Group Member
👩‍💻 Jennifer – Program.cs & GitHub Repo Setup


# 1. Create GitHub repository (via GitHub UI or CLI)
gh repo create Group1_Competition2_Inheritance --public

# 2. Clone the repo locally
git clone https://github.com/group1/Group1_Competition2_Inheritance.git
cd Group1_Competition2_Inheritance

# 3. Create a branch for main program
git checkout -b jennifer-main

# 4. Add Program.cs file with Main method
# (created manually in IDE or textor)

# 5. Stage and commit changes
git add Program.cs
git commit -m "Added main logic to Program.cs"

# 6. Push the branch to GitHub
git push origin jennifer-main

# 7. Create a Pull Request on GitHub and merge into main
🧑‍💻 Chandar – Book.cs and Staff.cs

# 1. Create a new branch for Book and Staff
git checkout -b chandar-books-staff

# 2. Add Book.cs
git add Book.cs 
# 3. Add Staff.cs
git add Staff.cs
# 4. Stage and commit
git add Book.cs Staff.cs
git commit -m "Added Book and Staff classes with borrowing logic"

# 5. Push to GitHub
git push origin chandar-books-staff

# 6. Create a Pull Request on GitHub and merge into main
🧑‍💻 Faisal – Library.cs



# 1. Create branch
git checkout -b faisal-library

# 2. Add Library.cs with AddBook, DisplayBooks, etc.

# 3. Stage and commit
git add Library.cs
git commit -m "Implemented Library class with book/patron management"

# 4. Push changes
git push origin faisal-library

# 5. Create Pull Request and merge
👩‍💻 Ronia – Person.cs


# 1. Create branch
git checkout -b ronia-person

# 2. Add Person.cs base class

# 3. Stage and commit
git add Person.cs
git commit -m "Created base class Person with common properties"

# 4. Push to GitHub
git push origin ronia-person

# 5. Create Pull Request and merge
🔁 Final Merge & Output Screenshot (Any Member)


After merging all components, the group ran the complete program and captured a screenshot of the console output showing:

Initial book availability

Patron details

Borrowing operations

Updated book availability


# 1. Switch to main branch
git checkout main
git pull origin main


# 2. Run the full program
dotnet build
dotnet run

# 3. screenshot of output and save as output.png
git add output.png
git commit -m "Added final output screenshot"

![image](https://github.com/user-attachments/assets/f1d40b97-e594-4046-999d-e13bb911e5d8)

