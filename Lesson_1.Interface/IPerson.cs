﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.Interface
{
    internal interface IPerson : IObject
    {
        int Move(int distance);
    }
}
