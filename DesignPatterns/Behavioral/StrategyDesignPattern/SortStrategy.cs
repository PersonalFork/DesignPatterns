﻿using System.Collections.Generic;

namespace Behavioral.StrategyDesignPattern
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}