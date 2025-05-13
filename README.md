# Instantiator

## ➤ Creation context :
During several group game development projects on the Unity engine, I noticed that each team member implemented singletons in their own way, often with inconsistent safety checks and conflict management strategies.

To speed up our workflow and avoid redundant boilerplate code, I decided to create a centralized tool to standardize the singleton pattern across projects.

Exactly one year later, I'm sharing this tool with you for free and open-source use.


## ➤ Description :
### ▸ What is a Singleton ?

A singleton is a software design pattern that ensures a class has **only one instance** and provides a **global point of access to it**. It’s commonly used in Unity for manager-like components, such as audio managers, game managers _(please avoid putting everything into a giant GameManager class)_, and more, where a single authoritative instance is needed (across scenes or not).

### ▸ What is Instantiator ?

Instantiator is a static Unity utility script that simplifies the process of implementing singleton patterns in your game objects. It automates :

- Detection of existing instances.
- Conflict resolution (with customizable behaviors like warnings, automatic destruction, or editor pause).
- Centralized naming convention enforcement for singleton variables (public static TYPE Instance).

By using Instantiator.GetInstance(...), you can write safer, more maintainable, and faster singleton implementations, especially in collaborative projects.

No need to write and rewrite the same boilerplate for every class. Just plug and play.

**Here’s are some typical examples of singleton creation, with and without the Instantiator:**

![InstantiatorUseExample_FromTo_RawImage1](https://github.com/user-attachments/assets/b77cd1c2-7f61-48ed-a113-33231d8ae35f)
![InstantiatorUseExample_FromTo_RawImage2](https://github.com/user-attachments/assets/db2e6a17-8064-4725-a8dc-fb621c260b45)


## ➤ Utilization examples :

Here’s a typical example of how to use the Instantiator tool in a singleton class :

![InstantiatorUseExample](https://github.com/user-attachments/assets/23f1f22c-1698-4b6f-9762-3860a2d26037)
 
As you can see in the first example we use reflexion to get the 'Instance' variable, if needed you can change the targeted variable by going in the Instantiator and changing the DEFAULT_SINGLETON_VARIABLE_NAME variable's value.

**Note :** If you need more documentation check out the Instantiator class.


## ➤ License :

As mentioned earlier, you're free to use Instantiator in your projects. 

If you release a game using this tool, I’d appreciate a small credit, for example, as “External Technical Help”.

Thank you !


## ➤ Credits :

### ▸ Programmers :
- [Alexandre RICHARD](https://github.com/Alexandre94fr)

### ▸ External assets
- No external assets used
