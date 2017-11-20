/*public static void main(String[] args)
{
       GameController GC = new GameController();
       GUI gui = new GUI();
       Map map = new Map();
       Cave cave = new Cave();
       Player player = new Player();
       Trivia trivia = new Trivia(); 

       gui.displayStart();

       boolean gameGoing = true;
       
       while(gameGoing)
     	{
		GC.move();

              gameGoing = gui.checkIfQuit(); 
	}
}

class GameController
{
       	public GameController()
       	{

       	}

       	public void move(GUI g, Map m, Cave c, Player p)
	{
              	int targetRoom = gui.askPlayerWhereToMove();
		m.movePlayer(targetRoom);
                g.displaySurroundingRooms(m.getSurroundingRooms(targetRoom));
		g.displayHazards(m.getHazards(targetRoom));
	}
} */