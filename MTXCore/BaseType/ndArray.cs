using System;
using System.Collections.Generic;
using System.Text;

namespace MTXCore.BaseType
{
    public abstract class ndArray
    {
        protected ndArray(params int[] dim)
        {
            Create(new List<int>(dim));
        }
        protected ndArray(List<int> dim)
        {
            Create(dim);
        }

        private void Create(List<int> dim)
        {

        }
    }
}
