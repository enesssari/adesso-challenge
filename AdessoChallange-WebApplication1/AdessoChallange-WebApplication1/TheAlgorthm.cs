﻿
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numOfPlayers;
        int savingCount = 1;
        List<int> updatedPlayers = new List<int>(); // temporary new round players list- defined also here to start while loop
        List<int> players = new List<int>();

        Console.Write("Please enter the number of players: ");
        numOfPlayers = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numOfPlayers; i++)
        {
            players.Add(i + 1);
        }


        while (updatedPlayers.Count != 1)
        { // while loop for player elimination unless new round players is 1 person

            updatedPlayers = new List<int>(); // temporary new round players list

            for (int i = 0; i < players.Count; i++)
            {    // Each round starts from here

                if (savingCount % 2 == 1)
                {    // Whether player is saved or not, odd numbers are saved. If saving count is odd, then the player is added temporary new round list.
                    updatedPlayers.Add(players[i]); // Adding survived players to new round player list.
                }

                savingCount++;  // global saving count increase happens here.
            }

            players = updatedPlayers; //  Elimination round ends here, new round players updated.
            players.ForEach(item => Console.Write(item + " ")); //New round players list
            Console.Write("\n--------\n");
        }
        Console.Write("Last Player to survive: ");
        players.ForEach(item => Console.Write(item)); //   #Last player to survive
    }
}




