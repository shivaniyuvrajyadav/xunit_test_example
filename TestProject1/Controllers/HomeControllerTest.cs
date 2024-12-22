using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xunit_test_example.Controllers;

namespace TestProject1.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidResult()
        {
           //AAA
           //ARANGE
           HomeController controller = new HomeController();
            string expectedResult = "hii";

            //ACT
          string result =  controller.Index();
           //ASSERT
           Assert.Equal(expectedResult, result);
        }
    }
}
