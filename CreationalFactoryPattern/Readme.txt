1) Simple Factory

- Real world example

	Consider, you are building a house and you need doors. 
	It would be a mess if every time you need a door, you put on your carpenter clothes and start making a door in your house. 
	Instead you get it made from a factory.

- In plain words

	Simple factory simply generates an instance for client without exposing any instantiation logic to the client.

- Wikipedia says

	In object-oriented programming (OOP), a factory is an object for creating other objects – formally a factory is a function 
	or method that returns objects of a varying prototype or class from some method call, which is assumed to be "new".

- When to Use?

	When creating an object is not just a few assignments and involves some logic, 
	it makes sense to put it in a dedicated factory instead of repeating the same code everywhere.

2) Factory Method

- Real world example

	Consider the case of a hiring manager. It is impossible for one person to interview for each of the positions. 
	Based on the job opening, she has to decide and delegate the interview steps to different people.

- In plain words

	It provides a way to delegate the instantiation logic to child classes.

- Wikipedia says

	In class-based programming, the factory method pattern is a creational pattern that uses factory methods 
	to deal with the problem of creating objects without having to specify the exact class of the object that will be created. 
	This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, 
	or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

- When to use?

	Useful when there is some generic processing in a class but the required sub-class is dynamically decided at runtime. 
	Or putting it in other words, when the client doesn't know what exact sub-class it might need.

3) Abstract Factory

- Real world example

	Extending our door example from Simple Factory. Based on your needs you might get a wooden door from a wooden door shop, 
	iron door from an iron shop or a PVC door from the relevant shop. 
	Plus you might need a guy with different kind of specialities to fit the door, for example a carpenter for wooden door, 
	welder for iron door etc. As you can see there is a dependency between the doors now, wooden door needs carpenter, 
	iron door needs a welder etc.

- In plain words

	A factory of factories; a factory that groups the individual but related/dependent factories together
	without specifying their concrete classes.

- Wikipedia says

	The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme 
	without specifying their concrete classes.

- When to use?

	When there are interrelated dependencies with not-that-simple creation logic involved