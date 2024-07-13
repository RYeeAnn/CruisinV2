using Microsoft.AspNetCore.Mvc;
using CruisinV2.Models;
using System.Collections.Generic;

namespace CruisinV2.Controllers
{
    public class WarningLightsController : Controller
    {
        // Example collection of warning lights (replace with your actual data)
        private List<WarningLights> GetWarningLights()
        {
            return new List<WarningLights>
            {
                new WarningLights
                {
                    ImageUrl = "/assets/ABS-light.png",
                    Name = "ABS System",
                    Title = "ABS system malfunction.",
                    Description = "The ABS warning light indicates a malfunction in the vehicle's anti-lock braking system (ABS). When this light is on, the ABS system may not function properly, and regular braking should still be effective. However, it's advised to have the system inspected and repaired by a qualified mechanic as soon as possible to ensure optimal braking performance."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/airbag-indicator.png",
                    Name = "Airbag System",
                    Title = "Airbag system malfunction.",
                    Description = "The airbag indicator light suggests that there might be a problem with the vehicle's airbag system. This is a crucial safety feature, and any issues with the airbag system should be addressed immediately. A faulty airbag system may not deploy in the event of an accident, increasing the risk of injury. Have the system checked by a professional technician."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/battery-alert.png",
                    Name = "Battery Alert",
                    Title = "Battery voltage is low",
                    Description = "The battery alert light indicates that the vehicle's battery voltage is low. This could be due to a failing battery, a malfunctioning charging system, or other electrical issues. It's important to address this issue promptly, as a low battery can lead to a no-start condition. Have the battery and charging system inspected by a mechanic."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/brake-warning.png",
                    Name = "Brake Alert",
                    Title = "Brake system warning",
                    Description = "The brake alert light indicates a problem with the vehicle's braking system. This could be due to low brake fluid, worn brake pads, or other issues. It's crucial to address brake system problems immediately, as compromised braking can lead to unsafe driving conditions. Have the brake system inspected and repaired by a professional."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/check-engine-light.png",
                    Name = "Check Engine Light",
                    Title = "Use a DTC scanner",
                    Description = "The check engine light, also known as the malfunction indicator light (MIL), indicates that the vehicle's onboard computer has detected a problem with the engine, emissions, or other related systems. It's recommended to use a diagnostic trouble code (DTC) scanner to retrieve the specific error code. Check the vehicle's manual or consult a mechanic for further guidance."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/engine-temperature.png",
                    Name = "Engine Temperature",
                    Title = "Engine temperature is high",
                    Description = "The engine temperature warning light signals that the engine's coolant temperature is higher than normal. High engine temperature can lead to overheating and potential engine damage. Safely pull over and allow the engine to cool down. Check the coolant level, radiator, and cooling system for issues. Avoid driving with an overheated engine."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/fog-lamp.png",
                    Name = "Fog Lamp Indicator",
                    Title = "Fog lamps are on",
                    Description = "The fog lamp indicator light indicates that the vehicle's fog lamps are turned on. Fog lamps are used to improve visibility in foggy conditions. Make sure to turn off the fog lamps when driving in clear weather, as they can be blinding to other drivers and reduce your own visibility."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/lane-departure.png",
                    Name = "Lane Departure Warning",
                    Title = "Vehicle is drifting from lane",
                    Description = "The lane departure warning light alerts the driver when the vehicle is unintentionally drifting out of the lane. This system uses sensors to monitor lane markings. If the vehicle starts to cross a lane without using the turn signal, the light will activate. This feature helps prevent accidents due to unintended lane changes."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/low-fuel.png",
                    Name = "Low Fuel",
                    Title = "Fuel level is low",
                    Description = "The low fuel warning light indicates that the vehicle's fuel level is low. It's important to refuel soon to avoid running out of fuel. Running the vehicle on a low fuel level can potentially damage the fuel system and lead to a breakdown. Find a gas station and refuel as soon as possible."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/oil-pressure-light.png",
                    Name = "Oil Pressure",
                    Title = "Oil pressure is low",
                    Description = "This warning light indicates that the engine's oil pressure is below the recommended level. Low oil pressure can lead to poor lubrication and potential engine damage. It's important to stop the vehicle immediately and check the oil level. If the oil level is sufficient and the light persists, consult a mechanic."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/seat-belt.png",
                    Name = "Seat Belt Reminder",
                    Title = "Seat belt not fastened",
                    Description = "The seat belt reminder light indicates that one or more occupants in the vehicle haven't fastened their seat belts. Seat belts are critical for passenger safety in the event of a collision. All occupants should fasten their seat belts before the vehicle is in motion. The light will turn off when seat belts are buckled."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/security-indicator.png",
                    Name = "Security Indicator",
                    Title = "Security system active",
                    Description = "The security indicator light indicates that the vehicle's security system is active. This system helps prevent unauthorized entry and theft. The light will blink when the vehicle is locked and the security system is armed. If the light stays on while driving, there may be an issue with the security system that requires attention."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/shift-lock.png",
                    Name = "Shift Lock Indicator",
                    Title = "Shift lock engaged",
                    Description = "The shift lock indicator light indicates that the vehicle's shift lock mechanism is engaged. This prevents the vehicle from being shifted out of the park position unless the brake pedal is pressed. If the light is on and the brake pedal is pressed, but the shifter still won't move, there may be an issue with the shift lock system."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/tire-pressure-light.png",
                    Name = "Tire Pressure",
                    Title = "Tire pressure is low",
                    Description = "The tire pressure warning light indicates that the pressure in one or more tires is below the recommended level. Low tire pressure can affect vehicle handling, fuel efficiency, and tire lifespan. Check the tire pressures and inflate them to the proper levels. If the light persists, there may be a puncture or leak that requires repair."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/traction-control-malfunction.png",
                    Name = "Traction Control",
                    Title = "Traction control system active",
                    Description = "The traction control warning light indicates that the traction control system is actively working to prevent wheel spin or skidding. This system helps improve traction and stability on slippery or uneven road surfaces. The light may flash when the system is active. If the light stays on continuously, there may be an issue with the system."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/traction-control.png",
                    Name = "Traction Control Malfunction",
                    Title = "Traction control system malfunction",
                    Description = "The traction control malfunction light indicates that there's a problem with the vehicle's traction control system. This could be due to a sensor issue, a faulty component, or other factors. When this light is on, the traction control system may be disabled, which could affect the vehicle's stability in certain driving conditions. Have the system inspected and repaired."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/transmission-temperature.png",
                    Name = "Transmission Temperature",
                    Title = "Transmission temperature is high",
                    Description = "The transmission temperature warning light signals that the transmission fluid temperature is higher than normal. Overheating transmission fluid can lead to transmission damage and poor shifting performance. Safely pull over and allow the transmission to cool down. Check the transmission fluid level and ensure proper cooling system function."
                },
                new WarningLights
                {
                    ImageUrl = "/assets/washer-fluid.png",
                    Name = "Washer Fluid Low",
                    Title = "Washer fluid level is low",
                    Description = "The washer fluid low warning light indicates that the vehicle's windshield washer fluid level is low. It's important to maintain an adequate washer fluid level to ensure clear visibility, especially in dirty or rainy conditions. Refill the washer fluid reservoir with an appropriate windshield washer fluid as needed."
                },
            };
        }

        // Action to display list of warning lights
        public IActionResult Index()
        {
            var warningLights = GetWarningLights();
            return View(warningLights);
        }

        // Action to display details of a specific warning light
        public IActionResult Details(string name)
        {
            // Retrieve the warning light based on name (replace with actual logic)
            var warningLight = GetWarningLights().Find(w => w.Name == name);
            return View(warningLight);
        }
    }
}
