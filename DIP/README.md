# Dependency Inversion Principle

High-level modules should not depend on low-level modules. Both should depend on abstractions.

The high-level modules describe those operations in our application that has more abstract nature and contain more complex logic. 
These modules orchestrate low-level modules in our application.

The low-level modules contain more specific individual components focusing on details and smaller parts of the application. 
These modules are used inside the high-level modules in our application.

### Example
In this example, at first, I created an interface **IBookshelfSearchable**. Then I added a class **BookshelfOrganizer** that implements 
the interface and using LINQ retrieves the bookshelves by type. In a class **BookshelfStatistic** I am calling the method 
**GetBookshelvesByType()** of an interface (!!!), not the BookshelfOrganizer, where it was implemented. After retrieving bookshelves I 
am getting all the books, that are placed there. This is important, because now the BookshelfStatistic high-level class is not dependent 
on the low-level BookshelfOrganizer class.
