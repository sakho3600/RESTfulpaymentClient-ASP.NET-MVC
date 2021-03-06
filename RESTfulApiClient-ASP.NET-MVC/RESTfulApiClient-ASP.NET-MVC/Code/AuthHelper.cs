﻿using DotNetOpenAuth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTfulApiClient_ASP.NET_MVC.Code
{
    public class AuthHelper
    {
        public static WebServerClient CreateClient()
        {
            //pleasea contact hellopaisa for the credentials

            var desc = GetAuthServerDescription();
            //client ID provided
            var client = new WebServerClient(desc, clientIdentifier: "ID");
            //client secret/password provided
            client.ClientCredentialApplicator = ClientCredentialApplicator.PostParameter("SECRET");

            return client;
        }

        private static AuthorizationServerDescription GetAuthServerDescription()
        {
            //throw new NotImplementedException();
            var authServerDesc = new AuthorizationServerDescription();

            //authorization endpoint of Hello Paisa for the test platform.
            authServerDesc.AuthorizationEndpoint = new Uri(@"https://test.hellopaisa.com.np/OAuth/Auth");

            //token endpoint for the test environment.
            authServerDesc.TokenEndpoint = new Uri(@"https://test.hellopaisa.com.np/OAuth/Token");
            //protocol version of OAuth
            authServerDesc.ProtocolVersion = ProtocolVersion.V20;
            return authServerDesc;

        }
    }
}