# Liskov Substitution Principle

If an interface takes an object of type Parent, it should equially take an object of type Child without anything breaking.

### Example
In this example, I created **MyJournal class** that derives from **MyBook class**, that implements **Book abstract class**.

There are few criterias I followed to make sure a child class can call methods of a parent and wont break:
- MyBook parent class derives from an abstract class Book and implements two abstract methods OpenPage() and OpenTableOfContent().
- **OpenPage()** function is something you can use both in MyBook and MyJournal and implemented in both. 
- **OpenTableOfContent()** function is only related to MyBook, as journals don't have a table of content. In this case, I simply 
check the the type of an object.