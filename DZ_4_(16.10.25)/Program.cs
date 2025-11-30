namespace classes
{
    // ------------------------ CLASS STUDENT ------------------------

    class Student
    {
        private string name = "Dima";
        private string secondname = "Antonov";
        private string fathername = "Kiril";

        DateTime birthday;
        private List<string> address = new List<string>();
        private List<int> exams = new List<int>();
        private List<int> homeworks = new List<int>();
        private List<int> lessons = new List<int>();

        private string numberPhone = "123456789";
        //---------------------------------------

        public void SetName(string name)
        {
            this.name = name;
        }
        //-------------------
        public string GetName()
        {
            return name!;
        }
        //---------------------------------------

        public void SetSecondName(string secondname)
        {
            this.secondname = secondname;
        }
        //-------------------
        public string GetSecondName()
        {
            return secondname!;
        }
        //---------------------------------------

        public void SetFathername(string fathername)
        {
            this.fathername = fathername;
        }
        //-------------------
        public string GetFathername()
        {
            return fathername!;
        }
        //---------------------------------------

        public void SetBirthday(int day, int month, int year)
        {
            birthday = new DateTime(year, month, day);
        }
        //-------------------
        public string GetBirthday()
        {
            return birthday.ToString("dd.MM.yyyy");
        }
        //---------------------------------------

        public void SetAddress(string street, string house)
        {
            address.Clear();
            address.Add(street);
            address.Add(house);
        }
        //-------------------
        public string GetAddress()
        {
            if (address.Count >= 2)
                return $"{address[0]}, {address[1]}";
            return "";
        }
        //---------------------------------------

        public void SetNumberPhone(string numberPhone)
        {
            this.numberPhone = numberPhone;
        }
        //-------------------
        public string GetNumberPhone()
        {
            return numberPhone!;
        }
        //---------------------------------------

        public void SetExam(int exam)
        {
            exams.Add(exam);
        }
        //-------------------
        public List<int> GetExam()
        {
            return exams;
        }
        //---------------------------------------

        public void SetHomework(int homework)
        {
            homeworks.Add(homework);
        }
        //-------------------
        public List<int> GetHomework()
        {
            return homeworks;
        }
        //---------------------------------------

        public void SetLesson(int lesson)
        {
            lessons.Add(lesson);
        }
        //-------------------
        public List<int> GetLesson()
        {
            return lessons;
        }
        //---------------------------------------

        public Student(string name, string secondname, string father, int day, int month, int year, string street, string house, string numberPhone,
            int count_lesson, int count_homework, int count_exam, int lesson, int exam, int homework)
        {
            SetName(name);
            SetSecondName(secondname);
            SetFathername(father);
            SetBirthday(day, month, year);
            SetAddress(street, house);
            SetNumberPhone(numberPhone);

            for (int i = 0; i < count_lesson; i++)
                SetLesson(lesson);

            for (int i = 0; i < count_homework; i++)
                SetHomework(homework);

            for (int i = 0; i < count_exam; i++)
                SetExam(exam);
        }
        //---------------------------------------
        public Student(int count_lesson, int count_homework, int count_exam, int lesson, int exam, int homework)
        {
            for (int i = 0; i < count_lesson; i++)
                SetLesson(lesson);

            for (int i = 0; i < count_homework; i++)
                SetHomework(homework);

            for (int i = 0; i < count_exam; i++)
                SetExam(exam);
        }
        //---------------------------------------
        public Student() : this("Dima", "John", "Snow", 10, 8, 2005, "Abrikosova", "18B", "05151515151", 5, 5, 3, 1, 85, 90)
        {
        }

        public void PrintAllFields()
        {
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Second Name: " + GetSecondName());
            Console.WriteLine("Father: " + GetFathername());
            Console.WriteLine("Birthday: " + GetBirthday());
            Console.WriteLine("Address: " + GetAddress());
            Console.WriteLine("Phone: " + GetNumberPhone());
            Console.WriteLine("Exam: " + (GetExam().Count > 0 ? string.Join(", ", GetExam()) : "No exams"));
            Console.WriteLine("Homework: " + (GetHomework().Count > 0 ? string.Join(", ", GetHomework()) : "No homeworks"));
            Console.WriteLine("Lesson: " + (GetLesson().Count > 0 ? string.Join(", ", GetLesson()) : "No lessons"));
        }
        //---------------------------------------

        public void PrintExams()
        {
            if (exams.Count == 0)
                Console.WriteLine("No exams");
            else
                Console.WriteLine("Exams: " + string.Join(", ", exams));
        }

        public void PrintHomeworks()
        {
            if (exams.Count == 0)
                Console.WriteLine("No exams");
            else
                Console.WriteLine("Exams: " + string.Join(", ", homeworks));
        }

        public void PrintLessons()
        {
            if (exams.Count == 0)
                Console.WriteLine("No exams");
            else
                Console.WriteLine("Exams: " + string.Join(", ", lessons));
        }
    }

    // ------------------------ CLASS GROUP ------------------------

    class Group
    {
        private List<Student> students = new List<Student>();
        private string GroupName = "Alpha";
        private string specialization = "B";
        private int course = 1;

        // -------- Геттеры и сеттеры --------
        public void SetGroupName(string GroupName)
        {
            this.GroupName = GroupName;
        }
        public string GetGroupName()
        {
            return GroupName;
        }

        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }
        public string GetSpecialization()
        {
            return specialization;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }
        public int GetCourse()
        {
            return course;
        }

        public void SetStudents(List<Student> students)
        {
            this.students = students;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        //---------------------------------------
        
        public Group()
        {
        }

        
        public Group(List<Student> students, string GroupName, string specialization, int course)
        {
            this.students = new List<Student>(students);
            this.GroupName = GroupName;
            this.specialization = specialization;
            this.course = course;
        }

        
        public Group(Group other)
        {
            GroupName = other.GroupName;
            specialization = other.specialization;
            course = other.course;
            students = new List<Student>(other.students);
        }

        // ------------------- Методы -------------------

        public void PrintGroup()
        {
            Console.WriteLine($"Group: {GroupName}");
            Console.WriteLine($"Specialization: {specialization}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine("Students:");

            if (students.Count == 0)
            {
                Console.WriteLine("No students in group.");
                return;
            }

            var sorted = students
                .OrderBy(s => s.GetSecondName())
                .ThenBy(s => s.GetName())
                .ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sorted[i].GetSecondName()} {sorted[i].GetName()}");
            }
        }
        //---------------------------------------

        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        //---------------------------------------

        public void TransferStudent(Student st, Group Gr)
        {
            if (students.Contains(st))
            {
                students.Remove(st);
                Gr.AddStudent(st);
            }
        }
        //---------------------------------------

        public void ExpelFailed()
        {
            students.RemoveAll(st =>
            {
                var exams = st.GetExam();
                if (exams.Count == 0) return true;
                return exams.Average() < 75;
            });
        }
        //---------------------------------------

        public bool RemoveLowestAverageStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Список студентов пуст.");
                return false;
            }

            double minAverage = students
                .Select(s => s.GetExam().Count > 0 ? s.GetExam().Average() : 0)
                .Min();

            Student toRemove = students
                .First(s => (s.GetExam().Count > 0 ? s.GetExam().Average() : 0) == minAverage);

            students.Remove(toRemove);

            Console.WriteLine($"Удалён студент: {toRemove.GetName()} {toRemove.GetSecondName()} со средним баллом {minAverage:F2}");
            return true;
        }
    }


    
    internal class Program
    {
        static void Main()
        {

            // ------------------------ CLASS STUDENT ------------------------

            Student student1 = new Student("John", "Doe", "Smith", 15, 6, 2002,
                "Main St", "123A", "6598584864648", 5, 5, 3, 7, 85, 90);

            Student student2 = new Student(5, 10, 3, 1, 90, 85);
            Student student3 = new Student();

            student1.PrintAllFields();
            Console.WriteLine("\n");
            student2.PrintAllFields();
            Console.WriteLine("\n");
            student3.PrintAllFields();
            Console.WriteLine("\n");

            student1.SetExam(95);
            student1.SetExam(76);
            student1.SetExam(56);
            Console.WriteLine("Exams: " + string.Join(", ", student1.GetExam()));
            student1.PrintExams();

            //------------------------ CLASS GROUP ------------------------

            Group GroupA = new Group(new List<Student> { student1, student2 }, "A-12", "Programming", 2);
            GroupA.AddStudent(student3);

            Console.WriteLine("\n=== GROUP A ===");
            GroupA.PrintGroup();

            GroupA.RemoveLowestAverageStudent();
            Console.WriteLine("\n=== AFTER EXPELLING WORST STUDENT ===");
            GroupA.PrintGroup();

            Console.WriteLine("\n=== GROUP B ===");
            Group Groupb = new Group();
            Groupb.PrintGroup();

            Console.WriteLine("\n=== GROUP  C ===");
            Group Groupc = new Group(Groupb);
            Groupc.PrintGroup();
        }
    }
}
