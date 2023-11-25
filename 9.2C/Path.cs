using System;
namespace Iteration6

{
	public class Path:Game_Object
	{
		Location _l;
		bool _locked;

		public Path(string[] ids, string name, string desc, Location l) : base(ids, name, desc)
		{
			_l = l;
		}

		public Location Loc
		{
			get
			{
				return _l;
			}
		}
		public bool Locked
		{
			get
			{
				return _locked;
			}
			set
			{
				_locked = value;
			}
		}

        public override string FullDescription
		{
			get
			{
				return "At " + Name + "there is" + Loc.Name;
			}
		}
        public void Move_to_path(Path p)
        {
            _l = p.Loc;
        }
    }
}


