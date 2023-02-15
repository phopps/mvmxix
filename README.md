# MVMXIX

## Style Guide

- [C# basics](https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/c_sharp_basics.html)
- [C# API differences to GDScript](https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/c_sharp_differences.html)
- Use 2 spaces instead of tabs
- Use `PascalCase` instead of `snake_case`:
  - Use `PascalCase` for all namespaces, type names and member level identifiers (i.e. methods, properties, constants, events), except for private fields
  - Use `camelCase` for all other identifiers (i.e. local variables, method arguments), and use an underscore (`_`) as a prefix for private fields (but not for methods or properties, as explained above)
  - There's an exception with acronyms which consist of two letters, like `UI`, which should be written in `UPPERCASE` letters where `PascalCase` would be expected, and in `lowercase` letters otherwise
  - Note that `id` is not an acronym, so it should be treated as a normal identifier
- Use `LF` instead of `CRLF` or `CR`
- Can use `using static Godot.GD` to simplify things like `Print` instead of `GD.Print`
- Can use `PropertyHint` and `hintString` with `[Export]` keywords:
  - `[Export(PropertyHint.Range, "0,100000,1000,or_greater")] private int _income;`
  - `[Export(PropertyHint.File, "*.png,*.jpg")] private string _icon;`
  - Note: see [C# exports](https://docs.godotengine.org/en/latest/tutorials/scripting/c_sharp/c_sharp_exports.html) in latest unstable version for more details, similar to stable version
- Use modifiers in this order: `public`/`protected`/`private`/`internal`/`virtual`/`override`/`abstract`/`new`/`static`/`readonly`

## Filetree

```txt
📦MVMXIX
 ┣ 📂Art
 ┃ ┣ 📜Circle.png
 ┃ ┣ 📜Circle.png.import
 ┃ ┣ 📜icon.png
 ┃ ┣ 📜icon.png.import
 ┃ ┣ 📜Screenshot.png
 ┃ ┣ 📜Screenshot.png.import
 ┃ ┣ 📜Screenshot2.png
 ┃ ┣ 📜Screenshot2.png.import
 ┃ ┣ 📜Tileset.png
 ┃ ┗ 📜Tileset.png.import
 ┣ 📂Platforms
 ┃ ┣ 📜CirclePlatform.gd
 ┃ ┣ 📜CirclePlatform.tscn
 ┃ ┣ 📜MovingPlatform.gd
 ┃ ┣ 📜MovingPlatform.tscn
 ┃ ┗ 📜TileMap.tscn
 ┣ 📂Player
 ┃ ┣ 📜Player.gd
 ┃ ┣ 📜Player.gdshader
 ┃ ┣ 📜Player.tscn
 ┃ ┗ 📜Sprite.gd
 ┣ 📂ScreenCamera
 ┃ ┣ 📜ScreenCamera.gd
 ┃ ┗ 📜ScreenCamera.tscn
 ┣ 📂World
 ┃ ┣ 📜Background.gdshader
 ┃ ┣ 📜World.gd
 ┃ ┣ 📜World.gdshader
 ┃ ┗ 📜World.tscn
 ┣ 📜.gitattributes
 ┣ 📜.gitignore
 ┣ 📜default_env.tres
 ┣ 📜export_presets.cfg
 ┣ 📜icon.ico
 ┣ 📜LICENSE.md
 ┣ 📜MVMXIX.csproj
 ┣ 📜MVMXIX.sln
 ┣ 📜project.godot
 ┗ 📜README.md
```
