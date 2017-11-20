using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GameController
    {
        Map M;
        Player P;
        private int triviaType;

        public GameController()
        {
            M = new Map();
            P = new Player();
            triviaType = 0;
        }

        public void setTriviaType(int num)
        {
            triviaType = num;
        }

        public int getTriviaType()
        {
            return triviaType;
        }

        public int getPlayerLocation()
        {
            return M.getPlayerLocation();
        }

        public int getNextRoom_GC(int num1, int num2)
        {
            return M.getNextRoom(num1, num2);
        }

        /*
        public int getHazardWarnings()
        {
            return M.adjacentHazardWarning(M.getPlayerLocation());
        }
        */
       

        public void launchTrivia(int type) //EMPTY METHOD
        {
            //LAUNCH TRIVIA(type) ------ if type is 1, its a bat. if its 2, its a pit
        }

        /*
        public int[] getSurroundingRooms()
        {
            return M.roomSingle(M.getPlayerLocation());
        }
        */

        public void moveRoom(int targetRoom)
        {
            M.movePlayer(targetRoom);
        }

        public int getGold()
        {
            return P.GetCoins();
        }

        public int getScore()
        {
            return P.GetScore();
        }

        public int getArrows()
        {
            return P.GetArrows();
        } 

        public void addCoins(int num)
        {
            P.addCoins(num);
        }

        public String getHazardWarnings()
        {
            return M.convertToString(M.warnings(M.getPlayerLocation()));
        }

        public int checkForHazard()
        {
            return M.isThereHazard();
        }

        
    }
}
