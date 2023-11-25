using System;
namespace Iteration6
{
    public interface IHaveInventory
    {
        Game_Object Locate(string id);


        public string Name
        {
            get;
        }
    }
}

