﻿namespace Cloth.Infrastructure.Extensions;

using Microsoft.Extensions.Logging;

public static partial class ReadFromUrlLoggerExtensions
{
    [LoggerMessage(EventId = 30, Level = LogLevel.Error, Message = "Failed to get cloths.")]
    public static partial void LogFailedGetItems(this ILogger logger);

    [LoggerMessage(EventId = 31, Level = LogLevel.Debug, Message = "Response: {Response}")]
    public static partial void LogGetItemsResponse(this ILogger logger, string Response);

    [LoggerMessage(EventId = 32, Level = LogLevel.Debug, Message = "HttpClient get:")]
    public static partial void LogHttpClientGet(this ILogger logger);
}
