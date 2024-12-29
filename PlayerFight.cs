using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
    partial class Player
    {
        string V = "X-090892";
        int debuffCount = 0;
        int enemyDef;

        public void PlayerFight(Enemy enemy)
        {
            bool turn = true;
            float damage;
            enemyDef = enemy.Def;
            Title title = new Title();
            int maxhp = enemy.HP;
            Item[] items = new Item[8];
            int count = 0;

            while (HP > 0 && enemy.HP > 0)
            {
                turn = true;


                while (turn)
                {
                    Console.SetCursorPosition(0, 0);
                    for (int i = 0; i < Console.BufferWidth; i++)
                    {
                        Console.Write(' ');
                    }

                    Console.SetCursorPosition(0, 1);

                    for (int i = 0; i < Console.BufferWidth; i++)
                    {
                        Console.Write(' ');
                    }

                    Console.SetCursorPosition(70, 0);
                    Console.Write($"{enemy.Name}");
                    Console.SetCursorPosition(68, 1);
                    Console.Write($"((( {enemy.HP} / {maxhp} )))");


                    back.Textbox();
                    Console.SetCursorPosition(cursorX, cursorY + 2);

                    Console.Write("무엇을 할까?");

                    Console.SetCursorPosition(cursorX, cursorY - 1);
                    Console.Write($"HP : {HP}/100    MP : {MP}/20");

                    Console.SetCursorPosition(cursorX + 2, cursorY + 4);
                    Console.Write("1. 공격");

                    Console.SetCursorPosition(cursorX + 2, cursorY + 6);
                    Console.Write("2. 포션 사용");

                    while (true)
                    {
                        keys = Console.ReadKey(true);

                        if (keys.Key == ConsoleKey.D1 || keys.Key == ConsoleKey.D2)
                        {
                            break;
                        }
                    }

                    if (keys.Key == ConsoleKey.D1)
                    {
                        #region 스킬목록
                        back.Textbox();
                        Console.SetCursorPosition(cursorX - 2, cursorY - 2);
                        Console.Write("보유 스킬");

                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("1. 데스페라도");
                        Console.SetCursorPosition(cursorX + 20, cursorY);
                        Console.Write("공중으로 뛰어올라 핸드건을 난사한다. MP 8 소모");

                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        Console.Write("2. 퀵 샷");
                        Console.SetCursorPosition(cursorX + 20, cursorY + 2);
                        Console.Write("빠르게 사격하여 피해를 입힌다. MP 0 소모");

                        Console.SetCursorPosition(cursorX, cursorY + 4);
                        Console.Write("3. 잔혹한 추적자");
                        Console.SetCursorPosition(cursorX + 20, cursorY + 4);
                        Console.Write("전방으로 핸드건을 난사하여 공격한다. MP 6 소모");

                        Console.SetCursorPosition(cursorX, cursorY + 6);
                        Console.Write("4. 이퀼리브리엄");
                        Console.SetCursorPosition(cursorX + 20, cursorY + 6);
                        Console.Write("넓은 범위에 연사하여 적의 방어력을 감소시킨다. MP 2 소모");

                        Console.SetCursorPosition(cursorX - 2, cursorY + 8);
                        Console.Write("ESC를 눌러 뒤로가기");
                        #endregion

                        while (true)
                        {
                            keys = Console.ReadKey(true);

                            if (keys.Key == ConsoleKey.Escape || keys.Key == ConsoleKey.D1 || keys.Key == ConsoleKey.D2
                                || keys.Key == ConsoleKey.D3 || keys.Key == ConsoleKey.D4)
                            {
                                break;
                            }
                        }

                        if (keys.Key == ConsoleKey.D1)
                        {
                            if (MP >= 8)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase($"{Name}는(은) 데스페라도를(을) 사용했다.");
                                Console.SetCursorPosition(cursorX, cursorY + 2);

                                damage = Atk * 10 * ((100 - enemy.Def) / 100.0f);
                                print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                                enemy.HP -= (int)damage;
                                MP -= 8;

                                print.next();
                            }

                            else if (MP < 8)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase("MP가 부족합니다.");
                                print.next();
                                continue;
                            }
                        }

                        if (keys.Key == ConsoleKey.D2)
                        {
                            if (MP >= 0)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase($"{Name}는(은) 퀵 샷를(을) 사용했다.");
                                Console.SetCursorPosition(cursorX, cursorY + 2);

                                damage = Atk * 3 * ((100 - enemy.Def) / 100.0f);
                                print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                                enemy.HP -= (int)damage;
                                MP -= 0;

                                print.next();
                            }

                            else if (MP < 0)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase("MP가 부족합니다.");
                                print.next();
                                continue;
                            }
                        }

                        if (keys.Key == ConsoleKey.D3)
                        {
                            if (MP >= 6)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase($"{Name}는(은) 잔혹한 추적자를(을) 사용했다.");
                                Console.SetCursorPosition(cursorX, cursorY + 2);

                                damage = Atk * 8 * ((100 - enemy.Def) / 100.0f);
                                print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                                enemy.HP -= (int)damage;
                                MP -= 6;

                                print.next();
                            }

                            else if (MP < 6)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase("MP가 부족합니다.");
                                print.next();
                                continue;
                            }
                        }

                        if (keys.Key == ConsoleKey.D4)
                        {
                            if (MP >= 2)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase($"{Name}는(은) 이퀼리브리엄를(을) 사용했다.");

                                damage = Atk * 5 * ((100 - enemy.Def) / 100.0f);

                                Console.SetCursorPosition(cursorX, cursorY + 2);
                                print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                                Console.SetCursorPosition(cursorX, cursorY + 4);
                                print.PrintPhrase("5턴동안 보스의 방어력이 감소한다!");
                                MP -= 2;

                                debuffCount = 5;
                                enemy.HP -= (int)damage;

                                print.next();
                            }

                            else if (MP < 2)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase("MP가 부족합니다.");
                                print.next();
                                continue;
                            }

                        }

                        if (keys.Key == ConsoleKey.Escape)
                        {
                            continue;
                        }

                        if (enemy.HP < 0)
                        {
                            enemy.HP = 0;
                        }

                        Console.SetCursorPosition(70, 0);
                        Console.Write($"{enemy.Name}");
                        Console.SetCursorPosition(68, 1);
                        Console.Write($"((( {enemy.HP} / {maxhp} )))");

                        Debuff(enemy);

                        debuffCount--;


                        MP += MPRefill;

                        if (MP > 20)
                        {
                            MP = 20;
                        }

                        turn = false;
                        enemy.Attack(this);
                    }



                    else if (keys.Key == ConsoleKey.D2)
                    {
                        Item tempitem = null;

                        foreach (Item itemA in invenlist)
                        {
                            if (itemA.ItemCode == 3)
                            {
                                tempitem = itemA;
                                invenlist.Remove(itemA);
                                break;
                            }
                        }

                        if(tempitem == null)
                        {
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);
                            print.PrintPhrase("사용 가능한 포션이 없습니다.");
                            print.next();
                            continue;
                        }

                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("포션을 사용하시겠습니까? 1.예 2.아니오");

                        while (true)
                        {
                            keys = Console.ReadKey(true);

                            if (keys.Key == ConsoleKey.D1 || keys.Key == ConsoleKey.D2)
                            {
                                break;
                            }
                        }

                        if (keys.Key == ConsoleKey.D1)
                        {
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.Write("포션을 사용합니다.");
                            tempitem.ItemEffect(this);
                            print.next();
                            count--;
                            continue;
                        }

                        if (keys.Key == ConsoleKey.D2)
                        {
                            continue;
                        }
                    }

                }
            }

            if (enemy.HP == 0)
            {
                enemy.Die(this);
            }

            if (HP < 0)
            {
                back.Textbox();
                Console.SetCursorPosition(cursorX, cursorY);
                print.PrintPhrase($"{enemy.Name}와(과)의 전투에서 패배했다...");
                print.next();

                print.PrintPhrase("GAME OVER");
                print.next();

                Console.Clear();
                title.PrintTitle();
            }

            
        }



        public void Debuff(Enemy enemy)
        {

            if (debuffCount > 0)
            {
                if (debuffCount > 4)
                {
                    enemy.Def = enemyDef / 2;
                }

                else if (debuffCount <= 4)
                {
                    enemy.Def = enemy.Def;
                }
            }

            else if (debuffCount <= 0)
            {
                enemy.Def = enemyDef;
            }
        }
    }
}
