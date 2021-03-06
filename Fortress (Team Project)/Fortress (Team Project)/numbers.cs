﻿//numbers class
//Shawn Jones wrote this part of the program
//04/11/17
//I did not copy this code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress__Team_Project_
{

    class numbers
    {
        //declare const
        const int USER = 3;
        const int GENERITOR = 6;
        const int MAX = 10;
        const int MIN = 0;
        const int HEALTH = 30;
        //delcare arrays for users input and for random gen
        int[] inputsR = new int[USER];
        int[] inputsL = new int[USER];
        int[] game = new int[GENERITOR];
        int[] damge = new int[USER];
        
        //declare new random list
        Random nums = new Random();


        //declare integers
        int base1_health = HEALTH;
        int base2_health = HEALTH;

        //this is the getter and setters, these are will put it directly into the array
        //rightValues
        //this will input the passed values from the form class
        //paramiters: int, int
        //returns: none
        public void rightValues(int input, int textbox)
        {
            inputsR[textbox] = input;
        }

        //leftValues
        //this will input the passed values from the form class
        //paramiters: int, int
        //returns: none
        public void leftValues(int input, int textbox)
        {
            inputsR[textbox] = input;
        }

        //randomGen
        //this creats a new list of numbers them populates the game array
        //paramiters: none
        //returns: none
        public void randonGen()
        {
            for (int i = 0; i < GENERITOR; i++)
            {
                game[i] = nums.Next(MIN, MAX);
            }
        }

        //checkNumbers
        //this validates the user input
        //paramiters: array right, array left
        //returns: bool
        public bool checkNumbers()
        {
            bool bools = true;

            for (int i = 0; i < USER; i++)
            {
                int check = inputsR[i];
                int check2 = inputsL[i];

                for (int j = 0; j < GENERITOR; j++)
                {
                    if (check == game[j])
                    { }
                    else
                    {
                        bools = false;
                    }
                }

                for (int j = 0; j < GENERITOR; j++)
                {
                    if (check2 == game[j])
                    { }
                    else
                    {
                        bools = false;
                    }
                }
            }
            return bools;
        }

        //subtrack
        //this methood subtracts the values and then pouplates the damage array
        //paramiters:none
        //returns: none
        public void subtrack()
        {
            for (int i = 0; i < USER; i++)
            {
                damge[i] = inputsR[i] - inputsL[i];
            }
        }

        //choseSide
        //this methood looks at the values of damge array if possive it retuns true, if negitve false, if 0 it will be counted as possitve. 
        //paramiters: int row (0-2)
        //returns: bool
        public bool choseSide(int row)
        {
            bool direction = false;
            if (MIN <= damge[row])
            {
                direction = true;
            }
            return direction;
        }

        //Base1Health
        //this method sets base1 health to 25
        //none
        //returns base1_health
        public int Base1Health()
        {
            return base1_health;
        }

        //Base2Health
        //this method sets base2 health to 25
        //none
        //returns base2_health
        public int Base2Health()
        {
            return base2_health;
        }
    }
}
    

