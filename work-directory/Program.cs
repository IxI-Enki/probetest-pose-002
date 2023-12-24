using Microsoft.VisualBasic;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using Test_pose_002;///--------Test_pose_0xx-----------------------------------

namespace Test_pose_002///------Test_pose_0xx----------------------------------

{
  class Program
  {
    static void Main()
    {///-----------------------------------------------------------------------

      string[] tasks = [
       ///--------------- Aufgaben Anzahl: -----------------------------------
       /* 1) */"Verschlüsselung ROT13",
       /* 2) */"String Modifikation"
       /* 3) */
       ///---------------------------------------------------------------------
       ];
      ///---------------- Aufgaben Anzahl: ------------------------------------
      int numberOfTasks = tasks.Count();
      int task;
      string choice;
      ///----------------------------------------------------------------------
      do
      {
        Console.Clear();
        do
        {
          Console.Write($"\n Wählen Sie eine Aufgabe [1-{numberOfTasks}]" +
                         "\n [0] > Auswahl beenden   " +
                         "\n\n");
          for (int i = 0; i < numberOfTasks; i++)
          {
            Console.Write($" {i + 1}) {tasks[i]}\n");
          }

          choice = Console.ReadLine();
        } while (int.TryParse(choice, out task) == false);
        ///------------- Aufgaben Anzahl: -------------------------------------
        switch (task)
        {
          ///------------------------------------------------------------------
          case 1:
            {
              First Show = new First();
              Show.Task();
            }
            break;
          ///------------------------------------------------------------------
          case 2:
            {
              Second Show = new Second();
              Show.Task();
            }
            break;
          ///------------------------------------------------------------------

          ///------------------------------------------------------------------
          case 0:
          default:
            Console.Write("\n Abbruch \n"); break;
        }
      } while (task != 0);
    }
  }
}
