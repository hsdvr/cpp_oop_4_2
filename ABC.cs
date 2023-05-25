using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4_2
{
    internal class ABC
    {
        private int a, b, c;

        public event NeedUpdateHandler NeedUpdate;
        public delegate void NeedUpdateHandler(object sender, EventArgs eventArgs);

        public ABC()
        {
            LoadNumbers();
        }

        private void LoadNumbers()
        {
            a = Settings.Default.A;
            b = Settings.Default.B;
            c = Settings.Default.C;
        }

        public void SaveNumbers()
        {
            Settings.Default.A = a;
            Settings.Default.B = b;
            Settings.Default.C = c;
            Settings.Default.Save();
        }

        public int this[int index]
        {
            get
            {
                return (index == 0) ? a :
                       (index == 1) ? b :
                       (index == 2) ? c :
                       -1;
            }
            set
            {
                if (value < 0 || value > 100) { }
                else if (index == 0)
                {
                    a = value;
                    c = (a > c) ? a : c;
                    b = (a > b) ? a : b;
                }
                else if (index == 1)
                {
                    b = (a <= value && value <= c) ? value : b;
                }
                else if (index == 2)
                {
                    c = value;
                    a = (a > c) ? c : a;
                    b = (b > c) ? c : b;
                }
                NeedUpdate.Invoke(this, null);
            }
        }
    }
}
