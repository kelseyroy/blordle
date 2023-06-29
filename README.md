# blordle - the Wordle clone made with Blazor 
## Overview

The goal of this feature is to implement Wordle using Blazor and Razor Components. At the start of the game, the computer will randomly generate a secret five-letter word. One human player ought to be able to submit a valid word guess and the computer opponent will evaluate their guess. The computer will then provide feedback to the player by highlighting the letters in different colors:
* Gray/No Color: Incorrect Letter
* Yellow: Correct letter in the incorrect position
* Green: Correct letter in the correct position

The human player will then be able to use the feedback to make an educated guess on what the secret word could be. The game will continue until the secret word is guessed by the human player, resulting in a win, or until the player submits 6 incorrect guesses, resulting in a loss.

## Functional Requirements

* Upon starting the game in the browser, the user should be presented with simple instructions on how to play the game.
* The game should generate a random, secret five-letter word to guess.
* A human player should be able to input at most 6 guesses for the secret word, as long as the guess is a valid five-letter word.
* The game should evaluate the user's guesses and provide feedback on the correctness of each letter by highlighting the letters with colors that correspond to the correctness and position of the letter.
* The game should keep track of the player's progress--including the number of attempts remaining, the letters guessed, and the feedback recieved--and update the game state accordingly.
* Winning or losing the game should be identified and the app should close gracefully after the game ends.

## Technical Requirements

* The game will be created using C# on the .NET platform
* All business logic should have close to 100% test coverage with unit tests.
* The code should be well organized and follow the Four Rules of Simple Design.
* There should be no major violations of the SOLID principles in the code.

## Dependencies
* C#
* [.NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## Setup
1. [Clone the repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository) to your local computer.
2. Use your terminal to navigate into your new blordle folder and install project dependencies by running `dotnet build`.
3. To build and start the application, call `dotnet watch run` from within the blordle folder.

