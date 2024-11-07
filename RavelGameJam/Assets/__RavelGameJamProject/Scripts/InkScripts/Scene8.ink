EXTERNAL MAINCHAR(charName)
EXTERNAL MAINIMAGE(active)
EXTERNAL MAINNAME(active)
EXTERNAL SECONDCHAR(charName)
EXTERNAL SECONDIMAGE(active)
EXTERNAL SECONDNAME(active)
EXTERNAL NEXTSCENE(sceneIndex)
EXTERNAL BACKGROUND(backgroundIndex)
EXTERNAL SHOWUI(UI_Index)
EXTERNAL HIDEUI(UI_Index)
EXTERNAL REMOVECHARACTERS(active)
//Scene 8: Alice (Madeliene) is at a train station keeping busy with knitting
{BACKGROUND(0)}
{MAINCHAR("Madeliene (Alice)")}
{MAINIMAGE(true)}
{MAINNAME(false)}
{SECONDCHAR("Miss Atkins")}
{SECONDIMAGE(true)}
{SECONDNAME(true)}
Right then, Madeliene, are you ready for your first mission?
{MAINNAME(true)}
{SECONDNAME(false)}
Yes, Ma’am!
{MAINNAME(false)}
{SECONDNAME(true)}
Excellent. Now, understand that even though this mission may seem simple, it is of utmost importance that you get it right.
{MAINNAME(true)}
{SECONDNAME(false)}
I’m ready. I was up last night practicing my stitches.
{MAINNAME(false)}
{SECONDNAME(true)}
Very good. If we are able to apprehend these men, it will give us quite the advantage in this war.
{MAINNAME(true)}
{SECONDNAME(false)}
Understood
{MAINNAME(false)}
{SECONDNAME(true)}
Now then, your station is this town here. It’s lovely, along the French coast line.
{MAINNAME(true)}
{SECONDNAME(false)}
... Toulon…
{MAINNAME(false)}
{SECONDNAME(true)}
We already have a number of agents there. Well established. You will know them with this phrase “He managed to thread through here…
{MAINNAME(true)}
{SECONDNAME(false)}
...Is that exact phrase?
{MAINNAME(false)}
{SECONDNAME(true)}
Weave it into a sentence however you can. You must listen for: “I gathered”.
{MAINNAME(true)}
{SECONDNAME(false)}
They will also use it in any which way?
{MAINNAME(false)}
{SECONDNAME(true)}
Yes, they might not use that phrase alone, so listen carefully.
{MAINNAME(true)}
{SECONDNAME(false)}
Alright.
{MAINNAME(false)}
{SECONDNAME(true)}
If they ask you to mend something, understand that whatever they give you must be destroyed after reading. We can’t have the enemy intercept any form of communications.
{MAINNAME(true)}
{SECONDNAME(false)}
I’ll be sure to unravel the item.
{MAINNAME(false)}
{SECONDNAME(true)}
Do your best to remember the message. And the message itself might be a clue, not a direct instruction.
{MAINNAME(true)}
{SECONDNAME(false)}
I do love figuring these things out. It won’t be a problem for me!
{MAINNAME(false)}
{SECONDNAME(true)}
{BACKGROUND(2)}
As for our target. These two men. They are also spies and have many aliases, so do not rely on that.
//Change Background <Show images>
{MAINNAME(true)}
{SECONDNAME(false)}
They seem quite recognisable for spies…
{MAINNAME(false)}
{SECONDNAME(true)}
We think they may be stopping at the train station in the town. We do not know for how long or when. You may need to visit there every day
{MAINNAME(true)}
{SECONDNAME(false)}
That’s alright.
{BACKGROUND(0)}
{MAINNAME(false)}
{SECONDNAME(true)}
You need to find out where they are headed and when. Understood?
{MAINNAME(true)}
{SECONDNAME(false)}
Understood.
{MAINNAME(false)}
{SECONDNAME(true)}
Alright. Best of luck. Go knit your bit!
{BACKGROUND(1)}
{MAINNAME(true)}
{SECONDNAME(false)}
{SECONDIMAGE(false)}
...
...hmmmm…
{SECONDCHAR("Conductor")}
{MAINNAME(false)}
{SECONDNAME(true)}
{SECONDIMAGE(true)}
Good day, Miss. Are you all right here?
{MAINNAME(true)}
{SECONDNAME(false)}
(Ah! What was my phrase again?)
... Oh, yes, thank you. I’m waiting for my husband. He managed to thread through here for a while.
{MAINNAME(false)}
{SECONDNAME(true)}
I gathered it would be something like that… Well the next train will be here soon.
{MAINNAME(true)}
{SECONDNAME(false)}
I see, thank you. I feel I arrived a stitch too early
{MAINNAME(false)}
{SECONDNAME(true)}
My scarf seems to be unraveling. Would you be able to mend it?
{MAINNAME(true)}
{SECONDNAME(false)}
This will require a bit of work. May I hang on to it for a day?
{MAINNAME(false)}
{SECONDNAME(true)}
Please do. Thank you
{SECONDCHAR("Conductor1")}
{SECONDNAME(false)}
Conductor removes scarf and leaves. Madeline inspects the scarf for a knitted code.
{SHOWUI(6)}
{MAINNAME(true)}
{SECONDIMAGE(false)}
Let's take a look...
//The code knitted is 16211812.1525
{MAINNAME(true)}
Well, that’s simple at least. There’s only one of those in this small town.
{HIDEUI(6)}
{BACKGROUND(1)}
{MAINNAME(false)}
She continues her knitting. 
The sound of an approaching train has her look up from her work.
//https://pixabay.com/sound-effects/steam-train-coming-into-the-station-75161/
{MAINNAME(true)}
(Alright. My briefing gave me a description of 2 men…) 
(Maybe if I’m lucky they’ll be easy to spot…)
{BACKGROUND(4)}
{MAINNAME(true)}
(That’s them!)
{MAINNAME(false)}
{SECONDCHAR("Man")}
{SECONDNAME(true)}
{SECONDIMAGE(false)}
Do as you please after you ’ave gazzered supplies. Be ‘ere tomorrow for ze evening train. Ze schedule says it leaves at quarter to seven. See you in Lyon! Adieu!
{MAINNAME(true)}
{SECONDNAME(false)}
Just a one more purl…
{SHOWUI(4)}
//Show stitching UI for player to input
//Let player input their own code. Correct combination is 12251514.1845
//Upon completion show new UI to choose destination
