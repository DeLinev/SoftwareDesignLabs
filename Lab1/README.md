# 1. DRY
To avoid code repetition, I extracted methods, used classes, and preferred composition to inheritance.
For example, in the [Enclosure class](./ZooManagement/ZooLib/Enclosures/Enclosure.cs) we often need to check whether it is possible
to add another animal to the enclosure, so the [CanBeAdded()](./ZooManagement/ZooLib/Enclosures/Enclosure.cs#L40-L66) method was created to check this condition.
# 2. KISS
Written code is quite simple and straightforward:
- Purpose of fields, methods, and classes is clear from their names ([IAnimal](./ZooManagement/ZooLib/Animals/IAnimal.cs),
[Elephant](./ZooManagement/ZooLib/Animals/Elephant.cs), [Lion](./ZooManagement/ZooLib/Animals/Lion.cs) etc.);
- To avoid making class responsible for the inventory too large, it was split into two: [AnimalsInventory](./ZooManagement/ZooLib/Inventories/AnimalsInventory.cs), which is responsible for
displaying information about animals and [EmployeesInventory](./ZooManagement/ZooLib/Inventories/EmployeesInventory.cs), which is responsible for information about employees;
- Сode has a low complexity of algorithms (Example: [GetAnimalsCount()](./ZooManagement/ZooLib/Inventories/AnimalsInventory.cs#L47-L55) method calculates the total number of animals in all enclosures. It starts with a counter set to 0, then iterates through each enclosure,
adding the number of animals in that enclosure to the counter. Finally, it returns the total count.
# 3. SOLID
## Single Responsibility
Each class has a single purpose:
- [Elephant](./ZooManagement/ZooLib/Animals/Elephant.cs), [Lion](./ZooManagement/ZooLib/Animals/Lion.cs), [Koala](./ZooManagement/ZooLib/Animals/Koala.cs) - represent the corresponding animal;
- [Employee](./ZooManagement/ZooLib/Employees/Employee.cs) - stores data about the employee and his/her role;
- [TourGuide](./ZooManagement/ZooLib/Employees/Roles/TourGuide.cs), [Veterinarian](./ZooManagement/ZooLib/Employees/Roles/Veterinarian.cs),
[Zookeeper](./ZooManagement/ZooLib/Employees/Roles/Zookeeper.cs) - represent the appropriate role of the employee;
- [Enclosure](./ZooManagement/ZooLib/Enclosures/Enclosure.cs) - represents enclosure and provides an opportunity to manage animals in it;
- [AnimalsInventory](./ZooManagement/ZooLib/Inventories/AnimalsInventory.cs),
[EmployeesInventory](./ZooManagement/ZooLib/Inventories/EmployeesInventory.cs) - store information about animals and zoo employees accordingly.
## Open/Closed
Project structure allows easy extension of functionality without modifying existing code. For instance, new roles can be added by implementing 
[IRole](./ZooManagement/ZooLib/Employees/Roles/IRole.cs), without changing the [Employee](./ZooManagement/ZooLib/Employees/Employee.cs) class.
It is also possible to create a class for a new animal by implementing [IAnimal](./ZooManagement/ZooLib/Animals/IAnimal.cs) interface without having to make changes to 
[Enclosure](./ZooManagement/ZooLib/Enclosures/Enclosure.cs) class that works with animals.
## Liskov Substitution
In my code all derived classes ([Lion](./ZooManagement/ZooLib/Animals/Lion.cs), [Koala](./ZooManagement/ZooLib/Animals/Koala.cs), 
[Elephant](./ZooManagement/ZooLib/Animals/Elephant.cs)) can be substituted wherever [IAnimal](./ZooManagement/ZooLib/Animals/IAnimal.cs) interface is expected without breaking functionality.
Each class correctly implements [PerformAction()](./ZooManagement/ZooLib/Animals/IAnimal.cs#L13) according to its unique behavior:
- Lion implements [ICanRoar](./ZooManagement/ZooLib/Animals/Behavior/ICanRoar.cs) and calls [Roar()](./ZooManagement/ZooLib/Animals/Lion.cs#L28);
- Koala implements [ICanClimb](./ZooManagement/ZooLib/Animals/Behavior/ICanClimb.cs) and calls [Climb()](./ZooManagement/ZooLib/Animals/Koala.cs#L28);
- Elephant implements [ICanSwim](./ZooManagement/ZooLib/Animals/Behavior/ICanSwim.cs) and calls [Swim()](./ZooManagement/ZooLib/Animals/Elephant.cs#L28).

Since IAnimal does not force methods like Roar() or Climb() on all animals, this design prevents incorrect behavior, ensuring that substituting any IAnimal does not cause unexpected failures.
## Interface Segregation Principle
I created several small interfaces ([IAnimal](./ZooManagement/ZooLib/Animals/IAnimal.cs), [ICanRoar](./ZooManagement/ZooLib/Animals/Behavior/ICanRoar.cs), [ICanSwim](./ZooManagement/ZooLib/Animals/Behavior/ICanSwim.cs), etc.), ensuring that classes only implement relevant behaviors. Classes representing animals implement only methods they need. For instance Elephant only implements ICanSwim instead of an unnecessary ICanClimb.
## Dependency Inversion Principle
[Employee class](./ZooManagement/ZooLib/Employees/Employee.cs) depends on the [IRole](./ZooManagement/ZooLib/Employees/Roles/IRole.cs) abstraction rather than concrete role implementations, making it easier to extend. This ensures that Employee can work with any role that follows IRole.
# 4. YAGNI
I followed YAGNI principle by only implementing features that are necessary for the current functionality of the system. For example [Employee class](./ZooManagement/ZooLib/Employees/Employee.cs) could have many additional properties like salary, work hours, or experience level but they are unnecessary for now. Also [Enclosure class](./ZooManagement/ZooLib/Enclosures/Enclosure.cs) only implements essential methods: adding, removing, and checking if an animal can be added. I didn't add complex features like automatic feeding schedules or temperature control ahead of time.
# 5. Composition Over Inheritance
In my code I tried to compose objects using smaller, reusable components rather than creating deep inheritance trees. An example of this is [Employee class](./ZooManagement/ZooLib/Employees/Employee.cs). Instead of creating separate subclasses for Zookeeper, Veterinarian, and TourGuide, I wrote [IRole interface](./ZooManagement/ZooLib/Employees/Roles/IRole.cs). This approach keeps Employee class simple while making it more flexible. New roles can be added without modifying the existing class hierarchy. 
# 6. Program to Interfaces not Implementations
The project depends on abstractions rather than concrete classes. [Employee class](./ZooManagement/ZooLib/Employees/Employee.cs) interacts with [IRole interface](./ZooManagement/ZooLib/Employees/Roles/IRole.cs) instead of specific role implementations like Zookeeper or Veterinarian. Similarly, [Enclosure class](./ZooManagement/ZooLib/Enclosures/Enclosure.cs) works with [IAnimal interface](./ZooManagement/ZooLib/Animals/IAnimal.cs) but not with specific types of animals. This approach makes it easy to extend functionality without modifying existing code.
# 7. Fail Fast
In my code, I applied the Fail Fast principle by validating inputs early to prevent incorrect states. For example, in [Enclosure class](./ZooManagement/ZooLib/Enclosures/Enclosure.cs), constructor immediately [checks if the capacity is greater than zero](./ZooManagement/ZooLib/Enclosures/Enclosure.cs#L14-L15) and [whether the provided animals can be added](./ZooManagement/ZooLib/Enclosures/Enclosure.cs#L22-L25). If these conditions are not met, an exception is thrown, preventing invalid enclosures from being created. This approach helps catch errors early, ensuring the system remains in a consistent state.
