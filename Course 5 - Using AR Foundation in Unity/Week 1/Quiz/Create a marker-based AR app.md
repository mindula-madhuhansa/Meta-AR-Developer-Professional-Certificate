1. The AR Session Origin manages an individual session of the AR experience, including things like frame rate and communication with the device. Select the best answer.

   - [ ] True
   - [x] **False**
     > The AR Session Origin represents the device in space. When the user moves or rotates in the real world, the AR Session Origin moves accordingly in the Unity scene. And just like your real device has a camera, the AR Session Origin has the AR Camera GameObject attached to it.

2. Complete this sentence. The ............................. package contains all the GameObjects and classes required to create and work with AR projects. Select the best answer.

   - [ ] ARCore
   - [x] **AR Foundation**
   - [ ] XR Plug-In Management
   - [ ] ARKit
     > AR Foundation is an official Unity package in the Unity Hub that contains all of the GameObjects and classes required to create and work with AR projects.

3. Fill in the blank: ............................... communicates with the AR framework and features of an Android™ device. Select the best answer.

   - [ ] AR Foundation
   - [ ] ARKit
   - [ ] XR Plug-In Management.
   - [x] **ARCore**
     > ARCore allows AR Foundation to communicate with the Android™ AR framework and use its features.

4. ARKit is the Apple API that provides access to the ........................., ........................... and other ........................ that make AR experiences possible on iOS devices. Select all that apply.

   - [ ] keyboards
   - [x] **sensors**
     > ARKit also provides access to the iOS hardware and cameras, and should be installed using XR Plug-In Management.
   - [x] **hardware**
     > ARKit also provides access to the iOS device cameras and sensors, and should be installed using XR Plug-In Management.
   - [x] **cameras**
     > ARKit also provides access to the device sensors and other hardware, and should be installed using XR Plug-In Management.

5. Complete this sentence. Because AR Foundation does not use color information to detect images, it is important that your grayscale AR marker image has plenty of .................. . Select the best answer.

   - [x] **contrast**
   - [ ] triggers
   - [ ] details
   - [ ] repeated patterns
     > AR Foundation does not use color information to detect images, only grayscale, which is why it’s important that markers have good contrast.

6. Beverly has designed an AR marker for her new marker-based app. It is a grayscale image in a PNG format with strong contrast values, and it is 150 x 150 pixels in size. Is this an example of a good AR marker? Select the best answer.

   - [ ] Yes, it is.
   - [x] **No, it is not.**
     > A good AR marker has a size of at least 300 x 300 pixels, is in a PNG or JPG format, has strong color-contrast values and avoids repeated patterns.

7. Dhanya needs to adjust the scale of her prefab. What should she do? Select the best answer.

   - [ ] Drag the object to the Hierarchy.
   - [x] **Double-click the object to open Prefab Mode.**
   - [ ] Adjust the scale of her model in an external 3D editor and re-import it.
   - [ ] Select the object and then select Edit > Scale.
     > She can also select the object in the Project or Hierarchy and select Open in the Inspector.

8. Use Prefab Mode to adjust the position, rotation and .....................Which of the following are use cases for marker-based AR? Select all that apply. of your model. Select the best answer.

   - [ ] shape
   - [ ] orientation
   - [x] **scale**
   - [ ] size
     > Edit the position, rotation and scale of the mesh so that your model appears as you want it to appear in your app relative to your marker in the real world.

9. Which of the following are use cases for marker-based AR? Select all that apply.

   - [x] **Create a coloring book where the shapes you color come to life in 3D.**
   - [ ] Send a marketing email.
   - [x] **Create a tattoo-planning app that shows what the tattoo will look like on your skin.**
   - [ ] Launch a website.
     > From fun games that make pizza boxes interactive, business cards that come to life, art that comes off the canvas or tattoo planning apps that let you place and edit what you want tattoos to look like, marker-based AR has a lot of use cases!

10. Kara is building an app in Unity. She wants users to hold their phone vertically when they use the app. Therefore, when she goes to test her app in the editor, she should update the Game view to reflect the desired aspect ratio. Select the best answer.

    - [x] **True**
    - [ ] False
      > When you run apps on your phone, they run in either portrait mode (vertical) or landscape mode (horizontal). By aligning your Game view with the correct aspect ratio, you can better visualize how the app will look on your device.
