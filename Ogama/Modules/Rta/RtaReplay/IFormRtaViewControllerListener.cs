﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ogama.Modules.Rta.RtaReplay
{
    public interface IFormRtaViewControllerListener
    {
        void onnewMoviePositionRequest(double requestedPosition);

    }
}
