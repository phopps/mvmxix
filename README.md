# MVMXIX

## Style Guide

- [C# basics](https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/c_sharp_basics.html)
- [C# API differences to GDScript](https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/c_sharp_differences.html)
- Use 4 spaces instead of tabs
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
📦mvmxix
 ┣ 📂Entities
 ┃ ┣ 📜Player.cs
 ┃ ┗ 📜Player.tscn
 ┣ 📂World
 ┃ ┣ 📜Player.aseprite
 ┃ ┣ 📜Player.png
 ┃ ┣ 📜Player.png.import
 ┃ ┣ 📜TileBottomLeft.aseprite
 ┃ ┣ 📜TileBottomLeft.png
 ┃ ┣ 📜TileBottomLeft.png.import
 ┃ ┣ 📜TileBottomRight.aseprite
 ┃ ┣ 📜TileBottomRight.png
 ┃ ┣ 📜TileBottomRight.png.import
 ┃ ┣ 📜TileCenter.aseprite
 ┃ ┣ 📜TileCenter.png
 ┃ ┣ 📜TileCenter.png.import
 ┃ ┣ 📜TileSet.tres
 ┃ ┣ 📜TileTopLeft.aseprite
 ┃ ┣ 📜TileTopLeft.png
 ┃ ┣ 📜TileTopLeft.png.import
 ┃ ┣ 📜TileTopRight.aseprite
 ┃ ┣ 📜TileTopRight.png
 ┃ ┣ 📜TileTopRight.png.import
 ┃ ┗ 📜World.tscn
 ┣ 📜.gitignore
 ┣ 📜default_env.tres
 ┣ 📜icon.ico
 ┣ 📜icon.png
 ┣ 📜icon.png.import
 ┣ 📜LICENSE
 ┣ 📜mvmxix.csproj
 ┣ 📜mvmxix.sln
 ┣ 📜project.godot
 ┗ 📜README.md
```
