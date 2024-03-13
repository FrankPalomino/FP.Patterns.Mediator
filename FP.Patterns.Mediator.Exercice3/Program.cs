/*
You are working on a software for an airport traffic control system. 
The system has multiple components such as Runway, Taxiway, Hangar, and ControlTower. 
The interactions between these components are complex. For example:

An airplane lands on a Runway, then moves to a Taxiway, and finally parks in a Hangar.
The ControlTower needs to coordinate all these movements to prevent collisions.
However, you want to ensure that these components are loosely coupled. 
That is, a Runway doesn’t need to know about Taxiway or Hangar, and vice versa.

Your task is to design this airport traffic control system using the Mediator design pattern. 
The Mediator will handle the communication between different components, ensuring that they remain loosely coupled.
*/

using FP.Patterns.Mediator.Exercice3;

ControlTower controlTower = new();

Runway runway = new();
Taxiway taxiway = new();
Hangar hangar = new();

controlTower.Register(runway);
controlTower.Register(taxiway);
controlTower.Register(hangar);

runway.SendMessage("Airplane landed.");
taxiway.SendMessage("Airplane moving.");
hangar.SendMessage("Airplane parked.");
