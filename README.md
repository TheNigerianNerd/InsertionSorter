# InsertionSorter

A C# implementation of the Insertion Sort algorithm, built with simplicity and testability in mind. This project includes a clean sorting method and a suite of xUnit tests covering a variety of edge cases and expected behaviors.

## 🔧 Features

- Sorts a list of integers using the Insertion Sort algorithm
- Handles edge cases:
  - Empty lists
  - Single-item lists
  - Lists with duplicate or negative numbers
  - Already sorted or reverse sorted lists
- Built-in unit tests using xUnit

## 📦 Requirements

- .NET 6.0 or later
- xUnit (`xunit`, `xunit.runner.visualstudio`)
- A C# IDE like Visual Studio or VS Code

## 📂 Project Structure

```
InsertionSorter/
├── InsertionSorter/
│ └── InsertionSorter.cs // Core sorting logic
├── InsertionSorter.Test/
│ └── SortTest.cs // xUnit test cases
└── README.md
```


## 🚀 Getting Started

### Clone the repository:
```
bash
git clone https://github.com/YourUsername/InsertionSorter.git
cd InsertionSorter
```
Build and run tests:

If you're using the CLI:
```
dotnet build
dotnet test
```
Or just use the built-in Test Explorer in Visual Studio.
📌 Example Usage
```
var sorter = new InsertionSorter();
var result = sorter.SortNumbers(new List<int> { 5, 2, 8, 1 });
// result => [1, 2, 5, 8]
```
✅ Test Coverage

Test cases include:

    List with random order

    Already sorted list

    Reverse sorted list

    Empty list

    Single-element list

    Duplicates

    Negative numbers

🧠 Why Insertion Sort?

Although not the most efficient for large datasets, Insertion Sort is a great algorithm for learning basic sorting principles and is efficient for small or nearly-sorted lists.

📃 License

This project is open-source and free to use, remix, or learn from. I didn’t invent insertion sort — just building with it and sharing the journey.

Keep learning, keep coding.
Shoutout to Oche @thenigeriannerd Edache🧠💥
