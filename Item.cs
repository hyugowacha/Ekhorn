using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    enum Category
    {
        Armour, weapon, useable
    }

    abstract class Item
    {
        protected string _name;
        protected string _explain;
        protected int _price;
        protected Category _category;

        public string Name
        { get { return _name; } }

        public string Explain
        { get { return _explain; } }

        public int Price
        { get { return _price; } }

        
    }

    class Armour : Item
    {
        public Armour()
        {
            _name = "아르데타인산 기본 방어구";
            _explain = "아르데타인에서 가장 흔하게 구할 수 있는 방어구.";
            _category = Category.Armour;
        }

        public Armour(int price)
        {
            _name = "마력이 깃든 방어구";
            _explain = "마력이 깃들어있는 방어구. MP 회복 속도를 증가시켜 준다.";
            _price = price;
            _category = Category.Armour;
        }
    }

    class Gun : Item
    {
        public Gun()
        {
            _name = "에크혼 알파";
            _explain = "파비안이 제작한 총. 공격력 + 10";
            _category = Category.weapon;
        }

        public Gun(int price)
        {
            _name = "사냥용 총";
            _explain = "평범한 사냥용 총. 공격력 + 15";
            _price = price;
            _category = Category.weapon;
        }
    }

    class Potion : Item
    {
        public Potion(int price)
        {
            _name = "X-090892";
            _explain = "케나인들이 즐겨 마시는 에너지 드링크";
            _price = price;
            _category = Category.weapon;
        }


    }
}
