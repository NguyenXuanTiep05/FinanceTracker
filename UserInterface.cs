













namespace FinanceTracker
{
	public static class UserInterface
	{
		private static readonly string[] _mainMenuOpt = {"Option 1", "Option 2", "Option 3", "Option 4"};
		private readonly static int _selOption;
		static int Mod(int a, int b) => ((a % b) + b) % b;
		public static void DrawMainMenu(int selected)
		{
			Console.Clear();
			for (int i = 0; i < _mainMenuOpt.Length; i++)
			{
				string space = " ";
				if (i == Mod(selected, _mainMenuOpt.Length)){space = ">";}
				string option =space + _mainMenuOpt[i];
				Console.WriteLine(option);
			}
		}
	}
}















