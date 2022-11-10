using StudentServiceLib;

namespace StudentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 8;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score7_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void Score5_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void Score3point5_ReturnD()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void Score_3_ReturnE()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 3;
            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
        [TestMethod]
        public void Check_addStudent_NullStudent()
        {
            StudentService sv = new StudentService();
            Student s = null;
            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }
        [TestMethod]
        public void Check_addStudent() {
            StudentService sv = new StudentService();
            Student s = new Student { Id = 1, Name = "Nguyen Van A", Age = 20, Score = 3 };
            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }
    }
}