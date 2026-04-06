# C# Assignments Repository

A collection of professional C# projects demonstrating core programming concepts, data structure implementation, performance optimization, and desktop application development.

## 📋 Projects Overview

### 1. [Custom Linked List](./CustomLinkedList)
**Purpose:** Generic implementation of a singly linked list data structure

**Key Features:**
- Generic `CustomLinkedList<T>` class implementing `ICollection<T>`
- Core operations: AddToFront, AddToEnd, Remove, Clear, Contains
- Supports iteration and array conversion (CopyTo)
- Type-safe implementation with null-safe patterns

**Technologies:** C# 11, Generics, Collections Interface

---

### 2. [Numeric Type Suggester](./NumericTypesSuggestor)
**Purpose:** Interactive Windows Forms application for selecting optimal numeric data types

**Key Features:**
- User-friendly GUI to determine appropriate numeric types (byte, short, int, long, float, double, decimal)
- Input validation with range checking (minValue < maxValue)
- Type filters: Integral-only option and precision requirements
- Real-time type suggestion based on value constraints
- Input safeguards and user guidance

**Technologies:** C# 8, Windows Forms (WinForms), UI/UX Design

---

### 3. [Net Under The Hood Assignment](./NetUnderTheHoodAssignment)
**Purpose:** CSV data processing with advanced performance optimization techniques

**Key Features:**
- High-performance CSV parser handling 4000+ rows and 432 columns
- Memory optimization: Sparse data storage (ignoring null values)
- Type-specific storage: Separate lists for bool, string, int, and decimal types
- Elimination of boxing/unboxing overhead
- Performance measurement and comparative analysis
- Both naive and optimized implementations for benchmarking

**Technologies:** C#, CSV Processing, Performance Optimization, Memory Management

---

## 🎓 Learning Path

These projects were developed while completing an **in-depth .NET programming course** focusing on:
- Clean code principles
- Performance optimization and benchmarking
- Data structure implementation
- Memory management and boxing/unboxing
- Desktop application development with Windows Forms

## 💡 Key Concepts Demonstrated

✅ Generic Programming & Type Safety  
✅ Collection Interfaces (ICollection<T>, IEnumerable<T>)  
✅ Data Structure Design & Implementation  
✅ Memory Optimization Techniques  
✅ Performance Profiling & Benchmarking  
✅ User Interface Design with Windows Forms  
✅ CSV Processing & Data Handling  

## 🔧 Getting Started

Each project is a standalone .NET project. To build and run:

```bash
cd [ProjectName]
dotnet build
dotnet run
```

## 📝 Project Structure

```
CSharpAssignments/
├── CustomLinkedList/          # Generic linked list implementation
├── NumericTypesSuggestor/     # WinForms type suggestion app
└── NetUnderTheHoodAssignment/ # CSV processing & optimization
```

---

**Author:** sfragkiadakhs  
**Target Framework:** .NET 8.0 and .NET 7.0
