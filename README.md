# Library and Backpack System

This project provides a library system and a backpack implementation, allowing you to manage books in a library and items in a backpack.

## Table of Contents

- [Introduction](#introduction)
- [Library System](#library-system)
- [Backpack Implementation](#backpack-implementation)


## Introduction

The library system allows you to add books to a library, borrow books, and return books. Each book has a title, author, and number of pages. The library keeps track of the books using a dictionary where the title is the key and the book object is the value.

The backpack implementation provides a generic backpack class that allows you to pack and unpack items. The backpack is implemented using a list to store the items.

## Library System

The `Library` class represents a library and implements the `ILibrary` interface. It provides the following functionality:

- Adding a book to the library using the `Add` method.
- Borrowing a book by title using the `Borrow` method. This method returns the book and removes it from the library.
- Returning a book to the library using the `Return` method. This method adds the book back to the library.
- Getting the count of books in the library using the `Count` property.
- Implementing the `IEnumerable<Book>` interface to allow iterating over the books in the library.

The `Book` class represents a book and provides properties for the title, author, and number of pages.

## Backpack Implementation

The `Backpack<T>` class represents a generic backpack and implements the `IBag<T>` interface. It provides the following functionality:

- Packing an item into the backpack using the `Pack` method.
- Unpacking an item from the backpack by index using the `Unpack` method. This method returns the item and removes it from the backpack.
- Implementing the `IEnumerable<T>` interface to allow iterating over the items in the backpack.

## Usage

To use the library and backpack system, you can create instances of the `Library` and `Backpack<T>` classes and call the respective methods to perform the desired operations.

Example usage:

```csharp
// Create a library instance
var library = new Library();

// Add a book to the library
library.Add("Book Title", "Author First Name", "Author Last Name", 200);

// Borrow a book from the library
var borrowedBook = library.Borrow("Book Title");

// Return the book to the library
library.Return(borrowedBook);

// Create a backpack instance
var backpack = new Backpack<string>();

// Pack items into the backpack
backpack.Pack("Item 1");

backpack.Pack("Item 2");

// Unpack an item from the backpack
var unpackedItem = backpack.Unpack(0);
```

## Run And Test Code

![Screenshot 2023-07-08 202433](https://github.com/bashar-27/Lab08-Phil-s-Library/assets/83985765/29cd3311-c219-43e1-b205-f11d890840f1)



![Screenshot 2023-07-08 202516](https://github.com/bashar-27/Lab08-Phil-s-Library/assets/83985765/49152d4e-b0c4-4129-9ed1-62997e68ae5a)


