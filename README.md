# Random Phrase Clicker

A small desktop app built with C# and XAML that shows a random phrase between 1 and 200 every time you press a button, while keeping track of how many times the button has been clicked.

## Features

- Shows a random phrase (indexed from 1 to 200) on each button click  
- Displays a total click counter in the UI  
- Simple, minimal XAML user interface  
- Great as a starter project for learning C#, XAML, and .NET 9

## Tech stack

- C# (.NET 9)
- XAML (MAUI)
- Visual Studio 2022

## Getting started
1. Download the **zip** with the files and stuff
2. Exctract the **zip**
3. Open the `.sln` in **Visual Studio 2022** and that's it!
   
Or

1. Clone this repository:
`git clone https://github.com/bl3ne/RandomPhrase.git`
2. Open the solution (`.sln`) in **Visual Studio 2022**.  
3. Make sure the **.NET desktop development** workload is installed.  
4. Set the main project as the **Startup Project** if needed.  
5. Press **F5** or click **Start** to run the app in Debug mode.

## Usage

1. Open the file.
2. Compile the solution.
3. Start the application.  
4. On each click:
- A new random phrase between 1 and 200 is shown.
- The click counter is increased by 1 and updated in the UI.

You can use this app for small games, challenges with friends, or just as a playground for random logic and basic data binding.

## Project structure 

- `MainPage.xaml`: defines the UI (button, phrase text, click counter).
- `MainPage.xaml.cs`: handles the click event, random phrase generation, and UI updates.
- Optional extra files for managing phrases (for example, a list of strings in code or in a resource file).

## Possible improvements

- Persist the total number of clicks to disk (settings file, JSON, etc.).
- Add a more advanced theme (Material, Fluent, custom styles).
- Add localization support for multiple languages.

## Requirements

- Windows 10 or Windows 11
- .NET 9 SDK / runtime
- Visual Studio 2022 with .NET desktop development workload

## Contributing

If you want to improve this project:

1. Fork the repository.
2. Create a feature branch
3. Commit and push your changes.
4. Open a Pull Request describing what you changed.

## License

Specify the project license here [MIT License](LICENSE).


