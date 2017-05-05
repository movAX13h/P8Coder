# P8Coder
P8Coder is a handy little tool that replaces the lua code in pico-8 cartridges (p8) with the code you write in P8Coder (Windows only, untested with Mono).

[Author release blog post](http://blog.thrill-project.com/p8coder-pico-8-programming-tool/)

It allows to group functions (any code actually) that belong to the same entity/unit in your game and lets you have functions (any kind of code sections) as tabs.

![codehints](screenshots/p8coder.png "P8Coder")

When writing to the cartridge it concatenates all code to one large lua code block as you would have when writing the cart directly in the p8 file or in pico-8.

In its functionality it serves the same way as a project explorer (multiple "files") and a code outline (functions list) but in P8Coder that's all just virtual (no files, just entries in a list). The structure of your projects is up to you.

It stores projects as p8c (P8Coder) files containing the code along with the path to the selected cartridge.

You can use upper-case characters in P8Coder for better readability. Everything will be converted to lower-case on build.

![codehints](screenshots/codehints.png "codehints")

P8Coder has pico-8 lua syntax highlighting and API code hints and can be used entirely with keyboard (F1/F2 to switch entity, ALT+F1/F2 to switch tab, see tooltips for more).

![codehints](screenshots/spritesheet.png "spritesheet viewer")

Internal pico-8 spritesheet viewer with zoom and location helper.

![codehints](screenshots/mapviewer.png "map viewer")

Internal pico-8 map viewer with zoom and location helper.

![codehints](screenshots/colors.png "pico-8 colors")

Pico-8 color table just one click away.

Links to [API cheatsheet](https://neko250.github.io/pico8-api/) and P8Coder GitHub page.

P8Coder watches changes made to sprites or map data of the loaded cartridge and updates its views automatically.

P8Coder project files (p8c) can be opened with P8Coder from Windows Explorer ("Open with..." and associate the file extension by choosing P8Coder.exe).

If you're looking for other tools for pico-8, check the [awesome-PICO-8](https://github.com/felipebueno/awesome-PICO-8) collection.

#### WARNING
P8Coder overwrites all lua code of the cartridge you select! Everything else (gfx/map/sfx/music) remains untouched.

## Download
- Binary (v1.1) from author server: http://thrill-project.com/archiv/coding/P8Coder.zip (147kb)

## Source code
- C# .NET4.5, VisualStudio 12 (2013) solution
- uses https://github.com/PavelTorgashov/FastColoredTextBox
- should be easy :)

