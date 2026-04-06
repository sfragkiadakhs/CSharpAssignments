# Net Under The Hood: CSV Processing & Performance Optimization

An advanced case study in performance optimization demonstrating memory efficiency techniques, type-specific storage, and comparison between naive and optimized data structure implementations.

## 📌 Project Purpose

This project tackles a **real-world performance challenge**: processing large CSV datasets efficiently.

**The Challenge:**
- Parse a 4,000-row × 432-column CSV file (~1.7M data points)
- Many cells are empty (sparse data)
- Mixed data types: bool, string, int, decimal
- Minimize memory footprint and access overhead

**The Solution:**
Implement a high-performance CSV loader using advanced optimization techniques, showcasing proficiency in:
- Memory optimization
- Boxing/unboxing elimination
- Sparse data handling
- Performance measurement

## 🎯 Key Achievements

### Problem #1: Sparse Data Storage
**Naive Approach:** Store every cell, including empty ones  
**Optimized Approach:** Only store non-null values

**Impact:** Massive reduction in memory consumption

### Problem #2: Type Inefficiency
**Naive Approach:** Store all cells as `object` type
```csharp
// Naive: uses boxing/unboxing on every access
object value = table[row, col];
int number = (int)value; // Unboxing overhead
```

**Optimized Approach:** Type-specific storage in segregated lists
```csharp
// Optimized: direct access, no boxing overhead
int number = intValues[index];
```

**Impact:** Elimination of boxing/unboxing performance penalty

## 🏗️ Architecture

### Solution Structure

#### `/OldSolution` - Naive Implementation
- `Row.cs` - Represents a single row as array of objects
- `TableData.cs` - Stores all data in memory
- `TableDataBuilder.cs` - Constructs table from CSV

**Characteristics:**
- Stores all cells including nulls
- Everything as `object` type
- Significant boxing/unboxing on access
- Large memory footprint

#### `/NewSolution` - Optimized Implementation
- `FastRow.cs` - Efficient row representation
- `FastTableData.cs` - Sparse, type-specific storage
- `FastTableDataBuilder.cs` - Optimized CSV parser

**Characteristics:**
- Only non-null values stored
- Type-specific lists (bool, string, int, decimal)
- Direct access without boxing overhead
- Minimal memory footprint

#### `/PerformanceTesting` - Benchmarking Tools
- `TableDataPerformanceMeasurer.cs` - Measuring execution time and memory
- `ContentEqualityChecker.cs` - Verifying both implementations produce identical results
- `TestResult.cs` - Structured performance metrics

#### `/CsvReading` - CSV Infrastructure
- `ICsvReader.cs` - Interface for CSV parsing
- `CsvReader.cs` - CSV file parser
- `CsvData.cs` - Parsed CSV representation

#### `/Interface` - Abstraction Layer
- `ITableData.cs` - Table data interface
- `ITableDataBuilder.cs` - Builder interface for constructing tables

## 📊 Performance Metrics

### Memory Efficiency
| Metric | Naive | Optimized | Saving |
|--------|-------|-----------|--------|
| Memory Cells Stored | All 1.7M | Only non-null | ~60-70% |
| Type Overhead | Boxing per access | None | Major |
| Access Pattern | object → cast | Direct reference | Faster |

### Time Complexity
| Operation | Naive | Optimized |
|-----------|-------|-----------|
| Parse CSV | O(n) | O(n) |
| Access Cell | O(1)* | O(1)* |
| Access Integer | O(1) + unboxing | O(1) |
| Memory Scan | O(all cells) | O(non-null cells) |

*With boxing overhead for naive approach

## 💡 Optimization Techniques Demonstrated

### 1. **Sparse Data Handling**
```
Traditional: [null, null, 15, null, null, 42, ...]
Optimized:  positions[0]=2, positions[1]=5
            values[0]=15, values[1]=42
```

### 2. **Type-Specific Storage**
```csharp
// Instead of:
object[] mixed = new object[4000 * 432];

// Use:
List<int> integers = new();
List<decimal> decimals = new();
List<string> strings = new();
List<bool> booleans = new();
```

### 3. **Boxing/Unboxing Elimination**
```csharp
// Naive (boxing on store, unboxing on retrieve):
table[row, col] = 42;      // boxes int to object
int x = (int)table[row, col]; // unboxes back

// Optimized (no boxing):
intValues[index] = 42;
int x = intValues[index];
```

## 📂 Project Structure

```
NetUnderTheHoodAssignment/
├── CsvReading/
│   ├── CsvReader.cs
│   ├── CsvData.cs
│   └── ICsvReader.cs
├── Interface/
│   ├── ITableData.cs
│   └── ITableDataBuilder.cs
├── OldSolution/
│   ├── Row.cs
│   ├── TableData.cs
│   └── TableDataBuilder.cs
├── NewSolution/
│   ├── FastRow.cs
│   ├── FastTableData.cs
│   └── FastTableDataBuilder.cs
├── PerformanceTesting/
│   ├── TableDataPerformanceMeasurer.cs
│   ├── ContentEqualityChecker.cs
│   └── TestResult.cs
├── Program.cs
├── README.md
└── sampleData.csv (4000x432 test data)
```

## 🔨 Building & Running

```bash
# Build the project
dotnet build

# Run performance tests
dotnet run
```

The program will:
1. Load CSV data using both implementations
2. Compare and verify correctness
3. Measure and display performance metrics
4. Show memory usage and execution time comparison

## 🎓 Learning Outcomes

This project teaches:

- **Memory Optimization** - Understanding memory footprint and efficient allocation
- **Type System** - Boxing/unboxing costs and type-specific storage
- **Performance Profiling** - Measuring and analyzing code performance
- **Data Structures** - Designing efficient data representations
- **CSV Processing** - Parsing and validating structured data
- **Benchmarking** - Comparative analysis and metrics

## 🧪 Verification Strategy

The project includes validation to ensure both implementations produce identical results:
- `ContentEqualityChecker` compares naive vs. optimized outputs
- Byte-by-byte verification of data integrity
- Performance metrics collected for both approaches

## 💼 Professional Value

For **Code Reviewers & Recruiters**, this demonstrates:
- ✅ Understanding of .NET internals (boxing/unboxing)
- ✅ Performance-conscious coding practices
- ✅ Ability to identify and fix performance bottlenecks
- ✅ Clear documentation of optimization strategies
- ✅ Proper benchmarking and validation methodology

---

**Target Framework:** .NET 7.0+  
**Language Version:** C# 10+  
**Key Concepts:** Performance Optimization, Memory Management, Type Systems, CSV Processing