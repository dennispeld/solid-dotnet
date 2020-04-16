# Single Responsibility Principle

Each class has one responsibility, and therefore has only one reason to change. 

### Example
In this example, the class **Scrapbook class** exists only to have entries, where **ScrapbookManager class** is used only to save the entries 
in the disk. We dont want these two separate functionalities to be mixed in one class. If we need to change the way we save the entry, we will
only need to change the logic of ScrapbookManager.