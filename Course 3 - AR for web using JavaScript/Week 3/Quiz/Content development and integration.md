1. PlayCanvas developed an AR starter kit that can be used as a base for AR projects. Which of the following assets does the start kit contain? Select all that apply.

   - [ ] JavaScript code for the three primary 3D interactions
   - [x] **An initial scene with a camera and light**
   - [ ] A sample game design document
   - [x] **A basic 3D object**
     > The AR starter kit contains an initial scene with a camera and light, a marker and a 3D object.

2. Which of the following PlayCanvas rendering settings should be reconfigured based on the requirements of your app? Select all that apply.

   - [ ] Lightmapping
   - [x] **Tonemapping**
   - [x] **Ambient Color**
   - [ ] Physics Gravity
     > The rendering settings you will most likely reconfigure are Ambient Color, Tonemapping, Exposure, Gamma Correction and Fog. There are also other non-rendering settings that may need to be adjusted.

3. What type of code defines the structure of the user interface? Select the best answer.

   - [x] **HTML code**
   - [ ] JavaScript code
   - [ ] C+ code
   - [ ] Design code
     > Web AR apps use HTML along with CSS to build a more robust user interface — the HTML code defines the structure of the user interface.

4. Complete this sentence. You can better manage assets efficiently in an AR app scene by .................................. . Select all that apply.

   - [x] **tagging them so they will be loaded at the right time**
   - [ ] unloading then reloading assets whenever your change scenes
   - [x] **disabling Preload for large assets to reduce memory requirements**
   - [ ] loading larger assets first so they are available when you need them
     > To use memory more efficiently, disable the preload for large assets and tag your assets so they will be loaded at the right time.

5. Complete this sentence. To use 3D assets in PlayCanvas you need to ................................. . Select the best answer.

   - [ ] use sprite and texture atlases
   - [x] **upload them**
   - [ ] fork the PlayCanvas 3D applications starter kit
   - [ ] take 2D assets and add a 3D texture
     > You create animation assets using a 3D editing tool such as Blender then upload them to PlayCanvas.

6. What do the physics settings do in a PlayCanvas animation? Select the best answer.

   - [x] **Determine how objects and entities have in relation to each other**
   - [ ] Anchor objects and entities to the background of a scene
   - [ ] Enable PlayCanvas to “see” the animation commands in Javascript
   - [ ] This is a trick question. Physics is only used for character animation.
     > You need physics to manage how objects behave in relation to each other and to their environment.

7. What kinds of user input are JavaScript events for the PlayCanvas engine? Select all that apply.

   - [ ] Bluetooth device input
   - [x] **Mouse input**
   - [ ] Voice recognition input
   - [x] **Keyboard input**
     > User input can be coded for touchscreen, mouse and keyboard.

8. When you launch an app with mini stats check, which stat tells you the number of rendered objects in every frame? Select the best answer.

   - [ ] CPU
   - [ ] Frame
   - [ ] GPU
   - [x] **Draw Calls**
     > raw Calls tells you the number of rendered objects dispatched in every frame — every draw call taxes the CPU and GPU.

9. What can you do to optimize graphics so you can improve the performance of your app? Select all that apply.

   - [x] **Reduce the number of shaders**
   - [x] **Batch**
   - [ ] Reduce the number of colors
   - [ ] Preload all the assets
     > You can optimize graphics by reducing the number of “draw” commands by batching, reducing the number of shaders and managing what the camera “sees” at any given point.

10. Which of the following AR components will you typically use most often when creating an AR app in PlayCanvas? Select all that apply.

    - [x] **Animation**
    - [x] **Lights**
    - [ ] Builds
    - [x] **Markers**
      > Some of the most often-used components for creating apps include the AR camera, lights, markers and animation. Depending on the type of app, this list could also include audio, HTML and CSS assets, 3D objects and UI components.
