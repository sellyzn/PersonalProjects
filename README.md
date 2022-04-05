# PersonalProjects
## LearnASPNETMVCWitheRealApps:
### Function:
- A shopping cart: implement the functions of adding, removing products, and calculating the total price operations.
- Product Page: show the product Id, Name, Photo, Price and Buy Operation
- Cart Page: show the products Id, Name, Photo, Price, Quantity, Sub Total price, and the total price. Can continue shopping and Remove product from the cart.


### Steps:
1. Create ASP.NET MVC Project, select Empty Template and Core Reference is MVC.
2. Create new folder named Content. In this folder, create new folder name Images. Add images.
3. Entity Class
    - In Models folder, create new entities class: 
      - Product.cs : 
      - Item.cs : 
      - ProductModel.cs:
     - Create Contoller:
       - Product Controller: Create new controller named ProductController.cs: 
       - Cart Controller: Create new controller named CartController.cs
     - Create Views:
        - Product Views: In Views/Product folder, new razor view named Index.cshtml
        - Cart Views: In Views/Cart folder, new razor view named Index.cshtml

### Display
![image](https://user-images.githubusercontent.com/25220204/161830513-98d5195c-4052-448f-bc88-088faeb72c8b.png)  

Initial Cart Page:  
![image](https://user-images.githubusercontent.com/25220204/161830953-76a4b45f-4623-4871-b884-bbb31d102502.png)  

Cart Page:  
![image](https://user-images.githubusercontent.com/25220204/161831599-0b329536-0a5b-4eb8-accf-c5f2ceb6b20f.png)  


## ACM:
### Function:


### Steps:
1. Identifying classes
    - Represents business entities
    - Defines properties (data)
    - Defines methods (actions/behavior)
2. Seperating responsibilities
    - Minimizes coupling
    - Maximizes cohesion
    - Simplifies maintenance
    - Improves testability
4. Establishing relationships
    - Defines how objects work together to perform the operations of the application
6. Leveraging reuse
    - Involes extracting commonality
    - Building reusable classes/components
    - Defining interfaces

### Components:
1. ACM.BL
    - Library for customer, product, and order
2. Acme.Common
    - Common functions that can be used in other classes
3. ACM.BLTest
    - Unit tests for methods in ACM.BL
4. Acme.CommonTest
    - Unit tests for methods in Acme.Common

### Display:
![image](https://user-images.githubusercontent.com/25220204/161826054-0928fcb4-9cff-490a-86b1-ff363721c594.png)


