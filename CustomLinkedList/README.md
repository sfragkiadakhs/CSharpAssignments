# Custom Linked List Implementation

A generic, type-safe implementation of a singly linked list data structure in C#, demonstrating foundational data structure design and collection interface implementation.

## 📌 Project Purpose

This project implements a custom `LinkedList<T>` to demonstrate:
- Understanding of fundamental data structures
- Generic programming in C#
- Implementation of collection interfaces
- Node-based memory allocation
- Null-safe patterns and modern C# practices

## 🏗️ Architecture

### Public Interface
```csharp
public interface ILinkedList<T> : ICollection<T>
{
    void AddToFront(T? item);
    void AddToEnd(T? item);
}
```

### Core Components

- **CustomLinkedList<T>** - Main linked list implementation
  - Implements `ILinkedList<T>` and `ICollection<T>`
  - Generic type parameter for type safety
  - Nullable reference types support

- **Node Class** - Internal node structure
  - Stores value and reference to next node
  - Enables singly-linked chain behavior

## 🎯 Key Features

### Operations Implemented
| Operation | Complexity | Description |
|-----------|-----------|-------------|
| **AddToFront(T)** | O(1) | Insert element at list beginning |
| **AddToEnd(T)** | O(n) | Append element at list end |
| **Remove(T)** | O(n) | Remove first occurrence of element |
| **Contains(T)** | O(n) | Check if element exists |
| **Clear()** | O(n) | Remove all elements |
| **CopyTo(Array, int)** | O(n) | Copy to array starting at index |

### Special Characteristics
✅ **Generic<T>** - Works with any data type  
✅ **Nullable-safe** - Handles null values correctly  
✅ **IEnumerable Support** - foreach iteration  
✅ **ICollection Implementation** - Full collection protocol  
✅ **Property-based Count** - O(1) size tracking  

## 💻 Usage Example

```csharp
// Create a linked list of strings
var linkedList = new CustomLinkedList<string>();

// Add elements
linkedList.AddToFront("first");
linkedList.AddToEnd("second");
linkedList.AddToEnd("third");

// Iterate through elements
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}

// Copy to array
var array = new string[linkedList.Count];
linkedList.CopyTo(array, 0);

// Check existence
bool exists = linkedList.Contains("second"); // true

// Remove elements
linkedList.Remove("first");
linkedList.Clear();
```

## 🔍 Design Patterns

- **Collections Pattern** - Implements standard .NET collection interfaces
- **Generic Pattern** - Type-safe, reusable implementation
- **Linked Structure Pattern** - Node-based chain architecture

## 📊 Performance Characteristics

| Operation | Best | Average | Worst |
|-----------|------|---------|-------|
| Access | O(1) | O(n) | O(n) |
| Search | O(1) | O(n) | O(n) |
| Insertion | O(1) | O(n) | O(n) |
| Deletion | O(1) | O(n) | O(n) |

## 🔨 Building & Running

```bash
# Build the project
dotnet build

# Run the console application
dotnet run
```

## 📚 What You'll Learn

This implementation demonstrates:
1. **Data Structure Fundamentals** - How linked lists work at their core
2. **Generics in C#** - Creating reusable, type-safe code
3. **Interface Implementation** - Adhering to .NET collection contracts
4. **Null Safety** - Modern nullable reference type handling
5. **Algorithm Design** - Time/space trade-offs in data structures

## 🎓 Learning Context

Part of an advanced C# programming course focusing on:
- Clean code principles
- Data structure mastery
- Performance awareness
- Standard library design patterns

---

**Target Framework:** .NET 8.0+  
**Language Version:** C# 11+
