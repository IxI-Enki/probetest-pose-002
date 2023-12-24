///-------------------------------------------------------------------//
using System;                                                        ///
namespace Test_pose_002                                              ///
{
  public class First                                                 ///
  {
    public void Task()                                               ///
    {  ///------------------------------------------------------------//
      /* DECLARE VARIABLES */
      // ROT13:
      /*
       *   0   1   2   3   4   5   6   7   8   9  10  11  12  
       *   A   B   C   D   E   F   G   H   I   J   K   L   M
       *   ↕   ↕   ↕   ↕   ↕   ↕   ↕   ↕   ↕   ↕   ↕   ↕   ↕  
       *   N   O   P   Q   R   S   T   U   V   W   X   Y   Z
       *  13  14  15  16  17  18  19  20  21  22  23  24  25
       *  
       *    +/- 13
       */
      const int ROT13 = 13;

      // 26 <= Buchstabe.ToUpper('A') bis Buchstabe.ToUpper('Z'):

      Console.WriteLine("\n\n Text eingeben: \n\n  ");
      string input = "";
      input = Console.ReadLine();
      int length = input.Length;
      string encryptThis = "";
      bool indicator = false;

      /* CALCULATION */
      for (int j = 0; j < 2; j++)
      {
        for (int i = 0; i < length; i++)
        {
          if ((Char.ToUpper(input[i])) >= 'A' && (Char.ToUpper(input[i]) <= 'M'))
          {
            encryptThis = encryptThis + (char)((int)(input[i]) + ROT13);
            indicator = true;
          }
          else if ((Char.ToUpper(input[i])) >= 'N' && (Char.ToUpper(input[i]) <= 'Z'))
          {
            encryptThis = encryptThis + (char)((int)(input[i]) - ROT13);
            indicator = true;
          }
          else
          {
            encryptThis = encryptThis + (input[i]);
            indicator = false;
          }
          Console.Write($"\n Zeichen: an Stelle {((int)(i)).ToString().PadLeft(4)}: {(char)input[i]}" +
                        $" -> wird {((indicator == true) ? " " +
                        "" : "nicht")}{((j == 0) ? "ver" : "ent")}schlüsselt." +
         //             $"\n -> neuer Zwischenspeicher: {encryptThis.PadLeft(6)}" +
                         "");
        }
        Console.Write($"\n neuer Text: {encryptThis.PadLeft(6)}");
        input = encryptThis;
        encryptThis = "";
        Console.Write($"\n ...entschlüssel{((j == 0) ? "n..." : "t !")}" +
                      $"\n ...[Enter] - {((j==0)?"weiter...":"zurück zur Auswahl...")}");
        Console.ReadLine();                                               ///
      }                                                                   ///
    }                                                                     ///
  } ///--------------------------------------------------------------------//
}