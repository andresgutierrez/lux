﻿
namespace Lux.Data;

public enum RaftWALActionType
{
    Append = 0,
    AppendCheckpoint = 1,
    Recover = 2,
    Update = 3
}
