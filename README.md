# ObserverPattern

Problem:
When you have Object A (subject / observable / publisher) that is measuring weather objects (like temparture etc). So with every new measurement the state of Object A is changing.

When object B (c,d,e ...) (observer / subscriber) are watching object A to change state, so that the observer object can act on the state change of Object A. 

This watching is called polling, and when enough observers are watching the observable, this can create a lot of overhead. (every second "is your state changed").  So it is best practice that you change from polling to Pushing.

Whit the observer Pattern the observers are subscribing to object A, and when the state of Object A is changing, all the subscribers are notified that the the state of object A is changed.



