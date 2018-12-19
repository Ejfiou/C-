using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_23
{
    class Player
    {
        public Player()
        {
        }

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, bool isPerson)
        {
            this.name = name;
            this.isPerson = isPerson;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int playContent;
        public int PlayContent
        {
            get { return playContent; }
            set { playContent = value; }
        }

        private bool isPerson = true;
        public bool IsPerson
        {
            get { return isPerson; }
            set { isPerson = value; }
        }
    }
}
