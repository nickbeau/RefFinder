## Referee Finder
The Referee finder application is a simple web application to allow the following:

1. Teams can login and record games whether they require a referee
2. Referees can login and bid for games
3. Once a game is agreed, the team marks it as complete and payment goes to the Referee


# Data Structures
the Key data structures are as follows

## Games

| Field     | Type              | Usage | 
| --------- | ----------------- | ----- |
| Club      | string            | name of the club this team belongs to |
| Ground    | string (location) | The location of where the game will be played |
| Age Group | string            | The Age Group, anything from 18, AL, O35, O45 |
| Date      | date              | the date of the game |
| time      | time              | the time of the game |

## Referees
| Field     | Type              | Usage | 
| --------- | ----------------- | ----- |
| Name      | string            | The name of the referee |
| ID        | Referee ID Number | The ID of the Referee |
| email     | Email             | Referee's Email |
| Accreditation | string        | Referee's accreditation |


# User Stories
#1 Game Owner
The Game Owner registers with the web site. They can then post games that require referees. They can see a list of games they have posted and games that require a referee. Once a referee bids on a game, they get notifications. They can accept a referee and that referee is then appointed to the game

#2 Referee
The referee registers with the web site. They can view all unassigned games (in the future). They can place a bid on a game. Once they are successful, they can see a list of games assigned to them. Once they have officiated the game, they can then see the history of games they have done. Once the game owner accepts the game as complete, payment is made

#3 Payment
Once a game owner accepts a bid, we take the agreed $. Once the game owner marks the game as complete, funds are sent to the referee -10% for us.


# Application Flow
## Basic Flow
1. The Game Owner records a game
2. Referee's bid on the game. Part of the bid includes how much they want to be paid
3. The Game Owner accepts a bid
4. We take the Money of the bid amount from the game owner
5. The Game Owner confirms the game has been held correctly
6. We pay the referee
