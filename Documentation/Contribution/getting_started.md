---
title: Getting started
description: How to get started as a contributor to the project
keywords: 
author: karolikl
---
# Getting Started

In order for you to get started easily, we have created an overview of how the project is structured and how you can get the application up and running. 

If you haven't already familiarized yourself with the [Contributor Guide](./contributing.md), please do so before proceeding. 

_Eager to get started right away? Have a look at the [example application](../../Source/Example/readme.md)._

## Setting up your development environment

Make sure you have the required [development environment](./development_environment.md) set up. 

## Understanding the project structure

CBS has been divided into 5 [bounded contexts](../Architecture/bounded_contexts.md) (or projects/modules). Each module is isolated from the others, and the communication between them is event-driven. This means that the module you are working in will process incoming [events](../Architecture/events.md) from other modules and emit events for other modules to process. 

### Source code
Each module has its own subfolder in the [Source](https://github.com/IFRCGo/cbs/tree/master/Source) folder, containing a .sln file. Everything you need to build and run the module can be found within the specified folder for said module.   
For example: Everything you need to build and run the "Volunteer Reporting" module, can be found in the [Volunteer Reporting](https://github.com/IFRCGo/cbs/tree/master/Source/VolunteerReporting) folder under Source. 

### Documentation and backlog
In addition to this, each module has its own documentation and its own backlog. The documentation can be found in the [Documentation/Projects](../Projects) folder while the backlog can be found on the [GitHub project page](https://github.com/IFRCGo/cbs/projects).  
For example: The documentation for the "Volunteer Reporting" module can be found in the [Volunteer Reporting](../Projects/Volunteer%20Reporting/index.md) folder. The backlog can be found on the "Volunteer Reporting" [project page](https://github.com/IFRCGo/cbs/projects/4). 

Any issue labeled ["good first issue"](https://github.com/IFRCGo/cbs/labels/good%20first%20issue) will be linked to a project/module so that you will be able to find the source code and documentation for the module as explained above. 

## Next steps

1. Find an issue you want to work on. Issues labeled ["good first issues"](https://github.com/IFRCGo/cbs/labels/good%20first%20issue) are issues that should be relatively easy to get started on without too much background information. 
1. Create a fork. In order to contribute to this project, you will need to [fork](https://help.github.com/articles/fork-a-repo/) this repository.
1. Make changes, test them and ensure the documentation is up to date. All commits SHOULD be related to an [issue](./issues.md) by adding a #{number of issue} to the comment.
1. Synchronize your fork. Keep your fork synchronized with the CBS repository to avoid conflicts, as described [here](https://help.github.com/articles/syncing-a-fork/).
1. Create a pull request. Once your changes are ready, create a [pull request](https://help.github.com/articles/creating-a-pull-request/) and reference the issues you have worked on.

