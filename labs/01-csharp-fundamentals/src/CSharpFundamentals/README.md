## Value Types and Reference Types

### What happened when I copied an integer?
It only changed b but not a.
### What happened when I copied a struct?
The values were not the same.
### What happened when I copied a class reference?
Names changed because the assign of classes is by reference.
### How did the record behave?
Record is immutable but I copy it with the "with" keyword
### Current understanding
By value will not store the "adress" of the original variable used, thus not changing the original. By reference will store this "adress" changing the original value used.