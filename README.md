# Endeavor
Endeavor is an "Easy to use" Player-Controller set for Unity3D.

## About
Within this repository you will find a Folder named [Endeavor/](https://github.com/harroo/Endeavor/tree/main/Endeavor).
This folder contains a handful of C# Scripts that handle Player-Movement.

The `FirstPersonPlayerController` is completely polished and ready to use. You can adjust a few settings and configure it to your liking, enabling and disabling certain functionalities all within the Unity-Editor.

## Setup
Simply copy the [Endeavor/](https://github.com/harroo/Endeavor/tree/main/Endeavor) folder into your Unity-Project's Assets directory.

It's recommended that you put it under a folder named "Plugins" or "Dependencies" or something of the like.

## `FirstPersonPlayerController`
This component is preconfigured quit nicely, however you're welcome to adjust it so that it's perfect for your Game.

It's recommended that you set up the Game-Object like so:

![scrot0](https://raw.githubusercontent.com/harroo/Endeavor/main/Images/Layout.png)
![scrot1](https://raw.githubusercontent.com/harroo/Endeavor/main/Images/Player.png)
![scrot2](https://raw.githubusercontent.com/harroo/Endeavor/main/Images/Camera.png)

### "Control"
`Return Toggles Control`: This setting, when enabled, will allow the pressing of the Return-Key -- or Enter-Key -- to toggle the Cursor's Lock-State and visibility.
When the Cursor is visible, `Cursor.visible`, then the `FirstPersonPlayerController` will not function. This is designed for when using menus and such.
You can set the `Return Toggles Control` option to false and enable & disable the controller by toggling the Cursor yourself.
Like so:
```cs

// Toggles the Cursor's Lock-State and visibility.
public void ToggleCursor ( ) {

    Cursor.visible = !Cursor.visible ;

    Cursor.lockState = Cursor.visible
        ? CursorLockMode.None
        : CursorLockMode.Locked ;

}

// Locks the Cursor and disabled it's visibility.
public void LockCursor ( ) {

    Cursor.visible = false ;

    // Locks the Cursor to the center of the Screen.
    Cursor.lockState = CursorLockMode.Locked ;

}

// Enables the Cursor and it's visibility.
public void UnlockCursor ( ) {

    Cursor.visible = true ;

    // Releases the Cursor.
    Cursor.lockState = CursorLockMode.None ;

}
```
Feel free to copy these Methods as they may be useful.

### "Movement"
These are rather self-explanatory, but I shall do so regardless.

`Walk Speed`: The Speed at which the Player will move.

`Run Speed`: The Speed the Player will run at.

`Jump Height`: The Height at which the Player will jump.

`Gravity`: The downwards influence.

Now for the more specific options.

`Run In All Directions`: When this is enabled the Player will be able to run sideways and backwards, as apposed to only being able to run forwards.

**Note** You must set the Player Game-Object Layer to "Ignore Raycast". Otherwise it'll fall in an obscure manour. 

### "Looking"

`Sensitivity`: The mouse sensitivity.

`Head`: The Camera object attached to the player.

### "Camera Bobbing"

`Use Bobbing`: When disabled the Camera will not bob when the Player moves around.

`Bob Speed`: The speed at which the Camera shall bob.

`Intensity`: The intensity of the bobbing.

### "Camera FOV"

`Use Zoom`: When enabled, pressing C or the Middle-Mouse-Button will zoom the Camera in, like Optifine.

`Use Leaning`: When this is enabled, the Camera will zoom out slightly when the Player is running.

`Lean Amount`: The level to which the outward zoom will take place. `8` or `16` works rather well. See what you like!


## Others

At this point the other components in this Repository are not as superb and polished as the FirstPersonPlayerController, they're more of a base-line for you to create your own. If you do please feel free to contribute!


If you would like to contact me, https://discord.gg/feRRmykReU feel free to join.

---

Spelling and Orthography correction: [Kieralia](https://github.com/kieralia)
