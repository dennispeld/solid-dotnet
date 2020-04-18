# Interface Segregation Principle

Separate interfaces to avoid forcing clients to implement functionality that they do not need.

### Example
In this example, I utilize already existing interface **IWritable**, that is used for the types of books, where you can add entries. 
In addition, I have written a separate interface **IReadable**, that reads the page of the book. I separated those two interfaces to
make sure I can use them for different type of books. 

To illustrate that, I implemented a IReadable interface in the **MyBook** class (that also inherits from Book abstract class), which 
is an ordinary book, that you cannot write anything or erase anything, hence no need to implement IWritable interface.
I have also created a generic class **MyWorkbook**, which is obviously a type of book, that has both texts (excersises, theory etc) 
and you can write in it (add/erase entries), too. So I want to make sure, it implements both IReadable and IWritable interfaces.