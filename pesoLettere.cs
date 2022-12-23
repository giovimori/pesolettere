using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {

        int PesoTot = 0;
        int Peso = 0;
        
        int dimensione = input.Length;

        for (int i = 0; i < dimensione; i++)
        {
            //lettere peso 1
            if(input[i]=='a') Peso = 1;
            if(input[i]=='A') Peso = 1;
            if(input[i]=='e') Peso = 1;
            if(input[i]=='E') Peso = 1;
            if(input[i]=='i') Peso = 1;
            if(input[i]=='I') Peso = 1;
            if(input[i]=='o') Peso = 1;
            if(input[i]=='O') Peso = 1;
            if(input[i]=='u') Peso = 1;
            if(input[i]=='U') Peso = 1;
            if(input[i]=='l') Peso = 1;
            if(input[i]=='L') Peso = 1;
            if(input[i]=='n') Peso = 1;
            if(input[i]=='N') Peso = 1;
            if(input[i]=='r') Peso = 1;
            if(input[i]=='R') Peso = 1;
            if(input[i]=='s') Peso = 1;
            if(input[i]=='S') Peso = 1;
            if(input[i]=='t') Peso = 1;
            if(input[i]=='T') Peso = 1;

            //lettere peso 2
            if(input[i]=='d') Peso = 2;
            if(input[i]=='D') Peso = 2;
            if(input[i]=='g') Peso = 2;
            if(input[i]=='G') Peso = 2;

            //lettere peso 3
            if(input[i]=='b') Peso = 3;
            if(input[i]=='B') Peso = 3;
            if(input[i]=='c') Peso = 3;
            if(input[i]=='C') Peso = 3;
            if(input[i]=='m') Peso = 3;
            if(input[i]=='M') Peso = 3;
            if(input[i]=='p') Peso = 3;
            if(input[i]=='P') Peso = 3;

            //lettere peso 4
            if(input[i]=='f') Peso = 4;
            if(input[i]=='F') Peso = 4;
            if(input[i]=='h') Peso = 4;
            if(input[i]=='H') Peso = 4;
            if(input[i]=='v') Peso = 4;
            if(input[i]=='V') Peso = 4;
            if(input[i]=='w') Peso = 4;
            if(input[i]=='W') Peso = 4;
            if(input[i]=='y') Peso = 4;
            if(input[i]=='Y') Peso = 4;

            //lettere peso 5
            if(input[i]=='k') Peso = 5;
            if(input[i]=='K') Peso = 5;

            //lettere peso 8
            if(input[i]=='j') Peso = 8;
            if(input[i]=='J') Peso = 8;
            if(input[i]=='x') Peso = 8;
            if(input[i]=='X') Peso = 8;

            //lettere peso 10
            if(input[i]=='q') Peso = 10;
            if(input[i]=='Q') Peso = 10;
            if(input[i]=='z') Peso = 10;
            if(input[i]=='Z') Peso = 10;

            PesoTot = PesoTot + Peso;

        }
        
        return PesoTot;
    }
   
}