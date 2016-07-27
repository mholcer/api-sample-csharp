# api-sample-csharp
API Sample Code - C Sharp

This is a small repository containing sample code for the WhatIsMyBrowser.com API. The code here is written for Microsoft C# and was provided by one of our users/customers: Thanks to Anil Kumar!

Accessing the API is very straightforward and requires no "official" libraries - all you need to do is send a POST request to:

    https://api.whatismybrowser.com/api/v1/user_agent_parse

containing two parameters:

    user_key
    user_agent

The ```user_key``` parameter is your API key/token which you obtain by logging in to https://developers.whatismybrowser.com

The ```user_agent``` parameter is the particular User Agent you want the API to parse.

The API will return a response in JSON containing everything we are able to tell you based on that user agent.

An important step with C# is url-encoding the user agent. This sample code does this with HttpUtility.UrlEncode(). This prevents the HTTP request library from truncating the user-agent at the first semi-colon that it encounters in the user agent.
