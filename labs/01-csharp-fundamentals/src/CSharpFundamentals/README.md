## Value Types and Reference Types

### What happened when I copied an integer?
It only changed b but not a.
### What happened when I copied a struct?
The values were not the same. The struct creates a independent copy.
### What happened when I copied a class reference?
Names changed because the assign of classes copy the reference.
### How did the record behave?
I used the "with" keyword to create a copy of the record without destroying the original values. The original record remained unchanged.
### Current understanding
By value will not store the reference of the original object used, thus not changing the original. By reference will store this reference changing a copied object, not the original object.

## Record vs Class explanation
I don't know much about equality in records, I know that two record class era equal if they reference the same objecte, unlike normal classes? But, record struct compares the type and value for equality. I would use a record to store a JSON response from API, because I don't want to change these values, but if I need to alter something, I can alter copying in another variable using "with". I would choose a regular class if I need a more complex custom object or implement relations like inheritance.