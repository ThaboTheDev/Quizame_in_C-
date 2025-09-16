# 🎮 Console Quiz Game

A simple C# console-based quiz game that asks multiple-choice questions, tracks your score, and shows your results at the end. This project is designed as a beginner-friendly way to practice C# fundamentals such as classes, lists, loops, and file I/O.

## 📚 Features

- Multiple-choice questions displayed in the console

- Score tracking

- Feedback for correct/incorrect answers

- Load questions from a JSON file

- Extensible design for adding more features (timers, categories, random order)

## 🗂️ Project Structure

```C#
QuizGame/
 ├─ Program.cs        // Entry point
 ├─ Question.cs       // Defines the Question model
 ├─ Quiz.cs           // Core quiz logic (asking questions, scoring)
 ├─ questions.json    // External file containing quiz questions
 └─ README.md

 ```

## ⚙️ How It Works

1. The program loads a list of questions (either hardcoded or from questions.json).

2. It loops through each question, showing the text and multiple-choice options.

3. The player selects an answer by entering a number.

4. The program checks the answer and updates the score.

5. At the end, the total score is displayed.

## 🚀 Getting Started

### Prerequisites

- .NET SDK (7.0 or later recommended) installed

- A code editor like Visual Studio Code or Visual Studio

### Running the Game

1. Clone the repository or download the project.

2. Open the project folder in your editor.

3. Answer the questions and view your score.

4. Run:

```bash

dotnet run
```

## 📝 Customizing Questions

- Edit questions.json to add or modify questions.

- Each question has a Text field, Options array, and a CorrectIndex pointing to the correct answer.

## 🛠️ Possible Improvements

- Randomize the order of questions and answers.

- Add a timer per question.

- Save high scores to a file or database.

- Add categories or difficulty levels.

## 🎯 Learning Goals

- Practice basic C# syntax.

- Work with lists, loops, and conditionals.

- Learn file I/O and JSON serialization.

- Understand how to structure small console projects.
