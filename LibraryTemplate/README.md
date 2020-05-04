# Library template

This is a standard .NET Core library, with GitHub actions to publish to NuGet.

# Usage

* Do trunk based development against a branch called `dev`.
* Any commits will build and be tested in release mode by `GitHub Actions`.
* Merge to `master` will trigger `Build, Test and Publish` to NuGet
* You need to setup your NuGet API key as a `GitHub Secret` for this to work.

# Additional Setup

## Setting up a NuGet.org key as a `GitHub Secret`

Create a GitHub Secret with your NuGet API Key called `NuGetApiKey`