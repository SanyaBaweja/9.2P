using System;
using System.IO;
using Iteration6;
namespace Iteration6
{
    public class Location : Game_Object, IHaveInventory

    {
        Inventory _inv = new Inventory();
        List<Path> _path = new List<Path>();

        public Location(string name, string desc) : base(new string[] { "room" }, name, desc)
        {

        }
        public Game_Object Locate(string id)
        {

            if (AreYou(id) == true)
            {
                return this;
            }

            else if (_path.Count >= 1)
            {
                foreach (Path pt in _path)
                {
                    if (pt.AreYou(id))
                    {
                        return pt;
                    }
                }
                return null;
            }
            else
            {
                return _inv.Fetch(id);
            }
        }
        public override string FullDescription
        {
            get
            {
                return ("You are in the " + Name + "\n" + base.FullDescription + "\n" + ListofPaths + ".\nIn this room you can see:\n" + _inv.ItemList);
            }
        }
        public Inventory Inv
        {
            get
            {
                return _inv;
            }
        }
        public void AddPathInList(Path p)
        {
            _path.Add(p);
        }

        public string ListofPaths
        {
            get
            {
                if (_path.Count == 0)
                {
                    return "There are no exits.";
                }
                else
                {
                    string multiplepaths = "";
                    bool isFirst = true;
                    foreach (Path path in _path)
                    {
                        if (!isFirst)
                        {
                            multiplepaths += ", ";
                        }
                        multiplepaths += path.Name;
                        isFirst = false;
                    }
                    return "There are exits to the " + multiplepaths;
                }
            }
        }
    }
}
