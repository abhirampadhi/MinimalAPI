﻿namespace GameShop.Application.Queries.GetGamesForConsole;

public record GetGamesForConsoleQueryResponse(IReadOnlyCollection<GetGamesForConsoleQueryResponseItem> Games);
