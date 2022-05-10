using System.Collections.Generic;
using System.Linq;
using System;

namespace ModalApplication
{
	public interface IAppModeFactory
	{
		IAppMode Create(int modeId);
		IAppMode Create(string modeName);

		int ModeIdForName( string name);

		string ModeName(int id);
	}

	public abstract class AppModeFactory : IAppModeFactory
	{
		protected Dictionary<int, Func<IAppMode>> AppModeCtors;
		protected Dictionary<int, string> AppModeNames;

        public IAppMode Create(int modeId) => AppModeCtors[modeId]();
        public IAppMode Create(string modeName) => AppModeCtors[ModeIdForName(modeName)]();

		public int ModeIdForName(string name) => AppModeNames.First(x => x.Value == name).Key;
		public string ModeName(int id) => AppModeNames[id];

	};
}

