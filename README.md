# AR Book Cover for Fire Cat
This project is a Unity project using Vuforia's engine to display a front and back bookcover for one of my favorite childhood books, Fire Cat. After cloning the repo and opening the project in Unity, make sure to navigate to the MainScene scene in /Assets/Scenes. Double check that your Vuforia License and camera settings are correct in the Vuforia Engine Configuration. Mac users like me will have some image target tracking difficulties because of the very low quality mac camera, but here are examples of the capabilities of the front and back cover. I noticed that the tracking words somewhat better with the lights off and the book illuminated by either an external light or just your computer screen displaying white light. Press play to start the AR experience.

## Front Cover
The front cover displays the title, author, and a fun 3D scene displaying some aspects from the book, including Pickles the fire cat. 

![](FrontCover_AdobeCreativeCloudExpress.gif)

## Back Cover
The back cover displays basic information about the book. If you press the red AR button, it switches to a short review written about the book by me (you might have some trouble with this with a mac camera because of loss of image target tracking). This works using Vuforia's virtual button game object and a simple C# script that switches which game object between the information and the review is active every time you hit the button.

![](BackCover_AdobeCreativeCloudExpress.gif)

If you want to try for yourself, the front and back cover image targets are included in this project. Just print them out and you will be able to see the display. 
