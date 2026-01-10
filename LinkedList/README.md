# Linked List (Singly Linked List)

This project contains a manual implementation of a **singly linked list** in C#.
The goal of this implementation is to deeply understand how linked lists work internally,
including node traversal, edge cases, and time/space complexity.
--------------------------------------------------------------------------
## What is a Linked List?

A linked list is a linear data structure where elements (nodes) are connected using references.
Each node contains:
- a value
- a reference to the next node

Unlike arrays, linked lists do not store elements in contiguous memory locations.
----------------------------------------------------------------------------
## Supported Operations

- AddLast(value) – adds an element to the end of the list
- RemoveLast() – removes the last element
- AddFirst() - adds an element to the begining of the list
- RemoveFirst() - removes the first element
- Find() - Finds the first element that matches the specified value.
- FindLast() - Finds the last element that matches the specified value.
- Reverse() - Reverses the linked list.
- ToArray() – converts the list to an array
- Count – returns the number of elements in the list

-----------------------------------------------------------------------------
## Time and Space Complexity

| Operation     | Time Complexity | Space Complexity |
|---------------|-----------------|------------------|
| AddLast       | O(1)            | O(1)             |
| RemoveLast    | O(n)            | O(1)             |
| ToArray       | O(n)            | O(n)             |
| AddFirst      | O(1)            | O(1)             |
| RemoveFirst   | O(1)            | (O(1))           |
| Find          | O(n)            | O(1)             |
| FindLast      | O(n)            | O(1)             |
| Reverse       | O(n)            | 0(1)             |
------------------------------------------------------------------------------
## Testing

All operations are covered with unit tests using **xUnit**.

Tests validate:
- correct behavior for empty lists
- single-element lists
- multi-element lists
- correct element order
- correct Count updates


--------------------------------------------------------------------------------
## Purpose

This project is part of a larger **Data Structures** repository.
The goal is not to replace built-in .NET collections, but to:

- understand internal mechanics of data structures
- practice writing clean, testable code
- practice time/space complexity analysis
- demonstrate core computer science knowledge
