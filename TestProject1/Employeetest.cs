using ConsoleApp1;

namespace TestProject1

{
    public class Employeetest
    {
        
        [Fact]
        public void Test1()
        {
            //arrange
            var emp = new Employee();



            //act
            var result = emp.addNums(5, 8);

            //assert
            Assert.Equal(13, result);
        }
    }
}