using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningGrid.Services.DataObjects
{
    public class Course:EntityData
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
       
    }
}