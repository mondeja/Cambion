﻿namespace Whitestone.Cambion.Common.Interfaces
{
    public interface IEventHandler
    {
    }

    public interface IEventHandler<in TInput> : IEventHandler
    {
        void HandleEvent(TInput input);
    }
}
