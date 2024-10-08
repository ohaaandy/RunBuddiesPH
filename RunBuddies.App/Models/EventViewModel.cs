﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RunBuddies.App.Models // Make sure this namespace matches your project structure
{
    public class EventViewModel
    {
        public int EventID { get; set; }

        [Required(ErrorMessage = "Club ID is required")]
        public int ClubID { get; set; }

        [Required(ErrorMessage = "Event Name is required")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Event Type is required")]
        public string EventType { get; set; }

        [Required(ErrorMessage = "Date and Time is required")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public string Description { get; set; }
        public string ClubName { get; set; }
        public bool IsOrganizer { get; set; }
        public bool IsParticipant { get; set; }
    }
}