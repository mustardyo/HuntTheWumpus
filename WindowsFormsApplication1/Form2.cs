using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form 
    {
        enum surroundingRoomsArray
        {
            //
            moveup = 4, 
            moverightup = 5,
            moverightdown = 0,
            movedown = 1,
            moveleftdown = 2,
            moveleftup = 3
        }
        GameController GC = new GameController();
        //holds current surrounding rooms
        //int[,] surroundingRooms;
        public Form2()
        {
            InitializeComponent();
            updates();
        }
        private void updates()
        {
            roomNum.Text = GC.getPlayerLocation().ToString();
            notifications.Text = "money";

            //get gold
            //display gold
            textBox1.Text = GC.getGold().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //move up
            GC.moveRoom(GC.getNextRoom_GC(GC.getPlayerLocation() - 1, 5));
            updates();
            notifications.Text = "movin on up";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //move right up
            GC.moveRoom(GC.getNextRoom_GC(GC.getPlayerLocation() - 1, 6));
            updates();
            notifications.Text = "blastin off and away";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //move right down
            //GC.moveRoom(surroundingRooms[(int)surroundingRoomsArray.moverightdown]);
            GC.moveRoom(GC.getNextRoom_GC(GC.getPlayerLocation() - 1, 1)); 
            updates();
            notifications.Text = "i like to move it move it";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //move down
            GC.moveRoom(GC.getNextRoom_GC(GC.getPlayerLocation() - 1, 2));
            updates();
            notifications.Text = "its going down";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //move left down
            GC.moveRoom(GC.getNextRoom_GC(GC.getPlayerLocation() - 1, 3));
            updates();
            notifications.Text = "to the left to the left";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //move left up
            GC.moveRoom(GC.getNextRoom_GC(GC.getPlayerLocation() - 1, 4));
            updates();
            notifications.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void roomNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            updates();
            notifications.Text = "Room Displayed";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
