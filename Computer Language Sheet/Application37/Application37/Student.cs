namespace Application37
{
    class Student
    {
        private string fullName;
        private string course;
        private string subject;
        private string university;
        private string eMail;
        private string phoneNumber;

        public string FullName
        {
            get { return fullName; }
            set { this.fullName = value; }
        }
        public string Course
        {
            get { return course; }
            set { this.course = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { this.subject = value; }
        }
        public string University
        {
            get { return university; }
            set { this.university = value; }
        }
        public string EMail
        {
            get { return eMail; }
            set { this.eMail = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public Student(string fullName, string course, string subject, string university, string eMail, string phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
        }

        public Student()
        {

        }

        public static int numberOfObjects;
        public int NumberOfObjects
        {
            get { return NumberOfObjects; }
            set { this.NumberOfObjects = value; }
        }

        public string PrintData()
        {
            string allData =
                "Number OF Methods Is : " + numberOfObjects + "\n" +
                "Full Name : " + fullName + "\n" +
                "Course : " + course + "\n" +
                "Subject : " + subject + "\n" +
                "University : " + university + "\n" +
                "E-Mail : " + eMail + "\n" +
                "Phone Number : " + phoneNumber + "\n";

            return allData;
        }

    }
}
