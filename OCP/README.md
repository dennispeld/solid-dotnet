# Open-Closed Principle

Open for extension, closed for modification. Basically, you should not need to changed code you have written and tested already.

### Example
In this example, instead of creating a new function for each filter we want to have (and potentially re-write the entire Filter class
each time we want to add a new filter), I created two generic interfaces 
- IFilter<T> to implement the filter logic in MyBookFilter class
- ISpecification<T> to implement by what parameter we will be filtering

Having this, we don't need to change a logic and each time we want to add a new filter, we simply create a new class that would implement
ISpecification interface, like TypeSpecification, for example.
In addition, I have created AndSpecification for logical AND operator in case if I want to combine specifications.
