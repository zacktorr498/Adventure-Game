using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int scene = 1;

        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V)       //yellow button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 10) { scene = 11; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 16) { scene = 18; }


                // other pathways with (letters)
                else if (scene == 6) { scene = 13; } // = A
                else if (scene == 7) { scene = 13; } // = A
                else if (scene == 11) { scene = 13; } // = A
                else if (scene == 9) { scene = 8; } // = B
                else if (scene == 19) { scene = 16; } // = C
                else if (scene == 4) { scene = 8; } // = D

            }
            else if (e.KeyCode == Keys.Space)  //green button press
            {
                if (scene == 1) { scene = 13; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 13) { scene = 15; }


                // other pathways with (letters)
                else if (scene == 12) { scene = 13; } // = A


                //Pathways that lead to the end
                else if (scene == 15) { scene = 99; } // = end
                else if (scene == 17) { scene = 99; } // = end
                else if (scene == 19) { scene = 99; } // right = end
                else if (scene == 18) { scene = 98; } // leads to the end with some extra text
                else if (scene == 98) { scene = 99; } // leads to the end with some extra text
                else if (scene == 9) { scene = 99; } // right = end


            }

            //switch

            switch (scene)
            {
                
                case 1:

                    sceneImage.BackgroundImage = Properties.Resources.Old_Ruins;
                    outputLabel.Text = "you are going on a walk through a forest and you come across some old ruins.";
                    redLabel.Text = "Enter";
                    blueLabel.Text = "Pass";
                    break;
                case 2: 
                    outputLabel.Text = "You enter the ruins. there is a doorway to the left and a stair case going down to the right. ";
                    redLabel.Text = "Left";
                    blueLabel.Text = "Right";
                    break;
                case 3:
                    outputLabel.Text = "You find a glass case with a key inside. its chained shut but there is enough space for you to fit you hand through.";
                    redLabel.Text = "Grab it";
                    blueLabel.Text = "Leave it";
                    break;
                case 4:
                    outputLabel.Text = "You walk down the stairs to a group of spiders and a locked door.";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 5:
                    outputLabel.Text = "you slip your hand through the case and grab the key. " +
                        "There is nothing else in the room so you leave. Now back at the 2 doorways.";
                    redLabel.Text = "Leave";
                    blueLabel.Text = "Go down stairs";
                    break;
                case 6:
                    outputLabel.Text = "There is nothing else in the room so you leave and your back in front of the 2 doors";
                    redLabel.Text = "leave";
                    blueLabel.Text = "down";
                    break;
                case 7:
                    outputLabel.Text = "You leave the old ruins and come across a cave";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 8:
                    outputLabel.Text = "You walk down the stairs and see some spiders up ahead. there is a room to your left.";
                    redLabel.Text = "Attempt to fight";
                    blueLabel.Text = "Check out the room ";
                    break;
                case 9:
                    outputLabel.Text = "You die trying to fight the spiders with your bare hands";
                    redLabel.Text = "Retry";
                    blueLabel.Text = "Quit";
                    break;
                case 10:
                    sceneImage.BackgroundImage = Properties.Resources.Old_Armory;
                    outputLabel.Text = "This room seems to be an old armory. There is a rusty sword and slightly rusty axe on the wall. " +
                        "you grab them because you think they will come in handy. You leave the room after having a look around";
                    redLabel.Text = "Fight";
                    blueLabel.Text = "Leave";
                    break;
                case 11:
                    outputLabel.Text = "You kill all the spiders but the sword is now chipped. You see a chest behind a bunch of cobwebs" +
                        "You cut apart the cobwebs to uncover a big chest with a lock on it. " +
                        "You unlock it with the key to revel a giant, shiny sword. after looking at the sword, you take it, " +
                        "leaving the axe and the sword you had and then leave the ruins.";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 12:
                    sceneImage.BackgroundImage = Properties.Resources.Cave;
                    outputLabel.Text = "You leave the ruins and come up onto a cave";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 13:
                    sceneImage.BackgroundImage = Properties.Resources.Cave;
                    outputLabel.Text = "You decide not to enter the ruins and find yourself in front of a cave. Do you enter?";
                    redLabel.Text = "Enter";
                    blueLabel.Text = "Pass";
                    break;
                case 14:
                    sceneImage.BackgroundImage = Properties.Resources.Cave_Bear_Treasure;
                    outputLabel.Text = "You enter the cave and you see a big shining chest behind a giant bear.";
                    redLabel.Text = "Fight";
                    blueLabel.Text = "Leave";
                    break;
                case 15:
                    sceneImage.BackgroundImage = Properties.Resources.City;
                    outputLabel.Text = "you continue your walk and eventually end up back in the city";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 16:
                    sceneImage.BackgroundImage = Properties.Resources.Cave_Bear_Treasure;
                    outputLabel.Text = "You approach the bear slowly. Do you have a weapon to fight the bear?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 17:
                    sceneImage.BackgroundImage = Properties.Resources.City;
                    outputLabel.Text = "You left the cave and eventually made your way back into the city";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 18:
                    sceneImage.BackgroundImage = Properties.Resources.Treasure_Chest;
                    outputLabel.Text = "You ready you sword you obtained from the ruins. " +
                        "After a good few minutes of fighting the bear falls over onto it's side with a bunch of stab wounds and a giant gash on its belly." +
                        "You go and claim you reward from the giant shining chest. Inside you find tons of gold." +
                        "You eventually make your way back to the city with your rewards. ";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 19:
                    outputLabel.Text = "You didn't have a weapon to fight the bear so you decided to try fighting it with your bare hands and got teared apart.";
                    redLabel.Text = "Retry";
                    blueLabel.Text = "Quit";
                    break;
                case 98:
                    outputLabel.Text = "Good Job Hero! What other Adventures Await You? :) ";
                    redLabel.Text = "";
                    blueLabel.Text = "press space to continue";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

    }
}