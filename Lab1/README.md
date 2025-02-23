# 1. DRY
To avoid code repetition, I extracted methods, used classes, and preferred composition to inheritance.
For example, in the [Enclosure class](./Lab1/ZooManagement/ZooLib/Enclosures/Enclosure.cs) we often need to check whether it is possible
to add another animal to the enclosure, so the [CanBeAdded()](./Lab1/ZooManagement/ZooLib/Enclosures/Enclosure.cs#L40-L66) method was created to check this condition.
# 2. KISS
Written code is quite simple and straightforward:
- Purpose of fields, methods, and classes is clear from their names ([IAnimal](./Lab1/ZooManagement/ZooLib/Animals/IAnimal.cs),
[Elephant](./Lab1/ZooManagement/ZooLib/Animals/Elephant.cs), [Lion](./Lab1/ZooManagement/ZooLib/Animals/Lion.cs) etc.);
- To avoid making class responsible for the inventory too large, it was split into two: [AnimalsInventory](./Lab1/ZooManagement/ZooLib/Inventories/AnimalsInventory.cs), which is responsible for
displaying information about animals and [EmployeesInventory](./Lab1/ZooManagement/ZooLib/Inventories/EmployeesInventory.cs), which is responsible for information about employees;
- Сode has a low complexity of algorithms (Example: [GetAnimalsCount()](./Lab1/ZooManagement/ZooLib/Inventories/AnimalsInventory.cs#L47-L55) method calculates the total number of animals in all enclosures. It starts with a counter set to 0, then iterates through each enclosure,
adding the number of animals in that enclosure to the counter. Finally, it returns the total count.)
# 3. SOLID
## Single Responsibility
Each class has a single purpose:
- [Elephant](./Lab1/ZooManagement/ZooLib/Animals/Elephant.cs), [Lion](./Lab1/ZooManagement/ZooLib/Animals/Lion.cs), [Coala](./Lab1/ZooManagement/ZooLib/Animals/Koala.cs) - represent the corresponding animal
- [Employee](./Lab1/ZooManagement/ZooLib/Employees/Employee.cs) - stores data about the employee and his/her role
- [TourGuide](./Lab1/ZooManagement/ZooLib/Employees/Roles/TourGuide.cs), [Veterinarian](./Lab1/ZooManagement/ZooLib/Employees/Roles/Veterinarian.cs),
[Zookeeper](./Lab1/ZooManagement/ZooLib/Employees/Roles/Zookeeper.cs) - represent the appropriate role of the employee
- [Enclosure](./Lab1/ZooManagement/ZooLib/Enclosures/Enclosure.cs) - represents enclosure and provides an opportunity to manage animals in it
- [AnimalsInventory](./Lab1/ZooManagement/ZooLib/Inventories/AnimalsInventory.cs),
[EmployeesInventory](./Lab1/ZooManagement/ZooLib/Inventories/EmployeesInventory.cs) - store information about animals and zoo employees accordingly
## Open/Closed
Project structure allows easy extension of functionality without modifying existing code. For instance, new roles can be added by implementing 
[IRole](./Lab1/ZooManagement/ZooLib/Employees/Roles/IRole.cs), without changing the [Employee](./Lab1/ZooManagement/ZooLib/Employees/Employee.cs) class.
It is also possible to create a class for a new animal by implementing [IAnimal](./Lab1/ZooManagement/ZooLib/Animals/IAnimal.cs) interface without having to make changes to 
[Enclosure](./Lab1/ZooManagement/ZooLib/Enclosures/Enclosure.cs) class that works with animals.
