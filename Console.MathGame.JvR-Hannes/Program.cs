using MathGame.JvR_Hannes;
using System.Diagnostics;

var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = Helpers.GetName();

menu.ShowMenu(name, date);
