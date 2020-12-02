John Koropchak Knock Assessment

For this assessment this test is written as a console application as opposed to be a class library.  For it to run automation test frameworks, (part of CI/CD)  it would need to be written as a class library.

This assessment is using basic verification that checks if the modal for a successful booking is present.  More verification is possible by checking if the correct date and time are present in the modal.  Tests could also be added checking for email and text events.

I assumed this assessment was asking to just schedule a booking with automation and have a verification for that booking.  I was not able to get the SelectElement for setting the date working.  In general it is better to add test tags to the selectors.  They are easy to grab and won't change.