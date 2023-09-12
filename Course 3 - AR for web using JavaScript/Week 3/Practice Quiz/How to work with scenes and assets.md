1. Which section of the script do you edit to integrate and render your HTML and CSS assets in PlayCanvas? Select the best answer.

   - [x] **Initialize**.
   - [ ] Update.
     > The Initialize section is where the ui.js file uses JavaScript and a special web API called “document” to integrate the HTML and CSS assets so they can be rendered in PlayCanvas.

2. What are the three entities every PlayCanvas AR starter kit project should have? Select all that apply.

   - [x] **Light**
     > PlayCanvas preconfigures light for AR projects. This defines how light and shadows appear within your 3D environment.
   - [x] **AR camera**
     > PlayCanvas preconfigures the AR camera for AR projects. The AR camera calculates how the elements we create in PlayCanvas will appear in the physical world.
   - [x] **Pattern marker**
     > The pattern marker comes preloaded in your AR starter kit. It determines where to display virtual objects in your environment.
   - [ ] Script

3. The Audiolistener component determines how a sound is heard. How many Audiolisteners can be active at one time? Select the best answer.

   - [x] **One (1)**
   - [ ] Two (2)
   - [ ] Three (3)
   - [ ] As many as you want
     > Only one Audiolistener can be active at a time. If you have more than one, only the most recently added Audiolistener will be active.

4. Which scene setting enables you to compress high dynamic range (HDR) colors to those colors that are visible on monitors (low dynamic range colors [LDR])? Select the best answer.

   - [ ] UI coloring
   - [ ] Batching
   - [ ] Cubemapping
   - [x] **Tonemapping**
     > Tonemapping is a scene setting that enables you to compress HDR colors to those visible on monitors with LDR colors.

5. What are the effects of letting all of your assets preload? Select the best answer.

   - [ ] Everything will load smoothly when you launch your application.
   - [x] **Memory and performance will be compromised.**
     > Having all of your assets preload will use up a lot of the application memory when it launches. This will also impact the performance of your App, making it slower. Uncheck the preload option for large assets, and keep an eye on the number of smaller assets, too.
