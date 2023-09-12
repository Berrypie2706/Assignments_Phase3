using System.Globalization;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public sealed class ValidationStepDefinitions
    {
        private readonly UserLogin userlogin;
        private string msg;
      
        public ValidationStepDefinitions(UserLogin userlogin)
        {
            this.userlogin = userlogin;
        }

        [Given("the user id is (.*)")]
        public void GivenUserId(string id)
        {
            userlogin.UserId = id;

           
        }

        [Given("the user password is (.*)")]
        public void GivenTheSecondNumberIs(string pwd)
        {
           userlogin.Password = pwd;
        }

        [When("the userid are valid")]
        public void WhenTheIdIsValidated()
        {
           userlogin.validateId();
        }
        [When("the userid are valid")]
        public void WhenThePasswordIsValidated()
        {
          msg=userlogin.validatepwd();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string msg)
        {
           msg.Should().Be(msg);
        }
    }
}