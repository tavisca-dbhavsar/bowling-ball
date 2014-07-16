using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
       
        int score=0;
        int i=0;
        int[] arr = new int[25];

        public void Roll(int pins)
        {
            //if (pins == 10 || (i % 2) == 0)
            if (pins == 10 )
            {
                arr[i] = pins;
                i++;
                arr[i] = 0;
                i++;
            }
            else
            {
                arr[i] = pins;
                i++;
            }

        }

        public int GetScore()
        {
           
            for (int j = 0; j < 20; j++)
            {
                if (arr[j] == 10)
                {
                    if (j % 2 == 0)
                    {
                        if ((arr[j + 2]) == 10)
                        {
                            score = score + arr[j] + arr[j + 2] + arr[j + 4];

                        }
                        else
                        {
                            score = score + arr[j] + arr[j + 2] + arr[j + 3];
                        }
                    }
                    else
                    {
                        score = score + arr[j] + arr[j + 1];
                    }

                }
                else if ((j % 2 == 0))
                {
                    if ((arr[j] + arr[j + 1]) == 10)
                    {
                        score = score + arr[j] + arr[j + 1] + arr[j + 2];
                        j++;
                    }

                    else
                    {
                        score = score + arr[j];
                    }
                }
                else
                {
                    score = score + arr[j];
                }
                //throw new NotImplementedException();
            }
            return score;
        }


       
    }
}
