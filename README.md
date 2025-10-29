# programmers-anderson-project
Repository for versioning the project programmers-anderson-project.

In this repository, you will be able to find the WebProject solution, built in ASP.NET WebForms, using jQuery on Front-End, and on code behind using, Visual Basic.

 
## **Project Details**
 
The project includes two main exercises:
 
### **1. Amount Currency Convert**
 
* **Page**: AmountConvertPage.aspx
 
* **Description**: Converts numeric values (in dollars) into their written representation.
 
* **Technologies used**:
 
  * **VisualBasic** for the core logic
 
  * **jQuery** for applying ajax call and input validation.
 
 
### **2. Palindrome Check**
 
* **Page**: PalindromeCheckPage.aspx
 
* **Description**: Checks whether the entered word is a palindrome.
 
* **Solutions provided:**
 
  In two different ways, this Palindrome will work with two distinct buttons to start the check.
  On first button, the logic will send an ajax request, using jQuery, so the code in Visual Basic, and the palindrome check will be validated.
  On second button, the logic will be executed over the javascript fron-end layer.
 
  * **1. JavaScript**:
 
    * Implements the verification logic directly on the frontend
 
    * Uses **jQuery** to prevent invalid characters and handle variables
 
  * **2. VB.NET (PalindromeCheckPage.aspx.vb)**:
 
    * Reverses the entered string on the server side
 
## **Project Files**
 
```
AndersonWebProject/
 
          ├── AmountConvertPage.aspx   # Exercise 1 - Javascript validation and request backend with Ajax
          ├── AmountConvertPage.aspx.vb   # Exercise 1 - Currency to words conversion
          ├── PalindromeCheckPage.aspx   # Exercise 2 - Palindrome checker
          ├── PalindromeCheckPage.aspx.vb   # Exercise 2 - Alternative implementation (code-behind)
          └── ... # Other files
```
