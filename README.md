# Social Media App MVP

## Overview
This is a cross-platform social media application developed as a semester project for the Mobile Programming course at Óbudai Egyetem. The application is built with .NET MAUI and connects to a central, dockerized database via a C# ASP.NET Core API backend. It features user authentication, a timeline feed, friend management, and media-rich post creation.

## Features
*   **User Management:** Account registration, login with local token storage, profile editing (picture and description), and account deletion via username confirmation.
*   **Timeline Feed:** Chronological display of friends' posts.
*   **Post Creation:** Users can create posts containing text, upload images or take photos using the device camera, and append their current geolocation.
*   **Friend System:** Search for users, send friend requests, manage incoming requests (accept/decline), and remove friends.
*   **Offline Detection:** Built-in network state monitoring that displays a warning banner when internet connectivity is lost.

## Tech Stack
*   **Frontend:** .NET MAUI (C#, XAML)
*   **Backend:** ASP.NET Core Web API (C#)
*   **Database:** Centralized database running in a Docker container

## Author
*   **Name:** Simon András Örs
