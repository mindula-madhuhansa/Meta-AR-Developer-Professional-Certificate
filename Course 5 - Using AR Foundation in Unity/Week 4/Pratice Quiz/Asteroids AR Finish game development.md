1. Which two states did you use to create the UFO? Select all that apply.

   - [x] **Attacking**
     > The two states you used were **idle** and **attacking**. Because the UFO was attacking the shooter, you used the **attacking** state to tell the UFO when to appear and start shooting at the player.
   - [ ] UFO
   - [ ] Cooldown
   - [x] **Idle**
     > The two states you used were **idle** and **attacking**. You used **idle** when the UFO either died or was waiting to respawn.

2. By adding the Die() function to the On Zero Health event, the UFO disappears and the mystery box shows up on screen. Select the best answer.

   - [x] **True**
   - [ ] False
     > When the UFO dies, the mystery box shows up on screen because you added the **Die()** function to the On Zero Health event.

3. To add sound to the game, you need to create C# code to play the audio files and attach this script to a scriptable object. Select the best answer.

   - [x] **True**
   - [ ] False
     > To add sound to the game, you need to create a small block of C# code to play the audio files and attach that script to the appropriate scriptable objects.

4. Fill in the blank. You add an explosion visual effect that is triggered when the UFO takes damage and its health trickles down to 0%. For this visual effect to work, make sure the .......................... box is checked. Select the best answer.

   - [ ] Game view
   - [x] **Sphere Collider**
   - [ ] TextMeshPro
   - [ ] Prefab
     > The **Sphere Collider** box must be checked in order for the visual effect to show the explosion when the UFO’s health trickles down to 0%.

5. Which field will communicate with the GameState.cs script to increase the shooter’s score if they destroy a UFO or asteroid? Select the best answer.

   - [ ] GameState
   - [ ] AddScore
   - [ ] IncreaseScore
   - [x] **OnIncreaseScore**
     > The **OnIncreaseScore** field will communicate with the GameState.cs script to increase the shooter’s score if they destroy a UFO or asteroid.
