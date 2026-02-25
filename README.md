# Custom Generic List (`MyList<T>`) in C#

## Overview
This project is a custom, from-scratch implementation of the `List<T>` data structure in C#. It was built to demonstrate a deep understanding of how dynamic arrays work "under the hood" without relying on the built-in `System.Collections.Generic.List<T>`.

## Key Features
* **Generics Support:** Strongly typed list capable of storing any data type (e.g., `int`, `string`, or custom objects) using `<T>`.
* **Dynamic Resizing:** Automatically doubles its internal capacity when the array is full, mimicking the behavior of the native C# `List`.
* **State Tracking:** Distinctly tracks both `Count` (the actual number of items) and `Capacity` (the currently allocated memory size).
* **Core Operations:**
  * `Add(T item)`: Appends an item to the list, triggering memory reallocation if necessary.
  * `Remove(T item)`: Finds and removes the first occurrence of a specific value.
  * `RemoveAtIndex(int index)`: Removes an item at a specific position, shifts subsequent elements to the left to fill the gap, and handles memory cleanup using `default!`.
  * `ShowAll()`: Iterates through the active elements and prints them to the console.

## How it Works (Under the Hood)
Unlike standard fixed-size arrays (`T[]`), `MyList<T>` dynamically manages memory. It initializes with a baseline capacity of 4. When a 5th element is added, the private `Resize()` method creates a new array with double the capacity (8), copies the old elements over, and points the reference to the new array. When items are removed, the `Count` decreases, but the `Capacity` remains stable, optimizing performance for future additions.

## Getting Started
1. Clone this repository.
2. Open the project in your preferred IDE (Rider, Visual Studio, or VS Code).
3. Run the project from the terminal to see the state machine in action:
   ```bash
   dotnet run
