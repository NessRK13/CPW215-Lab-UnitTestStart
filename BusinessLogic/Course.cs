using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private byte _credit;

        public Course(string courseName)
        {
            CourseName = courseName;

            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get => _credit;
            set
            {
                if (value > 0 && value < 30)
                    _credit = value;
                else
                    throw new ArgumentException();
            } 
        }

    }
}
