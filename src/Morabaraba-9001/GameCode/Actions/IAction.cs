﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001.GameCode.Actions
{
    public enum AvailableActions
    {
        Place,
        Shoot
    }

    public interface IAction
    {
        // Return if the next action should be called
        PlayOption PlayAction(Game game);
    }
}
