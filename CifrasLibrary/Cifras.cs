using System;
using System.Diagnostics;
using System.IO;

namespace CifrasLibrary
{
    public class Cifras
    {
        public Cifras()
        { 
            StreamWriter logfileTxt = File.AppendText("Sphinx.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logfileTxt));
            Trace.AutoFlush = true;
            Trace.WriteLine(string.Format("Iniciado {0}", DateTime.Now.ToString()));
        }

        public string Decifrar(string text, int cifra)
        {
            string textoCifrado = "";

            switch (cifra)
            {
                case 1:
                    Console.WriteLine("Cifra ATBASH");
                    textoCifrado = CifraAtbash(text);
                    Trace.WriteLine(string.Format("Texto de entrada: {0}\nTexto Cifrado: {1}", text, textoCifrado));
                    break;
                case 2:
                    Console.WriteLine("Cifra ALBAM");
                    textoCifrado = CifraAlbam(text);
                    Trace.WriteLine(string.Format("Texto de entrada: {0}\nTexto Cifrado: {1}", text, textoCifrado));
                    break;
                case 3:
                    Console.WriteLine("Cifra ATBAH");
                    textoCifrado = CifraAtbah(text);
                    Trace.WriteLine(string.Format("Texto de entrada: {0}\nTexto Cifrado: {1}", text, textoCifrado));
                    break;
            }

            return textoCifrado;
        }

        //(char)(65) == A; (char)(90) == Z;
        //(char)(97) == a; (char)(122) == z;

        private string CifraAtbash(string text)
        {
            string textoCifrado = "";
            text = text.ToUpper();
            
            foreach (byte letter in text)
            {
                int count = 0;
                if (letter >= 65 && letter <= 90)
                {
                    for (int i = letter; i < 90; i++)
                    {
                        count++;
                    }
                    int textAux = (65 + count);
                    textoCifrado += (char)(textAux);
                }
                else
                {
                    textoCifrado += (char)(letter);
                }
            }
            return textoCifrado;
        }

        private string CifraAlbam(string text)
        {
            string textoCifrado = "";
            text = text.ToUpper();

            foreach (byte letter in text)
            {
           
                if (letter >= 65 && letter <= 77)
                {
                    int textAux = (letter + 13);
                    textoCifrado += (char)(textAux);
                }
                else if (letter >= 78 && letter <= 90)
                {
                    int textAux = (letter - 13);
                    textoCifrado += (char)(textAux);
                }
                else
                {
                    textoCifrado += (char)(letter);
                }
            }

            return textoCifrado;
        }

        private string CifraAtbah(string text)
        {
            string textoCifrado = "";
            text = text.ToUpper();
            
            foreach (byte letter in text)
            {
                int textAux;
                switch (letter)
                {
                    case 65:
                        textAux = (letter + 8);
                        textoCifrado += (char)(textAux);
                        break;
                    case 66:
                        textAux = (letter + 6);
                        textoCifrado += (char)(textAux);
                        break;
                    case 67:
                        textAux = (letter + 4);
                        textoCifrado += (char)(textAux);
                        break;
                    case 68:
                        textAux = (letter + 2);
                        textoCifrado += (char)(textAux);
                        break;
                    case 69:
                        textAux = (letter + 9);
                        textoCifrado += (char)(textAux);
                        break;
                    case 70:
                        textAux = (letter - 2);
                        textoCifrado += (char)(textAux);
                        break;
                    case 71:
                        textAux = (letter - 4);
                        textoCifrado += (char)(textAux);
                        break;
                    case 72:
                        textAux = (letter - 6);
                        textoCifrado += (char)(textAux);
                        break;
                    case 73:
                        textAux = (letter -8);
                        textoCifrado += (char)(textAux);
                        break;
                    case 74:
                        textAux = (letter + 8);
                        textoCifrado += (char)(textAux);
                        break;
                    case 75:
                        textAux = (letter + 6);
                        textoCifrado += (char)(textAux);
                        break;
                    case 76:
                        textAux = (letter + 4);
                        textoCifrado += (char)(textAux);
                        break;
                    case 77:
                        textAux = (letter + 2);
                        textoCifrado += (char)(textAux);
                        break;
                    case 78:
                        textAux = (letter - 9);
                        textoCifrado += (char)(textAux);
                        break;
                    case 79:
                        textAux = (letter - 2);
                        textoCifrado += (char)(textAux);
                        break;
                    case 80:
                        textAux = (letter - 4);
                        textoCifrado += (char)(textAux);
                        break;
                    case 81:
                        textAux = (letter - 6);
                        textoCifrado += (char)(textAux);
                        break;
                    case 82:
                        textAux = (letter - 8);
                        textoCifrado += (char)(textAux);
                        break;
                    case 83:
                        textAux = (letter + 7);
                        textoCifrado += (char)(textAux);
                        break;
                    case 84:
                        textAux = (letter + 5);
                        textoCifrado += (char)(textAux);
                        break;
                    case 85:
                        textAux = (letter + 3);
                        textoCifrado += (char)(textAux);
                        break;
                    case 86:
                        textAux = (letter + 1);
                        textoCifrado += (char)(textAux);
                        break;
                    case 87:
                        textAux = (letter - 1);
                        textoCifrado += (char)(textAux);
                        break;
                    case 88:
                        textAux = (letter - 3);
                        textoCifrado += (char)(textAux);
                        break;
                    case 89:
                        textAux = (letter - 5);
                        textoCifrado += (char)(textAux);
                        break;
                    case 90:
                        textAux = (letter - 7);
                        textoCifrado += (char)(textAux);
                        break;
                    default:
                        textoCifrado += (char)(letter);
                        break;
                }
            }
            return textoCifrado;
        }
    }   
}
