













namespace FinanceTracker
{
	public static class UserInterface
	{
		private static readonly string[] _mainMenuOpt = ["Overview", "Add record"];
		private static int _selOption = 0;
        private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".FinanceData", "data.txt");



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
                    Overview();
				break;
				case 1:
                    AddRecord();
				break;
			}
		}



        private static void AddRecord(){
            Console.WriteLine("Write Expense:\t{value / note}");
            Console.CursorVisible = true;
            Console.WriteLine(filePath);
            string? record = Console.ReadLine();
            Console.CursorVisible = false;
            if (record == ""){return;}

            string[] data = record.Split("/");
            double val;
            string value = double.TryParse(data[0],out val) ? data[0] : "";
            string note = data.Length > 1 ? data[1] : "";
            if (value == ""){return;}
            string output = $"{DateTime.Now.ToString()} | {value} | {note}";

            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
            File.AppendAllText(filePath,output + Environment.NewLine);
        }

        private static void Overview(){
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
            string[] lines = File.ReadAllLines(filePath);           
            foreach(string line in lines){
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }

	}

}















