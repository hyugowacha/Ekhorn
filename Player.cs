using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleProject
{
    partial class Player
    {
        static int _progress;
        int _hp;
        int _mp;
        int _atk;
        int _mpRefill;
        int _silling;
        string _name;
        char cursor = '▶';
        LinkedList<Item> invenlist = new LinkedList<Item>();
        Item[] playerItem = new Item[2];

        Item item { get; set; }

        #region 생성자 & 프로퍼티
        public Player(int hp, int mp, int mpRefill, int atk, int silling, string name = "해결사")
        {
            _progress = 0;
            _hp = hp;
            _mp = mp;
            _mpRefill = mpRefill;
            _atk = atk;
            _silling = silling;
            _name = name;
        }

        public Item this[int i]
        {
            get { return playerItem[i]; }
            set { playerItem[i] = value; }
        }

        public LinkedList<Item> Invenlist
        {
            get { return invenlist; }
            set { invenlist = value; }
        }

        public int Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int MP
        {
            get { return _mp; }
            set { _mp = value; }
        }

        public int MPRefill
        {
            get { return _mpRefill; }
            set { _mpRefill = value; }
        }

        public int Atk
        {
            get { return _atk; }
            set { _atk = value; }
        }

        public int Silling
        {
            get { return _silling; }
            set { _silling = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        #endregion

        
    }
}
