# Rock Paper Scissors

#### A console application for playing rock, paper, scissors.

#### By Alex Shevlin

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Technology Requirements](#technology-requirements)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Contact Info](#contact-information)  
[Tests](#tests)**

## Technologies Used

* _C#_
* _Net 5.0_

## Description

A recreation of the game rock, paper, scissors by using user input. Logic allows the game to make rock beat scissors, scissors beat paper, and paper beat rock. If both players choose the same input then the game ends with a draw.

## Technology Requirements

* Download and install **[.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)**  
* Download and instal a code text editor. This project was set up with **[VS Code](https://code.visualstudio.com/)**

## Setup/Installation Requirements

* clone repo to pc

## Known Bugs

* _No known bugs. If any are found please contact us!_

## License

[GNU](/LICENSE-GNU)

Copyright (c) 2022 Alex Shevlin

## Contact Information

* Alex Shevlin <alexshevlin1@gmail.com>

### **Tests**

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>save input of both users</td>
    <td>
      string player1 = "rock";
      <br>
      string player2 = "paper"; 
      <br>
      string input = player1 + ", " + player2; 
      <br>
      Game newGame = new Game(player1, player2);  
    </td>
    <td>
    "rock, paper"
    </td>
  </tr>
  <tr>
    <td>compare input and return winner</td>
    <td>
    <code>
    </code>
    </td>
    <td>"user 2 wins"</td>
  </tr>
    <tr>
    <td>return draw if inputs are same</td>
    <td>
      <code>
      </code>
    </td>
    <td>"it's a draw!"</td>
  </tr>
    </tr>
    <tr>
    <td>return error if entered input is wrong</td>
    <td>
      <code>
      </code>
    </td>
    <td>"please enter rock, paper, or scissors"</td>
  </tr>

