# Group1_Competition2_Inheritance
Competition 2 - Inheritance Repo for Group 1 
Introduction:
Object-Oriented Programming (OOP) is a crucial paradigm in modern software development that enables developers to design scalable, reusable, and maintainable applications. By organizing code into classes and objects, OOP facilitates efficient problem-solving and code management. Its core principles—Inheritance, Encapsulation, Abstraction, and Polymorphism—help developers create flexible, modular, and extensible systems. Inheritance, for example, allows one class to inherit properties and behaviors from another, thereby promoting code reusability and reducing redundancy. Moreover, OOP encourages a logical organization of code, making it easier to maintain and extend over time. This structured approach is foundational to designing real-world applications that require clear hierarchies, like systems for library management, e-commerce, and content management.

Learning Objectives:
Upon completing this competition, you will:

Understand and apply key principles of Object-Oriented Programming.

Design and implement systems using classes, objects, inheritance, and encapsulation.

Collaborate effectively within a team environment using version control systems like Git and GitHub.

Demonstrate the ability to develop a functional library management system, implementing operations such as borrowing and returning books, adding patrons, and displaying library data.

Follow best practices in software design, including clear code organization, meaningful naming conventions, and regular code commits.

Assignment Instructions:
In this competition, you will work collaboratively in groups to develop a USF Library Management System. This system will manage books, students, and staff, implementing basic operations such as borrowing, returning, and displaying relevant details about books and patrons.

As a group, you will apply Object-Oriented Programming (OOP) concepts such as inheritance and encapsulation to build the system. Additionally, you will practice using GitHub for version control and code collaboration.

You will develop a Library Management System that includes the following:

Classes to Create:
Person → Base class with Name, Email, and ID properties.

Student → Inherits from Person, adds Major and GraduationYear properties.

Staff → Inherits from Person, adds Position and Department properties.

Book → Includes properties for Title, Author, ISBN, AvailableCopies, and method BorrowBook

Library → Manages a collection of books and patrons : DisplayBooks, DisplayPatrons

Functionality to Implement:
Add new books and patrons.

Borrow and return books.

Display library information, including book details and patron details.

Perform validation checks (e.g., verify book availability).

Objects to Create:
You will create the following objects in the Main method.

Books:

Book(“The Art of Data Strategy”, “Liam Reynolds”, “ISBN111”, 4)
Book(“Business Insights with AI”, “Olivia Carter”, “ISBN222”, 3)
Book(“Analytics in Action”, “Nathan Brooks”, “ISBN333”, 6)
Students:

Student(“Akhil”, “akhil@usf.edu”, “S001”, “Business Analytics”, 2026)
Student(“Sandeep”, “sandeep@usf.edu”, “S002”, “Information Systems”, 2025)
Staff:

Staff(“Grandon Gill”, “grandon@usf.edu”, “ST001”, “Librarian”, “Library Services”)
Task/Scenario: 
For the scope of this competition, we are just implementing a simple borrow books scenario. If interested, you can extend the scope.

1. Borrow Books:

Sandeep borrows “Business Insights with AI”.

Akhil borrows “Analytics in Action”.

2. Update and Display:

After borrowing, update the available copies for the books.

Display the list of books with their updated availability.

Expected Output:
In the output, implement the above scenario.

Display the books with their initial availability (before borrowing)

Display the Patrons in the Library

Display the borrowing books.

Display the books in Library (after borrowing)

Sample Reference Output:
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 3
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 6

Patrons in Library:
Name: Akhil, ID: S001
Name: Sandeep, ID: S002
Name: Grandon Gill, ID: ST001

Borrowing Books...
Sandeep borrowed 'Business Insights with AI'
Akhil borrowed 'Analytics in Action'

Books after borrowing:
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 2
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 5
Best Practices:
Divide tasks effectively – Assign different responsibilities to each member (e.g., one works on Student and Person classes, another on Library implementation, etc.).

Collaborate on GitHub – Work together using GitHub to manage code.

Use clear and meaningful names – Ensure class, method, and variable names are descriptive.

Commit and push frequently – Regularly commit, push, and pull code to keep the project up to date.

Use branches for collaboration – If multiple people are working on the same file, create and use branches to avoid conflicts.

Use separate .cs files for each class – Each class should be in its own file (e.g., Person.cs, Student.cs, Library.cs, etc.). This improves code organization and makes it easier to maintain and navigate.
