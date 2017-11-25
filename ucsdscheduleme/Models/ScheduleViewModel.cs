﻿using System.Collections.Generic;
using CourseId = System.Int32;
using BaseId = System.Char;
using SectionId = System.Int32;

namespace ucsdscheduleme.Models
{
    public class ScheduleViewModel
    {
        public Dictionary<CourseId, CourseViewModel> Courses { get; set; }
    }

    public class CourseViewModel
    {
        public char SelectedBase { get; set; }
        public int SelectedSection { get; set; }
        public Dictionary<BaseId, BaseViewModel> Bases { get; set; }
    }

    public class BaseViewModel
    {
        public List<CalendarEvent> BaseEvents { get; set; }
        public Dictionary<SectionId, List<CalendarEvent>> SectionEvents { get; set; }
        public Metadata Metadata { get; set; }
        public List<OneTimeEvent> OneTimeEvents { get; set; }
    }

    public class OneTimeEvent
    {
        public string CourseAbbreviation { get; set; }
        public string DateAndTime { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
    }

    public struct Metadata
    {
        public decimal AverageGpaExpected { get; set; }
        public decimal AverageGpaReceived { get; set; }
        public decimal AverageTotalWorkload { get; set; }
        public string CourseAbbreviation { get; set; }
        public string ProfessorName { get; set; }
    }

    public class CalendarEvent
    {
        // Fields used to place the event in the calendar.
        public int StartTimeInMinutesAfterFirstHour { get; set; }
        public int DurationInMinutes { get; set; }
        // String to be displayed to the user in the event. Ex: "( 8:00am - 9:20am )".
        public string Timespan { get; set; }
        // String literal of the day enum
        public string Type { get; set; }
        // String literal of the Day flag
        public string Day { get; set; }
        public string CourseAbbreviation { get; set; }
        public string ProfessorName { get; set; }
        // For example "A00"
        public string SectionCode { get; set; }
    }
}
