using System;

namespace Akka.TestKit
{
    // ReSharper disable once InconsistentNaming
    public interface IUnmutableFilter : IDisposable
    {
        /// <summary>
        /// Call this to let events that previously have been muted to be logged again.
        /// </summary>
        void Unmute();
    }
}