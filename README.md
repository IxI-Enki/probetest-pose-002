$$\color{seagreen}{ 
\Huge Probetest 
}$$

$$\color{lightgreen}{ 
\large 002
}$$

$$\color{seagreen}{
\Huge Strings \space und \space Arrays
}$$ 

<!-- ---------------------------------------------|-------------------------------------------- -->
$\color{white}{
\small Angabe: 
}$
📎 [ **PDF** ](https://github.com/IxI-Enki/probetest-pose-002/blob/main/work-directory/Test01.pdf) 

$$\color{green}{
\tiny ---------------------------------------------------------------------
}$$

# 🧮 **Aufgabenstellungen:**  
  - ### **1.** *Verschlüsselung* ***ROT13***    
  - ### **2.** *Strings filtern* ***Filtered Substring***

$$\color{lightgreen}{
\tiny ---------------------------------------------------------------------
}$$

$\color{seagreen}{
\large Hinweis \space und \space Ablauf:
}$

$\color{yellow}{
\huge Tipp: \qquad
}
\color{orange}{
\normalsize \space \space Es \space dürfen \space keine \space String \space Standard-Methoden \space verwendet \space werden }
\color{red}{
\space \qquad \Large (außer \space Length)!!
}$

---

# ***1.<sub>)</sub>***    
$\color{yellowgreen}{
\huge ROT \space 13:
}$
  - Ihr Programm realisiert einen einfachen Verschlüsselungsalgorithmus für Texte.  
  - Dabei werden nur die ASCII-Klein- und Großbuchstaben durch jenen Buchstaben ersetzt, der **13 Positionen entfernt** ist.  
  - Alle anderen Zeichen (Ziffern, Sonderzeichen, Umlaute, …) bleiben unverändert.  
<!-- ---------------------------------------------|-------------------------------------------- -->  
 #### 
   - ***zum Beispiel:***  
     > ↳ *Aus a wird n -* **ASCII** *Code* **97** *wird zu* **110**  
     > ↳ *Aus m wird z -* **ASCII** *Code* **109** *wird zu* **122**  
     > ↳ *Aus n wird a -* **ASCII** *Code* **110** *wird zu* **97**  
     > ↳ *Aus z wird m -* **ASCII** *Code* **122** *wird zu* **109**  
     > ↳ *Aus E wird R -* **ASCII** *Code* **69** *wird zu* **82**  
     > ↳ *Aus W wird J -* **ASCII** *Code* **87** *wird zu* **74**  
     > ↳ *8 bleibt 8*  
     > ↳ *ü bleibt ü*

$$\color{yellowgreen}{
\tiny ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  
*Das Programm nimmt Texteingaben vom Benutzer entgegen, verschlüsselt diese und gibt den verschlüsselten Text aus.*  
*Danach entschlüsselt das Programm den verschlüsselten Text (mit dem gleichen Code wie zum Verschlüsseln) und gibt hoffentlich wieder den Ursprungstext aus.*   
*In diesem Fall kommt es natürlich zu Codeverdoppelung.*  
*Das ist bei dieser Aufgabe ausnahmsweise OK.*  
*Das wird solange wiederholt, bis der Benutzer eine leere Eingabe (einfach Enter drückt) macht.*  
*Die Ausgabe hat sich an dem folgenden Beispieldialog zu halten.* 
<!-- ---------------------------------------------|-------------------------------------------- -->  
$$\color{yellow}{
\tiny ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  
### 🖥 **Beispiel**:  
   
   | *Ausgabe:* |  
   | :-------------------------------: |  
   |  ![**Beispiele 📎**](https://github.com/IxI-Enki/probetest-pose-002/assets/138018029/71b1a1cc-2310-4393-af02-dd10e48a7795) |  
<!-- ---------------------------------------------|-------------------------------------------- -->  

 ---
 
 # ***2.<sub>)</sub>***    
$\color{yellowgreen}{
\huge Filtered \space Substring:
}$
      
- Schreiben Sie ein Programm welches aus einem gegebenen String einen Substring erzeugt.  
- Um den Substring zu definieren, muss dessen Startindex im ursprünglichen Eingabetext und die gewünschte Länge des Substrings angegeben werden.  
<!-- ---------------------------------------------|-------------------------------------------- -->  
 #### 
   - ***Randbedingungen:***  
     - ↳ *Ist der Startindex kleiner als 0 wird der Startindex automatisch auf 0 gesetzt.*  
     - ↳ *Ist der Startindex größer als der Eingabestring, dann ist der Substring ein leerer String (""), unabhängig von der eingegebenen Substringlänge.*  
     - ↳ *Überschreitet die angegebene Länge ab dem Startindex die Gesamtlänge des Eingabestrings, so wird die Länge automatisch so gekürzt, sodass der Substring beim letzten Zeichen des Eingabestrings endet.*
<!-- ---------------------------------------------|-------------------------------------------- -->  
 #### 
   - ***Beispiel:***  
     > ↳ Eingabestring: "Hallo"  
     > ↳ Startindex: 3  
     > ↳ Länge: 5  
     > ↳ Die Länge wird automatisch auf 2 begrenzt, da ab Index 3 nur noch 2 Buchstaben ("lo") im Eingabestring vorhanden sind.
     >     Somit wird ein Laufzeitfehler (System.OutOfRangeException) vermieden.

$$\color{yellow}{
\tiny ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  
   - ***Zusatz-Feature:***
     - Der Benutzer kann noch Zeichen angeben, die er aus dem extrahierten Substring rausfiltern will.   
     - Es wird zwischen Groß- und Kleinschreibung unterschieden ('a' ist ungleich 'A').  
     - Die Eingabe wird beendet in dem der Benutzer einen leeren String eingibt (nur die Enter-Taste drückt).  
<!-- ---------------------------------------------|-------------------------------------------- -->  
$\color{yellow}{
\huge Tipp: \qquad
}
\color{orange}{ \Huge Implementieren \space Sie \space zuerst \space die \space einfache \space Substring \space Funktion. 
}$

$\color{orange}{
\small Wenn \space diese \space funktioniert, 
\normalsize dann \space erweitern \space Sie \space Ihr \space Programm 
\normalsize um \space die \space Möglichkeit \space den \space Substring \space zu \space filtern
}
\color{red}{
\large \quad (Zusatz-Feature).
}$

<!-- ---------------------------------------------|-------------------------------------------- -->  

$$\color{orange}{
\small ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  
### 🖥 **Beispiele**:  
   
   | Eingabestring:  \| Startindex  \| Länge  \| Filterzeichen  \| Ergebnis |  
   | :-------------------------------: |  
   |  ![**Beispiele 📎**](https://github.com/IxI-Enki/probetest-pose-002/assets/138018029/2071b35c-ae63-44c8-b919-15e90fba6792) |  
   
<!-- ---------------------------------------------|-------------------------------------------- -->  

$$\color{red}{
\small ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  
 
   | *Beispielausgaben*: |  
   | :-------------------------------: |  
   |  ![**Beispielausgaben 📎**](https://github.com/IxI-Enki/probetest-pose-002/assets/138018029/705f247d-4008-4b39-8d42-c42c6ec13c72) |  

<!-- ---------------------------------------------|-------------------------------------------- -->  

$$\color{yellow}{
\tiny ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  

$$\color{yellowgreen}{
\Huge SPOILER \quad \large SPOILER \quad \normalsize SPOILER \quad \small SPOILER \quad \tiny SPOILER \quad
}$$

---

 - → [*Lösung*](https://github.com/IxI-Enki/probetest-pose-002/blob/main/work-directory/Beispiel_1.cs)

  
$$\color{yellowgreen}{
\tiny ---------------------------------------------------------------------
}$$
<!-- ---------------------------------------------|-------------------------------------------- -->  
### 🖥 **Ausgabe**: 
   |            *meine Ausgabe:* |
   | :------------------------------- |
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/probetest-pose-002/assets/138018029/c27e4de3-c85e-4f87-b85d-0fd19e28edf7) |
<!-- ---------------------------------------------|-------------------------------------------- -->  
$$\color{green}{
\tiny ---------------------------------------------------------------------
}$$

<!-- ---------------------------------------------|-------------------------------------------- -->  
## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>

```c#
﻿namespace StringsArrays
{
  internal class Program
  {
    static void Main()
    {
     const int ROT13 = 13;

      Console.WriteLine("\n\n Text eingeben: \n\n  ");
      string input = "";
      input = Console.ReadLine();
      int length = input.Length;
      string encryptThis = "";
      bool indicator = false;

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
          Console.Write($"\n Zeichen: an Stelle {(int)(i)}: {(char)input[i]}" +
                        $" -> wird {((indicator == true) ? "" : "nicht")} {((j == 0) ? "ver" : "ent")}schlüsselt." +
          //            $"\n -> neuer Zwischenspeicher: {encryptThis.PadLeft(6)}" +
                         "");
        }
        Console.Write($"\n neuer Text: {encryptThis.PadLeft(6)}");
        input = encryptThis;
        encryptThis = "";
        Console.Write($"\n ...entschlüssel{((j == 0) ? "n..." : "t !")}" +
                       "\n ... Eingabetaste drücken ...");
        Console.ReadLine();
        }
      }
   }
}
```

<!-- ---------------------------------------------|-------------------------------------------- -->
$$\color{grey}{
\tiny ---------------------------------------------------------------------
}$$

- #### ROT13:

```c#
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
```
<!-- ---------------------------------------------|-------------------------------------------- -->
$$\color{grey}{
\tiny ---------------------------------------------------------------------
}$$

- #### ASCII Tabelle ausgeben *( - unnötiger Test)*:

```c#

        // UNNÖTIGER TEST:
        /* 
         * 
         * 
         * 
         char[] encodeThis = new char[255];
         Console.Write("\nASCII TABELLE:" +
           "\n--------------------------------" +
           "\n");
         for (int i = 0; i < encodeThis.Length; i++)
         {
           encodeThis[i] = (char)('A' + i);
           Console.Write($" Symbol: {(char)encodeThis[i]} num: {i.ToString("0").PadLeft(4)}   |");
           if (i % 3 == 0) { Console.WriteLine(); }
         } 
        *
        *
        *
        */
```

</details>
