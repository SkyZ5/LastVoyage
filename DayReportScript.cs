using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class DayReportScript : MonoBehaviour
{
    public bool GUIEnabled;
    public TMP_Text story;
    public TMP_Text effects;
    public GameObject button1;
    public GameObject button2;
    public FuelScript fuel;
    public FoodScript food;

    private int[] valuesUpdate;
    void Start()
    {
        disableGUI();
        button1.SetActive(false);
        button2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GUIEnabled = GetComponent<Canvas>().enabled;
    }
    public bool isGUI()
    {
        return GUIEnabled;
    }
    public void enableGUI()
    {
        GetComponent<Canvas>().enabled = true;
        int random = Random.Range(1, 15);
        if (random == 1)
        {
            valuesUpdate = quietDay();
        }
        else if (random == 2)
        {
            valuesUpdate = asteriodEncounter();
        }
        else if (random == 3)
        {
            valuesUpdate = unexpectedContact();
        }
        else if (random == 4)
        {
            valuesUpdate = freezerMalfunction();
        }
        else if (random == 5)
        {
            valuesUpdate = systemMaintenance();
        }
        else if (random == 6)
        {
            valuesUpdate = unchartedAnomaly();
        }
        else if (random == 7)
        {
            valuesUpdate = routineJourney();
        }
        else if (random == 8)
        {
            valuesUpdate = junkCollision();
        }
        else if (random == 9)
        {
            valuesUpdate = emergancyRepair();
        }
        else if (random == 10)
        {
            valuesUpdate = stellarObservation();
        }
        else if (random == 11)
        {
            valuesUpdate = minorHullDamage();
        }
        else if(random == 12)
        {
            valuesUpdate = powerFluctiations();
        }
        else if(random == 13)
        {
            valuesUpdate = meteorShower();
        }
        else if(random == 14)
        {
            valuesUpdate = unknownSignal();
            button1.SetActive(true);
        } 
        else if(random == 15)
        {
            valuesUpdate = strangePhenomenon();
            button2.SetActive(true);
        }
    }
    public void disableGUI()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        GetComponent<Canvas>().enabled = false;
    }

    public void continueButton()
    {
        food.addFood(valuesUpdate[0]);
        fuel.addFuel(valuesUpdate[1]);
        disableGUI();
    }
    public void exploreButton1()
    {
        int random = Random.Range(1, 4);
        if (random == 1)
        {
            valuesUpdate = unknownSignal1();
        }
        else if( random == 2)
        {
            valuesUpdate = unknownSignal2();
        }
        else if(random == 3)
        {
            valuesUpdate = unknownSignal3();
        }
        else if (random == 4)
        {
            valuesUpdate = unknownSignal4();
        }
        button1.SetActive(false);
    }
    public void exploreButton2()
    {
        int random = Random.Range(1, 5);
        if (random == 1)
        {
            valuesUpdate = strangePhenomenon1();
        }
        else if (random == 2)
        {
            valuesUpdate = strangePhenomenon2();
        }
        else if (random == 3)
        {
            valuesUpdate = strangePhenomenon3();
        }
        else if (random == 4)
        {
            valuesUpdate = strangePhenomenon4();
        }
        else if (random == 5)
        {
            valuesUpdate = strangePhenomenon5();
        }
        button2.SetActive(false);
    }
    private int[] quietDay()
    {
        story.SetText("The journey is progressing as expected. Nothing unusual has happened today. You are maintaining a steady pace. You kept yourself busy with maintenance checks and exercise routines.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0, 0 };
        return returnValue;
    }

    private int[] asteriodEncounter()
    {
        story.SetText("A large asteroid field was detected on the ship’s radar, and you had to maneuver to avoid a collision. Some minor stress on the hull, but nothing too serious. However, you lost some fuel due to the evasive maneuvers.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 5);
        int[] returnValue = { 0, -5 };
        return returnValue;
    }

    private int[] unexpectedContact()
    {
        story.SetText("A transmission was received from an unknown ship. They identified themselves as part of a rescue mission from a distant colony. They shared some information about a nearby habitable planet, and you exchanged supplies for some much-needed repairs.");
        effects.SetText("Effects: " + "\n" + "Food: +" + 10 + "\n" + "Fuel: +" + 30);
        int[] returnValue = { 10, 30 };
        return returnValue;
    }

    private int[] freezerMalfunction()
    {
        story.SetText("The ship's freezer has malfunctioned. A significant portion of your stored food has spoiled, and you lost a considerable amount of perishable supplies. You are disappointed, but there’s still enough to continue.");
        effects.SetText("Effects: " + "\n" + "Food: -" + 20 + "\n" + "Fuel: " + 0);
        int[] returnValue = { -20, 0 };
        return returnValue;
    }

    private int[] systemMaintenance()
    {
        story.SetText("Routine system checkups and maintenance today. No issues detected, and you are getting more comfortable with the ship's layout. The isolation is beginning to feel normal.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0 , 0 };
        return returnValue;
    }

    private int[] unchartedAnomaly()
    {
        story.SetText("You encountered a strange anomaly in space today. The ship’s sensors detected unusual electromagnetic readings. You did a quick scan and moved on, but you’re still unsure about the cause. The ship’s power systems fluctuated briefly, but no lasting damage.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 5);
        int[] returnValue = { 0, -5 };
        return returnValue;
    }

    private int[] routineJourney()
    {
        story.SetText("Another uneventful day in deep space. You are starting to get into a groove. Morale is stable, and the mission continues smoothly. Not much to report.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0, 0 };
        return returnValue;
    }

    private int[] junkCollision()
    {
        story.SetText("A small piece of space junk collided with the ship. Damage was minimal, but we lost a little bit of fuel in the process. It could have been worse, but we’re still on track.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 5);
        int[] returnValue = { 0, -5 };
        return returnValue;
    }

    private int[] emergancyRepair()
    {
        story.SetText("The main engine malfunctioned today, forcing you to perform emergency repairs. It took you a few hours, but the engine is back online. It did, however, burn a bit of extra fuel during the process.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 10);
        int[] returnValue = { 0, -10 };
        return returnValue;
    }

    private int[] stellarObservation()
    {
        story.SetText("You spent most of the day observing distant stars and the surrounding space. The quiet and isolation are starting to settle in, but it's still peaceful.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0, 0 };
        return returnValue;
    }
    private int[] minorHullDamage()
    {
        story.SetText("While adjusting course through a dense asteroid belt, you didn’t quite avoid a small rock. There’s some minor damage to the hull, but nothing that compromises your overall safety. Still, this delayed your journey slightly.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 5);
        int[] returnValue = { 0, -5 };
        return returnValue;
    }

    private int[] powerFluctiations()
    {
        story.SetText("The ship’s power systems experienced some unexplained fluctuations today. You had to shut down some non-essential systems temporarily to conserve energy. The source of the issue hasn’t been found yet, but you are investigating it.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 5);
        int[] returnValue = { 0, -5 };
        return returnValue;
    }

    private int[] meteorShower()
    {
        story.SetText("A meteor shower passed dangerously close to your ship today. You had to use your ship's shielding to protect against the larger meteors. No direct hits, but the cosmic debris caused some strain on your resources. You were lucky, but it was a reminder of how fragile your journey is.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 5);
        int[] returnValue = { 0, -5 };
        return returnValue;
    }
    private int[] unknownSignal()
    {
        story.SetText("An unknown signal has been detected. It appears to be a distress call from a nearby vessel. You're considering whether or not to investigate, as it might be a trap, but it could also lead to useful resources.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0, 0 };
        return returnValue;
    }
    private int[] unknownSignal1()
    {
        story.SetText("As you follow the signal, you come across an abandoned freighter drifting in space. Its hull shows signs of damage, and life signs are non-existent. However, the ship's cargo hold is still intact. You decide to board it, finding useful resources—fuel, food, and even some spare parts for ship repairs. The cargo might help you stay on course, but you wonder what happened to its crew. Was it a tragedy, or something more sinister?");
        effects.SetText("Effects: " + "\n" + "Food: +" + 20 + "\n" + "Fuel: +" + 30);
        int[] returnValue = { 20, 30 };
        return returnValue;
    }
    private int[] unknownSignal2()
    {
        story.SetText("As you close in on the signal, it turns out to be a trap. Pirates, hiding behind a small moon, ambush your ship as soon as you’re in range. A fierce firefight breaks out, but you manage to fight them off after taking some damage. You lose a few supplies in the struggle and some valuable fuel, but at least you’re alive.");
        effects.SetText("Effects: " + "\n" + "Food: -" + 15 + "\n" + "Fuel: -" + 20);
        int[] returnValue = { -15, -20 };
        return returnValue;
    }

    private int[] unknownSignal3()
    {
        story.SetText("The signal turns out to be from a small, abandoned radio tower on an otherwise uncharted planet. While you find no signs of life, you do find records of a lost colony that once inhabited the planet. You gather some useful data about the colony and its sudden disappearance, which could help your mission in the long run. There’s not much to salvage, but the knowledge gained is valuable.");
        effects.SetText("Effects: " + "\n" + "Food: +" + 5 + "\n" + "Fuel: +" + 5);
        int[] returnValue = { 5, 5 };
        return returnValue;
    }

    private int[] unknownSignal4()
    {
        story.SetText("After several hours of tracking, the signal simply disappears without explanation. You are left feeling disappointed, and some speculate that it might have been a malfunction or a glitch in your sensors. The ship continues on its course, but you wonder if it was some sort of cosmic anomaly. Still, you press on, even though the mystery remains unsolved.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0, 0 };
        return returnValue;
    }

    private int[] strangePhenomenon()
    {
        story.SetText("Today, your ship's sensors pick up a strange phenomenon. It’s not like anything you’ve encountered before—a fluctuation in the fabric of space-time itself. The phenomenon is on the edge of your radar, but you can’t tell exactly what it is. It could be a cosmic anomaly, an abandoned space station, or something far more dangerous. You have a choice: investigate it, or continue on your current path.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: " + 0);
        int[] returnValue = { 0, 0 };
        return returnValue;
    }

    private int[] strangePhenomenon1()
    {
        story.SetText("As you approach the source of the anomaly, you realize it’s a stable wormhole, possibly a shortcut to a distant part of the galaxy. While the gravitational forces are strong, you manage to navigate it without too much issue. You emerge in an uncharted region of space, discovering a wealth of unknown planets and star systems. It might be dangerous, but the opportunity for discovery is immense. You gain valuable new data for your mission.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 10);
        int[] returnValue = { 0, -10 };
        return returnValue;
    }

    private int[] strangePhenomenon2()
    {
        story.SetText("As you approach, the anomaly reveals itself to be a black hole. It’s much larger than anticipated, and its gravitational pull begins to affect your ship’s systems. Fortunately, you manage to turn the ship around before it’s too late, but you’ve wasted precious time and energy. You are shaken, because you narrowly avoided disaster. You’re back on course, but the encounter has left you on edge.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 25);
        int[] returnValue = { 0, -25 };
        return returnValue;
    }

    private int[] strangePhenomenon3()
    {
        story.SetText("As you approach, you realize the anomaly is a massive, abandoned space station. The station’s lights flicker weakly, and its systems are offline. You dock to investigate and discover that the station was once a research outpost, now completely deserted. After a thorough search, you manage to scavenge some valuable equipment and materials, though you find no sign of the station’s crew or what happened to them. Still, the salvage is enough to make the detour worthwhile.");
        effects.SetText("Effects: " + "\n" + "Food: +" + 30 + "\n" + "Fuel: +" + 40);
        int[] returnValue = { 30, 40 };
        return returnValue;
    }

    private int[] strangePhenomenon4()
    {
        story.SetText("The phenomenon is far stranger than you anticipated—a rift in space-time that seems to distort both light and matter. As you approach, strange things begin to happen. The ship’s navigation systems go haywire, and you start to experience hallucinations or momentary lapses in memory. After a tense few hours, you manage to pull away, but the strange effects leave you disoriented. You're still unsure if it was a rift, a sensor malfunction, or something more. You feel unsettled, but you press on.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: -" + 15);
        int[] returnValue = { 0, -15 };
        return returnValue;
    }

    private int[] strangePhenomenon5()
    {
        story.SetText("You investigate the anomaly and discover it’s actually an enormous, ancient alien artifact. It’s orbiting a dead star, perfectly intact and emitting low-frequency signals. You can’t fully decipher what it is or what its purpose was, but you do manage to gather some scans and data. It’s a major find, but you can’t help but wonder if it’s best left undisturbed. Still, the research data you gather could help you on your mission.");
        effects.SetText("Effects: " + "\n" + "Food: " + 0 + "\n" + "Fuel: +" + 10);
        int[] returnValue = { 0, 10 };
        return returnValue;
    }
}
