using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            return  chickens*2 + (cows + pigs) * 4;
             
            throw new NotImplementedException();
        }
    }
}
