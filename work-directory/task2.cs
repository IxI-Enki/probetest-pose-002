///-----------------------------------------------------------------------//
using System;                                                            ///
namespace Test_pose_002                                                  ///
{
  public class Second                                                    ///
  {
    public void Task()                                                   ///
    {  ///----------------------------------------------------------------//
      bool run = true,
           isInt;
      string input = "",
             inputCache = "",
             inputFilter = "",
             output;
      int inputLength,
          startIndex,
          endIndex,
          lengthSubstring,
          outputLength = 0,
          restlength;
      ///-----------------------------------------------------------------
      ///    
      do
      {
        do   ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        {    ///   INPUT TEXT OR ABORT ("0")
          Console.Write("\n (0=Abbruch) Text: ");
          input = Console.ReadLine();
          inputLength = input.Length;
          inputCache = input;

          Console.Write($"\n {((input == "0") ? "Ende" : ("Länge: ")+input.Length)}" +
                        $"\n Eingabe: {inputCache}");
        } while (inputLength <= 0);
        ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        ///    RUN WHILE NOT ABORTED:
        run = (input != "0") ? true : false;
        if (run)
        {
          output = "";
          endIndex = inputLength - 1;
          do   ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - -    
          {    ///   STARTINDEX:
            Console.Write("\n Startindex Substring: ");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out startIndex);
            //
            startIndex = (startIndex <= 0 ? 0 : startIndex);
            startIndex = (startIndex >= endIndex ? endIndex : startIndex);
            inputLength = inputLength - startIndex;
            /*
            Console.Write($"\n verbleibende Länge : {length}" +
            //            $"\n Eingabe  . . . . . : {inputCache}" +
            //            $"\n startindex . . . . : {startIndex}" +
            //            $"\n endIndex . . . . . : {endIndex}");
            */
          } while (!isInt);

          do   ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
          {    ///   SUBSTRING LENGTH:
            Console.Write("\n Länge Substring: ");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out lengthSubstring);
            isInt = (lengthSubstring >= 0) ? true : false;
            //
            lengthSubstring = (lengthSubstring <= 0 ||
                               startIndex >= endIndex ? 0 : lengthSubstring);
            inputLength = inputLength - lengthSubstring;
            /*
            Console.Write($"\n verbleibende Länge : {length}" +
            //            $"\n Eingabe  . . . . . : {inputCache}" +
            //            $"\n startindex . . . . : {startIndex}" +
            //            $"\n endIndex . . . . . : {endIndex}" +
            //            $"\n length substring . : {lengthSubstring}");
            */
          } while (!isInt);
          ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
          ///    CUT OUTPUT:
          for (int i = startIndex; (i < endIndex + 1) && i < (lengthSubstring + startIndex); i++)
          {
            outputLength = (i - startIndex + 1);
            output = output + (char)inputCache[i];

            //  restlength = (endIndex - startIndex + 1) - outputLength;
            /*
            Console.Write(
            //            "\n=================================" +
            //           $"\n outputLength . . . : {outputLength}" +
            //           $"\n cache  . . . . . . : {inputCache[i]}" +
            //           $"\n verbleibende Länge : {restlength}" +
            //            "\n---------------------------------" +
            //           $"\n input  . . . . . . : {inputCache}" +
            //           $"\n startIndex . . . . : {startIndex}" +
            //           $"\n endIndex . . . . . : {endIndex}" +
            //            "\n---------------------------------" +
            //           $"\n Output . . . . . . : {output}" + 
            //           ""); 
            */
          }
          ///--CLEARSCREEN FOR SOLUTION: -  -  -  -  -  -  -  -  -  -  -  -   
          Console.Clear();
          Console.Write($"\n---------------------------------" +
                        $"\n Ausgabe  . . . . . : {output}" +
                        $"\n Länge  . . . . . . : {outputLength}" +
                        $"\n=================================");

          ///---------------------------------------------------------------
          ///    FILTER CALL & OUTPUT  
          /*
           */
          do
          {
            Console.Write("\n Filter . . . . . . . : " +
                          $"\n (0=Abbruch)           " +
                           "");
            inputFilter = Console.ReadLine();
            ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            string filteredOutput = FilterString(output, inputFilter);
            ///- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            Console.Write($"\n---------------------------------" +
                          $"\n gefilterte Ausgabe: {filteredOutput}" +
                          $"\n=================================" +
                          $"\n Eingabe + [Enter] : weiter filtern.. " +
                          $"\n ");
            output = filteredOutput;
          } while (inputFilter != "0");
          /*
           */
          ///-------------------------------------------------------------//
          Console.Clear();                                               ///
        }                                                                ///
      } while (run);                                                     ///
      Console.Write("\n [Enter] - zurück zur Auswahl.");                 ///
      Console.ReadLine();                                                ///                    
    }///------------------------------------------------------------------//

     ///--------------------------------------------------------------------
     ///    FILTER CODE
    /*
     * - - - - - - - - - - - - - - - - - - - - - - - -
     *   FILTER VERSION MIT String.IndexOf METHODE
     * - - - - - - - - - - - - - - - - - - - - - - - -

     string filteredOutput= "";
     foreach(char c in output)
     {
      if(inputFilter.IndexOf(c) == -1)
      {
        filteredOutput += c;
      }
     }
     return filteredOutput;

     * - - - - - - - - - - - - - - - - - - - - - - - -
     */
    static string FilterString(string output, string inputFilter)
    {
      char[] filteredOutputArray = new char[output.Length];
      int filteredOutputIndex = 0;

      for (int j = 0; j < output.Length; j++)
      {
        char currentChar = output[j];
        bool isFiltered = false;
        for (int i = 0; i < inputFilter.Length; i++)
        {
          if (currentChar == inputFilter[i])
          {
            isFiltered = true;
            break;
          }
        }
        if (!isFiltered)
        {
          filteredOutputArray[filteredOutputIndex] = currentChar;
          filteredOutputIndex++;
        }
      }
      return new string(filteredOutputArray, 0, filteredOutputIndex);
    }
    ///----------------------------------------------------------------------------------------
  }
}