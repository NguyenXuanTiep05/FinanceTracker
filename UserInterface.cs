













namespace FinanceTracker
{
	public static class UserInterface
	{
		private static readonly string[] _mainMenuOpt = ["Overview", "Add record"];
		private static int _selOption = 0;
		static int Mod(int a, int b) => ((a % b) + b) % b;
		public static void DrawMainMenu(int selected)
		{
			Console.Clear();
			for (int i = 0; i < _mainMenuOpt.Length; i++)
			{
				string space = " ";
				_selOption = Mod(selected, _mainMenuOpt.Length);
				if (i == _selOption){space = ">";}
				string option =space + _mainMenuOpt[i];
				Console.WriteLine(option);
			}
		}

		public static void HandleUI()
		{
			Console.Clear();
			switch (_selOption)
			{
				case 0:
					Console.WriteLine("Overview");
				break;
				case 1:
					Console.WriteLine("Add");
				break;
			}
			Console.ReadKey();
		}
	}
}















