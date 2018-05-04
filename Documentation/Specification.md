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