using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public class Player : GameObject, IShootable, ITouchable
    {
        public int Score
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}