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

