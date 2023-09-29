1. When you create a new project using the AR Core template, by default the Plane Manager and Anchor Manager are enabled in the AR Session Origin. Select the best answer.

   - [x] **True**
   - [ ] False
     > It’s important to review the features that are activated by default in the AR Session Origin.

2. Without inheriting MonoBehaviour, you can’t use methods such as Instantiate or Transform. Select the best answer.

   - [x] **True**
   - [ ] False
     > When you’re using methods in your game, remember the importance of MonoBehaviour.

3. According to the game design document, what happens when a large asteroid's health reaches zero in the game? Select the best answer.

   - [ ] The game speed increases.
   - [x] **Two medium-sized asteroids are created**
   - [ ] Another large asteroid is created.
   - [ ] The player's health increases.
     > When a large asteroid's health reaches zero, the game score is updated and two medium-sized asteroids are created. The asteroid GameObject is also removed from the game instance.

4. Select all that apply to fill in the blanks. The primary purpose of the SpawnColliderArea.cs script in the Asteroids AR project is to ............................., ......................... and ............................ .

   - [x] **instantiate the asteroid prefab clones**
     > It also controls the area where the asteroids will randomly spawn and sets the collider bounds to a random range.
   - [ ] rotate the asteroids toward the planet GameObject
   - [x] **control the area where the asteroids will randomly spawn**
     > It also sets the collider bounds to a random range and instantiates the asteroid prefab clones.
   - [x] **set the collider bounds to a random range**
     > It also controls the area where the asteroids will randomly spawn and instantiates the asteroid prefab clones.

5. In the Asteroids AR project, the MoveForward.cs script uses the Update method to multiply the \_MyTransform vector by \_moveSpeed and deltaTime, which translates to a move speed per second. Select the best answer.

   - [x] **True**
   - [ ] False
     > A higher move speed results in a faster asteroid.

6. Select the best answer to fill in the blank. To remove an asteroid from the game instance, you created a Destroy Object (Script) that uses the ................................ method.

   - [ ] SerializeField
   - [x] **Object.Destroy**
   - [ ] Unity.Engine
   - [ ] GameObject
     > In Unity, the Object.Destroy method is used to remove a GameObject, component, or asset from the game instance.

7. In the Asteroids AR game, the Player.cs script uses the Input.GetMouseButtonDown() method to detect when the player taps the screen and subsequently triggers the shooting event. Select the best answer.

   - [x] **True**
   - [ ] False
     > The Player.cs script uses the Input.GetMouseButtonDown method to detect when the player taps the screen, as it is a convenient and easy way to handle input for both touch devices and desktop systems. This method returns true in the frame when the player's primary input (mouse left-click or touch) is initially pressed. By using this method, the script can easily trigger the shooting event in response to the player's input.

8. Select the best answer to fill in the blank. In the Asteroids AR game, to enable collisions and triggers between objects, a ........................... component is added along with a collider.

   - [ ] Physicsbody
   - [ ] Collisiondetector
   - [ ] Forcecomponent
   - [x] **Rigidbody**
     > The Rigidbody component is added to the objects along with a collider to enable collisions and triggers. This allows the Unity physics engine to simulate interactions between objects.

9. Which of the following colliders are used in the Asteroids AR game? Select all that apply.

   - [x] **Capsule Collider**
     > The capsule collider was chosen for the player bullet based on the shapes of the GameObject. This collider, in combination with the Rigidbody, is used to enable physics simulation and collision detection in the game.
   - [ ] Mesh Collider
   - [x] **Sphere Collider**
     > The sphere collider was chosen for the asteroids based on the shapes of the GameObjects. The collider, in combination with the Rigidbody, is used to enable physics simulation and collision detection in the game.
   - [ ] Box Collider

10. Using a game state in the Asteroids AR game provides a more dynamic game experience. Select the best answer.

    - [x] **True**
    - [ ] False
      > Using a game state enables the Asteroids AR game to change based on the player's actions and progress, providing a more engaging and immersive AR experience.
