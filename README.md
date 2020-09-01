# UnoColouredCommandBarIssue

This project reproduces issue with the colouring of command bar icons

See https://github.com/unoplatform/uno/issues/1665

01-Sept-2020

Reviewed the functionality on all the platforms, things have improved but there are still elements that are not yet correct.
These checks were on Uno.UI build 3.0.12

IOS
Displays AppBar Icon: Yes
Displays AppBar bitmap: Yes
AppBar icons in the correct colour: Yes
Bound commands fire: Yes
AppBar Secondary Menu ellipsis displayed: Yes
AppBar Secondary Menu ellipsis in the correct colour: No
Secondary Menu displayed on ellipsis tap: No
Expands to avoids text clipping of icon text: No

Android
Displays AppBar Icon: No
Displays AppBar bitmap: Yes
AppBar icons in the correct colour: Yes
Bound commands fire: Yes
AppBar Secondary Menu ellipsis displayed: Wrong symbol
AppBar Secondary Menu ellipsis in the correct colour: No
Secondary Menu displayed on ellipsis tap: No
Expands to avoids text clipping of icon text: Yes

WASM
Displays AppBar Icon: Yes
Displays AppBar bitmap: Yes
AppBar icons in the correct colour: Yes
Bound commands fire: No
AppBar Secondary Menu ellipsis displayed: Yes
AppBar Secondary Menu ellipsis in the correct colour: No
Secondary Menu displayed on ellipsis tap: No
Expands to avoids text clipping of icon text: Yes
