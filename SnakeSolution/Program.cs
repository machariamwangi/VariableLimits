using System;

namespace SnakeSolution
{
    class Program

    {

        static void Main(string[] args)

        {

            string strInput = "A B C D E F G H I J K L M N O P Q R S T U V W X Y";

            string[] strArray = strInput.Split(' ');

            int nDim = (int)Math.Sqrt(strArray.GetLength(0));



            string[,] arrCh;

            arrCh = new string[nDim, nDim];



            int r = 0, c = 0;//row,col

            int r1 = 0, c1 = 0; //start

            int r2 = nDim - 1, c2 = nDim - 1;//end



            int i = 0, nLen = nDim * nDim;



            //fill array

            char chDir = 'r'; //right

            do

            {

                arrCh[r, c] = strArray[i];

                //Console.WriteLine($"[{r},{c}]={strLetters[i]}");

                i++;

                switch (chDir)

                {

                    case 'r':

                        if (c == c2)

                        {

                            chDir = 'd'; //down

                            r1++;

                            r++;

                        }

                        else

                        {

                            c++;

                        }

                        break;

                    case 'd':

                        if (r == r2)

                        {

                            chDir = 'l';//left

                            c2--;

                            c--;

                        }

                        else

                        {

                            r++;

                        }

                        break;

                    case 'l':

                        if (c == c1)

                        {

                            chDir = 'u';//up

                            r2--;

                            r--;

                        }

                        else

                        {

                            c--;

                        }

                        break;

                    case 'u':

                        if (r == r1)

                        {

                            chDir = 'r';//right

                            c1++;

                            c++;

                        }

                        else

                        {

                            r--;

                        }

                        break;

                    default:

                        break;

                }



            } while (i < nLen);



            //show array

            for (int o1 = 0; o1 < nDim; o1++)

            {

                for (int o2 = 0; o2 < nDim; o2++)

                {

                    Console.Write($"{arrCh[o1, o2]} ");

                }

                Console.Write("\r\n");

            }



            Console.WriteLine();

            //final output

            r = 0;

            c = 0;//row,col

            r1 = 0;

            c1 = 0; //start

            r2 = nDim - 1;

            c2 = nDim - 1;//end

            i = 0;

            chDir = 'r'; //right

            do

            {

                Console.Write($"{arrCh[r, c]} ");

                i++;

                switch (chDir)

                {

                    case 'r':

                        if (c == c2)

                        {

                            chDir = 'd'; //down

                            r1++;

                            r++;

                        }

                        else

                        {

                            c++;

                        }

                        break;

                    case 'd':

                        if (r == r2)

                        {

                            chDir = 'l';//left

                            c2--;

                            c--;

                        }

                        else

                        {

                            r++;

                        }

                        break;

                    case 'l':

                        if (c == c1)

                        {

                            chDir = 'u';//up

                            r2--;

                            r--;

                        }

                        else

                        {

                            c--;

                        }

                        break;

                    case 'u':

                        if (r == r1)

                        {

                            chDir = 'r';//right

                            c1++;

                            c++;

                        }

                        else

                        {

                            r--;

                        }

                        break;

                    default:

                        break;

                }

            } while (i < nLen);

        }

    }
}
