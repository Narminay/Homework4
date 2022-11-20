namespace Student_ID
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Group;
        public byte Point;
        public bool IsGraduated;

        public Student(string name, string surname, int group, byte point, bool graduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            graduated = IsGraduated;

            if (IsGraduated)
            {
                Console.WriteLine(name + surname + "üniversitet məzunudur!");
            }
            else
            {
                Console.WriteLine(name + surname + "üniversitet məzunu deyil!");
            }
        }

        public void Exam(int n, string point)
        {
            Point = point;
            if (point>= 80 && point<=100)
            {
                Console.Write("İmtahana girişə icazə verilsin");
            }
            else
            {
                Console.WriteLine("imtahana giriş qadağandır");
            }
        }
    }
}