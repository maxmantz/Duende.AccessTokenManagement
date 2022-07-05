// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Duende.TokenManagement.OpenIdConnect;

/// <summary>
/// Service to provide a concurrent dictionary for synchronizing token endpoint requests
/// </summary>
public interface IUserAccessTokenRequestSynchronization
{
    /// <summary>
    /// Concurrent dictionary as synchronization primitive
    /// </summary>
    public ConcurrentDictionary<string, Lazy<Task<UserAccessToken>>> Dictionary { get; }
}