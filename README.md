# MVMXIX

- [MVMXIX](#mvmxix)
  - [Controls](#controls)
  - [Style Guide](#style-guide)
  - [Resources](#resources)
  - [Filetree](#filetree)

## Controls

<!-- NOTE: Can add images from UI/Input folder if useful -->

Action | Keyboard | Xbox | PlayStation | Nintendo
|---|---|---|---|---|
Up | W, Up Arrow | Left Stick Up | Left Stick Up | Left Stick Up
Down | S, Down Arrow | Left Stick Down | Left Stick Down | Left Stick Down
Left | A, Left Arrow | Left Stick Left | Left Stick Left | Left Stick Left
Right | D, Right Arrow | Left Stick Right | Left Stick Right | Left Stick Right
Jump | Space | A | Cross | B
Special | Q | B | Circle | A
Attack | Shift | X | Square | Y
Interact | F | Y | Triangle | X
Pause | P, Escape | Start | Options | Plus
Accept (Select) | Enter, Space | A | Cross | B
Back (Cancel) | Escape, Backspace | B | Circle | A
Select Sneak | 1 | D-Pad Left | D-Pad Left | D-Pad Left
Select Heavy | 2 | D-Pad Up | D-Pad Up | D-Pad Up
Select Tiny | 3 | D-Pad Right | D-Pad Right | D-Pad Right

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

- [Moving Rainbow Gradient - Godot Shaders](https://godotshaders.com/shader/moving-rainbow-gradient/)
- [Stars shader - Godot Shaders](https://godotshaders.com/shader/stars-shader/)
- [Xelu's FREE Controller Prompts](https://thoseawesomeguys.com/prompts/)

## Filetree

```txt
📦mvmxix
 ┣ 📂Actor
 ┃ ┣ 📂Enemy
 ┃ ┃ ┣ 📂FlyingEnemy
 ┃ ┃ ┃ ┣ 📜FlyingEnemy.cs
 ┃ ┃ ┃ ┣ 📜FlyingEnemy.png
 ┃ ┃ ┃ ┗ 📜FlyingEnemy.tscn
 ┃ ┃ ┣ 📂GroundEnemy
 ┃ ┃ ┃ ┣ 📜GroundEnemy.cs
 ┃ ┃ ┃ ┣ 📜GroundEnemy.png
 ┃ ┃ ┃ ┗ 📜GroundEnemy.tscn
 ┃ ┃ ┗ 📜Enemy.cs
 ┃ ┣ 📂NPC
 ┃ ┃ ┣ 📂Dude
 ┃ ┃ ┃ ┣ 📜Dude.cs
 ┃ ┃ ┃ ┣ 📜Dude.png
 ┃ ┃ ┃ ┗ 📜Dude.tscn
 ┃ ┃ ┣ 📂ToastGuy
 ┃ ┃ ┃ ┣ 📜ToastGuy.cs
 ┃ ┃ ┃ ┣ 📜ToastGuy.png
 ┃ ┃ ┃ ┗ 📜ToastGuy.tscn
 ┃ ┃ ┗ 📜NPC.cs
 ┃ ┣ 📂Player
 ┃ ┃ ┣ 📂Heavy
 ┃ ┃ ┃ ┣ 📜Heavy.cs
 ┃ ┃ ┃ ┣ 📜Heavy.png
 ┃ ┃ ┃ ┗ 📜Heavy.tscn
 ┃ ┃ ┣ 📂Sneak
 ┃ ┃ ┃ ┣ 📜Sneak.cs
 ┃ ┃ ┃ ┣ 📜Sneak.png
 ┃ ┃ ┃ ┗ 📜Sneak.tscn
 ┃ ┃ ┣ 📂Sneak2
 ┃ ┃ ┃ ┣ 📜Sneak2.cs
 ┃ ┃ ┃ ┣ 📜Sneak2.png
 ┃ ┃ ┃ ┗ 📜Sneak2.tscn
 ┃ ┃ ┣ 📂Tiny
 ┃ ┃ ┃ ┣ 📜Tiny.cs
 ┃ ┃ ┃ ┣ 📜Tiny.png
 ┃ ┃ ┃ ┗ 📜Tiny.tscn
 ┃ ┃ ┣ 📜Player.cs
 ┃ ┃ ┗ 📜Player.gdshader
 ┃ ┗ 📜Actor.cs
 ┣ 📂Audio
 ┃ ┣ 📜Fantasy_Game_Action_Door_Close.wav
 ┃ ┣ 📜Fantasy_Game_Action_Door_Open.wav
 ┃ ┣ 📜Fantasy_Game_Attack_Cloth_Armor_Hit_A.wav
 ┃ ┣ 📜Fantasy_Game_Attack_Cloth_Armor_Hit_B.wav
 ┃ ┣ 📜Fantasy_Game_Attack_Creature_High_B.wav
 ┃ ┣ 📜Fantasy_Game_Crafting_Material_Liquid_Deep_Hit_1.wav
 ┃ ┣ 📜Fantasy_Game_Crafting_Select_Gem.wav
 ┃ ┣ 📜Fantasy_Game_Crafting_Smelting_A.wav
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_D.wav
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_E.wav
 ┃ ┣ 📜Fantasy_Game_Footstep_Grass_Heavy_F.wav
 ┃ ┣ 📜Fantasy_Game_Item_Crafting_Sword_A.wav
 ┃ ┣ 📜Fantasy_Game_Loops_Crystal_1_Light_Hum_Ambience_Magical.wav
 ┃ ┣ 📜Fantasy_Game_UI_Organic_Magic_Accept_Quest_Drum_Impact_1.wav
 ┃ ┣ 📜Fantasy_Game_UI_Organic_Magic_Accept_Quest_Drum_Impact_2.wav
 ┃ ┣ 📜Puzzle_Game_Accent_Bubble_01.wav
 ┃ ┣ 📜Puzzle_Game_Accent_Chatter_01.wav
 ┃ ┣ 📜Puzzle_Game_Accent_Chatter_02.wav
 ┃ ┣ 📜Puzzle_Game_Achievement_01.wav
 ┃ ┣ 📜Puzzle_Game_Break_Magic_01.wav
 ┃ ┣ 📜Puzzle_Game_Break_Magic_05.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_01.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_02.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_03.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_04.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_05.wav
 ┃ ┣ 📜Puzzle_Game_Collectible_Small_06.wav
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_1.wav
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_2.wav
 ┃ ┣ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_3_App_Click.wav
 ┃ ┗ 📜Puzzle_Game_Organic_Wood_Block_Tone_Tap_4_App_Click.wav
 ┣ 📂Entity
 ┃ ┣ 📂OnOffBlock
 ┃ ┃ ┗ 📜OnOffBlock.tscn
 ┃ ┣ 📂PhysicsBlock
 ┃ ┃ ┗ 📜PhysicsBlock.tscn
 ┃ ┗ 📂Pickup
 ┃ ┃ ┣ 📜KeyPickup.cs
 ┃ ┃ ┣ 📜KeyPickup.tscn
 ┃ ┃ ┣ 📜PowerupPickup.cs
 ┃ ┃ ┗ 📜PowerupPickup.tscn
 ┣ 📂Item
 ┃ ┣ 📂Gate
 ┃ ┃ ┣ 📂Bridge
 ┃ ┃ ┃ ┣ 📜Bridge.cs
 ┃ ┃ ┃ ┣ 📜Bridge.png
 ┃ ┃ ┃ ┗ 📜Bridge.tscn
 ┃ ┃ ┗ 📂Door
 ┃ ┃ ┃ ┣ 📜Door.cs
 ┃ ┃ ┃ ┣ 📜Door.png
 ┃ ┃ ┃ ┗ 📜Door.tscn
 ┃ ┣ 📂Key
 ┃ ┃ ┣ 📂KeyCard
 ┃ ┃ ┃ ┗ 📜KeyCard.png
 ┃ ┃ ┣ 📂SkeletonKey
 ┃ ┃ ┃ ┗ 📜SkeletonKey.png
 ┃ ┃ ┗ 📜Key.cs
 ┃ ┣ 📂Obstacle
 ┃ ┃ ┣ 📂Crate
 ┃ ┃ ┃ ┗ 📜Crate.png
 ┃ ┃ ┣ 📂Rock
 ┃ ┃ ┃ ┗ 📜Rock.png
 ┃ ┃ ┗ 📜Obstacle.cs
 ┃ ┣ 📂Shrine
 ┃ ┃ ┣ 📜Shrine.cs
 ┃ ┃ ┣ 📜Shrine.png
 ┃ ┃ ┗ 📜Shrine.tscn
 ┃ ┗ 📂Switch
 ┃ ┃ ┣ 📂Button
 ┃ ┃ ┃ ┗ 📜Button.png
 ┃ ┃ ┣ 📂Lever
 ┃ ┃ ┃ ┗ 📜Lever.png
 ┃ ┃ ┗ 📜Switch.cs
 ┣ 📂UI
 ┃ ┣ 📂Input
 ┃ ┃ ┣ 📜KBM_0_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_0_Key_Light.png
 ┃ ┃ ┣ 📜KBM_10_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_10_Key_Light.png
 ┃ ┃ ┣ 📜KBM_11_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_11_Key_Light.png
 ┃ ┃ ┣ 📜KBM_12_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_12_Key_Light.png
 ┃ ┃ ┣ 📜KBM_1_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_1_Key_Light.png
 ┃ ┃ ┣ 📜KBM_2_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_2_Key_Light.png
 ┃ ┃ ┣ 📜KBM_3_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_3_Key_Light.png
 ┃ ┃ ┣ 📜KBM_4_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_4_Key_Light.png
 ┃ ┃ ┣ 📜KBM_5_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_5_Key_Light.png
 ┃ ┃ ┣ 📜KBM_6_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_6_Key_Light.png
 ┃ ┃ ┣ 📜KBM_7_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_7_Key_Light.png
 ┃ ┃ ┣ 📜KBM_8_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_8_Key_Light.png
 ┃ ┃ ┣ 📜KBM_9_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_9_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Alt_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Alt_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Arrow_Down_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Arrow_Down_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Arrow_Left_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Arrow_Left_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Arrow_Right_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Arrow_Right_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Arrow_Up_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Arrow_Up_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Asterisk_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Asterisk_Key_Light.png
 ┃ ┃ ┣ 📜KBM_A_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_A_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Backspace_Alt_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Backspace_Alt_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Backspace_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Backspace_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Bracket_Left_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Bracket_Left_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Bracket_Right_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Bracket_Right_Key_Light.png
 ┃ ┃ ┣ 📜KBM_B_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_B_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Caps_Lock_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Caps_Lock_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Command_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Command_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Ctrl_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Ctrl_Key_Light.png
 ┃ ┃ ┣ 📜KBM_C_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_C_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Del_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Del_Key_Light.png
 ┃ ┃ ┣ 📜KBM_D_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_D_Key_Light.png
 ┃ ┃ ┣ 📜KBM_End_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_End_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Enter_Alt_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Enter_Alt_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Enter_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Enter_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Enter_Tall_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Enter_Tall_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Esc_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Esc_Key_Light.png
 ┃ ┃ ┣ 📜KBM_E_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_E_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F10_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F10_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F11_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F11_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F12_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F12_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F1_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F1_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F2_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F2_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F3_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F3_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F4_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F4_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F5_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F5_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F6_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F6_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F7_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F7_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F8_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F8_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F9_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F9_Key_Light.png
 ┃ ┃ ┣ 📜KBM_F_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_F_Key_Light.png
 ┃ ┃ ┣ 📜KBM_G_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_G_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Home_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Home_Key_Light.png
 ┃ ┃ ┣ 📜KBM_H_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_H_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Insert_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Insert_Key_Light.png
 ┃ ┃ ┣ 📜KBM_I_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_I_Key_Light.png
 ┃ ┃ ┣ 📜KBM_J_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_J_Key_Light.png
 ┃ ┃ ┣ 📜KBM_K_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_K_Key_Light.png
 ┃ ┃ ┣ 📜KBM_L_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_L_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Mark_Left_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Mark_Left_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Mark_Right_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Mark_Right_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Minus_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Minus_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Mouse_Left_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Mouse_Left_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Mouse_Middle_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Mouse_Middle_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Mouse_Right_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Mouse_Right_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Mouse_Simple_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Mouse_Simple_Key_Light.png
 ┃ ┃ ┣ 📜KBM_M_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_M_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Num_Lock_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Num_Lock_Key_Light.png
 ┃ ┃ ┣ 📜KBM_N_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_N_Key_Light.png
 ┃ ┃ ┣ 📜KBM_O_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_O_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Page_Down_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Page_Down_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Page_Up_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Page_Up_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Plus_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Plus_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Plus_Tall_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Plus_Tall_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Print_Screen_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Print_Screen_Key_Light.png
 ┃ ┃ ┣ 📜KBM_P_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_P_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Question_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Question_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Quote_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Quote_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Q_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Q_Key_Light.png
 ┃ ┃ ┣ 📜KBM_R_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_R_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Semicolon_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Semicolon_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Shift_Alt_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Shift_Alt_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Shift_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Shift_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Slash_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Slash_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Space_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Space_Key_Light.png
 ┃ ┃ ┣ 📜KBM_S_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_S_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Tab_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Tab_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Tilda_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Tilda_Key_Light.png
 ┃ ┃ ┣ 📜KBM_T_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_T_Key_Light.png
 ┃ ┃ ┣ 📜KBM_U_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_U_Key_Light.png
 ┃ ┃ ┣ 📜KBM_V_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_V_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Win_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Win_Key_Light.png
 ┃ ┃ ┣ 📜KBM_W_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_W_Key_Light.png
 ┃ ┃ ┣ 📜KBM_X_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_X_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Y_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Y_Key_Light.png
 ┃ ┃ ┣ 📜KBM_Z_Key_Dark.png
 ┃ ┃ ┣ 📜KBM_Z_Key_Light.png
 ┃ ┃ ┣ 📜PS5_Circle.png
 ┃ ┃ ┣ 📜PS5_Cross.png
 ┃ ┃ ┣ 📜PS5_Diagram.png
 ┃ ┃ ┣ 📜PS5_Diagram_Simple.png
 ┃ ┃ ┣ 📜PS5_Dpad.png
 ┃ ┃ ┣ 📜PS5_Dpad_Down.png
 ┃ ┃ ┣ 📜PS5_Dpad_Left.png
 ┃ ┃ ┣ 📜PS5_Dpad_Right.png
 ┃ ┃ ┣ 📜PS5_Dpad_Up.png
 ┃ ┃ ┣ 📜PS5_L1.png
 ┃ ┃ ┣ 📜PS5_L2.png
 ┃ ┃ ┣ 📜PS5_Left_Stick.png
 ┃ ┃ ┣ 📜PS5_Left_Stick_Click.png
 ┃ ┃ ┣ 📜PS5_Microphone.png
 ┃ ┃ ┣ 📜PS5_Options.png
 ┃ ┃ ┣ 📜PS5_Options_Alt.png
 ┃ ┃ ┣ 📜PS5_R1.png
 ┃ ┃ ┣ 📜PS5_R2.png
 ┃ ┃ ┣ 📜PS5_Right_Stick.png
 ┃ ┃ ┣ 📜PS5_Right_Stick_Click.png
 ┃ ┃ ┣ 📜PS5_Share.png
 ┃ ┃ ┣ 📜PS5_Share_Alt.png
 ┃ ┃ ┣ 📜PS5_Square.png
 ┃ ┃ ┣ 📜PS5_Touch_Pad.png
 ┃ ┃ ┣ 📜PS5_Triangle.png
 ┃ ┃ ┣ 📜SteamDeck_A.png
 ┃ ┃ ┣ 📜SteamDeck_B.png
 ┃ ┃ ┣ 📜SteamDeck_Dots.png
 ┃ ┃ ┣ 📜SteamDeck_Dpad.png
 ┃ ┃ ┣ 📜SteamDeck_Dpad_Down.png
 ┃ ┃ ┣ 📜SteamDeck_Dpad_Left.png
 ┃ ┃ ┣ 📜SteamDeck_Dpad_Right.png
 ┃ ┃ ┣ 📜SteamDeck_Dpad_Up.png
 ┃ ┃ ┣ 📜SteamDeck_Gyro.png
 ┃ ┃ ┣ 📜SteamDeck_L1.png
 ┃ ┃ ┣ 📜SteamDeck_L2.png
 ┃ ┃ ┣ 📜SteamDeck_L4.png
 ┃ ┃ ┣ 📜SteamDeck_L5.png
 ┃ ┃ ┣ 📜SteamDeck_Left_Stick.png
 ┃ ┃ ┣ 📜SteamDeck_Left_Stick_Click.png
 ┃ ┃ ┣ 📜SteamDeck_Left_Track.png
 ┃ ┃ ┣ 📜SteamDeck_Menu.png
 ┃ ┃ ┣ 📜SteamDeck_Minus.png
 ┃ ┃ ┣ 📜SteamDeck_Plus.png
 ┃ ┃ ┣ 📜SteamDeck_Power.png
 ┃ ┃ ┣ 📜SteamDeck_R1.png
 ┃ ┃ ┣ 📜SteamDeck_R2.png
 ┃ ┃ ┣ 📜SteamDeck_R4.png
 ┃ ┃ ┣ 📜SteamDeck_R5.png
 ┃ ┃ ┣ 📜SteamDeck_Right_Stick.png
 ┃ ┃ ┣ 📜SteamDeck_Right_Stick_Click.png
 ┃ ┃ ┣ 📜SteamDeck_Right_Track.png
 ┃ ┃ ┣ 📜SteamDeck_Square.png
 ┃ ┃ ┣ 📜SteamDeck_Steam.png
 ┃ ┃ ┣ 📜SteamDeck_X.png
 ┃ ┃ ┣ 📜SteamDeck_Y.png
 ┃ ┃ ┣ 📜Switch_A.png
 ┃ ┃ ┣ 📜Switch_B.png
 ┃ ┃ ┣ 📜Switch_Controllers.png
 ┃ ┃ ┣ 📜Switch_Controllers_Separate.png
 ┃ ┃ ┣ 📜Switch_Controller_Left.png
 ┃ ┃ ┣ 📜Switch_Controller_Right.png
 ┃ ┃ ┣ 📜Switch_Down.png
 ┃ ┃ ┣ 📜Switch_Dpad.png
 ┃ ┃ ┣ 📜Switch_Dpad_Down.png
 ┃ ┃ ┣ 📜Switch_Dpad_Left.png
 ┃ ┃ ┣ 📜Switch_Dpad_Right.png
 ┃ ┃ ┣ 📜Switch_Dpad_Up.png
 ┃ ┃ ┣ 📜Switch_Home.png
 ┃ ┃ ┣ 📜Switch_LB.png
 ┃ ┃ ┣ 📜Switch_Left.png
 ┃ ┃ ┣ 📜Switch_Left_Stick.png
 ┃ ┃ ┣ 📜Switch_LT.png
 ┃ ┃ ┣ 📜Switch_Minus.png
 ┃ ┃ ┣ 📜Switch_Plus.png
 ┃ ┃ ┣ 📜Switch_RB.png
 ┃ ┃ ┣ 📜Switch_Right.png
 ┃ ┃ ┣ 📜Switch_Right_Stick.png
 ┃ ┃ ┣ 📜Switch_RT.png
 ┃ ┃ ┣ 📜Switch_Square.png
 ┃ ┃ ┣ 📜Switch_Up.png
 ┃ ┃ ┣ 📜Switch_X.png
 ┃ ┃ ┣ 📜Switch_Y.png
 ┃ ┃ ┣ 📜XboxSeriesX_A.png
 ┃ ┃ ┣ 📜XboxSeriesX_B.png
 ┃ ┃ ┣ 📜XboxSeriesX_Diagram.png
 ┃ ┃ ┣ 📜XboxSeriesX_Diagram_Simple.png
 ┃ ┃ ┣ 📜XboxSeriesX_Dpad.png
 ┃ ┃ ┣ 📜XboxSeriesX_Dpad_Down.png
 ┃ ┃ ┣ 📜XboxSeriesX_Dpad_Left.png
 ┃ ┃ ┣ 📜XboxSeriesX_Dpad_Right.png
 ┃ ┃ ┣ 📜XboxSeriesX_Dpad_Up.png
 ┃ ┃ ┣ 📜XboxSeriesX_LB.png
 ┃ ┃ ┣ 📜XboxSeriesX_Left_Stick.png
 ┃ ┃ ┣ 📜XboxSeriesX_Left_Stick_Click.png
 ┃ ┃ ┣ 📜XboxSeriesX_LT.png
 ┃ ┃ ┣ 📜XboxSeriesX_Menu.png
 ┃ ┃ ┣ 📜XboxSeriesX_RB.png
 ┃ ┃ ┣ 📜XboxSeriesX_Right_Stick.png
 ┃ ┃ ┣ 📜XboxSeriesX_Right_Stick_Click.png
 ┃ ┃ ┣ 📜XboxSeriesX_RT.png
 ┃ ┃ ┣ 📜XboxSeriesX_Share.png
 ┃ ┃ ┣ 📜XboxSeriesX_View.png
 ┃ ┃ ┣ 📜XboxSeriesX_X.png
 ┃ ┃ ┗ 📜XboxSeriesX_Y.png
 ┃ ┣ 📜HUD.cs
 ┃ ┗ 📜HUD.tscn
 ┣ 📂World
 ┃ ┣ 📂Bootsplash
 ┃ ┃ ┗ 📜Bootsplash.png
 ┃ ┣ 📂Icon
 ┃ ┃ ┣ 📜icon.ico
 ┃ ┃ ┗ 📜icon.png
 ┃ ┣ 📂Level
 ┃ ┃ ┣ 📜LevelOne.tscn
 ┃ ┃ ┗ 📜Sandbox.tscn
 ┃ ┣ 📂Tile
 ┃ ┃ ┣ 📜TileBottomLeft.png
 ┃ ┃ ┣ 📜TileBottomRight.png
 ┃ ┃ ┣ 📜TileCenter.png
 ┃ ┃ ┣ 📜TileSet.tres
 ┃ ┃ ┣ 📜TileTopLeft.png
 ┃ ┃ ┗ 📜TileTopRight.png
 ┃ ┣ 📜Background.gdshader
 ┃ ┣ 📜World.cs
 ┃ ┗ 📜World.tscn
 ┣ 📜.gitignore
 ┣ 📜default_env.tres
 ┣ 📜Game.cs
 ┣ 📜LICENSE
 ┣ 📜MainCam.cs
 ┣ 📜MainCam.gd
 ┣ 📜mvmxix.csproj
 ┣ 📜mvmxix.sln
 ┣ 📜OneScreenTile.png
 ┣ 📜project.godot
 ┣ 📜README.md
 ┣ 📜TestLevel.cs
 ┗ 📜TestLevel.tscn
```
