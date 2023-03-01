# MVMXIX

- [MVMXIX](#mvmxix)
  - [Style Guide](#style-guide)
  - [Filetree](#filetree)
  - [Resources](#resources)

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
 ┣ 📂Asset
 ┃ ┣ 📜toaster-sheet.png
 ┃ ┣ 📜toaster-sheet.png.import
 ┃ ┣ 📜toaster-sheet2.png
 ┃ ┣ 📜toaster-sheet2.png.import
 ┃ ┣ 📜toaster-sheet3.png
 ┃ ┗ 📜toaster-sheet3.png.import
 ┣ 📂Entities
 ┃ ┗ 📂Actor
 ┃ ┃ ┣ 📂Player
 ┃ ┃ ┃ ┣ 📂Heavy
 ┃ ┃ ┃ ┃ ┣ 📜Heavy.cs
 ┃ ┃ ┃ ┃ ┣ 📜Heavy.png
 ┃ ┃ ┃ ┃ ┣ 📜Heavy.png.import
 ┃ ┃ ┃ ┃ ┗ 📜Heavy.tscn
 ┃ ┃ ┃ ┣ 📂Sneak
 ┃ ┃ ┃ ┃ ┣ 📜Sneak.cs
 ┃ ┃ ┃ ┃ ┣ 📜Sneak.png
 ┃ ┃ ┃ ┃ ┣ 📜Sneak.png.import
 ┃ ┃ ┃ ┃ ┗ 📜Sneak.tscn
 ┃ ┃ ┃ ┣ 📂Tiny
 ┃ ┃ ┃ ┃ ┣ 📜Tiny.cs
 ┃ ┃ ┃ ┃ ┣ 📜Tiny.png
 ┃ ┃ ┃ ┃ ┣ 📜Tiny.png.import
 ┃ ┃ ┃ ┃ ┗ 📜Tiny.tscn
 ┃ ┃ ┃ ┣ 📜Player.cs
 ┃ ┃ ┃ ┣ 📜Player.gdshader
 ┃ ┃ ┃ ┣ 📜Player.png
 ┃ ┃ ┃ ┣ 📜Player.png.import
 ┃ ┃ ┃ ┗ 📜Player.tscn
 ┃ ┃ ┗ 📜Actor.cs
 ┣ 📂Scene
 ┃ ┣ 📜FlyingEnemy.tscn
 ┃ ┣ 📜GroundEnemy.tscn
 ┃ ┗ 📜NPC.tscn
 ┣ 📂Script
 ┃ ┣ 📜FlyingEnemy.cs
 ┃ ┣ 📜GroundEnemy.cs
 ┃ ┗ 📜NPC.cs
 ┣ 📂UI
 ┃ ┣ 📜HUD.cs
 ┃ ┗ 📜HUD.tscn
 ┣ 📂World
 ┃ ┣ 📂Bootsplash
 ┃ ┃ ┣ 📜bootsplash.png
 ┃ ┃ ┗ 📜bootsplash.png.import
 ┃ ┣ 📂Icons
 ┃ ┃ ┣ 📜icon.ico
 ┃ ┃ ┣ 📜icon.png
 ┃ ┃ ┗ 📜icon.png.import
 ┃ ┣ 📂Tiles
 ┃ ┃ ┣ 📜TileBottomLeft.png
 ┃ ┃ ┣ 📜TileBottomLeft.png.import
 ┃ ┃ ┣ 📜TileBottomRight.png
 ┃ ┃ ┣ 📜TileBottomRight.png.import
 ┃ ┃ ┣ 📜TileCenter.png
 ┃ ┃ ┣ 📜TileCenter.png.import
 ┃ ┃ ┣ 📜TileSet.tres
 ┃ ┃ ┣ 📜TileTopLeft.png
 ┃ ┃ ┣ 📜TileTopLeft.png.import
 ┃ ┃ ┣ 📜TileTopRight.png
 ┃ ┃ ┗ 📜TileTopRight.png.import
 ┃ ┣ 📜Background.gdshader
 ┃ ┣ 📜World.cs
 ┃ ┗ 📜World.tscn
 ┣ 📜.gitignore
 ┣ 📜default_env.tres
 ┣ 📜LICENSE
 ┣ 📜mvmxix.csproj
 ┣ 📜mvmxix.sln
 ┣ 📜project.godot
 ┗ 📜README.md
```

## Resources

[Moving Rainbow Gradient - Godot Shaders](https://godotshaders.com/shader/moving-rainbow-gradient/)

[Stars shader - Godot Shaders](https://godotshaders.com/shader/stars-shader/)
