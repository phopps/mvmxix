# MVMXIX

- [MVMXIX](#mvmxix)
  - [Style Guide](#style-guide)
  - [Resources](#resources)
  - [Filetree](#filetree)

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
- Use modifiers in this order: `public` / `protected` / `private` / `internal` / `virtual` / `override` / `abstract` / `new` / `static` / `readonly`

## Resources

[Moving Rainbow Gradient - Godot Shaders](https://godotshaders.com/shader/moving-rainbow-gradient/)

[Stars shader - Godot Shaders](https://godotshaders.com/shader/stars-shader/)

## Filetree

```txt
📦mvmxix
 ┣ 📂Actor
 ┃ ┣ 📂NPC
 ┃ ┃ ┣ 📂Dude
 ┃ ┃ ┃ ┣ 📜Dude.cs
 ┃ ┃ ┃ ┣ 📜Dude.png
 ┃ ┃ ┃ ┣ 📜Dude.png.import
 ┃ ┃ ┃ ┗ 📜Dude.tscn
 ┃ ┃ ┣ 📂FlyingEnemy
 ┃ ┃ ┃ ┣ 📜FlyingEnemy.cs
 ┃ ┃ ┃ ┣ 📜FlyingEnemy.png
 ┃ ┃ ┃ ┣ 📜FlyingEnemy.png.import
 ┃ ┃ ┃ ┗ 📜FlyingEnemy.tscn
 ┃ ┃ ┣ 📂GroundEnemy
 ┃ ┃ ┃ ┣ 📜GroundEnemy.cs
 ┃ ┃ ┃ ┣ 📜GroundEnemy.png
 ┃ ┃ ┃ ┣ 📜GroundEnemy.png.import
 ┃ ┃ ┃ ┗ 📜GroundEnemy.tscn
 ┃ ┃ ┣ 📂ToastGuy
 ┃ ┃ ┃ ┣ 📜ToastGuy.cs
 ┃ ┃ ┃ ┣ 📜ToastGuy.png
 ┃ ┃ ┃ ┣ 📜ToastGuy.png.import
 ┃ ┃ ┃ ┗ 📜ToastGuy.tscn
 ┃ ┃ ┗ 📜NPC.cs
 ┃ ┣ 📂Player
 ┃ ┃ ┣ 📂Heavy
 ┃ ┃ ┃ ┣ 📜Heavy.cs
 ┃ ┃ ┃ ┣ 📜Heavy.png
 ┃ ┃ ┃ ┣ 📜Heavy.png.import
 ┃ ┃ ┃ ┗ 📜Heavy.tscn
 ┃ ┃ ┣ 📂Sneak
 ┃ ┃ ┃ ┣ 📜Sneak.cs
 ┃ ┃ ┃ ┣ 📜Sneak.png
 ┃ ┃ ┃ ┣ 📜Sneak.png.import
 ┃ ┃ ┃ ┗ 📜Sneak.tscn
 ┃ ┃ ┣ 📂Tiny
 ┃ ┃ ┃ ┣ 📜Tiny.cs
 ┃ ┃ ┃ ┣ 📜Tiny.png
 ┃ ┃ ┃ ┣ 📜Tiny.png.import
 ┃ ┃ ┃ ┗ 📜Tiny.tscn
 ┃ ┃ ┣ 📜Player.cs
 ┃ ┃ ┗ 📜Player.gdshader
 ┃ ┗ 📜Actor.cs
 ┣ 📂Item
 ┃ ┣ 📂Gate
 ┃ ┃ ┣ 📂Bridge
 ┃ ┃ ┣ 📂Door
 ┃ ┃ ┗ 📜Gate.cs
 ┃ ┣ 📂Key
 ┃ ┃ ┣ 📂KeyCard
 ┃ ┃ ┃ ┣ 📜KeyCard.png
 ┃ ┃ ┃ ┗ 📜KeyCard.png.import
 ┃ ┃ ┣ 📂SkeletonKey
 ┃ ┃ ┃ ┣ 📜SkeletonKey.png
 ┃ ┃ ┃ ┗ 📜SkeletonKey.png.import
 ┃ ┃ ┗ 📜Key.cs
 ┃ ┣ 📂Obstacle
 ┃ ┃ ┣ 📂Crate
 ┃ ┃ ┃ ┣ 📜Crate.png
 ┃ ┃ ┃ ┗ 📜Crate.png.import
 ┃ ┃ ┣ 📂Rock
 ┃ ┃ ┃ ┣ 📜Rock.png
 ┃ ┃ ┃ ┗ 📜Rock.png.import
 ┃ ┃ ┗ 📜Obstacle.cs
 ┃ ┣ 📂Shrine
 ┃ ┃ ┣ 📜Shrine.cs
 ┃ ┃ ┣ 📜Shrine.png
 ┃ ┃ ┣ 📜Shrine.png.import
 ┃ ┃ ┗ 📜Shrine.tscn
 ┃ ┗ 📂Switch
 ┃ ┃ ┣ 📂Button
 ┃ ┃ ┃ ┣ 📜Button.png
 ┃ ┃ ┃ ┗ 📜Button.png.import
 ┃ ┃ ┣ 📂Lever
 ┃ ┃ ┃ ┣ 📜Lever.png
 ┃ ┃ ┃ ┗ 📜Lever.png.import
 ┃ ┃ ┗ 📜Switch.cs
 ┣ 📂UI
 ┃ ┣ 📜HUD.cs
 ┃ ┗ 📜HUD.tscn
 ┣ 📂World
 ┃ ┣ 📂Bootsplash
 ┃ ┃ ┣ 📜Bootsplash.png
 ┃ ┃ ┗ 📜Bootsplash.png.import
 ┃ ┣ 📂Icon
 ┃ ┃ ┣ 📜icon.ico
 ┃ ┃ ┣ 📜icon.png
 ┃ ┃ ┗ 📜icon.png.import
 ┃ ┣ 📂Level
 ┃ ┃ ┣ 📜LevelOne.tscn
 ┃ ┃ ┗ 📜Sandbox.tscn
 ┃ ┣ 📂Tile
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
 ┣ 📜export_presets.cfg
 ┣ 📜Game.cs
 ┣ 📜LICENSE
 ┣ 📜mvmxix.csproj
 ┣ 📜mvmxix.sln
 ┣ 📜project.godot
 ┗ 📜README.md
```
