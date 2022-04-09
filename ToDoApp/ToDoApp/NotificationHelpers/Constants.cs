using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.NotificationHelpers
{
    public static class Constants
    {
        public static ObservableCollection<string> AddOptions = new ObservableCollection<string>() {
            "task",
            "list"
        };

        public static List<string> ListColorList = new List<string>() {
            "#F07167",
            "#007200",
            "#335C67",
            "#FF9100",
            "#FF7D00",
            "#E71D36"
        };

        public static ListModel InboxList = new ListModel() {
            Id = "zlDZNn3sNmyirSNs3mRY",
            Name = "Inbox",
            UserId = "Default",
            Color = "#F07167"
        };

        public static ListModel AllLists = new ListModel()
        {
            Id = "alllist",
            Name = "All lists",
            UserId = "Default",
            Color = "#007200",
        };

        public static TaskModel DefaultTask = new TaskModel()
        {
            Task = "",
            Archived = false,
            List = "Inbox",
            Date = DateTime.Now.ToString("dd/MM/yyyy")
        };

        public static ListModel DefaultList = new ListModel()
        {
            Name = "",
            Color = "#FF7D00",
        };

        public static class Errors
        {
            public static string GeneralError = "Oops!Something went wrong, Please hang on a moment and try again.";
            public static string WrongUserOrPasswordError = "Incorrect email and password, try again or Sign up";
        }
    }
}
