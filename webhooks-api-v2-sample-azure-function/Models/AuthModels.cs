﻿/*---------------------------------------------------------------------------------------------
* Copyright (c) Bentley Systems, Incorporated. All rights reserved.
* See LICENSE.md in the project root for license terms and full copyright notice.
*--------------------------------------------------------------------------------------------*/

namespace webhooks_api_v2_sample_azure_function.Models;

public class TokenResponse
    {
    public string access_token
        {
        get; set;
        }
    public string token_type
        {
        get; set;
        }
    public int expires_in
        {
        get; set;
        }
    }


