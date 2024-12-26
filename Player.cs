using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleProject
{
    partial class Player
    {
        protected int _hp;
        protected int _mp;
        protected int _atk;
        protected string _name;
        protected char cursor = '▶';       
          
        #region
        public Player(int hp, int mp, int atk, string name = "해결사")
        {
            _hp = hp;
            _mp = mp;
            _atk = atk;
            _name = name;
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

        public int Atk
        {
            get { return _atk; }
            set { _atk = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
      
        public void inventory()
        {

        }
    }
}
