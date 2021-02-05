# VoteR
### **WINNER** of the Best Use of Google Cloud: COVID-19 Hackathon Fund at VandyHacks VII!
### **WINNER** of the Best Hardware Hack from MLH & Digi-key at VandyHacks VII!
### **WINNER** of the Best Use of Google Cloud at VandyHacks VII!

[![Demo video](https://github.com/jordansmithsgames/jordansmithsgames/blob/main/readmes/voter/voter.png)](https://www.youtube.com/embed/CurNqGTqgCY)

(Psst, check out the [Devpost](https://devpost.com/software/voter-7xrsoi)!)

# Inspiration

Everyone knows that voting is one of the most important things we can do to make a difference in our country. Despite this, many Americans face difficulties at the polls every year due to unclear voting regulations and communication gaps between election officials and the general public.

To make matters worse, the 2020 election season will be complicated by COVID-19. While many are opting to vote by mail, others will face long lines and crowded booths as they go to make their voice heard.

As college students who experienced these issues ourselves as relatively new voters, we reflected on the challenges we faced during the last few election cycles and those we expect to face this year. We found that:
- As young people, it is often difficult to know how to vote, especially for the first time!
- Determining what to bring to the polls can be a challenge-- and being turned away at the booth after standing in line for hours is awful
- Preparing to vote in person during COVID-19 is daunting, and communication about staying safe at the voting booth is spotty at best, if it exists at all

We decided to apply our knowledge of virtual reality development to help voters overcome these issues on an accessible and innovative platform. Thus VoteR was born.

# What it does

VoteR is a virtual reality mobile application developed for Google Cardboard that educates users about the voting process. More specifically, it:
- Teaches users how to vote, by taking them through the process in virtual reality
- Teaches users what they need to bring to the polls (and advises them on where to check for further information, given that regulations are different in every state)
- Teaches users safety , by demonstrating proper social distancing practices while at the polls!
- Teaches users why It is important to vote and encourages them to vote.

The application starts with a user interface on the mobile device, which authenticates the user using Google Firebase and collects basic data like name and email. Once the user is authenticated, the user can open a virtual reality scene built for Google Cardboard. The user is placed in an urban environment waiting in line to vote. As the simulation progresses the user is lead through the process of placing their vote through a series of animations and user interactions.

By the end of the experience, the user has been through the full process of casting a vote in person during the COVID-19 pandemic at least once before they actually do it in person. They are then awarded with a certificate demonstrating that they have completed this training! The certificate will be displayed in the UI section “badges”.

The Home page of the UI also includes the number of days until the next Election along with some news articles about the election. There is also a settings page that displays the information stored in Firebase.

We utilized Google Cardboard to ensure our application was accessible to everyone! This is a low-cost VR solution that brings this powerful technology into everyone's hands.

# How we built it

Our team broke the development process into two cones, which were then assembled at the end. This project was completed as follows:

Modeling Team (Aadithya and Austin): Used Maya to create the characters in this simulation, rig them, animate them, and develop an animation sequence corresponding to the steps of the voting process. Assembled asset models in Unity and applied materials to the models Utilized photoshop to create the user interface buttons and produce custom alphas for use in Substance Painter. Used Maya to model the assets in this simulation, and utilized Substance Painter to create textures for the assets. Compiled the script for our voter information user prompts and created the demo video.

Coding Team (Ines and Jordan): Used Unity to create an authentication system and user interface for the mobile application. Utilized Google Firebase to produce the authentication system. Produced the application functionality linking our VR scene and the mobile app with Google Cardboard and implementing the switch between VR mode and not VR mode.

# Challenges we ran into

As with any worthwhile project, there were many challenges along the way.

Modeling Team: The greatest challenges we faced were creating all of the assets and animations from scratch. We storyboarded to create a basic outline of the user experience inside of the application, and then broke down every asset and interaction we would need. Creating everything from scratch is an arduous process that is difficult to do in a short timespan, competing against the tendency of technology to crash and projects to go wrong. There were many times when a model didn't turn out right, a UV map was impossible to figure out, or an animation led characters to looks crazy (like walking into the sky). This is, of course, the joy of developing in VR, and watching a world come to life despite the flaws and challenges is extremely rewarding.

Coding Team: The greatest challenges we faced were working with Firebase and Google Cardboard in Unity along with switching back and fourth between VR mode and not VR mode. The nature of working with authentication is that it is very time consuming, so being able to get a working authentication pipeline in our application proved to be very difficult indeed due to the time constraints of this hackathon. Creating the user interface was also challenging because both members of the coding team do not have experience in UI.

# Accomplishments that we're proud of

We're very proud that we were able to construct a fairly detailed experience in terms of a UI interface and a 3D environment in a very small amount of time. We are very proud that everything was made FROM SCRATCH (No imported assets or textures)! We are also proud that we made a fully working VR experience that encourages people to vote and teaches them how to do so, especially since the next election is coming up in just a couple weeks.

What we learned We learned the ins and outs of importing and integrating 3D models from Maya into Unity, as well as the process of combining the textures made in Substance Painters onto these models as well. We learned about Firebase's authentication and database technologies, and we also learned about creating and maintaining user sessions in a mobile application through UI elements.

# What's next for VoteR

With the election less than a month away for those of us here in the United States, we think it is important that we finish the VoteR app in order to share it with our friends and family to encourage them to make their voice heard in this critical election. Ideally, we would add social media features that allows users to share their experiences and their earned badges with their followers in order to increase suffrage awareness. We would also want to add another scene that shows how to vote using mailing button. We would also want to polish up the animations and add more assets to the scenes in the application.
