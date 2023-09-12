1. Which components make any Entity in a scene participate in physics simulations? Select all that apply.

   - [x] **Collision**
     > A collision component defines the physical shape of the rigidbody. Collision components can be used together with a rigidbody component to give an Entity physical properties, such as a ball bouncing.
   - [ ] Gravity
   - [ ] Animation
   - [x] **Rigidbody**
     > Rigidbody specifies the type of movement: static, dynamic or kinetic, which allows for a realistic simulation of the movement of an Entity.

2. ammo.js is a powerful physics engine used by PlayCanvas that needs to be imported before you can apply any physics to your 3D models.

   - [x] **True**
   - [ ] False
     > PlayCanvas does not load ammo.js by default to avoid consuming resources on devices used if physics isn’t needed.

3. Select the best answer to fill in the blank: Use the ......... setting to control how the object moves on the X, Y and Z axes.

   - [ ] Angular factor
   - [x] **Linear factor**
   - [ ] Damping
     > The linear factor setting controls how objects move on the X, Y, and Z axes.

4. When implementing 3D animation in PlayCanvas, each character will have a single animation that includes all of the actions the character might perform. Select the best answer.

   - [ ] True
   - [x] **False**
     > You’ll typically have a set of animations, one for each action the character might perform. For example, you might have separate animations that show the character standing, walking, running or jumping.
