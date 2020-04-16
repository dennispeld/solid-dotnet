# Liskov Substitution Principle

If an interface takes an object of type Parent, it should equially take an object of type Child without anything breaking.

### Example
In this example, I created a class MyBook and derived from it in another class MyJournal it has some similar properties.
Very important is to make sure that any methond of MyBook class can be used by its child MyJournal, and dont break. 

There are few criterias I followed to make sure a child class can call methods of a parent and wont break:
- The OpenPage() function is something you can use both in MyBook and MyJournal. 
- the OpenTableOfContent() function is only related to MyBook, as journals dont have a table of content. In this case, I simply
check the table of the book I am calling it from.