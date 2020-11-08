// <copyright file="InsertionSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    /// <summary>
    /// Represents a benchmark for <see cref="Sorting.InsertionSort"/>.
    /// </summary>
    [SimpleJob(launchCount: 10, warmupCount: 10, targetCount: 10)]
    public class InsertionSort : Sort<Sorting.InsertionSort>
    {
        // Intentionally left bank
    }
}