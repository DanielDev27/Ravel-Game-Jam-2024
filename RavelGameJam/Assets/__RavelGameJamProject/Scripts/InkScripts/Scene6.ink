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
//Scene 6: show the letter table (eg at the end of this chapter) and a knitting overlay sample side by side
{SHOWUI(3)}
{MAINCHAR("Alice")}
{MAINIMAGE(false)}
{MAINNAME(false)}
{SECONDCHAR("Miss Atkins")}
{SECONDIMAGE(false)}
{SECONDNAME(true)}
Very good. Now try to knit a code. Remember, after the full stop comes a time code, as hour:minute. Here, try this example…: Knit.Twenty-Three past Ten.
{REMOVECHARACTERS(false)}