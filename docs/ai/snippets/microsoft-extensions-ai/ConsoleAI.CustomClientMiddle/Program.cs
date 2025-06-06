﻿using Microsoft.Extensions.AI;
using System.Threading.RateLimiting;

var client = new RateLimitingChatClient(
    new OllamaChatClient(new Uri("http://localhost:11434"), "llama3.1"),
    new ConcurrencyLimiter(new() { PermitLimit = 1, QueueLimit = int.MaxValue }));

Console.WriteLine(await client.GetResponseAsync("What color is the sky?"));
