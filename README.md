# Datastructures and Algorithms

We are starting with the following sample problems.

## Problems
- Google sample - Find if a pair exists in an array
- Find is there are any common item in two arrays

## Data structures
Most of the times data structures are mostly prebuild. What is more important is to pick the right datastructures for the right
problem.
- Arrays (in case of C# use the inbuilt ArrayList or List<T>)
  - lookup O(1)
  - push O(1) // insert at end
  - insertAt O(n)
  - deleteAt O(n)
- HashTables (in case of C# use the inbuilt HashSet) - Use more space but helps in time optimization
  - lookup O(1) // find the key only
  - search O(1) // this depends on how the data structure handles collision; it can be 0(n);
  - insert O(1) 
  - delete O(1) // this depends on how the data structure handles collision; it can be 0(n);
  - keys O(n) // this depends on how the data structure handles collision; it can be 0(n ^ 2);
- Linked list (in C# we have an inbuilt LinkedList implementation)
  - Append O(1)
  - prepend O(1)
  - lookup O(n)
  - insert O(n)
  - delete O(n)