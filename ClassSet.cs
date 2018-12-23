using System;
using System.Collections.Generic;
namespace lab3OneMoreTime
{
    public class ClassSet
    {


        public List<int> Summ(List<int> r1, List<int> r2)
        {
            int size1 = r1.Count;
            int size2 = r2.Count;
            List<int> r3 = new List<int>();



            if (size1 >= size2)
            {
                for (int i = 0; i < size1; i++)
                {
                    r3.Add(r1[i]);
                }
                for (int i = 0; i < size2; i++)
                {
                    int k = 0;
                    bool isIn = false;
                    while (k < r3.Count)
                    {
                        
                        if (r3[k] == r2[i])
                        {
                            isIn = true;
                        }
                        k++;
                    }
                    if (isIn == false)
                    {
                        r3.Add(r2[i]);
                    }

                }
            }
            else
            {
                for (int i = 0; i < size2; i++)
                {
                    r3.Add(r2[i]);
                }
                for (int i = 0; i < size1; i++)
                {
                    int k = 0;
                    bool isIn = false;
                    while (k < r3.Count)
                    {
                        if (r3[k] == r1[i])
                        {
                            isIn = true;
                        }
                        k++;
                    }
                    if (isIn == false)
                    {
                        r3.Add(r1[i]);
                    }

                }

               
            }
            r3.Sort();
            return r3;
        }

        public List<int> Peresech (List<int>r1, List<int>r2)
        {
            int size1 = r1.Count;
            int size2 = r2.Count;
            List<int> r3 = new List<int>();

                for(int i=0; i<size1; i++)
                {
                    bool isIn = false;
                    for (int j=0; j<size2; j++)
                    {

                        if (r2[j]==r1[i])
                        {
                            isIn = true;
                        }
                    }
                    if(isIn == true)
                    {
                        r3.Add(r1[i]);
                    }
                }

            r3.Sort();
            return r3;

        }
        public List<int> Substraction(List<int>r1, List<int>r2)
        {
            List<int> r3 = new List<int>();
            int size1 = r1.Count;
            int size2 = r2.Count;
            for(int i=0; i<size1; i++)
            {
                bool isIn = false;
                for ( int j=0; j<size2; j++)
                {
                    if (r2[j] == r1[i])
                    {
                        isIn = true;
                    }
                }
                if (isIn == false)
                {
                    r3.Add(r1[i]);
                }

            }
            return r3;
        }
        public bool Isin(List<int>r1, int r2)
        {
            bool answer = false;
            int size1 = r1.Count;
            for (int i=0; i<size1; i++)
            {
                if(r1[i]==r2)
                {
                    answer = true;
                  }

            }
            return answer; 
        }

    }
}
