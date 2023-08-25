1. True or False: Virtual reality allows us to overlay a real world image on top of a virtual world in real time. Select the best answer.

   - [ ] True
   - [x] **False**
     > Augmented reality (AR) is the technology that allows us to overlay a virtual image on top of the physical world in real-time. For example, if there is a wall in the scene, you might create an effect to hang a virtual picture on that wall.

2. Which feature detects and separates parts of the camera input in Meta Spark? Select the best answer.

   - [x] **Segmentation**
   - [ ] Face tracker
   - [ ] Occluders
   - [ ] Plane tracker
     > Segmentation in Meta Spark detects and separates parts of the camera input. For example, it would detect and separate the hair of a person from the face of that person.

3. Which patches that represent scene objects produce signals that can be passed to the other patches? Select the best answer.

   - [ ] Inspector Property patches
   - [ ] Asset patches
   - [x] **Producer patches**
   - [ ] Scene Object patches
     > Patches that represent scene objects produce signals are also called “producer” patches. For example, the face tracker patch produces a signal for the position and movement of the face.

4. Which patch would someone use to apply complex changes to materials? Select the best answer.

   - [ ] Animation
   - [ ] Logic
   - [x] **Shader**
   - [ ] Facial Recognition
     > You can use the Shader patch to apply complex changes to the appearance of materials. Shader patches are particularly useful for determining the appearance of a 3D object’s surface.

5. What are the best practices that you should use when choosing a target image for your AR effect? Select all that apply.

   - [x] **Stay away from images that have smooth or soft edges.**
     > Try to stay away from smooth or soft edges and textures with a lot of gradients.
   - [x] **Avoid asymmetrical patterns and compositions.**
     > Avoid symmetry and repeated patterns. Images that can easily be inverted might not track as well.
   - [ ] Use images with resolution at least 100x100 pixels.
   - [ ] Try to use simple images as much as possible, especially with the same motifs.

6. How would someone drag a 3D text object onto a fixed target tracker? Select the best answer.

   - [ ] Separate both objects in their own target trackers before combining.
   - [x] **Make sure that the 3D text object is a child of the fixed target tracker.**
   - [ ] Make sure that the object is a parent of the fixed target tracker.
   - [ ] Use Shortcut C on the keyboard to combine selected objects.
     > In order to drag objects onto a fixed target tracker, you must make sure the objects are a child of the fixed target tracker.

7. Where will an environment texture be listed once it has been imported to your Meta Spark project? Select the best answer.

   - [x] **Asset panel**
   - [ ] Inspector panel
   - [ ] Scene
   - [ ] Environment panel
     > The texture will be listed in the Assets panel. The image in the Assets panel won't look exactly like the texture you imported, because the texture undergoes some processing before it can be used as an environment texture in Meta Spark Studio.

8. Which interaction patch would someone use to make something happen to an object when it’s tapped on the screen? Select the best answer.

   - [ ] Screen Pinch
   - [x] **Object Tap**
   - [ ] Object Action
   - [ ] Screen Action
     > Use the Object Tap patch to make something happen to an object when it’s tapped on the screen. For example, you can create an effect that changes the color of a plane when that plane is tapped on a device screen.

9. How can someone edit a GIF in Meta Spark? Select the best answer.

   - [ ] Import GIF and edit in Scene
   - [ ] Inspector Panel
   - [ ] File Editor
   - [x] **GIFs cannot be edited in Meta Spark**
     > Meta Spark does not support editing GIFs. You must make changes in an image editor such as Blender or Illustrator and then import the edited GIF into Meta Spark.

10. What term is used to change the size of an object in Meta Spark? Select the best answer.

    - [ ] Rotate
    - [ ] Resize
    - [x] **Scale**
    - [ ] Move
      > Changing the size of an object in Meta Spark is called scaling an object. Select scaling at the top of the viewport to make a gizmo with three axes appear. Use this gizmo to change the size of an object.
