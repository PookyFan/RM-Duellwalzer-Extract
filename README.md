# RM Duellwalzer Extract
Tool for extracting stuff from Rozen Maiden Duellwalzer PS2 game.
Requires Windows OS and .Net Framework 4.8.

## How to use it
Download and unpack binaries from release. Choose where to look for game files (need to specify directory containing game binary with all its directories) and where to save extracted stuff. Choose what you want to extract (for now only images are available) and hit *EXTRACT!* button. Go complain to me if there are too many failure messages in the logs (read further for some information regarding un-extractable stuff).

## What it can extract
For now the tool can only extract images.

## Why it's so limited?
In fact lots of stuff doesn't need to be extracted, because it's accessible as it is. Videos in folders MOV nad MOV2 can be played just fine (try to load them to MPC for example). Same goes for music from BW directory.
That leaves us dialogs voices (which I doubt anyone would be interested in) and dialogs texts (whichs extraction is planned to be imlemented). And images, of course, and those are handled by this tool right here.

## Some of the files are marked as FAILED in the logs
There is *system.gsl* that has some strange internal structure and I don't have patience to get it right, especially that it's probably some unimportant stuff (the file's tiny so image it contains probably isn't worth seeing, especially that it's inside SYS folder containing game's meta stuff such as menus and buttons).
In case there are other files that failed to get extracted, please let me know.

## I have some other errors...
Impossible, but in any case report them to me.