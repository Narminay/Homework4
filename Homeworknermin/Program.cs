using System.Globalization;
using System.Text;
namespace Student_ID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            string soz = "bU iŞ ÇoX mƏnaSız";
            string ups = soz.ToLower();
            char[] array = ups.ToCharArray();
            if (array[0] == 'b')
            {
                array[0]='B';
            }
            if (array[3] == 'i')
            {
                array[3] = 'I';
            }
            if (array[6] == 'ç')
            {
                array[6] = 'Ç';
            }
            if (array[10] == 'm')
            {
                array[10] = 'M';
            }

            foreach (char item in array)
            {

            }
            string butov = string.Join("", array);
            Console.WriteLine(butov);
            #endregion

            #region Task 2

            Student telebe = new Student();
            telebe.Name = "Nərmin";
            telebe.Surname = "Abdullayeva";
            telebe.Group = 329;
            telebe.Point = 91;
            telebe.IsGraduated = true;

            Student student = new Student("Nərmin", "Abdullayeva", 329, 91, true);
            Console.WriteLine(student.Surname);
            #endregion
        }

    }
}


