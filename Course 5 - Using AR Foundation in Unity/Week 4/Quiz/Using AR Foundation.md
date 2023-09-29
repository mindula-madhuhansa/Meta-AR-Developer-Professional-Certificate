1. Select the best answer to fill in the blank: If you want to use AR Foundation in a project but you haven’t created the project using the AR template, you have to install AR Foundation from the ...................... before you can use it.

   - [ ] ARKit
   - [ ] Package Manager
   - [ ] GameObjects
   - [x] **AR Session Origin**
     > The AR Session Origin represents the device in space. When the user moves or rotates in the real world, the AR Session Origin moves accordingly in the Unity scene. And just like your real device has a camera, the AR Session Origin has the AR Camera GameObject attached to it.

2. Which SDK communicates with the AR framework and features of an Apple (iOS) device? Select the best answer.

   - [ ] AR Foundation
   - [x] **ARKit**
   - [ ] ARCore
   - [ ] XR Plug-In Management
     > ARKit is the SDK you would install to work with an Apple device.

3. You use Prefab Mode to adjust the position, rotation and scale of your model. Select the best answer.

   - [x] **True**
   - [ ] False
     > You use Prefab Mode to edit the position, rotation and scale of the mesh so that your model appears as you want it to appear in your app relative to your marker in the real world.

4. Which special kind of GameObject does Unity use to display 2D images for the user interface? Select the best answer.

   - [x] **Canvas**
   - [ ] TextMeshPro
   - [ ] Marker
   - [ ] Variable
     > Unity uses a special kind of GameObject called a canvas to display 2D images for the user interface.

5. What is useful to identify GameObjects for scripting purposes? Select the best answer.

   - [ ] GameObject
   - [ ] Nodes
   - [x] **Tags**
   - [ ] Mesh
     > Tags are useful to identify GameObjects for scripting purposes.

6. Select all that apply to fill in the blanks. Audio sources can control ....................., ........................ and ......................... settings.

   - [x] **volume**
     > Volume settings establish how loud the sound will be based on the length of one meter from the audio listener.
   - [ ] file location settings
   - [x] **priority**
     > Priority settings determine which audio sources are the highest and lowest priority.
   - [x] **spatial sound**
     > Spatial sounds are sound effects that you can add to 3D effects by making sounds louder when their sources are closer and softer when they are farther away.

7. Select all that apply to fill in the blanks. When you create a new project, there may be features activated that can affect the performance of your AR game. If not needed, you should deactivate the ....................... and .......................... to make your AR game less resource intensive.

   - [ ] AR Session Origin
   - [x] **Plane manager**
     > Plane detection automatically surfaces and adds some collision effects. Deactivating this feature can improve your player’s overall experience.
   - [ ] Visual Scripting
   - [x] **Anchor manager**
     > The anchor manager updates the position and orientation of anchors throughout its lifetime. Deactivating this feature can improve your player’s overall experience.

8. Select the best answer to fill in the blank. In the Asteroids AR game, the purpose of the Player.cs script is to ....................... .

   - [ ] manage the player's health
   - [ ] align the AR camera with the player’s AR device
   - [x] **handle user input for shooting bullets**
   - [ ] add to the Player’s score when a GameObject is destroyed
     > The Player.cs script is designed to handle user input, specifically the action of shooting bullets in the game. It uses the Input.GetMouseButtonDown function to detect when the player taps the screen then subsequently triggers the shooting event.

9. Select the best answer to fill in the blank. ......................... display editable fields in the Inspector view.

   - [x] **[SerializeFields]**
   - [ ] Functions
   - [ ] Game States
   - [ ] GameObjects
     > [SerializeFields] are coded in the C# script to display editable fields that are visible in the Inspector view.

10. Select the best answer to fill in the blank. By adding the ....................... function to the On Zero Health event, the UFO and the mystery box show up on screen.

    - [ ] ShowObject()
    - [ ] OnStartAttack()
    - [ ] OnStopAttack()
    - [x] **Die()**
      > By adding the Die() function and adding it to the On Zero Health event, the UFO and the mystery box shows up on screen.
