using System;

namespace DelegateDemo
{
    class Program
    {
        /// <summary>
        /// 烹調方式 Delegate
        /// </summary>
        /// <param name="食材"></param>
        /// <returns>煮好的佳餚</returns>
        public delegate string HowToCook(string 食材);

        /// <summary>
        /// 媽媽煮
        /// </summary>
        /// <param name="食材"></param>
        /// <returns>煮好的佳餚</returns>
        public static string MaMaCook(string 食材)
        {
            Console.WriteLine($"先清理{食材}");
            Console.WriteLine("熱鍋後爆香");
            Console.WriteLine("快炒3分鐘");

            return $"一盤美味的{食材}料理";
        }

        /// <summary>
        /// 爸爸煮
        /// </summary>
        /// <param name="食材"></param>
        /// <returns>煮好的佳餚</returns>
        public static string PaPaCook(string 食材)
        {
            Console.WriteLine($"先清理{食材}");
            Console.WriteLine("發生火災");

            return $"一盤焦黑的{食材}料理";
        }

        /// <summary>
        /// 妹妹煮
        /// </summary>
        /// <param name="食材"></param>
        /// <returns>煮好的佳餚</returns>
        public static void SisterCook(string 食材)
        {
            Console.WriteLine($"我不會煮{食材}");
        }

        /// <summary>
        /// 阿嬤煮
        /// </summary>
        /// <param name="食材"></param>
        /// <returns>煮好的佳餚</returns>
        public static string GrandMaCook(string 食材)
        {
            Console.WriteLine($"阿嬤覺得不夠鹹，加一些調味料在{食材}料理上");
            return $"一盤重口味的{食材}料理";
        }

        /// <summary>
        /// 得到煮好的食物
        /// </summary>
        /// <param name="人數"></param>
        /// <param name="烹調方式"></param>
        public static void GetFood(int 人數, HowToCook 烹調方式)
        {
            var food = 烹調方式("鮮魚");
            Console.WriteLine($"{food}給{人數}個人吃");
        }

        private static void Main(string[] args)
        {
            //// 產生委派的參考
            //HowToCook howToCook;

            //// 將 媽媽煮 指派給 howToCook
            //howToCook = MaMaCook;

            //string MaMaCookResult = MaMaCook("鮮魚");
            //string HowToCookResult = howToCook("鮮魚");

            //Console.WriteLine($"MaMaCookResult : {MaMaCookResult}");
            //// Output : MaMaCookResult : 一盤美味的鮮魚料理

            //Console.WriteLine($"HowToCookResult : {HowToCookResult}");
            //// Output : HowToCookResult : 一盤美味的鮮魚料理

            HowToCook howToCook;
            howToCook = MaMaCook;
            howToCook += GrandMaCook;

            GetFood(4, howToCook);
            Console.Read();
        }
    }
}