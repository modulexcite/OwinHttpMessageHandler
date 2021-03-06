﻿﻿// ReSharper disable once CheckNamespace
namespace System.Threading.Tasks
{
    using System.Runtime.CompilerServices;

    internal static class TaskExtensions
    {
        internal static ConfiguredTaskAwaitable NotOnCapturedContext(this Task task)
        {
            return task.ConfigureAwait(false);
        }

        internal static ConfiguredTaskAwaitable<T> NotOnCapturedContext<T>(this Task<T> task)
        {
            return task.ConfigureAwait(false);
        }
    }
}