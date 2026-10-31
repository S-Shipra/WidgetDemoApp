# Experiment 9: Cross-Platform Application with Widgets (.NET MAUI)

**Author:** Shipra Singh

## Aim
To set up a cross-platform mobile development environment and build an Android application that demonstrates core UI widgets, with the layout defined in XAML and the interactive behaviour handled in C# code-behind.

## Note on the framework
The lab experiment is written for Xamarin.Forms. Xamarin support ended in May 2024, so this project uses **.NET MAUI**, its successor. The concepts are the same, with a few widget replacements:

| Xamarin.Forms | .NET MAUI |
|---|---|
| `StackLayout` | `VerticalStackLayout` / `HorizontalStackLayout` |
| `Frame` | `Border` |
| `ListView` | `CollectionView` |

## About the app
A single-screen **Student Profile Card** app. It combines several widgets on one page and wires them to C# event handlers.

### Features
- Circular profile picture (`Image` inside a `Border`)
- Profile card with name and course (`Border` and `Label`)
- **Like** button with a live counter, and a **Reset** button
- **Message** button that shows an `ActivityIndicator` and then an alert
- Comment `Entry` with a **Post** button that displays the comment
- Bio `Editor` (multi-line input)
- "Available for internships" `Switch`
- Horizontally scrolling skills list (`CollectionView` with data binding), where tapping a skill shows an alert

### Widgets and concepts used
`ContentPage`, `ScrollView`, `VerticalStackLayout`, `HorizontalStackLayout`, `Grid`, `Label`, `Image`, `Border`, `Button`, `Entry`, `Editor`, `Switch`, `ActivityIndicator`, `CollectionView`, event handlers, data binding, `async`/`await`.

## Tech stack
- Visual Studio Community 2026
- .NET 10 with the .NET Multi-platform App UI workload
- C# and XAML
- Android Emulator (Pixel 7, API 36)

## Project structure
```
WidgetDemoApp/
├── Pages/
│   ├── MainPage.xaml        # UI layout (widgets)
│   └── MainPage.xaml.cs     # Event handlers and data
├── Platforms/               # Android, iOS and other platform code
├── Resources/               # Images, fonts, styles
├── App.xaml
├── AppShell.xaml
└── MauiProgram.cs
```

## How to run
1. Install **Visual Studio 2022 or later** with the **.NET Multi-platform App UI development** workload.
2. Create an Android emulator in **Tools → Android → Android Device Manager** and start it.
3. Clone this repository and open the solution file in Visual Studio.
4. Choose the emulator in the **Select Startup Item** dropdown.
5. Click **Run**. The first build takes several minutes.

## How the main parts work
- **XAML and code-behind:** `MainPage.xaml` declares the widgets, and `MainPage.xaml.cs` holds the logic. An event such as `Clicked="OnLikeClicked"` in XAML connects a button to the method of the same name in C#.
- **Data binding:** `BindingContext = this` lets the `CollectionView` read the `Skills` list through `ItemsSource="{Binding Skills}"`, and a `DataTemplate` renders each item.
- **Asynchronous code:** the Message button uses `await Task.Delay(...)` so the spinner animates without freezing the UI.

## Screenshots
Add your screenshots to a `screenshots/` folder and update the file names below.

| Top of the screen | Buttons and comment | Skills list |
|---|---|---|
| ![Top](screenshots/screen1.png) | ![Buttons](screenshots/screen2.png) | ![Skills](screenshots/screen3.png) |

## Result
The application was built without errors, deployed to the Android emulator, and each widget was tested successfully.

## Conclusion
The experiment covered the full workflow of cross-platform development: setting up the environment, understanding the project structure, designing a screen with multiple widgets in XAML, and connecting it to C# event handlers and data binding. It gives a foundation for building multi-page apps with navigation and data binding.
