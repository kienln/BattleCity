﻿using BattleCity.Core;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCity.Gameplay.GameObject
{
    class Bound : Actor
    {
        public Bound()
        {
            new HitBox(Vector2.One, true, false).Owner = this;
            Application.ContentLoader.CreateDrawable("Bound").Owner = this;
        }
    }
}
