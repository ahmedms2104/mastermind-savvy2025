
# Mastermind Console Game - Savvy Kickstarter 2025
> Gameplay Programming Track – Skills Assessment  
> By Ahmed Al-Mohammadi

## 🎮 About the Game

This is a simple **console-based implementation of the classic Mastermind game** written in **C#**, built as part of the skills assessment for the **Savvy Games Group Kickstarter Internship Program – Gameplay Programming Track (2025)**.

In this game:
- There are **9 unique pieces** (from `'0'` to `'8'`)
- A **secret code** is generated (or given via parameter) using **4 unique digits**
- The player has a limited number of attempts (default: 10) to guess the code
- After each guess, the game tells:
  - How many pieces are **well placed**
  - How many pieces are **misplaced**
- Input is taken via the Windows console

---

## 🧠 Features & Concepts

- Written using **C# and Object-Oriented Programming (OOP)**
- Demonstrates:
  - **Encapsulation** (class structure & private members)
  - **Inheritance/Polymorphism** concepts potential (though kept simple)
  - **Method design** and responsibility separation
  - **Input validation & control flow**
- Accepts optional parameters:
  - `-c [CODE]` → Provide a custom secret code
  - `-t [ATTEMPTS]` → Set the number of rounds (default: 10)

---

## 🕹️ How to Play

1. **Build the project** in Visual Studio or using `.NET CLI`
2. **Run it in the console** with or without parameters:

```bash
# Default: random code, 10 attempts
dotnet run

# Custom code and attempts
dotnet run -- -c 1234 -t 5
```

3. The game will display:
```
Can you break the code? Enter a valid guess.
```

4. Then type your 4-digit guess using digits between 0-8 (no repeats), e.g.:
```
> 1032
Well placed pieces: 2
Misplaced pieces: 1
```

5. Win by guessing the code, or lose when attempts are over.

---

## 📌 Sample Output

```bash
Round 0
> 1234
Well placed pieces: 1
Misplaced pieces: 2
...
Round 3
> 0321
Congratz! You did it!
```

---

## 💡 Additional Notes

- Handles `Ctrl + D` (EOF) to exit gracefully
- Prevents invalid inputs like:
  - Letters
  - Digits out of range
  - Repeated numbers

---

## 📂 Folder Structure

```
📁 Mastermind/
│   └── Program.cs
│   └── README.md
```

---

## ✅ Requirements

- .NET 6.0 SDK or later  
- Windows console (cmd or terminal)

---

## 📫 Author

**Ahmed Al-Mohammadi**  
Kickstarter 2025 – Gameplay Programming Track Candidate  
Email: [you@example.com] *(replace with your real one)*  
GitHub: [https://github.com/yourusername] *(replace with your repo)*
