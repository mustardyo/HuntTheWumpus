using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Map
    {
        int bat1;
        int bat2;
        int pit1;
        int pit2;
        int wumpusLocation;
        int playerLocation;
        int[,] surroundingRooms;

        Random random = new Random();

        public Map()
        {
            /*
            // hazards  
            int rand = random.Next(1, 30);

            bat1 = random.Next(1, 30);
            while (bat1 == rand)
            {
                rand = random.Next(1, 30);
            }
            bat2 = rand;
            while (bat1 == rand || bat2 == rand)
            {
                rand = random.Next(1, 30);
            }
            pit1 = rand;
            while (bat1 == rand || bat2 == rand || pit1 == rand)
            {
                rand = random.Next(1, 30);
            }
            pit2 = rand;
            */

            bat1 = 5;
            bat2 = 10;
            pit1 = 15;
            pit2 = 20;

            // wumpus

            wumpusLocation = random.Next(1, 30);

            // player

            playerLocation = random.Next(1, 30);


            // array with surrounding rooms = ANY of the rooms surrounding not just the ones
            // that the player can access 
            surroundingRooms = new int[30, 7]
            {
                    { 01, 02, 07, 06, 30, 25, 26 },
                    { 02, 09, 08, 07, 01, 26, 03 },
                    { 03, 04, 09, 02, 26, 27, 28 },
                    { 04, 11, 10, 09, 03, 28, 05 },
                    { 05, 06, 11, 04, 28, 29, 30 },
                    { 06, 07, 12, 11, 05, 30, 01 },
                    { 07, 08, 13, 12, 06, 01, 02 },
                    { 08, 15, 14, 13, 07, 02, 09 },
                    { 09, 10, 15, 08, 02, 03, 04 },
                    { 10, 17, 16, 15, 09, 04, 11 },
                    { 11, 12, 17, 10, 04, 05, 06 },
                    { 12, 13, 18, 17, 11, 06, 07 },
                    { 13, 14, 19, 18, 12, 07, 08 },
                    { 14, 21, 20, 19, 13, 08, 15 },
                    { 15, 16, 21, 14, 08, 09, 10 },
                    { 16, 23, 22, 21, 15, 10, 17 },
                    { 17, 18, 23, 16, 10, 11, 12 },
                    { 18, 19, 24, 23, 17, 12, 13 },
                    { 19, 20, 25, 24, 18, 13, 14 },
                    { 20, 27, 26, 25, 19, 14, 21 },
                    { 21, 22, 27, 20, 14, 15, 16 },
                    { 22, 29, 28, 27, 21, 16, 23 },
                    { 23, 24, 29, 22, 16, 17, 18 },
                    { 24, 25, 30, 29, 23, 18, 19 },
                    { 25, 26, 01, 30, 24, 19, 20 },
                    { 26, 03, 02, 01, 25, 20, 27 },
                    { 27, 28, 03, 26, 20, 21, 22 },
                    { 28, 05, 04, 03, 27, 22, 29 },
                    { 29, 30, 05, 28, 22, 23, 24 },
                    { 30, 01, 06, 05, 29, 24, 25 }
            };


        }
        /*       
       •	Store and interact with the cave used for this game
       •	Keep track of where the hazards are
       •	Keep track of where the Wumpus is. This includes controlling Wumpus behavior(that is, asleep, awake, moving).
       •	Keep track of where the player is
       •	Control arrow shooting.
       •	Give any necessary warnings
       •	Obtain secrets to help the player
       */
        // interact with the cave


        // to access rooms surrounding the given room

        public int getNextRoom(int num1, int num2)
        {
            return surroundingRooms[num1, num2];
        }

        public int[] roomSingle(int room)
        {
            int[] single = new int[7];
            for (int x = 0; x < 7; x++)
            {
                single[x] = surroundingRooms[room - 1, x];
            }
            return single;
        }

        // warnings
        public String[] warnings(int room)
        {
            String[] hazardWarnings = new String[4];

            String batWarning = "Bats nearby!";
            String pitWarning = "I feel a draft!";

            int[] single = roomSingle(room);
            //int[] single2 = surroundingRooms(room);

            // accessing the values in one element array of the 2d array

            for (int x = 0; x < single.Length; x++)
            {
                int count = 0;
                if (single[x] == pit1)
                {
                    hazardWarnings[count] = pitWarning;
                    count++;
                }
                if (single[x] == pit2)
                {
                    hazardWarnings[count] = pitWarning;
                    count++;
                }
                if (single[x] == bat1)
                {
                    hazardWarnings[count] = batWarning;
                    count++;
                }
                if (single[x] == bat2)
                {
                    hazardWarnings[count] = batWarning;
                    count++;
                }
            }

            return hazardWarnings;
        }

        public String convertToString(String[] a)
        {
            String returned = "";
            for (int x = 0; x < a.Length; x++)
            {
                returned += a[x];
            }

            return returned;
        }

        public int adjacentHazardWarning(int roomNum)   //EMPTY METHOD
        {                                               //detects adjacent hazards, returns 1, 2, or 3
            return 1;                                   //1 = bat(s) nearby, 2 = pit(s), 3 = both
        }

        public Boolean isThereABat(int roomNum)     //EMPTY METHOD
        {                                           //Check if there is a bat in this room
            return false;
        }

        public Boolean isThereAPit(int roomNum)     //EMPTY METHOD
        {                                           //Check if there is a pit in this room
            return false;
        }

        // moving player and bat 

        public void movePlayerWithBat()
        {
            int whichToMove = 0;
            if (playerLocation == bat1)
            {
                whichToMove = -1;
            }
            if (playerLocation == bat2)
            {
                whichToMove = 1;
            }

            //initializes new room
            // checks to see if new room corresponds with room for new hazard
            int newRoom = random.Next(1, 30);
            playerLocation = newRoom;
            newRoom = random.Next(1, 30);
            while (hazardSameRoom(newRoom) == false)
            {
                if (whichToMove == -1)
                {
                    bat1 = newRoom;
                }
                else if (whichToMove == 1)
                {
                    bat2 = newRoom;
                }
            }
        }

        public int isThereHazard()
        {
            // 0 == wumpus
            // 1 == bat
            // 2 = pit

            if (playerLocation == pit1 || playerLocation == pit2)
            {
                return 2;
            }
            if (playerLocation == bat1 || playerLocation == bat2)
            {
                return 1;
            }
            if (playerLocation == wumpusLocation)
            {
                return 0;
            }
            return 3;
        }

        // to check if the hazards are in the same room 

        public Boolean hazardSameRoom(int first)
        {
            if (bat1 == first || bat2 == first || pit1 == first || pit2 == first)
            {
                return false;
            }
            return true;
        }
        // wumpus methods

        public int getWumpusLocation()
        {
            return wumpusLocation;
        }

        public Boolean doesWumpusMove()
        {
            Boolean moves = false;
            int woken = random.Next(1, 30);

            if (woken == 1)
            {
                moves = true;
            }

            return moves;
        }


        public int moveWumpus(int toWhichRoom)
        {
            // return 0 for player winning
            // return -1 for wumpus running into the same room as the player

            // if player hits
            if (shootArrow(toWhichRoom) == true)
            {
                // player wins
                return 0;
            }
            else
            // player doesnt hit
            {
                int[] rooms = roomSingle(wumpusLocation);
                int newRoomIndex = random.Next(1, 30);
                wumpusLocation = rooms[newRoomIndex];

                if (wumpusLocation == playerLocation)
                {
                    return -1;
                }
                return 1;
            }
        }

        // player methods

        public int getPlayerLocation()
        {
            return playerLocation;
        }

        public void movePlayer(int newRoom)
        {
            playerLocation = newRoom;
        }

        // arrow shooting/controlling

        public int[] canShootWhere(int room)
        {

            return roomSingle(room);
        }

        public Boolean shootArrow(int toWhichRoom)
        {

            if (toWhichRoom == wumpusLocation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}

