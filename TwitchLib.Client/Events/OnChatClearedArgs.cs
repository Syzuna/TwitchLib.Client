﻿using System;

namespace TwitchLib.Client.Events
{
    /// <inheritdoc />
    /// <summary>Args representing a cleared chat event.</summary>
    public class OnChatClearedArgs : EventArgs
    {
        /// <summary>Channel that had chat cleared event.</summary>
        public string Channel;
    }
}
