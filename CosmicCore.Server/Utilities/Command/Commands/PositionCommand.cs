﻿using CosmicCore.Server.Gate.Manager.Handlers;
using Serilog;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["pos", "position"],
    Description = "Prints the player's current position.",
    Usage = "",
    RequiredPermissions = [])]
public class PositionCommand : ICommand
{
    public Dictionary<int, string> ReturnCodeMap { get; } = [];

    public int OnExecute(string args)
    {
        Log.Information("Current player position: {@Position}", SceneReqGroup.PlayerPosition);
        return 0;
    }
}