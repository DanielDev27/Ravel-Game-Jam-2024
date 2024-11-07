EXTERNAL MAINCHAR(charName)
EXTERNAL MAINIMAGE(active)
EXTERNAL MAINNAME(active)
EXTERNAL SECONDCHAR(charName)
EXTERNAL SECONDIMAGE(active)
EXTERNAL SECONDNAME(active)
EXTERNAL NEXTSCENE(sceneIndex)
EXTERNAL BACKGROUND(backgroundIndex)
//Scene 2: office building interior
{BACKGROUND(0)}
{MAINCHAR("Alice")}
{MAINIMAGE(true)}
{MAINNAME(true)}
Hmmm… I think this is the place? Now to find the correct office…
Agriculture, no…
Military, oh that’s not it.
Industry, no…
Medical, aha!
{SECONDCHAR("Officer")}
{SECONDIMAGE(true)}
{MAINNAME(false)}
{SECONDNAME(true)}
Good day, madam! May I help you?
{MAINNAME(true)}
{SECONDNAME(false)}
Oh, yes! I want to do my part! How do I become a field nurse?
{MAINNAME(false)}
{SECONDNAME(true)}
Oh, I’m terribly sorry. Our latest intake is full. Is there something else you want to do?
{MAINNAME(true)}
{SECONDNAME(false)}
But… the papers…
{MAINNAME(false)}
{SECONDNAME(true)}
The same ads are printed all over the country. Not much we can do about it.
{MAINNAME(true)}
{SECONDNAME(false)}
There must be a list?
{MAINNAME(false)}
{SECONDNAME(true)}
I’m afraid not.
{MAINNAME(true)}
{SECONDNAME(false)}
Why are there so few options? I would very much like to help the war effort!
{MAINNAME(false)}
{SECONDNAME(true)}
I’m so sorry madam, there are many things you can do to help. But we have nothing for you. Good day.
{NEXTSCENE(3)}