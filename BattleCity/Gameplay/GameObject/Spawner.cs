﻿using BattleCity.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCity.Gameplay.GameObject
{
    class Spawner : Actor
    {
        protected override void OnStart()
        {
            Spawn<Enemy>(Transform.Position);
        }
    }
}
