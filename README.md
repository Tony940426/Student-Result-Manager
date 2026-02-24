# Student-Result-Manager
Requirements:
- Create Student class - 4 properties ( id , name , age, grade )
- store 3 subject's grade for each student
- create 3 student objects
- Print the average marks of each student

# Extended-Student-Result-Manager
A private school is building a small internal system to manage people in the organization.

Currently, they track:
Students
Teachers
However, the system must be designed in a way that it can grow in the future (e.g., adding Admin staff, Principal, Librarian, etc.).

Business Requirements
1️. Every person in the school must have:
A unique ID ( eg. 11, 22, 33 )
A Name
A method to display their details
The system should automatically assign IDs when a new person is created.

2️.Students
Students must:
Have marks
Ensure marks are valid (0–100)
Be able to display their full details
The system should prevent invalid marks from being stored.

3️.Teachers
Teachers must:
Have a subject they teach
Be able to display their full details

4️. System Rules

The system must track how many total people have been created.
The system must not allow invalid data (empty names, invalid marks).
Business logic must stay inside the classes — not in Main.

Evalution parameters

Proper use of inheritance
Proper use of access modifiers
Correct use of constructors
Proper use of static
Iterate through the list using a loop

In Main:
Create at least:
4 Students
2 Teacher

Get all inputs from users - do not hardcode any value when creating objects
Display their details
Display the total number of persons created
print  Top Scoring Student
example output,

New Student : ID=1, Name=Nick
New Student Created: ID=2, Name=Sara
New Teacher Created: ID=3, Name=Liam

---- SCHOOL MEMBERS ----
ID: 1, Name:  Nick  , Role: Student, Marks: 85
ID: 2, Name: Sara, Role: Student, Marks: 92
ID: 3, Name: Liam, Role: Teacher, Subject: Mathematics

---- SYSTEM SUMMARY ----
Total Persons Created: 3
Total Students: 2
Total Teachers: 1

Top Scoring Student: Sara (92)
