using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* File: Event.cs | Event Class
* Author: Austin A. Irvine
* Date Created: September 14, 2017
* Brief: Holds information about an real-life event
*        The event info will be added to a json file for later consumption
*/

#region Table of Contents Notes
/*
    TABLE OF CONTENTS
    -name of event
    -unique event id (eventually for duplicate)
    -host
    -location
    -brief
    -start
    -end
    -capacity
    -attendees
*/
#endregion
public class Event
{
    #region Private Variables and Properties
    private int numberOfEvents = 0;

    public string nameOfEvent = "";
    public string host = "";
    public string location = "";
    public string brief = "";

    //Tuple<DateTime,DateTime> contains 2 datetimes
    //first one is start time 
    //second one is end time
    //list because we can have multiple time blocks with independent start, end times
    public List<Tuple<DateTime, DateTime>> dateTimes;

    private int capacity = 0;
    private int numberOfAttendees = 0;
    #endregion

    public Event(string eventName, string hostName, string description, List<Tuple<DateTime, DateTime>> dateTimes, string loc, int attending, int cap)
    {
        nameOfEvent = eventName;
        host = hostName;
        location = loc;
        brief = description;
        this.dateTimes = dateTimes;
        numberOfAttendees = attending;
        capacity = cap;

        //saveToFile(eventName, capacity, brief, start, end);
    }

    //SETTERS
    #region Public Method Setters
    public void setName(string name)
    {
        nameOfEvent = name;
    }
    public void setHost(string hostName)
    {
        host = hostName;
    }
    public void setLocation(string loc)
    {
        location = loc;
    }
    public void setBrief(string msg)
    {
        brief = msg;
    }
    public void setCapacity(int cap)
    {
        capacity = cap;
    }
    public void setAttendees(int att)
    {
        numberOfAttendees = att;
    }
    #endregion
    /*
    NOTE:Maybe we'll eventually show everyone who is going to said event?
    */
    public void addAttendee()
    {
        numberOfAttendees++;
    }

    /*
    NOTE: WIP Random Event ID
    */

    //GETTERS
    #region Public Method Getters
    public string getName()
    {
        return (nameOfEvent);
    }
    public string getHost()
    {
        return (host);
    }
    public string getLocation()
    {
        return (location);
    }
    public string getBrief()
    {
        return (brief);
    }
    public int getCapacity()
    {
        return (capacity);
    }
    public int getAttendeeCount()
    {
        return (numberOfAttendees);
    }
    #endregion

    #region File Functionality
    public void saveToFile(string eventName, int capacity, string briefMsg, string startTime, string endTime)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/eventSaveFile.txt";
        System.IO.StreamWriter file;
        if (numberOfEvents == 0)
        {
            // Write the string to a file.
            file = new System.IO.StreamWriter(path);
        }
        else
        {
            file = new System.IO.StreamWriter(path);
        }
        numberOfEvents++;

        //Traverses To A New Line

        file.WriteLine(eventName + capacity + briefMsg + startTime + endTime);
        file.Close();
    }

    /*
     * Note: this will change number of attendees for an event in file 
    */
    public void quickSaveToFile()
    {

    }

    public void deleteEventFromFile(string matchName)
    {

    }
    #endregion
    public override string ToString()
    {
        return (this.nameOfEvent+"("+this.numberOfAttendees+")");
    }
}