using System;

namespace ConsoleApp3
{

    //class enemy
    //{

    //    static void main(string[] args)
    //    {

    //    }
    //}
    class Program
    {
        public static int str = 1, vit = 1, agi = 1, luck = 1, dex = 1, str1 = 1, vit1 = 1, agi1 = 1, luck1 = 1, dex1 = 1, x = 10, exp1, add1, lvluo, battle;
        public string name;
        public int HP;
        public int exp;
        public int add;
        public int STR;
        public int Battle;
        public int[] EXP;



        static void Main(string[] args)

        {


            //start game
            Console.WriteLine("Путник, привет давай устроим тебе испытание");

            int[] lvl = new int[5] { 50, 60, 150, 200, 250 };
            exp1 = 0;


            if
     (exp1 > -1)
            {
                lvluo = LVLup(lvluo);
                Console.WriteLine(lvluo);
            }

            static int Battle(int battle)
            {
                Console.WriteLine("ты наткнулся на монстра");
                Program person = new Program();
                person.HP = 10;
                int[] lvl = new int[5] { 50, 60, 150, 200, 250 };
                Program skelet = new Program();
                skelet.HP = 10;
                skelet.STR = 1;
                skelet.exp = 30;

                Console.WriteLine(skelet.HP);
                for (; skelet.HP > 0; skelet.HP -= 0)
                {
                    Random rnd = new Random();
                    int value = rnd.Next(1, 100);
                    Console.WriteLine("моя точность");
                    Console.WriteLine(value);
                    if (value > 50)
                    {
                        skelet.HP -= str;
                        Console.WriteLine("удача ты обошел врага и дал ему под зад");
                        Console.WriteLine("у врага осталось ровно");
                        Console.WriteLine(skelet.HP);
                    }
                    else if
                        (value < 50)
                    {

                        Console.WriteLine("промах, возможно ты попадешь в следующий раз");
                        Console.WriteLine("у врага осталось ровно");
                        Console.WriteLine(skelet.HP);

                    }
                    else if (skelet.HP <= 0)
                    {
                        break;
                    }

                    if (person.HP > 0)
                    {
                        Random rnd2 = new Random();
                        int value2 = rnd2.Next(1, 100);
                        Console.WriteLine("проверка точности врага");
                        Console.WriteLine(value);
                        if (value > 50)
                        {
                            person.HP -= skelet.STR;
                            Console.WriteLine("удача повернулась к тебе спиной... собирай свои потраха с пола");
                            Console.WriteLine("у меня осталось");
                            Console.WriteLine(person.HP);

                            if (person.HP <= 0)
                            {
                                Console.WriteLine("Ты помер... гроб тебе не закажем");
                                break;
                            }
                        }
                        else if
                            (value < 50)
                        {

                            Console.WriteLine("Враг промазал... да ты везунчик");
                            Console.WriteLine("у меня осталось");
                            Console.WriteLine(person.HP);

                        };


                    }
                }
                exp1 += 30;
                return battle;
            }


            int p = 0;
            Console.WriteLine(lvl[p]);
            Console.WriteLine(exp1);
            for (; lvl[p] < exp1; x += 10)
            {

                lvluo = LVLup(lvluo);
                Console.WriteLine(lvluo);

            }

            for (; lvl[p] > exp1;)
            {
                battle = Battle(battle);
                Console.WriteLine(battle);

            }
            Console.ReadLine();
        }
        // end game




        static int LVLup(int lvluo)
        {
            string LVLUP = "у тебя 10 очков распредели их";
            Console.WriteLine(LVLUP);

            string alert1 = String.Empty, alert2 = String.Empty, alert3 = String.Empty, alert4 = String.Empty, alert5 = String.Empty;

            alert1 = "сила";
            alert2 = "живучесть";
            alert3 = "ловкость";
            alert4 = "удача";
            alert5 = "точность";
            for (; x > 0; x -= 0)
            {

                var values = (alert1, "=", str, alert2, "=", vit, alert3, "=", agi, alert4, "=", luck, alert5, "=", dex);
                Console.WriteLine(values);

                Console.WriteLine("к какоЙ характеристике хотите добавить очки?");

                Console.WriteLine("введите характеристику");
                string command = Console.ReadLine();
                command = command.ToLower().Trim().Trim();


                if (command == "сила")
                {
                    str = strLVLup(str);

                }

                if (command == "живучесть")
                {
                    vit = vitLVLup(vit);

                }

                if (command == "ловкость")
                {
                    agi = agiLVLup(agi);

                }

                if (command == "удача")
                {
                    luck = luckLVLup(luck);

                }

                if (command == "точность")
                {
                    dex = dexLVLup(dex);

                }

                Console.WriteLine("проверить характеристики?");
                command = Console.ReadLine();
                command = command.ToLower().Trim().Trim();
                if
                    (command == "да")
                {
                    Console.WriteLine(values);
                    if (x > 0)
                    {
                        Console.WriteLine(lvluo);
                    }

                };

                if
                    (command == "нет")
                {
                    if (x > 0)
                    {
                        Console.WriteLine(lvluo);
                    }

                }
            }

            return lvluo;
        }
        static int strLVLup(int str)
        {

            Console.WriteLine("сколько добавить силы?");

            int add = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {

                if (x > 0)

                {
                    x -= add;
                    Console.WriteLine(x);
                    str1 = str;
                    str1 += add;
                    str = str1;
                    Console.WriteLine("теперь у вас сила равна", str);
                    Console.WriteLine(str);
                    Console.WriteLine("у вас осталось ровно очков");
                    Console.WriteLine(x);
                    return str1;
                }
                else
                    Console.WriteLine("мало очков");
                return str1;
            }
            else
                Console.WriteLine("мало очков");
            return str1;
        }

        static int vitLVLup(int vit)
        {
            Console.WriteLine("сколько добавить живучести?");

            int add = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {

                if (x > 0)
                {
                    x -= add;
                    Console.WriteLine(x);
                    vit1 = vit;
                    vit1 += add;
                    vit = vit1;
                    Console.WriteLine("теперь у вас живучесть");
                    Console.WriteLine(vit);
                    Console.WriteLine("у вас осталось ровно очков");
                    Console.WriteLine(x);
                    return vit1;
                }
                else
                    Console.WriteLine("мало очков");
                return vit1;
            }
            else
                Console.WriteLine("мало очков");
            return vit1;
        }

        static int agiLVLup(int agi)
        {
            Console.WriteLine("сколько добавить ловкости?");

            int add = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {

                if (x > 0)
                {
                    x -= add;
                    Console.WriteLine(x);
                    agi1 = agi;
                    agi1 += add;
                    agi = agi1;
                    Console.WriteLine("теперь у вас ловкость");
                    Console.WriteLine(agi);
                    Console.WriteLine("у вас осталось ровно очков");
                    Console.WriteLine(x);
                    return agi1;
                }
                else
                    Console.WriteLine("мало очков");
                return agi;
            }
            else
                Console.WriteLine("мало очков");
            return agi;
        }

        static int luckLVLup(int luck)
        {
            Console.WriteLine("сколько добавить удачи?");

            int add = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {

                if (x > 0)
                {
                    x -= add;
                    Console.WriteLine(x);
                    luck1 = luck;
                    luck1 += add;
                    luck = luck1;
                    Console.WriteLine("теперь у вас удачи");
                    Console.WriteLine(luck);
                    Console.WriteLine("у вас осталось ровно очков");
                    Console.WriteLine(x);
                    return luck1;
                }
                else
                    Console.WriteLine("мало очков");
                return luck;
            }
            else
                Console.WriteLine("мало очков");
            return luck;
        }

        static int dexLVLup(int dex)
        {
            Console.WriteLine("сколько добавить точности?");

            int add = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {

                if (x > 0)
                {
                    x -= add;
                    Console.WriteLine(x);
                    dex1 = dex;
                    dex1 += add;
                    dex = dex1;
                    Console.WriteLine("теперь у вас точность");
                    Console.WriteLine(dex);
                    Console.WriteLine("у вас осталось ровно очков");
                    Console.WriteLine(x);
                    return dex1;
                }
                else
                    Console.WriteLine("мало очков");
                return dex;
            }
            else
                Console.WriteLine("мало очков");
            return dex;
        }


    }
}


