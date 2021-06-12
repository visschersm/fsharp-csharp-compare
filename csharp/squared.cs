using System;
using System.Linq;
using System.Collections.Generic;

int squared(int x) => x * x;
var list = new List<int> {1, 2, 3};
list.Select(x => squared(x))
    .ToList()
    .ForEach(x => Console.WriteLine(x));