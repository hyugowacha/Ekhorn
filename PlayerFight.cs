using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
    partial class Player
    {
        int debuffCount = 0;
        int tempDef;

        public void PlayerFight(Enemy enemy)
        {
            bool turn = true;
            int damage;

            while (HP > 0 || enemy.HP > 0)
            {
                turn = true;

                while (turn)
                {
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
                        Console.Write("빠르게 사격하여 피해를 입힌다. MP 1 소모");

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
                            if (MP > 8)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase($"{Name}는(은) 데스페라도를(을) 사용했다.");
                                Console.SetCursorPosition(cursorX, cursorY + 2);

                                damage = (int)(Atk * 100 * ((100 - enemy.Def)/100));
                                print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                                enemy.HP -= damage;
                                MP -= 8;

                                Thread.Sleep(2000);
                            }

                            else if (MP < 8)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase("MP가 부족합니다.");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }

                        if (keys.Key == ConsoleKey.D2)
                        {
                            if (MP > 1)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                print.PrintPhrase($"{Name}는(은) 퀵 샷를(을) 사용했다.");
                                Console.SetCursorPosition(cursorX, cursorY + 2);

                                damage = (int)(Atk * 50 * ((100 - enemy.Def) / 100));
                                print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                                enemy.HP -= damage;

                                Thread.Sleep(2000);
                            }

                        }

                        if (keys.Key == ConsoleKey.D3)
                        {
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);
                            print.PrintPhrase($"{Name}는(은) 잔혹한 추적자를(을) 사용했다.");
                            Console.SetCursorPosition(cursorX, cursorY + 2);

                            damage = (int)(Atk * 80 * ((100 - enemy.Def) / 100));
                            print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                            enemy.HP -= damage;

                            Thread.Sleep(2000);
                        }

                        if (keys.Key == ConsoleKey.D4)
                        {
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);
                            print.PrintPhrase($"{Name}는(은) 이퀼리브리엄를(을) 사용했다.");

                            damage = (int)(Atk * 50 * ((100 - enemy.Def) / 100));

                            Console.SetCursorPosition(cursorX, cursorY + 2);
                            print.PrintPhrase($"{damage}만큼의 데미지를 입혔다!");
                            Console.SetCursorPosition(cursorX, cursorY + 4);
                            print.PrintPhrase("5턴동안 보스의 방어력이 감소한다!");

                            debuffCount = 6;
                            enemy.HP -= damage;

                            Thread.Sleep(2000);
                        }

                        debuffCount--;

                        Debuff(enemy);

                        MP += MPRefill;

                        if (MP > 20)
                        {
                            MP = 20;
                        }

                        turn = false;
                    }

                    else if (keys.Key == ConsoleKey.D2)
                    {
                        foreach (Item item in invenlist)
                        {
                            if (item.ItemCode == 1 || item.ItemCode == 2)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("사용할 수 있는 포션이 없습니다.");
                                Thread.Sleep(2000);
                                break;
                            }

                            else if (item.ItemCode == 3)
                            {
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
                                    Thread.Sleep(2000);
                                    invenlist.Remove(item);
                                    break;
                                }

                                if (keys.Key == ConsoleKey.D2)
                                {
                                    break;
                                }
                            }
                        }

                    }

                }


            }

        }

        public void Debuff(Enemy enemy)
        {
            if (debuffCount > 0)
            {
                tempDef = enemy.Def;
                enemy.Def = enemy.Def / 2;
            }

            else if (debuffCount <= 0)
            {
                enemy.Def = tempDef;
            }
        }
    }
}
