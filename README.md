# Rock Paper Scissors

#### A console application for playing rock, paper, scissors.

#### By Alex Shevlin

## Technologies Used

* _C#_
* _Net 5.0_
* _Markdown_

## Description

A recreation of the game rock, paper, scissors by using user input. Logic allows the game to make rock beat scissors, scissors beat paper, and paper beat rock. If both players choose the same input then the game ends with a draw.

## Setup/Installation Requirements

* _clone repo to pc_

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
      <code lang="C#"> 
        string player1 = "rock";
        <br>
        string player2 = "paper";
        <br>
        string input = player1 + ", " + player2;
        <br>
        Game newGame = new Game(player1, player2);
      </code>
    </td>
    <td>
    "Rock, Paper"
    </td>
  </tr>
  <tr>
    <td>save input of both users</td>
    <td>
      <code>
      </code>
    </td>
    <td>"Rock, Paper"</td>
  </tr>
    <tr>
    <td></td>
    <td>
      <code>
      </code>
    </td>
    <td></td>
  </tr>

  | "Rock, Paper" |
| compare input and return winner| | "user 2 wins" |
| return draw if inputs are same| | "it's a draw!" |
| return error if entered input is wrong | | "please enter rock, paper, or scissors" |
