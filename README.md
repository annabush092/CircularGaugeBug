# CircularGaugeBug

To reproduce bug:
- Clone and run app on iphone simulator running version 13.0 or higher.
- You will see the circular gauge and pointer load correctly. So far so good.
- Click the "Another View" button to navigate to a second view.
- Use the nav-bar to navigate back to the initial view.
- You will see now that the MarkerPointer is in the wrong place. Though the value of the pointer remains unchanged (and correct) the pointer itself is offset slightly on the circular dial. 

Running the application on lower iOS versions and on all Android devices works as expected - They do not exhibit this bug. The bug seems to be isolated to iOS 13 and above only. Please advise!
