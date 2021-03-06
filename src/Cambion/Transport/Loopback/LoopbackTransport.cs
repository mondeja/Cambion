﻿using System;
using Whitestone.Cambion.Events;
using Whitestone.Cambion.Interfaces;
using Whitestone.Cambion.Types;

namespace Whitestone.Cambion.Transport.Loopback
{
    public class LoopbackTransport : ITransport
    {
        public ISerializer Serializer { get; set; }

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        public void Start() { }
        public void Stop() { }

        public void Publish(MessageWrapper message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            // This is a loopback, so no need to serialize the message.
            // Just fire the message received event at once.

            MessageReceived?.Invoke(this, new MessageReceivedEventArgs(message));
        }
    }
}
