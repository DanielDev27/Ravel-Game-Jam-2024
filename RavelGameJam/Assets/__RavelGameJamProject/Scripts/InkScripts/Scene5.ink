EXTERNAL MAINCHAR(charName)
EXTERNAL MAINIMAGE(active)
EXTERNAL MAINNAME(active)
EXTERNAL SECONDCHAR(charName)
EXTERNAL SECONDIMAGE(active)
EXTERNAL SECONDNAME(active)
EXTERNAL NEXTSCENE(sceneIndex)
EXTERNAL BACKGROUND(backgroundIndex)
EXTERNAL SHOWUI(UI_Index)
EXTERNAL REMOVECHARACTERS(active)
{BACKGROUND(0)}
//Scene 5: show the letter table (eg at the end of this chapter) and a knitting sample side by side
{SHOWUI(0)}
{MAINCHAR("Alice")}
{MAINIMAGE(false)}
{MAINNAME(false)}
{SECONDCHAR("Miss Atkins")}
{SECONDIMAGE(false)}
{SECONDNAME(true)}
First let’s assign each letter a double digit number, A is 01, B is 02, C is 03… and so on all the way through to Z, which is 26.
{MAINNAME(true)}
{SECONDNAME(false)}
Alright…
{MAINNAME(false)}
{SECONDNAME(true)}
Now if you notice the knitting has 10 stitches across, the first stitch on the bottom left represents zero. Count the stitches moving left…
{MAINNAME(true)}
{SECONDNAME(false)}
0, 1, 2, 3… to 9… I think I see how this might work… Every two rows is one letter… but what is happening in row 9?
{MAINNAME(false)}
{SECONDNAME(true)}
A row made from white is a full-stop.
{MAINNAME(true)}
{SECONDNAME(false)}
I see! But the rows at the top... That’s not a word at all…
{MAINNAME(false)}
{SECONDNAME(true)}
Clever thing. Can you work out what they are?
//A sinlge response based on development
{MAINNAME(true)}
{SECONDNAME(false)}
It’s a timecode; hour:min.
{MAINNAME(false)}
{SECONDNAME(true)}
Excellent work. Here’s another example. Try to read it without the code sheet, what does it say?
{REMOVECHARACTERS(false)}