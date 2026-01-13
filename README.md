# C-Sharp-Stellar-Lifecycle-Simulator

## Overview

The **Star Lifecycle Simulator** is a simple C# console application that models the basic lifecycle of a star.  
It demonstrates how a star is created, ages over time, shines with decreasing brightness, and can eventually explode in a supernova.

The program is designed to be easy to read and understand, making it suitable for learning and demonstrating object-oriented programming concepts in C#.

---

## What the Program Does

- Creates stars with either a known or unknown type
- Tracks a star’s age and brightness
- Reduces brightness as the star grows older
- Displays the star’s current state to the console
- Simulates a supernova event

---

## Coding Techniques Demonstrated

This project showcases several core C# and object-oriented programming techniques:

- **Classes and Objects** – The `Star` class represents a real-world entity
- **Encapsulation** – Internal state is protected using private setters
- **Constructor Overloading** – Different ways to create a `Star`
- **Constructor Chaining** – Reusing constructor logic with `this(...)`
- **State Management** – Preventing invalid actions (multiple supernovas)
- **String Interpolation** – Clean and readable console output
- **Basic Formatting** – Limiting numeric output to a fixed number of decimals

---

## Example Output

```
Star Sun is shining with brightness 1.00.
Star Sun is shining with brightness 0.90.
Star Sun has exploded in a supernova.
Type undefined. Defaulting to unknown.
Star Mystery Star is shining with brightness 1.00.
```
