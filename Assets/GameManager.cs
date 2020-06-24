using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GameManager 
{
    public static bool isClickDown = false;

    public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
    {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
            enumerator.MoveNext();
            TSource current = enumerator.Current;
            while (enumerator.MoveNext())
                current = func(current, enumerator.Current);
            return current;
        }
    }

}