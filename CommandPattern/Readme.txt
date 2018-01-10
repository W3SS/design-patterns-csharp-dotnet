﻿- Real world example

	A generic example would be you ordering food at a restaurant. 
	You (i.e. Client) ask the waiter (i.e. Invoker) to bring some food (i.e. Command) 
	and waiter simply forwards the request to Chef (i.e. Receiver) who has the knowledge of what and how to cook. 

	Another example would be you (i.e. Client) switching on (i.e. Command) 
	the television (i.e. Receiver) using a remote control (Invoker).

- In plain words

	Allows you to encapsulate actions in objects. 
	The key idea behind this pattern is to provide the means to decouple client from receiver.

- Wikipedia says

	In object-oriented programming, the command pattern is a behavioral design pattern in which an object is used to encapsulate 
	all information needed to perform an action or trigger an event at a later time. 
	This information includes the method name, the object that owns the method and values for the method parameters.

- Command pattern can also be used to implement a transaction based system. 
  Where you keep maintaining the history of commands as soon as you execute them. 
  If the final command is successfully executed, all good otherwise just iterate through the history 
  and keep executing the undo on all the executed commands.