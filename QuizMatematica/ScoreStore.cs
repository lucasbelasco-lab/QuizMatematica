using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMatematica;

public static class ScoreStore
{
    public static int Points { get; set; } = 0;

    public static void Add(int pts)
    {
        Points += pts;
    }

    public static void Reset()
    {
        Points = 0;
    }
}