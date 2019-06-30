using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorPass
{
    public class Generator_Password
    {

        private static string RL(string letra)
        {
            Random r = new Random();
            string a = "", b = "", c = "", letra1 = "", contraseña;
            int nro = 0;

            //-------------------------primera parte--------------------------------
            nro = r.Next(1, 10);
            //a
            switch (nro)
            {
                case 1:
                    a = "E";
                    break;
                case 2:
                    a = "R";
                    break;
                case 3:
                    a = "S";
                    break;
                case 4:
                    a = "Y";
                    break;
                case 5:
                    a = "a";
                    break;
                case 6:
                    a = "r";
                    break;
                case 7:
                    a = "g";
                    break;
                case 8:
                    a = "f";
                    break;
                case 9:
                    a = "y";
                    break;
                case 10:
                    a = "q";
                    break;
            }

            nro = r.Next(1, 4);
            //b
            switch (nro)
            {
                case 1:
                    b = "L";
                    break;
                case 2:
                    b = "S";
                    break;
                case 3:
                    b = "B";
                    break;
                case 4:
                    b = "D";
                    break;
            }

            nro = r.Next(1, 10);
            //c
            switch (nro)
            {
                case 1:
                    c = "Y";
                    break;
                case 2:
                    c = "P";
                    break;
                case 3:
                    c = "M";
                    break;
                case 4:
                    c = "N";
                    break;
                case 5:
                    c = "b";
                    break;
                case 6:
                    c = "y";
                    break;
                case 7:
                    c = "z";
                    break;
                case 8:
                    c = "q";
                    break;
                case 9:
                    c = "f";
                    break;
                case 10:
                    c = "n";
                    break;
            }

            if (a == b)
            {
                b = "2";
                a = "3";
            }
            else if (a == c)
            {
                c = "5";
                a = "2";
            }
            else if (b == c)
            {
                c = "7";
                b = "8";
            }

            letra = a + b + c;


            //------------------------------------segunda parte------------------------------------

            nro = r.Next(1, 10);
            //a
            switch (nro)
            {
                case 1:
                    a = "E";
                    break;
                case 2:
                    a = "R";
                    break;
                case 3:
                    a = "S";
                    break;
                case 4:
                    a = "Y";
                    break;
                case 5:
                    a = "a";
                    break;
                case 6:
                    a = "r";
                    break;
                case 7:
                    a = "g";
                    break;
                case 8:
                    a = "f";
                    break;
                case 9:
                    a = "y";
                    break;
                case 10:
                    a = "q";
                    break;
            }

            nro = r.Next(1, 4);
            //b
            switch (nro)
            {
                case 1:
                    b = "L";
                    break;
                case 2:
                    b = "S";
                    break;
                case 3:
                    b = "B";
                    break;
                case 4:
                    b = "D";
                    break;
            }

            nro = r.Next(1, 10);
            //c
            switch (nro)
            {
                case 1:
                    c = "Y";
                    break;
                case 2:
                    c = "P";
                    break;
                case 3:
                    c = "M";
                    break;
                case 4:
                    c = "N";
                    break;
                case 5:
                    c = "b";
                    break;
                case 6:
                    c = "y";
                    break;
                case 7:
                    c = "z";
                    break;
                case 8:
                    c = "q";
                    break;
                case 9:
                    c = "f";
                    break;
                case 10:
                    c = "n";
                    break;
            }

            if (a == b)
            {
                b = "5";
                a = "6";
            }
            else if (a == c)
            {
                c = "3";
                a = "4";
            }
            else if (b == c)
            {
                c = "0";
                b = "2";
            }

            letra1 = a + b + c;
            contraseña = letra + letra1;
            return contraseña;

        }

        private static char LR(char l)
        {
            Random r = new Random();
            char a = 'a';
            int nro = 0;
            nro = r.Next(1, 5);
            //a
            switch (nro)
            {
                case 1:
                    a = 'A';
                    break;
                case 2:
                    a = 'R';
                    break;
                case 3:
                    a = 'Z';
                    break;
                case 4:
                    a = 'Y';
                    break;
                case 5:
                    a = 'S';
                    break;
            }
            return a;
        }

        public string GeneratePassword(string a)
        {
            string contraseña = "", g = "";
            contraseña = RL(contraseña);

            Byte[] encrip = System.Text.Encoding.Unicode.GetBytes(contraseña);


            try
            {
                char i = 'i';
                i = LR(i);
                string[] corte = Convert.ToBase64String(encrip).Split(i);
                g = corte[0] + contraseña + corte[1] + "==";
                //Console.Write(frase);
                //Console.Write("\nContraseña Completada con Exito");
            }
            catch
            {
                g = Convert.ToBase64String(encrip) + contraseña + "==";
                //Console.Write("\nContraseña Completada");
            }
            return g;
        }
    }
}
