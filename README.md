# C# .NET Core Templates with GitHub Actions CI

These templates offer the following:

* Empty C# project
* Pre-Generated GitHub Actions CI builds for Windows
* Pre-Generated NUnit Test Project
* NuGet publishing by default for any packages generated from the **master** branch

Currently the templates target .netcore 3.1

Available templates:

    csghlib - C#, GitHub, Library Project
    csghtool - C#, GitHub, .NET Global Tool Command Line App

# Using the templates

First, install the template pack:

```bash
dotnet new -i ElectricHead.CSharpLib
```

Then, you can create a new project from the command line


You can create a new project by calling

```bash
dotnet new <templatename> --name <project name>
```

# Additional Setup

## Setting up a NuGet.org key as a `GitHub Secret`

Publishing to NuGet only works if you setup a NuGet API key as a GitHub secret.

* Go to NuGet.org, sign in, and generate a key.
* Create a GitHub Secret with your NuGet API Key called `NuGetApiKey` (visit Settings -> Secrets, to do so)


# Development workflow

* Do trunk based development against a branch called `dev`.
* Any commits will build and be tested in release mode by `GitHub Actions`.
* Merge to `master` will trigger `Build, Test and Publish` to NuGet
* You need to setup your NuGet API key as a `GitHub Secret` for this to work.
