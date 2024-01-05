using FP.Patterns.Mediator;
using FP.Patterns.Mediator.Exercice2;

Mediator mediator = new Mediator();

Light light = new Light(mediator);
Thermostat thermostat = new Thermostat(mediator);
SecurityCamera securityCamera = new SecurityCamera(mediator);

mediator.AddDevice(light);
mediator.AddDevice(thermostat);
mediator.AddDevice(securityCamera);

light.Communicate("Light turn on");