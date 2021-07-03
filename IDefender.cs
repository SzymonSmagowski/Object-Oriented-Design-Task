using System;
using System.Collections.Generic;
using System.Text;
using Enemies;

namespace Defenders
{
    interface IDefender
    {
        int AtakGiant(Giant enemy);
        int AtakOgre(Ogre enemy);
        int AtakRat(Rat enemy);

    }
}
