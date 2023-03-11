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
 ┣ 📂Audio
 ┃ ┣ 📜Fantasy_Game_Action_Door_Close.wav
 ┃ ┣ 📜Fantasy_Game_Action_Door_Close.wav.import
 ┃ ┣ 📜Fantasy_Game_Action_Door_Open.wav
 ┃ ┣ 📜Fantasy_Game_Action_Door_Open.wav.import
 ┃ ┣ 📜Fantasy_Game_Attack_Cloth_Armor_Hit_A.wav
 ┃ ┣ 📜Fantasy_Game_Attack_Cloth_Armor_Hit_A.wav.import
 ┃ ┣ 📜Fantasy_Game_Attack_Cloth_Armor_Hit_B.wav
 ┃ ┣ 📜Fantasy_Game_Attack_Cloth_Armor_Hit_B.wav.import
 ┃ ┣ 📜Fantasy_Game_Attack_Creature_High_B.wav
 ┃ ┣ 📜Fantasy_Game_Attack_Creature_High_B.wav.import
 ┃ ┣ 📜Fantasy_Game_Crafting_Material_Liquid_Deep_Hit_1.wav
 ┃ ┣ 📜Fantasy_Game_Crafting_Material_Liquid_Deep_Hit_1.wav.import
 ┃ ┣ 📜Fantasy_Game_Crafting_Select_Gem.wav
 ┃ ┣ 📜Fantasy_Game_Crafting_Select_Gem.wav.import
 ┃ ┣ 📜Fantasy_Game_Crafting_Smelting_A.wav
 ┃ ┣ 📜Fantasy_Game_Crafting_Smelting_A.wav.import
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_D.wav
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_D.wav.import
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_E.wav
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_E.wav.import
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_F.wav
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_F.wav.import
 ┃ ┣ 📜Fantasy_Game_Item_Crafting_Sword_A.wav
 ┃ ┣ 📜Fantasy_Game_Item_Crafting_Sword_A.wav.import
 ┃ ┣ 📜Fantasy_Game_Loops_Crystal_1_Light_Hum_Ambience_Magical.wav
 ┃ ┣ 📜Fantasy_Game_Loops_Crystal_1_Light_Hum_Ambience_Magical.wav.import
 ┃ ┣ 📜Fantasy_Game_UI_Organic_Magic_Accept_Quest_Drum_Impact_1.wav
 ┃ ┣ 📜Fantasy_Game_UI_Organic_Magic_Accept_Quest_Drum_Impact_1.wav.import
 ┃ ┣ 📜Fantasy_Game_UI_Organic_Magic_Accept_Quest_Drum_Impact_2.wav
 ┃ ┣ 📜Fantasy_Game_UI_Organic_Magic_Accept_Quest_Drum_Impact_2.wav.import
 ┃ ┣ 📜Puzzle_Game_Accent_Bubble_01.wav
 ┃ ┣ 📜Puzzle_Game_Accent_Bubble_01.wav.import
 ┃ ┣ 📜Puzzle_Game_Accent_Chatter_01.wav
 ┃ ┣ 📜Puzzle_Game_Accent_Chatter_01.wav.import
 ┃ ┣ 📜Puzzle_Game_Accent_Chatter_02.wav
 ┃ ┣ 📜Puzzle_Game_Accent_Chatter_02.wav.import
 ┃ ┣ 📜Puzzle_Game_Achievement_01.wav
 ┃ ┣ 📜Puzzle_Game_Achievement_01.wav.import
 ┃ ┣ 📜Puzzle_Game_Break_Magic_01.wav
 ┃ ┣ 📜Puzzle_Game_Break_Magic_01.wav.import
 ┃ ┣ 📜Puzzle_Game_Break_Magic_05.wav
 ┃ ┣ 📜Puzzle_Game_Break_Magic_05.wav.import
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_01.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_01.wav.import
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_02.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_02.wav.import
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_03.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_03.wav.import
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_04.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_04.wav.import
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_05.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_05.wav.import
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_06.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_06.wav.import
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_1.wav
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_1.wav.import
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_2.wav
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_2.wav.import
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_3_App_Click.wav
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_3_App_Click.wav.import
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_4_App_Click.wav
 ┃ ┗ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_4_App_Click.wav.import
 ┣ 📂Item
 ┃ ┣ 📂Gate
 ┃ ┃ ┣ 📂Bridge
 ┃ ┃ ┃ ┣ 📜Bridge.cs
 ┃ ┃ ┃ ┣ 📜Bridge.png
 ┃ ┃ ┃ ┣ 📜Bridge.png.import
 ┃ ┃ ┃ ┗ 📜Bridge.tscn
 ┃ ┃ ┗ 📂Door
 ┃ ┃ ┃ ┣ 📜Door.cs
 ┃ ┃ ┃ ┣ 📜Door.png
 ┃ ┃ ┃ ┣ 📜Door.png.import
 ┃ ┃ ┃ ┗ 📜Door.tscn
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
 ┣ 📜MainCam.cs
 ┣ 📜MainCam.gd
 ┣ 📜mvmxix.csproj
 ┣ 📜mvmxix.sln
 ┣ 📜OneScreenTile.png
 ┣ 📜OneScreenTile.png.import
 ┣ 📜project.godot
 ┣ 📜README.md
 ┣ 📜TestLevel.cs
 ┗ 📜TestLevel.tscn
```
