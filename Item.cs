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
        protected int _itemCode;

        public string Name
        { get { return _name; } }

        public string Explain
        { get { return _explain; } }

        public int Price
        { get { return _price; } }

        public Category Category
        { get { return _category; } }

        public int ItemCode
        {
            get { return _itemCode; }
        }

        public virtual void ItemEffect(Player player) { }
    }

    class Armour : Item
    {
        public Armour()
        {
            _itemCode = 1;
            _name = "아르데타인산 기본 방어구";
            _explain = "아르데타인에서 가장 흔하게 구할 수 있는 방어구.";
            _category = Category.Armour;
        }

        public Armour(int price)
        {
            _itemCode = 2;
            _name = "마력이 깃든 방어구";
            _explain = "마력이 깃들어있는 방어구. MP 회복 속도를 증가시켜 준다.";
            _price = price;
            _category = Category.Armour;
        }

        public override void ItemEffect(Player player)
        {
            if (_itemCode == 1)
            {
                player.MPRefill = 1;
            }
            if (_itemCode == 2)
            {
                player.MPRefill = 3;
            }              
        }
    }

    class Gun : Item
    {
        public Gun()
        {
            _itemCode = 1;
            _name = "에크혼 알파";
            _explain = "파비안이 나를 위해 제작한 총. 공격력 10";
            _category = Category.weapon;
        }

        public Gun(int price)
        {
            _itemCode = 2;
            _name = "사냥용 총";
            _explain = "평범한 사냥용 총. 공격력 15";
            _price = price;
            _category = Category.weapon;
        }

        public override void ItemEffect(Player player)
        {
            if (_itemCode == 1)
            {
                player.Atk = 10;
            }

            else if (_itemCode == 2)
            {
                player.Atk = 15;
            }
        }
    }

    class Potion : Item
    {
        public Potion(int price)
        {
            _name = "X-090892";
            _explain = "케나인들이 즐겨 마시는 에너지 드링크. HP + 40";
            _price = price;
            _category = Category.useable;
            _itemCode = 3;
        }

        public override void ItemEffect(Player player)
        {
            player.HP += 40;

            if(player.HP > 100)
            {
                player.HP = 100;
            }
        }
    }
}
