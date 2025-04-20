using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static DefaultProject.lesson_7.task_7._1.GameTicTacToe;
using static System.Net.Mime.MediaTypeNames;

namespace DefaultProject.lesson_7.task_7._1
{
    public static class GameTicTacToe
    {
        static string[,] _gameField;
        public class User
        {
            public string Name;
            public string Symbol;
            public bool CurentMove;
        };

        public static void Exec()
        {
            _gameField = new string[5, 5];
            Console.WriteLine("game Tic-Toc-Toe");

            start:

            var userFirst = new User();
            userFirst.Name = GetNameUser("first");
            userFirst.Symbol = "X";
            userFirst.CurentMove = true;
            var userSecond = new User();
            userSecond.Name = GetNameUser("second");
            userSecond.Symbol = "O";
            userSecond.CurentMove = false;

            Console.WriteLine($"play {userFirst.Name} VS {userSecond.Name}");

            CreateFieldGame();

            while (true)
            {
                var curentPlayer = GetCurentPlayer(userFirst, userSecond);

                var playerMove = GetPlayerMove(curentPlayer);

                ReplaceSymbolField(playerMove, curentPlayer);

                WrightGameField(5);

                if (IsWin())
                {
                    Console.WriteLine($"{curentPlayer.Name} win");
                    break;
                }
                if (IsDraw())
                {
                    Console.WriteLine("Draw");
                    break;
                }
            }

            Console.WriteLine("Do you want to play again? (yes/no): ");
            var answer = Console.ReadLine();
            if (answer?.ToLower() == "no")
            {
                Console.WriteLine("Thanks for playing!");
            }
            else if (answer?.ToLower() == "yes")
            {
                Console.WriteLine("OK");
                goto start;
            }
            else
            {
                Console.WriteLine("I guess bye?");
            }
        }

        private static bool IsDraw()
        {
            if (_gameField[0, 0] == "1" ||
                        _gameField[0, 2] == "2" ||
                        _gameField[0, 4] == "3" ||
                        _gameField[2, 0] == "4" ||
                        _gameField[2, 2] == "5" ||
                        _gameField[2, 4] == "6" ||
                        _gameField[4, 0] == "7" ||
                        _gameField[4, 2] == "8" ||
                        _gameField[4, 4] == "9")
            {
                return false;
            }

            return true;
        }

        private static bool IsWin()
        {
            for (int i = 0; i < 5; i += 2)
            {
                if (_gameField[i, 0] == _gameField[i, 2] && _gameField[i, 0] == _gameField[i, 4] && _gameField[i, 0] != "-")
                {
                    return true;
                }
            }

            for (int i = 0; i < 5; i += 2)
            {
                if (_gameField[0, i] == _gameField[2, i] && _gameField[0, i] == _gameField[4, i] && _gameField[0, i] != "-")
                {
                    return true;
                }
            }

            if (_gameField[0, 0] == _gameField[2, 2] && _gameField[0, 0] == _gameField[4, 4] && _gameField[0, 0] != "-")
            {
                return true;
            }
            if (_gameField[0, 4] == _gameField[2, 2] && _gameField[0, 4] == _gameField[4, 0] && _gameField[0, 4] != "-")
            {
                return true;
            }

            return false;
        }

        private static User GetCurentPlayer(User userFirst, User userSecond)
        {
            if (userFirst.CurentMove)
            {
                userFirst.CurentMove = false;
                userSecond.CurentMove = true;
                return userFirst;
            }
            else
            {
                userFirst.CurentMove = true;
                userSecond.CurentMove = false;
                return userSecond;
            }
        }

        private static void ReplaceSymbolField(string playerMove, User user)
        {
            switch (playerMove)
            {
                case "1":
                    _gameField[0, 0] = user.Symbol;
                    break;
                case "2":
                    _gameField[0, 2] = user.Symbol;
                    break;
                case "3":
                    _gameField[0, 4] = user.Symbol;
                    break;
                case "4":
                    _gameField[2, 0] = user.Symbol;
                    break;
                case "5":
                    _gameField[2, 2] = user.Symbol;
                    break;
                case "6":
                    _gameField[2, 4] = user.Symbol;
                    break;
                case "7":
                    _gameField[4, 0] = user.Symbol;
                    break;
                case "8":
                    _gameField[4, 2] = user.Symbol;
                    break;
                case "9":
                    _gameField[4, 4] = user.Symbol;
                    break;
            }
        }

        private static string GetPlayerMove(User userFirst)
        {
            var result = true;
            var choose = "";
            while (result)
            {
                Console.WriteLine($"play {userFirst.Name}, choose number on field");
                choose = Console.ReadLine();
                result = CurrectChoosrUser(choose);
                if (result)
                {
                    Console.WriteLine("Uncorect input");
                }
            }
            return choose;
        }

        private static bool CurrectChoosrUser(string choose)
        {
            var currectResult = int.TryParse(choose, out int result) && result >= 1 && result <= 9;
            if (!currectResult)
            {
                return !currectResult;
            }
            var symbolArray = GetSymbolForAdress(choose);
            if (symbolArray == "X" || symbolArray == "O")
            {
                return true;
            }
            return false;

        }

        private static string GetSymbolForAdress(string choose)
        {
            switch (choose)
            {
                case "1":
                    return _gameField[0, 0];
                case "2":
                    return _gameField[0, 2];
                case "3":
                    return _gameField[0, 4];
                case "4":
                    return _gameField[2, 0];
                case "5":
                    return _gameField[2, 2];
                case "6":
                    return _gameField[2, 4];
                case "7":
                    return _gameField[4, 0];
                case "8":
                    return _gameField[4, 2];
                case "9":
                    return _gameField[4, 4];
            }
            return null;
        }

        private static string GetNameUser(string numberUser)
        {
            Console.WriteLine($"you {numberUser} player, who you warrior?");
            var answerUser = Console.ReadLine();
            if (string.IsNullOrEmpty(answerUser))
            {
                answerUser = $"player {numberUser}";
            }
            return answerUser;
        }

        private static void CreateFieldGame()
        {
            var counterArray = 5;

            for (int x = 0; x < counterArray; x++)
            {
                for (int y = 0; y < counterArray; y++)
                {
                    var symbol = GetSymbol(x, y);
                    _gameField[x, y] = symbol;

                }
            }

            WrightGameField(counterArray);
        }

        private static void WrightGameField(int counterArray)
        {

            for (int x = 0; x < counterArray; x++)
            {
                var text = "";
                for (int y = 0; y < counterArray; y++)
                {
                    text += _gameField[x, y];

                }
                Console.WriteLine(text);
            }
        }

        private static string GetSymbol(int x, int y)
        {
            var adress = $"{x}{y}";
            switch (adress)
            {
                case "01":
                case "03":
                case "21":
                case "23":
                case "41":
                case "43":
                    return "|";
                case "00":
                    return "1";
                case "02":
                    return "2";
                case "04":
                    return "3";
                case "20":
                    return "4";
                case "22":
                    return "5";
                case "24":
                    return "6";
                case "40":
                    return "7";
                case "42":
                    return "8";
                case "44":
                    return "9";
                default: return "-";
            }
        }
    }
}
