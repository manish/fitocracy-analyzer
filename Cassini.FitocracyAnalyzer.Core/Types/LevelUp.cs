using System;
using System.Collections.Generic;

namespace Cassini.FitocracyAnalyzer.Core
{
	public class LevelUp
	{
		public int Level { get; private set; }
		public DateTime Date { get; private set; }

		public IReadOnlyList<string> Props { get; private set;}

		public LevelUp (int level, DateTime date, List<string> props)
		{
			Level = level;
			Date = date;
			Props = props.AsReadOnly ();
		}
	}

	public class LevelUpEventArgs : EventArgs
	{
		public LevelUp LevelUp { get; private set; }

		public LevelUpEventArgs (LevelUp levelUp)
		{
			LevelUp = levelUp;
		}
	}
}

