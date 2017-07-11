using System;
using EasyConfig.Attributes;

namespace NuKeeper.Configuration
{
    public class CommandLineArguments
    {
        [CommandLine("mode")]
        public string Mode;

        [CommandLine("github_token"), Required, SensitiveInformation]
        public string GithubToken;

        [CommandLine("github_repository_uri")]
        public Uri GithubRepositoryUri;

        [CommandLine("github_organisation_name")]
        public string GithubOrganisationName;

        [CommandLine("github_api_endpoint"), Default("https://api.github.com")]
        public Uri GithubApiEndpoint;
    }
}