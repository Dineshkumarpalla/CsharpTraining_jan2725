using System.Net.Http.Headers;

namespace TestProject1
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GetCount(List<student> students)
        {
            return students.Count;
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            student student = new student();
            List<student> list = new List<student>()
            {
                new student() {Id=1,Name="A"},
                new student() {Id=2,Name="B"},
                new student() {Id=3,Name="C"}
            };
        }
       // Assert.Equals(3,student.GetCount(list));
    }
}