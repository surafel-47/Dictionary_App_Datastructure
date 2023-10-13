using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    [Serializable]
    public struct Dictionary//Dicionary Record Struct
    {
        public char []word;
        public char []pron;
        public char []type;
        public char []meaning;
        public Dictionary(int size=314/*bytes*/)
        {
            word = new char[50];
            pron = new char[60];
            type = new char[4];
            meaning = new char[200];
        }
    }

    public struct DicIndex //Dicionary Index Struct (to be Inserted as Data Part of AVLNode in AVL Tree
    {
       public string word;
       public long posIndex;
    }
}
