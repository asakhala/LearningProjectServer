using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningGrid.Services.DataObjects
{
    public class Lesson:EntityData
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}
